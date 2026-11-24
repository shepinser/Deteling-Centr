using System.Data;

namespace WinFormsApp1;

public enum RecordKind { Client, Admin, Master, Service }

// Вид записи определяет нужную страницу и запрос сохранения.
public partial class Form4 : Form
{
    private Session? session;
    private int id;
    private RecordKind kind;
    public Form4()
    {
        InitializeComponent(); Ui.Phone(client_phone);
        admin_position.Text="Администратор";
        client_chkShowPassword.CheckedChanged += (_,_) => client_password.UseSystemPasswordChar=!client_chkShowPassword.Checked;
        admin_chkShowPassword.CheckedChanged += (_,_) => admin_password.UseSystemPasswordChar=!admin_chkShowPassword.Checked;
    }
    public Form4(Session user,RecordKind recordKind,int recordId) : this()
    {
        AppData.AdminOnly(user); session=user; kind=recordKind; id=recordId;
        TabPage page=kind switch { RecordKind.Client=>clientPage,RecordKind.Admin=>adminPage,RecordKind.Master=>masterPage,_=>servicePage };
        recordTabs.SelectedTab=page;
        foreach(TabPage other in recordTabs.TabPages.Cast<TabPage>().ToArray()) if(other!=page) recordTabs.TabPages.Remove(other);
        Text=(id==0?"Добавить: ":"Изменить: ")+page.Text;
        if (id==0) return;
        switch(kind)
        {
            case RecordKind.Client:
                DataRow client=Db.Read("SELECT * FROM Clients WHERE ID_Client=?",id).Rows[0];
                client_lastName.Text=Convert.ToString(client["LastName"]); client_firstName.Text=Convert.ToString(client["FirstName"]);
                client_middleName.Text=Convert.ToString(client["MiddleName"]); client_phone.Text=AppData.NormalizePhone(Convert.ToString(client["Phone"])!);
                client_login.Text=Convert.ToString(client["Login"]); client_password.PlaceholderText="Пусто — оставить прежний пароль";
                break;
            case RecordKind.Admin:
                DataRow admin=Db.Read("SELECT * FROM Managers WHERE ID_Manager=?",id).Rows[0];
                admin_fullName.Text=Convert.ToString(admin["FullName"]); admin_position.Text=Convert.ToString(admin["Position"]);
                admin_login.Text=Convert.ToString(admin["Login"]); admin_password.PlaceholderText="Пусто — оставить прежний пароль";
                break;
            case RecordKind.Master:
                DataRow master=Db.Read("SELECT * FROM Masters WHERE ID_Master=?",id).Rows[0];
                master_name.Text=Convert.ToString(master["FullName"]); master_specialization.Text=Convert.ToString(master["Specialization"]);
                break;
            case RecordKind.Service:
                DataRow service=Db.Read("SELECT * FROM Services WHERE ID_Service=?",id).Rows[0];
                service_name.Text=Convert.ToString(service["ServiceName"]); service_price.Value=Convert.ToDecimal(service["Price"]);
                service_duration.Value=service["DurationMinutes"]==DBNull.Value?60:Convert.ToDecimal(service["DurationMinutes"]);
                service_description.Text=Convert.ToString(service["Description"]);
                break;
        }
    }
    private void Save()
    {
        if (session is null) throw new Exception("Сначала войдите в программу.");
        AppData.AdminOnly(session);
        switch(kind)
        {
            case RecordKind.Client: SaveClient(); break;
            case RecordKind.Admin: SaveAdmin(); break;
            case RecordKind.Master: SaveMaster(); break;
            case RecordKind.Service: SaveService(); break;
        }
    }
    private void btnSave_Click(object? sender,EventArgs e) => Ui.Try(() => { Save(); DialogResult=DialogResult.OK; Close(); });
    private void SaveClient()
    {
        if (session is null) throw new Exception("Сначала войдите в программу.");
        AppData.AdminOnly(session);
        if (!client_phone.MaskCompleted) throw new Exception("Введите телефон полностью: +7 (900) 123-45-67.");
        if (string.IsNullOrWhiteSpace(client_lastName.Text)||string.IsNullOrWhiteSpace(client_firstName.Text)) throw new Exception("Введите фамилию и имя.");
        string userLogin=client_login.Text.Trim(), number=AppData.NormalizePhone(client_phone.Text);
        AppData.CheckLogin(userLogin,"Clients",id);
        if (id==0) AppData.Register(client_lastName.Text,client_firstName.Text,client_middleName.Text,number,userLogin,client_password.Text);
        else
        {
            if (client_password.Text.Length>0) AppData.CheckPassword(client_password.Text);
            Db.Execute("UPDATE Clients SET LastName=?,FirstName=?,MiddleName=?,Phone=?,[Login]=? WHERE ID_Client=?",client_lastName.Text.Trim(),client_firstName.Text.Trim(),client_middleName.Text.Trim(),number,userLogin,id);
            if (client_password.Text.Length>0) Db.Execute("UPDATE Clients SET [Password]=? WHERE ID_Client=?",client_password.Text,id);
        }
    }
    private void SaveAdmin()
    {
        if (session is null) throw new Exception("Сначала войдите в программу.");
        AppData.AdminOnly(session); string userLogin=admin_login.Text.Trim(); AppData.CheckLogin(userLogin,"Managers",id);
        if (string.IsNullOrWhiteSpace(admin_fullName.Text)) throw new Exception("Введите ФИО.");
        if (id==0 || admin_password.Text.Length>0) AppData.CheckPassword(admin_password.Text);
        if (id==0) Db.Execute("INSERT INTO Managers (FullName,[Position],[Login],[Password]) VALUES (?,?,?,?)",admin_fullName.Text.Trim(),admin_position.Text.Trim(),userLogin,admin_password.Text);
        else
        {
            Db.Execute("UPDATE Managers SET FullName=?,[Position]=?,[Login]=? WHERE ID_Manager=?",admin_fullName.Text.Trim(),admin_position.Text.Trim(),userLogin,id);
            if (admin_password.Text.Length>0) Db.Execute("UPDATE Managers SET [Password]=? WHERE ID_Manager=?",admin_password.Text,id);
        }
    }
    private void SaveMaster()
    {
        if (string.IsNullOrWhiteSpace(master_name.Text) || string.IsNullOrWhiteSpace(master_specialization.Text)) throw new Exception("Заполните ФИО и специализацию.");
        if (id == 0) Db.Execute("INSERT INTO Masters (FullName,Specialization) VALUES (?,?)", master_name.Text.Trim(), master_specialization.Text.Trim());
        else Db.Execute("UPDATE Masters SET FullName=?,Specialization=? WHERE ID_Master=?", master_name.Text.Trim(), master_specialization.Text.Trim(), id);
    }
    private void SaveService()
    {
        if (string.IsNullOrWhiteSpace(service_name.Text)) throw new Exception("Введите название услуги.");
        if (id == 0) Db.Execute("INSERT INTO Services (ServiceName,Price,DurationMinutes,[Description]) VALUES (?,?,?,?)", service_name.Text.Trim(), service_price.Value, (int)service_duration.Value, service_description.Text.Trim());
        else Db.Execute("UPDATE Services SET ServiceName=?,Price=?,DurationMinutes=?,[Description]=? WHERE ID_Service=?", service_name.Text.Trim(), service_price.Value, (int)service_duration.Value, service_description.Text.Trim(), id);
    }
}
