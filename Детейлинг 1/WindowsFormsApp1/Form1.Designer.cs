namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.database61DataSet = new WindowsFormsApp1.Database61DataSet();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new WindowsFormsApp1.Database61DataSetTableAdapters.ClientsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.Database61DataSetTableAdapters.TableAdapterManager();
            this.managersTableAdapter = new WindowsFormsApp1.Database61DataSetTableAdapters.ManagersTableAdapter();
            this.mastersTableAdapter = new WindowsFormsApp1.Database61DataSetTableAdapters.MastersTableAdapter();
            this.ordersTableAdapter = new WindowsFormsApp1.Database61DataSetTableAdapters.OrdersTableAdapter();
            this.servicesTableAdapter = new WindowsFormsApp1.Database61DataSetTableAdapters.ServicesTableAdapter();

            // Сетки данных
            this.clientsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();

            // Колонки Клиенты
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // Колонки Менеджеры
            this.iDManagerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managersBindingSource = new System.Windows.Forms.BindingSource(this.components);

            // Колонки Мастера
            this.ID_Master = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mastersBindingSource = new System.Windows.Forms.BindingSource(this.components);

            // Колонки Заказы (Переделаны на ComboBox)
            this.iDOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboClientColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.comboManagerColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.comboMasterColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.comboServiceColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);

            // Колонки Услуги
            this.iDServiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);

            // Элементы навигации и поиска
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();

            this.lblSearchClient = new System.Windows.Forms.Label();
            this.txtSearchClient = new System.Windows.Forms.TextBox();

            // Кнопки с понятными именами
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnSaveClients = new System.Windows.Forms.Button();
            this.btnRefreshClients = new System.Windows.Forms.Button();

            this.btnAddManager = new System.Windows.Forms.Button();
            this.btnDeleteManager = new System.Windows.Forms.Button();
            this.btnSaveManagers = new System.Windows.Forms.Button();
            this.btnRefreshManagers = new System.Windows.Forms.Button();

            this.btnAddMaster = new System.Windows.Forms.Button();
            this.btnDeleteMaster = new System.Windows.Forms.Button();
            this.btnSaveMasters = new System.Windows.Forms.Button();
            this.btnRefreshMasters = new System.Windows.Forms.Button();

            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnSaveOrders = new System.Windows.Forms.Button();
            this.btnRefreshOrders = new System.Windows.Forms.Button();

            this.btnAddService = new System.Windows.Forms.Button();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.btnSaveServices = new System.Windows.Forms.Button();
            this.btnRefreshServices = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.database61DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managersBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // database61DataSet
            // 
            this.database61DataSet.DataSetName = "Database61DataSet";
            this.database61DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.database61DataSet;
            // 
            // managersBindingSource
            // 
            this.managersBindingSource.DataMember = "Managers";
            this.managersBindingSource.DataSource = this.database61DataSet;
            // 
            // mastersBindingSource
            // 
            this.mastersBindingSource.DataMember = "Masters";
            this.mastersBindingSource.DataSource = this.database61DataSet;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.database61DataSet;
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "Services";
            this.servicesBindingSource.DataSource = this.database61DataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.ManagersTableAdapter = this.managersTableAdapter;
            this.tableAdapterManager.MastersTableAdapter = this.mastersTableAdapter;
            this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.ServicesTableAdapter = this.servicesTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.Database61DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            //
            // clientsTableAdapter
            //
            this.clientsTableAdapter.ClearBeforeFill = true;
            //
            // managersTableAdapter
            //
            this.managersTableAdapter.ClearBeforeFill = true;
            //
            // mastersTableAdapter
            //
            this.mastersTableAdapter.ClearBeforeFill = true;
            //
            // ordersTableAdapter
            //
            this.ordersTableAdapter.ClearBeforeFill = true;
            //
            // servicesTableAdapter
            //
            this.servicesTableAdapter.ClearBeforeFill = true;
            //
            // tabControl1
            //
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(0, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 482);
            this.tabControl1.TabIndex = 6;
            //
            // tabPage1 (КЛИЕНТЫ)
            //
            this.tabPage1.Controls.Add(this.lblSearchClient);
            this.tabPage1.Controls.Add(this.txtSearchClient);
            this.tabPage1.Controls.Add(this.clientsDataGridView);
            this.tabPage1.Controls.Add(this.btnAddClient);
            this.tabPage1.Controls.Add(this.btnDeleteClient);
            this.tabPage1.Controls.Add(this.btnSaveClients);
            this.tabPage1.Controls.Add(this.btnRefreshClients);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 456);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Клиенты";
            this.tabPage1.UseVisualStyleBackColor = true;
            //
            // lblSearchClient
            //
            this.lblSearchClient.AutoSize = true;
            this.lblSearchClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSearchClient.Location = new System.Drawing.Point(490, 428);
            this.lblSearchClient.Name = "lblSearchClient";
            this.lblSearchClient.Size = new System.Drawing.Size(98, 13);
            this.lblSearchClient.Text = "Живой поиск:";
            //
            // txtSearchClient
            //
            this.txtSearchClient.Location = new System.Drawing.Point(594, 425);
            this.txtSearchClient.Name = "txtSearchClient";
            this.txtSearchClient.TextChanged += new System.EventHandler(this.txtSearchClient_TextChanged);
            this.txtSearchClient.Size = new System.Drawing.Size(190, 20);
            this.txtSearchClient.TabIndex = 6;
            //
            // clientsDataGridView
            //
            this.clientsDataGridView.AutoGenerateColumns = false;
            this.clientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
