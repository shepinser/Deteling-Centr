using System.Data;

namespace WinFormsApp1;

public partial class Form1 : Form
{
    private readonly Session? session;
    private readonly Dictionary<DataGridView, DataTable> tables = new();
    private Session User => session ?? throw new Exception("Сначала войдите в программу.");

    public Form1() { InitializeComponent(); tabPage1.CellFormatting += orders_CellFormatting; }

    private void orders_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
    {
        if(e.RowIndex<0 || e.ColumnIndex<0 || tabPage1.Columns[e.ColumnIndex].Name!="Статус") return;
        Color background=Convert.ToString(e.Value) switch
        {
            "Ожидает назначения мастера" => Color.Khaki,
            "В работе" => Color.LightGray,
            "Выполнен" => Color.LightGreen,
            _ => Color.White
        };
        e.CellStyle.BackColor=background;
        e.CellStyle.SelectionBackColor=background;
        e.CellStyle.ForeColor=Color.Black;
        e.CellStyle.SelectionForeColor=Color.Black;
    }
    public Form1(Session user) : this()
    {
        session = user;
        Text = "Детейлинг Центр — " + (user.IsAdmin ? "Администратор" : "Клиент");
        carsPage.Text = user.IsAdmin ? "Автомобили" : "Мои автомобили";
        dgvOrders.Text = user.IsAdmin ? "Заказы" : "Мои заказы";
        btnReview.Visible = !user.IsAdmin;
        if (!user.IsAdmin)
        {
            tabControl1.TabPages.Remove(dgvClients);
            tabControl1.TabPages.Remove(dgvManagers);
            tabControl1.TabPages.Remove(dgvMasters);
            btnDeleteOrder.Visible = btnChangeStatus.Visible = false;
            btnAddService.Visible = btnEditService.Visible = btnDeleteService.Visible = false;
            btnOrderServices.Left = btnCreateOrder.Right + 6;
            btnReview.Left = btnOrderServices.Right + 6;
        }
        tabControl1.SelectedTab = dgvOrders;
        tabControl1.SelectedIndexChanged += (_, _) => { search.Clear(); Ui.Try(RefreshData); };
        Shown += (_, _) => Ui.Try(RefreshData);
    }

    private void btnCreateOrder_Click(object? sender, EventArgs e) => Ui.Try(() => Edit(new Form5(User)));
    private void btnDeleteOrder_Click(object? sender, EventArgs e) => Ui.Try(DeleteOrder);
    private void btnChangeStatus_Click(object? sender, EventArgs e) => Ui.Try(() => Edit(new Form5(User, SelectedId(tabPage1), OrderAction.Status)));
    private void btnOrderServices_Click(object? sender, EventArgs e) => Ui.Try(ShowOrderDetails);
    private void btnReview_Click(object? sender, EventArgs e) => Ui.Try(() => Edit(new Form5(User, SelectedId(tabPage1), OrderAction.Review)));
    private void btnAddCar_Click(object? sender, EventArgs e) => Ui.Try(() => Edit(new Form3(User)));
    private void btnDeleteCar_Click(object? sender, EventArgs e) => Ui.Try(DeleteCar);
    private void btnAddClient_Click(object? sender, EventArgs e) => Ui.Try(() => Edit(new Form4(User, RecordKind.Client, 0)));
    private void btnEditClient_Click(object? sender, EventArgs e) => Ui.Try(() => Edit(new Form4(User, RecordKind.Client, SelectedId(dataGridView2))));
    private void btnDeleteClient_Click(object? sender, EventArgs e) => Ui.Try(() => DeleteRecord("Clients", dataGridView2, "клиента"));
    private void btnAddAdmin_Click(object? sender, EventArgs e) => Ui.Try(() => Edit(new Form4(User, RecordKind.Admin, 0)));
    private void btnEditAdmin_Click(object? sender, EventArgs e) => Ui.Try(() => Edit(new Form4(User, RecordKind.Admin, SelectedId(dataGridView3))));
    private void btnDeleteAdmin_Click(object? sender, EventArgs e) => Ui.Try(() => DeleteRecord("Managers", dataGridView3, "администратора"));
    private void btnAddMaster_Click(object? sender, EventArgs e) => Ui.Try(() => Edit(new Form4(User, RecordKind.Master, 0)));
    private void btnEditMaster_Click(object? sender, EventArgs e) => Ui.Try(() => Edit(new Form4(User, RecordKind.Master, SelectedId(dataGridView4))));
    private void btnDeleteMaster_Click(object? sender, EventArgs e) => Ui.Try(() => DeleteRecord("Masters", dataGridView4, "мастера"));
    private void btnAddService_Click(object? sender, EventArgs e) => Ui.Try(() => Edit(new Form4(User, RecordKind.Service, 0)));
    private void btnEditService_Click(object? sender, EventArgs e) => Ui.Try(() => Edit(new Form4(User, RecordKind.Service, SelectedId(dataGridView5))));
    private void btnDeleteService_Click(object? sender, EventArgs e) => Ui.Try(() => DeleteRecord("Services", dataGridView5, "услугу"));
    private void btnRefresh_Click(object? sender, EventArgs e) => Ui.Try(RefreshData);
    private void btnLogout_Click(object? sender, EventArgs e) => Close();
    private void search_TextChanged(object? sender, EventArgs e) => ApplySearch();

