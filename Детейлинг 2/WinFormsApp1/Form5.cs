using System.Data;

namespace WinFormsApp1;

public enum OrderAction { Create, Status, Details, Review }

// Все действия с заказом используют одну форму и разные страницы.
public partial class Form5 : Form
{
    private Session? session;
    private int orderId;
    private int? currentMaster;
    private OrderAction action;
    private DataTable serviceTable=new();
    public Form5()
    {
        InitializeComponent();
        client.SelectedIndexChanged += (_,_) => { if(session is not null && action==OrderAction.Create) LoadCars(); };
        services.ItemCheck += services_ItemCheck;
        edit_master.SelectedIndexChanged += (_,_) =>
        {
            if(action!=OrderAction.Status) return;
            if(edit_status.Text=="В работе" || edit_status.Text=="Ожидает назначения мастера")
                edit_status.SelectedItem=edit_master.SelectedValue is int ? "В работе" : "Ожидает назначения мастера";
        };
        Load += (_,_) =>
        {
            if(session is null) return;
            if(action==OrderAction.Create) LoadCars();
            if(action==OrderAction.Status) { if(currentMaster.HasValue) edit_master.SelectedValue=currentMaster.Value; else edit_master.SelectedIndex=0; }
        };
    }
    public Form5(Session user) : this()
    {
        session=user; SelectAction(OrderAction.Create);
        LoadNewOrder(user);
    }
    public Form5(Session user,int id,OrderAction operation) : this()
    {
        if(operation==OrderAction.Create) throw new Exception("Для нового заказа не указывается номер.");
        session=user; orderId=id;
        DataRow row=AppData.CheckOrderOwner(user,id);
        if(operation==OrderAction.Status) AppData.AdminOnly(user);
        if(operation==OrderAction.Review && (user.IsAdmin || Convert.ToString(row["Status"])!="Выполнен"))
            throw new Exception("Клиент может оставить отзыв после выполнения заказа.");
        SelectAction(operation);
        Text+=$" №{row[user.IsAdmin ? "OrderNumber" : "ClientOrderNumber"]}";
        if(operation==OrderAction.Status)
        {
            currentMaster=row["MasterID"]==DBNull.Value?null:Convert.ToInt32(row["MasterID"]);
            edit_status.Items.AddRange(AppData.Statuses); edit_status.SelectedItem=Convert.ToString(row["Status"]);
            if(edit_status.SelectedIndex<0) edit_status.SelectedIndex=0;
            var masters=Db.Read("SELECT ID_Master,FullName FROM Masters ORDER BY FullName");
            masters.Rows.InsertAt(masters.NewRow(),0); masters.Rows[0]["FullName"]="Не назначен";
            Ui.Bind(edit_master,masters,"ID_Master","FullName");
        }
        if(operation==OrderAction.Details)
        {
            details_grid.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.AllCells;
            details_grid.DataSource=AppData.OrderDetails(user,id);
            details_grid.Columns["Стоимость"]!.DefaultCellStyle.Format="#,##0.00 '₽'";
        }
        if(operation==OrderAction.Review)
        {
            if(row["Rating"]!=DBNull.Value) review_rating.Value=Convert.ToInt32(row["Rating"]);
            review_text.Text=Convert.ToString(row["ReviewText"]);
        }
    }
    private void SelectAction(OrderAction operation)
    {
        action=operation;
        TabPage page=operation switch { OrderAction.Create=>newOrderPage,OrderAction.Status=>statusPage,OrderAction.Details=>detailsPage,_=>reviewPage };
        orderTabs.SelectedTab=page;
        foreach(TabPage other in orderTabs.TabPages.Cast<TabPage>().ToArray()) if(other!=page) orderTabs.TabPages.Remove(other);
        Text="Заказ";
        btnSave.Text=operation==OrderAction.Create?"Оплатить и оформить":"Сохранить";
        btnSave.Visible=operation!=OrderAction.Details;
        if(operation==OrderAction.Details) { btnCancel.Text="Закрыть"; AcceptButton=null; }
        ClientSize=operation switch { OrderAction.Status=>new Size(580,210),OrderAction.Review=>new Size(580,310),OrderAction.Details=>new Size(650,410),_=>new Size(580,480) };
    }
    private void LoadNewOrder(Session user)
    {
        Ui.Bind(client,user.IsAdmin ? Db.Read("SELECT ID_Client,LastName & ' ' & FirstName AS FullName FROM Clients ORDER BY LastName")
            : Db.Read("SELECT ID_Client,LastName & ' ' & FirstName AS FullName FROM Clients WHERE ID_Client=?",user.Id),"ID_Client","FullName");
        client.Enabled=user.IsAdmin;
        if (user.IsAdmin)
        {
            var masters=Db.Read("SELECT ID_Master,FullName FROM Masters ORDER BY FullName");
            masters.Rows.InsertAt(masters.NewRow(),0); masters.Rows[0]["FullName"]="Не назначен";
            Ui.Bind(master,masters,"ID_Master","FullName");
        }
        else { master.Items.Add("Назначит администратор"); master.SelectedIndex=0; master.Enabled=false; }
        serviceTable=Db.Read("SELECT ID_Service,ServiceName,Price FROM Services ORDER BY ServiceName");
        services.Items.Clear();
        // В списке показываем обычный текст. Данные услуги берём по тому же номеру строки.
        foreach(DataRow row in serviceTable.Rows)
            services.Items.Add($"{row["ServiceName"]} — {Convert.ToDecimal(row["Price"]):N2} ₽");
        LoadCars();

    }
    private void services_ItemCheck(object? sender, ItemCheckEventArgs e)
    {
        decimal sum=0;
        for(int i=0;i<serviceTable.Rows.Count;i++)
            if (i==e.Index?e.NewValue==CheckState.Checked:services.GetItemChecked(i)) sum+=Convert.ToDecimal(serviceTable.Rows[i]["Price"]);
        total.Text=$"Итого: {sum:N2} ₽";
    }
    private void LoadCars()
    {
        if (session is null || client.SelectedValue is not int) return;
        var cars=AppData.Cars(session,session.IsAdmin?Ui.Selected(client):session.Id);
        cars.Columns.Add("Caption",typeof(string));
        foreach(DataRow row in cars.Rows) row["Caption"]=$"{row["Автомобиль"]} — {row["Госномер"]}";
        Ui.Bind(car,cars,"ID","Caption");
    }
    private bool ConfirmNewOrder()
    {
        if (car.Items.Count==0) throw new Exception("Сначала добавьте автомобиль.");
        if (services.CheckedIndices.Count==0) throw new Exception("Выберите хотя бы одну услугу.");
        decimal sum=services.CheckedIndices.Cast<int>().Sum(i=>Convert.ToDecimal(serviceTable.Rows[i]["Price"]));
        return MessageBox.Show(this,$"Оплатить и оформить заказ на {sum:N2} ₽?","Подтверждение заказа",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes;
    }
    private void SaveNewOrder()
    {
        if (session is null) throw new Exception("Сначала войдите в программу.");
        int[] ids=services.CheckedIndices.Cast<int>().Select(i=>Convert.ToInt32(serviceTable.Rows[i]["ID_Service"])).ToArray();
        int? masterId=session.IsAdmin && master.SelectedValue is int id?id:null;
        AppData.CreateOrder(session,session.IsAdmin?Ui.Selected(client):session.Id,Ui.Selected(car),masterId,ids);
    }

    private void Save()
    {
        if(session is null) throw new Exception("Сначала войдите в программу.");
        switch(action)
        {
            case OrderAction.Create: SaveNewOrder(); break;
            case OrderAction.Status: AppData.SetStatus(session,orderId,edit_status.Text,edit_master.SelectedValue is int id?id:null); break;
            case OrderAction.Review: AppData.Review(session,orderId,(int)review_rating.Value,review_text.Text); break;
        }
    }
    private void btnSave_Click(object? sender,EventArgs e) => Ui.Try(() =>
    {
        if(action==OrderAction.Create && !ConfirmNewOrder()) return;
        Save(); DialogResult=DialogResult.OK; Close();
    });
}
