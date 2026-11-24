namespace WinFormsApp1;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    private TabControl tabControl1;
    private TabPage dgvOrders;
    private DataGridView tabPage1;
    private Button btnCreateOrder;
    private Button btnDeleteOrder;
    private Button btnChangeStatus;
    private Button btnOrderServices;
    private Button btnReview;
    private TabPage carsPage;
    private DataGridView carsGrid;
    private Button btnAddCar;
    private Button btnDeleteCar;
    private TabPage dgvClients;
    private DataGridView dataGridView2;
    private Button btnAddClient;
    private Button btnEditClient;
    private Button btnDeleteClient;
    private TabPage dgvManagers;
    private DataGridView dataGridView3;
    private Button btnAddAdmin;
    private Button btnEditAdmin;
    private Button btnDeleteAdmin;
    private TabPage dgvMasters;
    private DataGridView dataGridView4;
    private Button btnAddMaster;
    private Button btnEditMaster;
    private Button btnDeleteMaster;
    private TabPage dgvServices;
    private DataGridView dataGridView5;
    private Button btnAddService;
    private Button btnEditService;
    private Button btnDeleteService;
    private Label lblSearch;
    private TextBox search;
    private Button btnRefresh;
    private Button btnLogout;

    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        tabControl1 = new TabControl();
        dgvOrders = new TabPage();
        tabPage1 = new DataGridView();
        btnCreateOrder = new Button();
        btnDeleteOrder = new Button();
        btnChangeStatus = new Button();
        btnOrderServices = new Button();
        btnReview = new Button();
        carsPage = new TabPage();
        carsGrid = new DataGridView();
        btnAddCar = new Button();
        btnDeleteCar = new Button();
        dgvClients = new TabPage();
        dataGridView2 = new DataGridView();
        btnAddClient = new Button();
        btnEditClient = new Button();
        btnDeleteClient = new Button();
        dgvManagers = new TabPage();
        dataGridView3 = new DataGridView();
        btnAddAdmin = new Button();
        btnEditAdmin = new Button();
        btnDeleteAdmin = new Button();
        dgvMasters = new TabPage();
        dataGridView4 = new DataGridView();
        btnAddMaster = new Button();
        btnEditMaster = new Button();
        btnDeleteMaster = new Button();
        dgvServices = new TabPage();
        dataGridView5 = new DataGridView();
        btnAddService = new Button();
        btnEditService = new Button();
        btnDeleteService = new Button();
        lblSearch = new Label();
        search = new TextBox();
        btnRefresh = new Button();
        btnLogout = new Button();
        tabControl1.SuspendLayout();
        dgvOrders.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)tabPage1).BeginInit();
        carsPage.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)carsGrid).BeginInit();
        dgvClients.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
        dgvManagers.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
        dgvMasters.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
        dgvServices.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
        SuspendLayout();
        // 
        // tabControl1
        // 
        tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        tabControl1.Controls.Add(dgvOrders);
        tabControl1.Controls.Add(carsPage);
        tabControl1.Controls.Add(dgvClients);
        tabControl1.Controls.Add(dgvManagers);
        tabControl1.Controls.Add(dgvMasters);
        tabControl1.Controls.Add(dgvServices);
        tabControl1.Location = new Point(0, 0);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(900, 480);
        tabControl1.TabIndex = 0;
        // 
        // dgvOrders
        // 
        dgvOrders.Controls.Add(tabPage1);
        dgvOrders.Controls.Add(btnCreateOrder);
        dgvOrders.Controls.Add(btnDeleteOrder);
        dgvOrders.Controls.Add(btnChangeStatus);
        dgvOrders.Controls.Add(btnOrderServices);
        dgvOrders.Controls.Add(btnReview);
        dgvOrders.Location = new Point(4, 24);
        dgvOrders.Name = "dgvOrders";
        dgvOrders.Size = new Size(892, 452);
        dgvOrders.TabIndex = 0;
        dgvOrders.Text = "Заказы";
        // 
        // tabPage1
        // 
        tabPage1.AllowUserToAddRows = false;
        tabPage1.AllowUserToDeleteRows = false;
        tabPage1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        tabPage1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        tabPage1.BackgroundColor = SystemColors.AppWorkspace;
        tabPage1.Location = new Point(4, 4);
        tabPage1.MultiSelect = false;
        tabPage1.Name = "tabPage1";
        tabPage1.ReadOnly = true;
        tabPage1.RowHeadersVisible = false;
        tabPage1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        tabPage1.Size = new Size(884, 408);
        tabPage1.TabIndex = 0;
        // 
        // btnCreateOrder
        // 
        btnCreateOrder.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnCreateOrder.Location = new Point(5, 418);
        btnCreateOrder.Name = "btnCreateOrder";
        btnCreateOrder.Size = new Size(118, 28);
        btnCreateOrder.TabIndex = 0;
        btnCreateOrder.Text = "Добавить заказ";
        btnCreateOrder.Click += btnCreateOrder_Click;
        // 
        // btnDeleteOrder
        // 
        btnDeleteOrder.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnDeleteOrder.Location = new Point(129, 418);
        btnDeleteOrder.Name = "btnDeleteOrder";
        btnDeleteOrder.Size = new Size(118, 28);
        btnDeleteOrder.TabIndex = 0;
        btnDeleteOrder.Text = "Удалить заказ";
        btnDeleteOrder.Click += btnDeleteOrder_Click;
        // 
        // btnChangeStatus
        // 
        btnChangeStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnChangeStatus.Location = new Point(253, 418);
        btnChangeStatus.Name = "btnChangeStatus";
        btnChangeStatus.Size = new Size(119, 28);
        btnChangeStatus.TabIndex = 0;
        btnChangeStatus.Text = "Править";
        btnChangeStatus.Click += btnChangeStatus_Click;
        // 
        // btnOrderServices
        // 
        btnOrderServices.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnOrderServices.Location = new Point(378, 418);
        btnOrderServices.Name = "btnOrderServices";
        btnOrderServices.Size = new Size(118, 28);
        btnOrderServices.TabIndex = 0;
        btnOrderServices.Text = "Услуги заказа";
        btnOrderServices.Click += btnOrderServices_Click;
        // 
        // btnReview
        // 
        btnReview.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnReview.Location = new Point(502, 418);
        btnReview.Name = "btnReview";
        btnReview.Size = new Size(118, 28);
        btnReview.TabIndex = 0;
        btnReview.Text = "Оставить отзыв";
        btnReview.Click += btnReview_Click;
        // 
        // carsPage
        // 
        carsPage.Controls.Add(carsGrid);
        carsPage.Controls.Add(btnAddCar);
        carsPage.Controls.Add(btnDeleteCar);
        carsPage.Location = new Point(4, 24);
        carsPage.Name = "carsPage";
        carsPage.Size = new Size(892, 452);
        carsPage.TabIndex = 0;
        carsPage.Text = "Автомобили";
        // 
        // carsGrid
        // 
        carsGrid.AllowUserToAddRows = false;
        carsGrid.AllowUserToDeleteRows = false;
        carsGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        carsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        carsGrid.BackgroundColor = SystemColors.AppWorkspace;
        carsGrid.Location = new Point(4, 4);
        carsGrid.MultiSelect = false;
        carsGrid.Name = "carsGrid";
        carsGrid.ReadOnly = true;
        carsGrid.RowHeadersVisible = false;
        carsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        carsGrid.Size = new Size(884, 408);
        carsGrid.TabIndex = 0;
        // 
        // btnAddCar
        // 
        btnAddCar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnAddCar.Location = new Point(5, 418);
        btnAddCar.Name = "btnAddCar";
        btnAddCar.Size = new Size(147, 28);
        btnAddCar.TabIndex = 0;
        btnAddCar.Text = "Добавить автомобиль";
        btnAddCar.Click += btnAddCar_Click;
        // 
        // btnDeleteCar
        // 
        btnDeleteCar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnDeleteCar.Location = new Point(158, 418);
        btnDeleteCar.Name = "btnDeleteCar";
        btnDeleteCar.Size = new Size(140, 28);
        btnDeleteCar.TabIndex = 0;
        btnDeleteCar.Text = "Удалить автомобиль";
        btnDeleteCar.Click += btnDeleteCar_Click;
        // 
        // dgvClients
        // 
        dgvClients.Controls.Add(dataGridView2);
        dgvClients.Controls.Add(btnAddClient);
        dgvClients.Controls.Add(btnEditClient);
        dgvClients.Controls.Add(btnDeleteClient);
        dgvClients.Location = new Point(4, 24);
        dgvClients.Name = "dgvClients";
        dgvClients.Size = new Size(892, 452);
        dgvClients.TabIndex = 0;
        dgvClients.Text = "Клиенты";
        // 
        // dataGridView2
        // 
        dataGridView2.AllowUserToAddRows = false;
        dataGridView2.AllowUserToDeleteRows = false;
        dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        dataGridView2.BackgroundColor = SystemColors.AppWorkspace;
        dataGridView2.Location = new Point(4, 4);
        dataGridView2.MultiSelect = false;
        dataGridView2.Name = "dataGridView2";
        dataGridView2.ReadOnly = true;
        dataGridView2.RowHeadersVisible = false;
        dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView2.Size = new Size(884, 408);
        dataGridView2.TabIndex = 0;
        // 
        // btnAddClient
        // 
        btnAddClient.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnAddClient.Location = new Point(5, 418);
        btnAddClient.Name = "btnAddClient";
        btnAddClient.Size = new Size(126, 28);
        btnAddClient.TabIndex = 0;
        btnAddClient.Text = "Добавить клиента";
        btnAddClient.Click += btnAddClient_Click;
        // 
        // btnEditClient
        // 
        btnEditClient.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnEditClient.Location = new Point(137, 418);
        btnEditClient.Name = "btnEditClient";
        btnEditClient.Size = new Size(189, 28);
        btnEditClient.TabIndex = 0;
        btnEditClient.Text = "Изменить / сменить пароль";
        btnEditClient.Click += btnEditClient_Click;
        // 
        // btnDeleteClient
        // 
        btnDeleteClient.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnDeleteClient.Location = new Point(332, 418);
        btnDeleteClient.Name = "btnDeleteClient";
        btnDeleteClient.Size = new Size(119, 28);
        btnDeleteClient.TabIndex = 0;
        btnDeleteClient.Text = "Удалить клиента";
        btnDeleteClient.Click += btnDeleteClient_Click;
        // 
        // dgvManagers
        // 
        dgvManagers.Controls.Add(dataGridView3);
        dgvManagers.Controls.Add(btnAddAdmin);
        dgvManagers.Controls.Add(btnEditAdmin);
        dgvManagers.Controls.Add(btnDeleteAdmin);
        dgvManagers.Location = new Point(4, 24);
        dgvManagers.Name = "dgvManagers";
        dgvManagers.Size = new Size(892, 452);
        dgvManagers.TabIndex = 0;
        dgvManagers.Text = "Администраторы";
        // 
        // dataGridView3
        // 
        dataGridView3.AllowUserToAddRows = false;
        dataGridView3.AllowUserToDeleteRows = false;
        dataGridView3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        dataGridView3.BackgroundColor = SystemColors.AppWorkspace;
        dataGridView3.Location = new Point(4, 4);
        dataGridView3.MultiSelect = false;
        dataGridView3.Name = "dataGridView3";
        dataGridView3.ReadOnly = true;
        dataGridView3.RowHeadersVisible = false;
        dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView3.Size = new Size(884, 408);
        dataGridView3.TabIndex = 0;
        // 
        // btnAddAdmin
        // 
        btnAddAdmin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnAddAdmin.Location = new Point(5, 418);
        btnAddAdmin.Name = "btnAddAdmin";
        btnAddAdmin.Size = new Size(175, 28);
        btnAddAdmin.TabIndex = 0;
        btnAddAdmin.Text = "Добавить администратора";
        btnAddAdmin.Click += btnAddAdmin_Click;
        // 
        // btnEditAdmin
        // 
        btnEditAdmin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnEditAdmin.Location = new Point(186, 418);
        btnEditAdmin.Name = "btnEditAdmin";
        btnEditAdmin.Size = new Size(189, 28);
        btnEditAdmin.TabIndex = 0;
        btnEditAdmin.Text = "Изменить / сменить пароль";
        btnEditAdmin.Click += btnEditAdmin_Click;
        // 
        // btnDeleteAdmin
        // 
        btnDeleteAdmin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnDeleteAdmin.Location = new Point(381, 418);
        btnDeleteAdmin.Name = "btnDeleteAdmin";
        btnDeleteAdmin.Size = new Size(168, 28);
        btnDeleteAdmin.TabIndex = 0;
        btnDeleteAdmin.Text = "Удалить администратора";
        btnDeleteAdmin.Click += btnDeleteAdmin_Click;
        // 
        // dgvMasters
        // 
        dgvMasters.Controls.Add(dataGridView4);
        dgvMasters.Controls.Add(btnAddMaster);
        dgvMasters.Controls.Add(btnEditMaster);
        dgvMasters.Controls.Add(btnDeleteMaster);
        dgvMasters.Location = new Point(4, 24);
        dgvMasters.Name = "dgvMasters";
        dgvMasters.Size = new Size(892, 452);
        dgvMasters.TabIndex = 0;
        dgvMasters.Text = "Мастера";
        // 
        // dataGridView4
        // 
        dataGridView4.AllowUserToAddRows = false;
        dataGridView4.AllowUserToDeleteRows = false;
        dataGridView4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        dataGridView4.BackgroundColor = SystemColors.AppWorkspace;
        dataGridView4.Location = new Point(4, 4);
        dataGridView4.MultiSelect = false;
        dataGridView4.Name = "dataGridView4";
        dataGridView4.ReadOnly = true;
        dataGridView4.RowHeadersVisible = false;
        dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView4.Size = new Size(884, 408);
        dataGridView4.TabIndex = 0;
        // 
        // btnAddMaster
        // 
        btnAddMaster.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnAddMaster.Location = new Point(5, 418);
        btnAddMaster.Name = "btnAddMaster";
        btnAddMaster.Size = new Size(126, 28);
        btnAddMaster.TabIndex = 0;
        btnAddMaster.Text = "Добавить мастера";
        btnAddMaster.Click += btnAddMaster_Click;
        // 
        // btnEditMaster
        // 
        btnEditMaster.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnEditMaster.Location = new Point(137, 418);
        btnEditMaster.Name = "btnEditMaster";
        btnEditMaster.Size = new Size(126, 28);
        btnEditMaster.TabIndex = 0;
        btnEditMaster.Text = "Изменить мастера";
        btnEditMaster.Click += btnEditMaster_Click;
        // 
        // btnDeleteMaster
        // 
        btnDeleteMaster.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnDeleteMaster.Location = new Point(269, 418);
        btnDeleteMaster.Name = "btnDeleteMaster";
        btnDeleteMaster.Size = new Size(119, 28);
        btnDeleteMaster.TabIndex = 0;
        btnDeleteMaster.Text = "Удалить мастера";
        btnDeleteMaster.Click += btnDeleteMaster_Click;
        // 
        // dgvServices
        // 
        dgvServices.Controls.Add(dataGridView5);
        dgvServices.Controls.Add(btnAddService);
        dgvServices.Controls.Add(btnEditService);
        dgvServices.Controls.Add(btnDeleteService);
        dgvServices.Location = new Point(4, 24);
        dgvServices.Name = "dgvServices";
        dgvServices.Size = new Size(892, 452);
        dgvServices.TabIndex = 0;
        dgvServices.Text = "Услуги";
        // 
        // dataGridView5
        // 
        dataGridView5.AllowUserToAddRows = false;
        dataGridView5.AllowUserToDeleteRows = false;
        dataGridView5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        dataGridView5.BackgroundColor = SystemColors.AppWorkspace;
        dataGridView5.Location = new Point(4, 4);
        dataGridView5.MultiSelect = false;
        dataGridView5.Name = "dataGridView5";
        dataGridView5.ReadOnly = true;
        dataGridView5.RowHeadersVisible = false;
        dataGridView5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView5.Size = new Size(884, 408);
        dataGridView5.TabIndex = 0;
        // 
        // btnAddService
        // 
        btnAddService.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnAddService.Location = new Point(5, 418);
        btnAddService.Name = "btnAddService";
        btnAddService.Size = new Size(119, 28);
        btnAddService.TabIndex = 0;
        btnAddService.Text = "Добавить услугу";
        btnAddService.Click += btnAddService_Click;
        // 
        // btnEditService
        // 
        btnEditService.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnEditService.Location = new Point(130, 418);
        btnEditService.Name = "btnEditService";
        btnEditService.Size = new Size(119, 28);
        btnEditService.TabIndex = 0;
        btnEditService.Text = "Изменить услугу";
        btnEditService.Click += btnEditService_Click;
        // 
        // btnDeleteService
        // 
        btnDeleteService.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnDeleteService.Location = new Point(255, 418);
        btnDeleteService.Name = "btnDeleteService";
        btnDeleteService.Size = new Size(118, 28);
        btnDeleteService.TabIndex = 0;
        btnDeleteService.Text = "Удалить услугу";
        btnDeleteService.Click += btnDeleteService_Click;
        // 
        // lblSearch
        // 
        lblSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblSearch.Location = new Point(10, 492);
        lblSearch.Name = "lblSearch";
        lblSearch.Size = new Size(45, 20);
        lblSearch.TabIndex = 0;
        lblSearch.Text = "Поиск:";
        // 
        // search
        // 
        search.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        search.Location = new Point(56, 488);
        search.Name = "search";
        search.Size = new Size(190, 23);
        search.TabIndex = 0;
        search.TextChanged += search_TextChanged;
        // 
        // btnRefresh
        // 
        btnRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnRefresh.Location = new Point(257, 486);
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new Size(90, 28);
        btnRefresh.TabIndex = 0;
        btnRefresh.Text = "Обновить";
        btnRefresh.Click += btnRefresh_Click;
        // 
        // btnLogout
        // 
        btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnLogout.Location = new Point(356, 486);
        btnLogout.Name = "btnLogout";
        btnLogout.Size = new Size(90, 28);
        btnLogout.TabIndex = 0;
        btnLogout.Text = "Выйти";
        btnLogout.Click += btnLogout_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(900, 520);
        Controls.Add(tabControl1);
        Controls.Add(lblSearch);
        Controls.Add(search);
        Controls.Add(btnRefresh);
        Controls.Add(btnLogout);
        MinimumSize = new Size(850, 480);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Детейлинг Центр";
        tabControl1.ResumeLayout(false);
        dgvOrders.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)tabPage1).EndInit();
        carsPage.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)carsGrid).EndInit();
        dgvClients.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
        dgvManagers.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
        dgvMasters.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
        dgvServices.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}