    private static int SelectedId(DataGridView grid)
    {
        if (grid.CurrentRow?.DataBoundItem is not DataRowView row) throw new Exception("Сначала выберите строку в таблице.");
        return Convert.ToInt32(row["ID"]);
    }

    private void Edit(Form dialog)
    {
        using (dialog) if (dialog.ShowDialog(this) == DialogResult.OK) RefreshData();
    }

    private void Bind(DataGridView grid, DataTable table)
    {
        tables[grid] = table; grid.DataSource = table;
        if (grid.Columns["ClientID"] is { } ownerColumn) ownerColumn.Visible = false;
        if (grid.Columns["ID"] is { } idColumn)
        {
            if (grid == tabPage1 || grid == carsGrid) idColumn.Visible = false;
            else idColumn.HeaderText = grid == dataGridView2 ? "Номер клиента" : grid == dataGridView3
                ? "Номер администратора" : grid == dataGridView4 ? "Номер мастера" : "Номер услуги";
        }
        if (grid.Columns["Номер заказа"] is { } numberColumn) numberColumn.DefaultCellStyle.Format = "'Заказ №'0";
        if (grid.Columns["Стоимость"] is { } amountColumn) amountColumn.DefaultCellStyle.Format = "#,##0.00 '₽'";
        if (grid.Columns["Цена"] is { } priceColumn) priceColumn.DefaultCellStyle.Format = "#,##0.00 '₽'";
        if (grid.Columns["Дата"] is { } dateColumn) dateColumn.DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
    }

    private void RefreshData()
    {
        if (session is null) return;
        Bind(tabPage1, AppData.Orders(session));
        Bind(carsGrid, AppData.Cars(session));
        Bind(dataGridView5, Db.Read("SELECT ID_Service AS [ID], ServiceName AS [Услуга], Price AS [Цена], DurationMinutes AS [Длительность (мин)], [Description] AS [Описание] FROM Services ORDER BY ServiceName"));
        if (session.IsAdmin)
        {
            Bind(dataGridView2, Db.Read("SELECT ID_Client AS [ID], LastName AS [Фамилия], FirstName AS [Имя], MiddleName AS [Отчество], Phone AS [Телефон], [Login] AS [Логин], [Role] AS [Роль], CreatedAt AS [Дата регистрации] FROM Clients ORDER BY LastName"));
            Bind(dataGridView3, Db.Read("SELECT ID_Manager AS [ID], FullName AS [ФИО], [Position] AS [Должность], [Login] AS [Логин], [Role] AS [Роль], CreatedAt AS [Дата регистрации] FROM Managers ORDER BY FullName"));
            Bind(dataGridView4, Db.Read("SELECT ID_Master AS [ID], FullName AS [ФИО], Specialization AS [Специализация] FROM Masters ORDER BY FullName"));
        }
        ApplySearch();
    }

    private void ApplySearch()
    {
        DataGridView? grid = tabControl1.SelectedTab?.Controls.OfType<DataGridView>().FirstOrDefault();
        if (grid is null || !tables.TryGetValue(grid, out DataTable? source)) return;
        string text = search.Text.Trim();
        if (text.Length == 0) { grid.DataSource = source; return; }
        DataTable filtered = source.Clone();
        foreach (DataRow row in source.Rows)
            if (row.ItemArray.Any(value => Convert.ToString(value)?.Contains(text, StringComparison.CurrentCultureIgnoreCase) == true)) filtered.ImportRow(row);
        grid.DataSource = filtered;
    }

    private bool Confirm(string message) => MessageBox.Show(this, message, "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
    private void DeleteOrder()
    {
        if (session is null) return;
        int id = SelectedId(tabPage1);
        int number = Convert.ToInt32(AppData.CheckOrderOwner(session, id)["OrderNumber"]);
        if (!Confirm($"Удалить заказ №{number} вместе с его услугами?")) return;
        AppData.DeleteOrder(session, id); RefreshData();
    }
    private void DeleteCar()
    {
        if (session is null) return;
        int id = SelectedId(carsGrid);
        if (!Confirm("Удалить выбранный автомобиль?")) return;
        AppData.DeleteCar(session, id); RefreshData();
    }
    private void DeleteRecord(string table, DataGridView grid, string label)
    {
        if (session is null) return;
        int id = SelectedId(grid);
        string prompt = table == "Services" ? "Удалить выбранную услугу?" : $"Удалить выбранного {label}?";
        if (!Confirm(prompt)) return;
        AppData.DeleteRecord(session, table, id); RefreshData();
    }
    private void ShowOrderDetails()
    {
        if (session is null) return;
        using var form = new Form5(session, SelectedId(tabPage1), OrderAction.Details);
        form.ShowDialog(this);
    }
}