this.dataGridViewTextBoxColumn1,
this.dataGridViewTextBoxColumn2,
this.dataGridViewTextBoxColumn3,
this.dataGridViewTextBoxColumn4,
this.dataGridViewTextBoxColumn5,
this.dataGridViewTextBoxColumn6});
            this.clientsDataGridView.DataSource = this.clientsBindingSource;
            this.clientsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.clientsDataGridView.Name = "clientsDataGridView";
            this.clientsDataGridView.Size = new System.Drawing.Size(792, 417);
            this.clientsDataGridView.TabIndex = 1;
            //
            // dataGridViewTextBoxColumn1
            //
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Client";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Client";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            //
            // dataGridViewTextBoxColumn2
            //
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            //
            // dataGridViewTextBoxColumn3
            //
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            //
            // dataGridViewTextBoxColumn4
            //
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn4.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            //
            // dataGridViewTextBoxColumn5
            //
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CarModel";
            this.dataGridViewTextBoxColumn5.HeaderText = "Модель авто";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            //
            // dataGridViewTextBoxColumn6
            //
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CarNumber";
            this.dataGridViewTextBoxColumn6.HeaderText = "Госномер";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            //
            // btnAddClient
            //
            this.btnAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.btnAddClient.Location = new System.Drawing.Point(8, 423);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(112, 23);
            this.btnAddClient.TabIndex = 2;
            this.btnAddClient.Text = "Добавить клиента";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAdd_Click);
            //
            // btnDeleteClient
            //
            this.btnDeleteClient.BackColor = System.Drawing.Color.Red;
            this.btnDeleteClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.btnDeleteClient.Location = new System.Drawing.Point(126, 423);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(112, 23);
            this.btnDeleteClient.TabIndex = 3;
            this.btnDeleteClient.Text = "Удалить клиента";
            this.btnDeleteClient.UseVisualStyleBackColor = false;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDelete_Click);
            //
            // btnSaveClients
            //
            this.btnSaveClients.BackColor = System.Drawing.Color.Lime;
            this.btnSaveClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.btnSaveClients.Location = new System.Drawing.Point(244, 423);
            this.btnSaveClients.Name = "btnSaveClients";
            this.btnSaveClients.Size = new System.Drawing.Size(112, 23);
            this.btnSaveClients.TabIndex = 4;
            this.btnSaveClients.Text = "Сохранить всё";
            this.btnSaveClients.UseVisualStyleBackColor = false;
            this.btnSaveClients.Click += new System.EventHandler(this.btnSave_Click);
            //
            // btnRefreshClients
            //
            this.btnRefreshClients.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRefreshClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.btnRefreshClients.Location = new System.Drawing.Point(362, 423);
            this.btnRefreshClients.Name = "btnRefreshClients";
            this.btnRefreshClients.Size = new System.Drawing.Size(112, 23);
            this.btnRefreshClients.TabIndex = 5;
            this.btnRefreshClients.Text = "Обновить";
            this.btnRefreshClients.UseVisualStyleBackColor = false;
            this.btnRefreshClients.Click += new System.EventHandler(this.btnRefresh_Click);
            //
            // tabPage2 (МЕНЕДЖЕРЫ)
            //
            this.tabPage2.Controls.Add(this.btnAddManager);
            this.tabPage2.Controls.Add(this.btnDeleteManager);
            this.tabPage2.Controls.Add(this.btnSaveManagers);
            this.tabPage2.Controls.Add(this.btnRefreshManagers);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 456);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Менеджеры";
            this.tabPage2.UseVisualStyleBackColor = true;
            //
            // dataGridView1
            //
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
this.iDManagerDataGridViewTextBoxColumn,
this.fullNameDataGridViewTextBoxColumn,
this.positionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.managersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(796, 417);
            this.dataGridView1.TabIndex = 2;
            //
            // iDManagerDataGridViewTextBoxColumn
            //
            this.iDManagerDataGridViewTextBoxColumn.DataPropertyName = "ID_Manager";
            this.iDManagerDataGridViewTextBoxColumn.HeaderText = "ID_Manager";
            this.iDManagerDataGridViewTextBoxColumn.Name = "iDManagerDataGridViewTextBoxColumn";
            //
            // fullNameDataGridViewTextBoxColumn
            //
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "ФИО Менеджера";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.Width = 200;
            //
            // positionDataGridViewTextBoxColumn
            //
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.Width = 150;
            //
            // btnAddManager
            //
            this.btnAddManager.Location = new System.Drawing.Point(9, 423);
            this.btnAddManager.Name = "btnAddManager";
            this.btnAddManager.Size = new System.Drawing.Size(146, 23);
            this.btnAddManager.TabIndex = 6;
            this.btnAddManager.Text = "Добавить менеджера";
            this.btnAddManager.Click += new System.EventHandler(this.btnAdd_Click);
            //
            // btnDeleteManager
            //
            this.btnDeleteManager.BackColor = System.Drawing.Color.Red;
            this.btnDeleteManager.Location = new System.Drawing.Point(161, 423);
            this.btnDeleteManager.Name = "btnDeleteManager";
            this.btnDeleteManager.Size = new System.Drawing.Size(166, 23);
            this.btnDeleteManager.TabIndex = 7;
            this.btnDeleteManager.Text = "Удалить менеджера";
            this.btnDeleteManager.Click += new System.EventHandler(this.btnDelete_Click);
            //
            // btnSaveManagers
            //
            this.btnSaveManagers.BackColor = System.Drawing.Color.Lime;
            this.btnSaveManagers.Location = new System.Drawing.Point(333, 423);
            this.btnSaveManagers.Name = "btnSaveManagers";
            this.btnSaveManagers.Size = new System.Drawing.Size(112, 23);
            this.btnSaveManagers.TabIndex = 8;
            this.btnSaveManagers.Text = "Сохранить всё";
            this.btnSaveManagers.Click += new System.EventHandler(this.btnSave_Click);
            //
            // btnRefreshManagers
            //
            this.btnRefreshManagers.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRefreshManagers.Location = new System.Drawing.Point(451, 423);
            this.btnRefreshManagers.Name = "btnRefreshManagers";
            this.btnRefreshManagers.Size = new System.Drawing.Size(112, 23);
            this.btnRefreshManagers.TabIndex = 9;
            this.btnRefreshManagers.Text = "Обновить";
            this.btnRefreshManagers.Click += new System.EventHandler(this.btnRefresh_Click);
            //
            // tabPage3 (МАСТЕРА)
            //
            this.tabPage3.Controls.Add(this.btnAddMaster);
            this.tabPage3.Controls.Add(this.btnDeleteMaster);
            this.tabPage3.Controls.Add(this.btnSaveMasters);
            this.tabPage3.Controls.Add(this.btnRefreshMasters);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 456);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Мастера";
            this.tabPage3.UseVisualStyleBackColor = true;
            //
            // dataGridView2
            //
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
this.ID_Master,
this.dataGridViewTextBoxColumn8,
this.Specialization});
            this.dataGridView2.DataSource = this.mastersBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(796, 417);
            this.dataGridView2.TabIndex = 10;
            //
            // ID_Master
            //
            this.ID_Master.DataPropertyName = "ID_Master";
            this.ID_Master.HeaderText = "ID_Master";
            this.ID_Master.Name = "ID_Master";
            //
            // dataGridViewTextBoxColumn8
            //
            this.dataGridViewTextBoxColumn8.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn8.HeaderText = "ФИО Мастера";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 200;
            //
            // Specialization
            //
            this.Specialization.DataPropertyName = "Specialization";
            this.Specialization.HeaderText = "Специализация";
            this.Specialization.Name = "Specialization";
            this.Specialization.Width = 150;
            //
            // btnAddMaster
            //
            this.btnAddMaster.Location = new System.Drawing.Point(9, 423);
            this.btnAddMaster.Name = "btnAddMaster";
            this.btnAddMaster.Size = new System.Drawing.Size(146, 23);
            this.btnAddMaster.TabIndex = 11;
            this.btnAddMaster.Text = "Добавить мастера";
            this.btnAddMaster.Click += new System.EventHandler(this.btnAdd_Click);
            //
            // btnDeleteMaster
            //
            this.btnDeleteMaster.BackColor = System.Drawing.Color.Red;
            this.btnDeleteMaster.Location = new System.Drawing.Point(161, 423);
            this.btnDeleteMaster.Name = "btnDeleteMaster";
            this.btnDeleteMaster.Size = new System.Drawing.Size(124, 23);
            this.btnDeleteMaster.TabIndex = 12;
            this.btnDeleteMaster.Text = "Удалить мастера";
            this.btnDeleteMaster.Click += new System.EventHandler(this.btnDelete_Click);
            //
            // btnSaveMasters
            //
            this.btnSaveMasters.BackColor = System.Drawing.Color.Lime;
            this.btnSaveMasters.Location = new System.Drawing.Point(291, 423);
            this.btnSaveMasters.Name = "btnSaveMasters";
            this.btnSaveMasters.Size = new System.Drawing.Size(112, 23);
            this.btnSaveMasters.TabIndex = 13;
            this.btnSaveMasters.Text = "Сохранить всё";
            this.btnSaveMasters.Click += new System.EventHandler(this.btnSave_Click);
            //
            // btnRefreshMasters
            //
            this.btnRefreshMasters.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRefreshMasters.Location = new System.Drawing.Point(409, 423);
            this.btnRefreshMasters.Name = "btnRefreshMasters";
            this.btnRefreshMasters.Size = new System.Drawing.Size(112, 23);
            this.btnRefreshMasters.TabIndex = 14;
            this.btnRefreshMasters.Text = "Обновить";
            this.btnRefreshMasters.Click += new System.EventHandler(this.btnRefresh_Click);
            //
            // tabPage4 (ЗАКАЗЫ - С КРАСИВЫМИ ВЫПАДАЮЩИМИ СПИСКАМИ)
            //
            this.tabPage4.Controls.Add(this.btnAddOrder);
            this.tabPage4.Controls.Add(this.btnDeleteOrder);
            this.tabPage4.Controls.Add(this.btnSaveOrders);
            this.tabPage4.Controls.Add(this.btnRefreshOrders);
            this.tabPage4.Controls.Add(this.dataGridView3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 456);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Заказы";
            this.tabPage4.UseVisualStyleBackColor = true;
            //
            // dataGridView3
            //
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
this.iDOrderDataGridViewTextBoxColumn,
this.comboClientColumn,
this.comboManagerColumn,
this.comboMasterColumn,
this.comboServiceColumn,
this.orderDateDataGridViewTextBoxColumn,
this.statusDataGridViewTextBoxColumn,
this.ratingDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.ordersBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(-2, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView3_CellFormatting);
            this.dataGridView3.Size = new System.Drawing.Size(796, 417);
            this.dataGridView3.TabIndex = 15;
            //
            // iDOrderDataGridViewTextBoxColumn
            //
            this.iDOrderDataGridViewTextBoxColumn.DataPropertyName = "ID_Order";
            this.iDOrderDataGridViewTextBoxColumn.HeaderText = "№ Заказа";
            this.iDOrderDataGridViewTextBoxColumn.Name = "iDOrderDataGridViewTextBoxColumn";
            this.iDOrderDataGridViewTextBoxColumn.Width = 70;
            //
            // comboClientColumn
            //
            this.comboClientColumn.DataSource = this.clientsBindingSource;
            this.comboClientColumn.DataPropertyName = "ClientID";
            this.comboClientColumn.DisplayMember = "LastName";
            this.comboClientColumn.ValueMember = "ID_Client";
            this.comboClientColumn.HeaderText = "Клиент";
            this.comboClientColumn.Name = "comboClientColumn";
            this.comboClientColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.comboClientColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.comboClientColumn.Width = 120;
            //
            // comboManagerColumn
            //
            this.comboManagerColumn.DataSource = this.managersBindingSource;
            this.comboManagerColumn.DataPropertyName = "ManagerID";
            this.comboManagerColumn.DisplayMember = "FullName";
            this.comboManagerColumn.ValueMember = "ID_Manager";
            this.comboManagerColumn.HeaderText = "Менеджер";
            this.comboManagerColumn.Name = "comboManagerColumn";
            this.comboManagerColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.comboManagerColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.comboManagerColumn.Width = 120;
            //
            // comboMasterColumn
            //
            this.comboMasterColumn.DataSource = this.mastersBindingSource;
            this.comboMasterColumn.DataPropertyName = "MasterID";
            this.comboMasterColumn.DisplayMember = "FullName";
            this.comboMasterColumn.ValueMember = "ID_Master";
            this.comboMasterColumn.HeaderText = "Мастер";
            this.comboMasterColumn.Name = "comboMasterColumn";
            this.comboMasterColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.comboMasterColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.comboMasterColumn.Width = 120;
            //
            // comboServiceColumn
            //
            this.comboServiceColumn.DataSource = this.servicesBindingSource;
            this.comboServiceColumn.DataPropertyName = "ServiceID";
            this.comboServiceColumn.DisplayMember = "ServiceName";
            this.comboServiceColumn.ValueMember = "ID_Service";
            this.comboServiceColumn.HeaderText = "Услуга";
            this.comboServiceColumn.Name = "comboServiceColumn";
            this.comboServiceColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.comboServiceColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.comboServiceColumn.Width = 120;
            //
            // orderDateDataGridViewTextBoxColumn
            //
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.Width = 80;
            //
            // statusDataGridViewTextBoxColumn
            //
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 90;
            //
            // ratingDataGridViewTextBoxColumn
            //
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Оценка";
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            this.ratingDataGridViewTextBoxColumn.Width = 50;
            //
            // btnAddOrder
            //
            this.btnAddOrder.Location = new System.Drawing.Point(7, 428);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(146, 23);
            this.btnAddOrder.TabIndex = 16;
            this.btnAddOrder.Text = "Добавить заказ";
            this.btnAddOrder.Click += new System.EventHandler(this.btnAdd_Click);
            //
            // btnDeleteOrder
            //
            this.btnDeleteOrder.BackColor = System.Drawing.Color.Red;
            this.btnDeleteOrder.Location = new System.Drawing.Point(159, 428);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(124, 23);
            this.btnDeleteOrder.TabIndex = 17;
            this.btnDeleteOrder.Text = "Удалить заказ";
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDelete_Click);
            //
            // btnSaveOrders
            //
            this.btnSaveOrders.BackColor = System.Drawing.Color.Lime;
            this.btnSaveOrders.Location = new System.Drawing.Point(289, 428);
            this.btnSaveOrders.Name = "btnSaveOrders";
            this.btnSaveOrders.Size = new System.Drawing.Size(112, 23);
            this.btnSaveOrders.TabIndex = 18;
            this.btnSaveOrders.Text = "Сохранить всё";
            this.btnSaveOrders.Click += new System.EventHandler(this.btnSave_Click);
            //
            // btnRefreshOrders
            //
            this.btnRefreshOrders.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRefreshOrders.Location = new System.Drawing.Point(407, 428);
            this.btnRefreshOrders.Name = "btnRefreshOrders";
            this.btnRefreshOrders.Size = new System.Drawing.Size(112, 23);
            this.btnRefreshOrders.TabIndex = 19;
            this.btnRefreshOrders.Text = "Обновить";
            this.btnRefreshOrders.Click += new System.EventHandler(this.btnRefresh_Click);
            //
            // tabPage5 (УСЛУГИ)
            //
            this.tabPage5.Controls.Add(this.btnAddService);
            this.tabPage5.Controls.Add(this.btnDeleteService);
            this.tabPage5.Controls.Add(this.btnSaveServices);
            this.tabPage5.Controls.Add(this.btnRefreshServices);
            this.tabPage5.Controls.Add(this.dataGridView4);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(792, 456);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Услуги";
            this.tabPage5.UseVisualStyleBackColor = true;
            //
            // dataGridView4
            //
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
this.iDServiceDataGridViewTextBoxColumn,
this.serviceNameDataGridViewTextBoxColumn,
this.priceDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.servicesBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(-2, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(796, 417);
            this.dataGridView4.TabIndex = 20;
            //
            // iDServiceDataGridViewTextBoxColumn
            //
            this.iDServiceDataGridViewTextBoxColumn.DataPropertyName = "ID_Service";
            this.iDServiceDataGridViewTextBoxColumn.HeaderText = "ID_Service";
            this.iDServiceDataGridViewTextBoxColumn.Name = "iDServiceDataGridViewTextBoxColumn";
            //
            // serviceNameDataGridViewTextBoxColumn
            //
            this.serviceNameDataGridViewTextBoxColumn.DataPropertyName = "ServiceName";
            this.serviceNameDataGridViewTextBoxColumn.HeaderText = "Название услуги";
            this.serviceNameDataGridViewTextBoxColumn.Name = "serviceNameDataGridViewTextBoxColumn";
            this.serviceNameDataGridViewTextBoxColumn.Width = 250;
            //
            // priceDataGridViewTextBoxColumn
            //
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 120;
            //
            // btnAddService
            //
            this.btnAddService.Location = new System.Drawing.Point(7, 428);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(146, 23);
            this.btnAddService.TabIndex = 21;
            this.btnAddService.Text = "Добавить услугу";
            this.btnAddService.Click += new System.EventHandler(this.btnAdd_Click);
            //
            // btnDeleteService
            //
            this.btnDeleteService.BackColor = System.Drawing.Color.Red;
            this.btnDeleteService.Location = new System.Drawing.Point(159, 428);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(124, 23);
            this.btnDeleteService.TabIndex = 22;
            this.btnDeleteService.Text = "Удалить услугу";
            this.btnDeleteService.Click += new System.EventHandler(this.btnDelete_Click);
            //
            // btnSaveServices
            //
            this.btnSaveServices.BackColor = System.Drawing.Color.Lime;
            this.btnSaveServices.Location = new System.Drawing.Point(289, 428);
            this.btnSaveServices.Name = "btnSaveServices";
            this.btnSaveServices.Size = new System.Drawing.Size(112, 23);
            this.btnSaveServices.TabIndex = 23;
            this.btnSaveServices.Text = "Сохранить всё";
            this.btnSaveServices.Click += new System.EventHandler(this.btnSave_Click);
            //
            // btnRefreshServices
            //
            this.btnRefreshServices.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRefreshServices.Location = new System.Drawing.Point(407, 428);
            this.btnRefreshServices.Name = "btnRefreshServices";
            this.btnRefreshServices.Size = new System.Drawing.Size(112, 23);
            this.btnRefreshServices.TabIndex = 24;
            this.btnRefreshServices.Text = "Обновить";
            this.btnRefreshServices.Click += new System.EventHandler(this.btnRefresh_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Детейлинг Центр";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database61DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managersBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastersBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion
        private Database61DataSet database61DataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private Database61DataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private Database61DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView clientsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label lblSearchClient;
        private System.Windows.Forms.TextBox txtSearchClient;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnSaveClients;
        private System.Windows.Forms.Button btnRefreshClients;
        private Database61DataSetTableAdapters.ManagersTableAdapter managersTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource managersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDManagerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAddManager;
        private System.Windows.Forms.Button btnDeleteManager;
        private System.Windows.Forms.Button btnSaveManagers;
        private System.Windows.Forms.Button btnRefreshManagers;
        private Database61DataSetTableAdapters.MastersTableAdapter mastersTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource mastersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Master;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialization;
        private System.Windows.Forms.Button btnAddMaster;
        private System.Windows.Forms.Button btnDeleteMaster;
        private System.Windows.Forms.Button btnSaveMasters;
        private System.Windows.Forms.Button btnRefreshMasters;
        private Database61DataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn comboClientColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn comboManagerColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn comboMasterColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn comboServiceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnSaveOrders;
        private System.Windows.Forms.Button btnRefreshOrders;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Button btnSaveServices;
        private System.Windows.Forms.Button btnRefreshServices;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private Database61DataSetTableAdapters.ServicesTableAdapter servicesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDServiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}
