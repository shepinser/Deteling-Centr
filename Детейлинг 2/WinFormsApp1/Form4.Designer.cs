namespace WinFormsApp1;

partial class Form4
{
    private System.ComponentModel.IContainer components = null;
    private TabControl recordTabs;
    private TabPage clientPage;
    private Label client_lbl_lastName;
    private TextBox client_lastName;
    private Label client_lbl_firstName;
    private TextBox client_firstName;
    private Label client_lbl_middleName;
    private TextBox client_middleName;
    private Label client_lbl_phone;
    private MaskedTextBox client_phone;
    private Label client_lbl_login;
    private TextBox client_login;
    private Label client_lbl_password;
    private TextBox client_password;
    private CheckBox client_chkShowPassword;
    private Label client_lblRole;
    private TabPage adminPage;
    private Label admin_lbl_fullName;
    private TextBox admin_fullName;
    private Label admin_lbl_position;
    private TextBox admin_position;
    private Label admin_lbl_login;
    private TextBox admin_login;
    private Label admin_lbl_password;
    private TextBox admin_password;
    private CheckBox admin_chkShowPassword;
    private Label admin_lblRole;
    private TabPage masterPage;
    private Label master_lbl_name;
    private TextBox master_name;
    private Label master_lbl_specialization;
    private TextBox master_specialization;
    private TabPage servicePage;
    private Label service_lbl_name;
    private TextBox service_name;
    private Label service_lbl_price;
    private NumericUpDown service_price;
    private Label service_lbl_duration;
    private NumericUpDown service_duration;
    private Label service_lbl_description;
    private TextBox service_description;
    private Button btnSave;
    private Button btnCancel;

    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        recordTabs = new TabControl();
        clientPage = new TabPage();
        client_lbl_lastName = new Label();
        client_lastName = new TextBox();
        client_lbl_firstName = new Label();
        client_firstName = new TextBox();
        client_lbl_middleName = new Label();
        client_middleName = new TextBox();
        client_lbl_phone = new Label();
        client_phone = new MaskedTextBox();
        client_lbl_login = new Label();
        client_login = new TextBox();
        client_lbl_password = new Label();
        client_password = new TextBox();
        client_chkShowPassword = new CheckBox();
        client_lblRole = new Label();
        adminPage = new TabPage();
        admin_lbl_fullName = new Label();
        admin_fullName = new TextBox();
        admin_lbl_position = new Label();
        admin_position = new TextBox();
        admin_lbl_login = new Label();
        admin_login = new TextBox();
        admin_lbl_password = new Label();
        admin_password = new TextBox();
        admin_chkShowPassword = new CheckBox();
        admin_lblRole = new Label();
        masterPage = new TabPage();
        master_lbl_name = new Label();
        master_name = new TextBox();
        master_lbl_specialization = new Label();
        master_specialization = new TextBox();
        servicePage = new TabPage();
        service_lbl_name = new Label();
        service_name = new TextBox();
        service_lbl_price = new Label();
        service_price = new NumericUpDown();
        service_lbl_duration = new Label();
        service_duration = new NumericUpDown();
        service_lbl_description = new Label();
        service_description = new TextBox();
        btnSave = new Button();
        btnCancel = new Button();
        recordTabs.SuspendLayout();
        clientPage.SuspendLayout();
        adminPage.SuspendLayout();
        masterPage.SuspendLayout();
        servicePage.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)service_price).BeginInit();
        ((System.ComponentModel.ISupportInitialize)service_duration).BeginInit();
        SuspendLayout();
        //
        // recordTabs
        //
        recordTabs.Name = "recordTabs";
        recordTabs.Location = new Point(8, 8);
        recordTabs.Size = new Size(484, 340);
        recordTabs.TabIndex = 0;
        recordTabs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        recordTabs.SelectedIndex = 0;
        //
        // clientPage
        //
        clientPage.Name = "clientPage";
        clientPage.Location = new Point(4, 24);
        clientPage.Size = new Size(476, 312);
        clientPage.TabIndex = 0;
        clientPage.Text = "Клиент";
        //
        // client_lbl_lastName
        //
        client_lbl_lastName.Name = "client_lbl_lastName";
        client_lbl_lastName.Location = new Point(14, 22);
        client_lbl_lastName.Size = new Size(140, 22);
        client_lbl_lastName.TabIndex = 0;
        client_lbl_lastName.Text = "Фамилия";
        //
        // client_lastName
        //
        client_lastName.Name = "client_lastName";
        client_lastName.Location = new Point(156, 18);
        client_lastName.Size = new Size(290, 23);
        client_lastName.TabIndex = 0;
        client_lastName.MaxLength = 100;
        //
        // client_lbl_firstName
        //
        client_lbl_firstName.Name = "client_lbl_firstName";
        client_lbl_firstName.Location = new Point(14, 56);
        client_lbl_firstName.Size = new Size(140, 22);
        client_lbl_firstName.TabIndex = 0;
        client_lbl_firstName.Text = "Имя";
        //
        // client_firstName
        //
        client_firstName.Name = "client_firstName";
        client_firstName.Location = new Point(156, 52);
        client_firstName.Size = new Size(290, 23);
        client_firstName.TabIndex = 1;
        client_firstName.MaxLength = 100;
        //
        // client_lbl_middleName
        //
        client_lbl_middleName.Name = "client_lbl_middleName";
        client_lbl_middleName.Location = new Point(14, 90);
        client_lbl_middleName.Size = new Size(140, 22);
        client_lbl_middleName.TabIndex = 0;
        client_lbl_middleName.Text = "Отчество";
        //
        // client_middleName
        //
        client_middleName.Name = "client_middleName";
        client_middleName.Location = new Point(156, 86);
        client_middleName.Size = new Size(290, 23);
        client_middleName.TabIndex = 2;
        client_middleName.MaxLength = 100;
        //
        // client_lbl_phone
        //
        client_lbl_phone.Name = "client_lbl_phone";
        client_lbl_phone.Location = new Point(14, 124);
        client_lbl_phone.Size = new Size(140, 22);
        client_lbl_phone.TabIndex = 0;
        client_lbl_phone.Text = "Телефон";
        //
        // client_phone
        //
        client_phone.Name = "client_phone";
        client_phone.Location = new Point(156, 120);
        client_phone.Size = new Size(290, 23);
        client_phone.TabIndex = 3;
        client_phone.Mask = "+7 (000) 000-00-00";
        client_phone.ResetOnSpace = false;
        //
        // client_lbl_login
        //
        client_lbl_login.Name = "client_lbl_login";
        client_lbl_login.Location = new Point(14, 158);
        client_lbl_login.Size = new Size(140, 22);
        client_lbl_login.TabIndex = 0;
        client_lbl_login.Text = "Логин";
        //
        // client_login
        //
        client_login.Name = "client_login";
        client_login.Location = new Point(156, 154);
        client_login.Size = new Size(290, 23);
        client_login.TabIndex = 4;
        client_login.MaxLength = 100;
        //
        // client_lbl_password
        //
        client_lbl_password.Name = "client_lbl_password";
        client_lbl_password.Location = new Point(14, 192);
        client_lbl_password.Size = new Size(140, 22);
        client_lbl_password.TabIndex = 0;
        client_lbl_password.Text = "Новый пароль";
        //
        // client_password
        //
        client_password.Name = "client_password";
        client_password.Location = new Point(156, 188);
        client_password.Size = new Size(290, 23);
        client_password.TabIndex = 5;
        client_password.MaxLength = 100;
        client_password.UseSystemPasswordChar = true;
        //
        // client_chkShowPassword
        //
        client_chkShowPassword.Name = "client_chkShowPassword";
        client_chkShowPassword.Location = new Point(156, 222);
        client_chkShowPassword.Size = new Size(270, 24);
        client_chkShowPassword.TabIndex = 7;
        client_chkShowPassword.Text = "Показать пароль";
        //
        // client_lblRole
        //
        client_lblRole.Name = "client_lblRole";
        client_lblRole.Location = new Point(14, 254);
        client_lblRole.Size = new Size(400, 22);
        client_lblRole.TabIndex = 0;
        client_lblRole.Text = "";
        client_lblRole.Visible = false;
        //
        // adminPage
        //
        adminPage.Name = "adminPage";
        adminPage.Location = new Point(4, 24);
        adminPage.Size = new Size(476, 312);
        adminPage.TabIndex = 0;
        adminPage.Text = "Администратор";
        //
        // admin_lbl_fullName
        //
        admin_lbl_fullName.Name = "admin_lbl_fullName";
        admin_lbl_fullName.Location = new Point(14, 22);
        admin_lbl_fullName.Size = new Size(140, 22);
        admin_lbl_fullName.TabIndex = 0;
        admin_lbl_fullName.Text = "ФИО";
        //
        // admin_fullName
        //
        admin_fullName.Name = "admin_fullName";
        admin_fullName.Location = new Point(156, 18);
        admin_fullName.Size = new Size(290, 23);
        admin_fullName.TabIndex = 0;
        admin_fullName.MaxLength = 255;
        //
        // admin_lbl_position
        //
        admin_lbl_position.Name = "admin_lbl_position";
        admin_lbl_position.Location = new Point(14, 56);
        admin_lbl_position.Size = new Size(140, 22);
        admin_lbl_position.TabIndex = 0;
        admin_lbl_position.Text = "Должность";
        //
        // admin_position
        //
        admin_position.Name = "admin_position";
        admin_position.Location = new Point(156, 52);
        admin_position.Size = new Size(290, 23);
        admin_position.TabIndex = 1;
        admin_position.MaxLength = 255;
        //
        // admin_lbl_login
        //
        admin_lbl_login.Name = "admin_lbl_login";
        admin_lbl_login.Location = new Point(14, 90);
        admin_lbl_login.Size = new Size(140, 22);
        admin_lbl_login.TabIndex = 0;
        admin_lbl_login.Text = "Логин";
        //
        // admin_login
        //
        admin_login.Name = "admin_login";
        admin_login.Location = new Point(156, 86);
        admin_login.Size = new Size(290, 23);
        admin_login.TabIndex = 2;
        admin_login.MaxLength = 100;
        //
        // admin_lbl_password
        //
        admin_lbl_password.Name = "admin_lbl_password";
        admin_lbl_password.Location = new Point(14, 124);
        admin_lbl_password.Size = new Size(140, 22);
        admin_lbl_password.TabIndex = 0;
        admin_lbl_password.Text = "Новый пароль";
        //
        // admin_password
        //
        admin_password.Name = "admin_password";
        admin_password.Location = new Point(156, 120);
        admin_password.Size = new Size(290, 23);
        admin_password.TabIndex = 3;
        admin_password.MaxLength = 100;
        admin_password.UseSystemPasswordChar = true;
        //
        // admin_chkShowPassword
        //
        admin_chkShowPassword.Name = "admin_chkShowPassword";
        admin_chkShowPassword.Location = new Point(156, 154);
        admin_chkShowPassword.Size = new Size(260, 24);
        admin_chkShowPassword.TabIndex = 5;
        admin_chkShowPassword.Text = "Показать пароль";
        //
        // admin_lblRole
        //
        admin_lblRole.Name = "admin_lblRole";
        admin_lblRole.Location = new Point(14, 188);
        admin_lblRole.Size = new Size(420, 22);
        admin_lblRole.TabIndex = 0;
        admin_lblRole.Text = "";
        admin_lblRole.Visible = false;
        //
        // masterPage
        //
        masterPage.Name = "masterPage";
        masterPage.Location = new Point(4, 24);
        masterPage.Size = new Size(476, 312);
        masterPage.TabIndex = 0;
        masterPage.Text = "Мастер";
        //
        // master_lbl_name
        //
        master_lbl_name.Name = "master_lbl_name";
        master_lbl_name.Location = new Point(14, 22);
        master_lbl_name.Size = new Size(140, 22);
        master_lbl_name.TabIndex = 0;
        master_lbl_name.Text = "ФИО";
        //
        // master_name
        //
        master_name.Name = "master_name";
        master_name.Location = new Point(156, 18);
        master_name.Size = new Size(290, 23);
        master_name.TabIndex = 0;
        master_name.MaxLength = 255;
        //
        // master_lbl_specialization
        //
        master_lbl_specialization.Name = "master_lbl_specialization";
        master_lbl_specialization.Location = new Point(14, 56);
        master_lbl_specialization.Size = new Size(140, 22);
        master_lbl_specialization.TabIndex = 0;
        master_lbl_specialization.Text = "Специализация";
        //
        // master_specialization
        //
        master_specialization.Name = "master_specialization";
        master_specialization.Location = new Point(156, 52);
        master_specialization.Size = new Size(290, 23);
        master_specialization.TabIndex = 1;
        master_specialization.MaxLength = 255;
        //
        // servicePage
        //
        servicePage.Name = "servicePage";
        servicePage.Location = new Point(4, 24);
        servicePage.Size = new Size(476, 312);
        servicePage.TabIndex = 0;
        servicePage.Text = "Услуга";
        //
        // service_lbl_name
        //
        service_lbl_name.Name = "service_lbl_name";
        service_lbl_name.Location = new Point(14, 22);
        service_lbl_name.Size = new Size(140, 22);
        service_lbl_name.TabIndex = 0;
        service_lbl_name.Text = "Название";
        //
        // service_name
        //
        service_name.Name = "service_name";
        service_name.Location = new Point(156, 18);
        service_name.Size = new Size(290, 23);
        service_name.TabIndex = 0;
        service_name.MaxLength = 255;
        //
        // service_lbl_price
        //
        service_lbl_price.Name = "service_lbl_price";
        service_lbl_price.Location = new Point(14, 56);
        service_lbl_price.Size = new Size(140, 22);
        service_lbl_price.TabIndex = 0;
        service_lbl_price.Text = "Цена, ₽";
        //
        // service_price
        //
        service_price.Name = "service_price";
        service_price.Location = new Point(156, 52);
        service_price.Size = new Size(290, 23);
        service_price.TabIndex = 1;
        service_price.Maximum = 10000000;
        service_price.DecimalPlaces = 2;
        service_price.ThousandsSeparator = true;
        //
        // service_lbl_duration
        //
        service_lbl_duration.Name = "service_lbl_duration";
        service_lbl_duration.Location = new Point(14, 90);
        service_lbl_duration.Size = new Size(140, 22);
        service_lbl_duration.TabIndex = 0;
        service_lbl_duration.Text = "Длительность, мин.";
        //
        // service_duration
        //
        service_duration.Name = "service_duration";
        service_duration.Location = new Point(156, 86);
        service_duration.Size = new Size(290, 23);
        service_duration.TabIndex = 2;
        service_duration.Minimum = 1;
        service_duration.Maximum = 100000;
        service_duration.Value = 60;
        //
        // service_lbl_description
        //
        service_lbl_description.Name = "service_lbl_description";
        service_lbl_description.Location = new Point(14, 124);
        service_lbl_description.Size = new Size(140, 22);
        service_lbl_description.TabIndex = 0;
        service_lbl_description.Text = "Описание";
        //
        // service_description
        //
        service_description.Name = "service_description";
        service_description.Location = new Point(156, 120);
        service_description.Size = new Size(290, 95);
        service_description.TabIndex = 3;
        service_description.MaxLength = 2000;
        service_description.Multiline = true;
        //
        // btnSave
        //
        btnSave.Name = "btnSave";
        btnSave.Location = new Point(258, 361);
        btnSave.Size = new Size(134, 28);
        btnSave.TabIndex = 20;
        btnSave.Text = "Сохранить";
        btnSave.Click += btnSave_Click;
        //
        // btnCancel
        //
        btnCancel.Name = "btnCancel";
        btnCancel.Location = new Point(400, 361);
        btnCancel.Size = new Size(86, 28);
        btnCancel.TabIndex = 21;
        btnCancel.Text = "Отмена";
        btnCancel.DialogResult = DialogResult.Cancel;
        Controls.Add(recordTabs);
        recordTabs.Controls.Add(clientPage);
        clientPage.Controls.Add(client_lbl_lastName);
        clientPage.Controls.Add(client_lastName);
        clientPage.Controls.Add(client_lbl_firstName);
        clientPage.Controls.Add(client_firstName);
        clientPage.Controls.Add(client_lbl_middleName);
        clientPage.Controls.Add(client_middleName);
        clientPage.Controls.Add(client_lbl_phone);
        clientPage.Controls.Add(client_phone);
        clientPage.Controls.Add(client_lbl_login);
        clientPage.Controls.Add(client_login);
        clientPage.Controls.Add(client_lbl_password);
        clientPage.Controls.Add(client_password);
        clientPage.Controls.Add(client_chkShowPassword);
        clientPage.Controls.Add(client_lblRole);
        recordTabs.Controls.Add(adminPage);
        adminPage.Controls.Add(admin_lbl_fullName);
        adminPage.Controls.Add(admin_fullName);
        adminPage.Controls.Add(admin_lbl_position);
        adminPage.Controls.Add(admin_position);
        adminPage.Controls.Add(admin_lbl_login);
        adminPage.Controls.Add(admin_login);
        adminPage.Controls.Add(admin_lbl_password);
        adminPage.Controls.Add(admin_password);
        adminPage.Controls.Add(admin_chkShowPassword);
        adminPage.Controls.Add(admin_lblRole);
        recordTabs.Controls.Add(masterPage);
        masterPage.Controls.Add(master_lbl_name);
        masterPage.Controls.Add(master_name);
        masterPage.Controls.Add(master_lbl_specialization);
        masterPage.Controls.Add(master_specialization);
        recordTabs.Controls.Add(servicePage);
        servicePage.Controls.Add(service_lbl_name);
        servicePage.Controls.Add(service_name);
        servicePage.Controls.Add(service_lbl_price);
        servicePage.Controls.Add(service_price);
        servicePage.Controls.Add(service_lbl_duration);
        servicePage.Controls.Add(service_duration);
        servicePage.Controls.Add(service_lbl_description);
        servicePage.Controls.Add(service_description);
        Controls.Add(btnSave);
        Controls.Add(btnCancel);
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(500, 400);
        Name = "Form4";
        Text = "Редактирование данных";
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = FormStartPosition.CenterParent;
        CancelButton = btnCancel;
        AcceptButton = btnSave;
        recordTabs.ResumeLayout(false);
        recordTabs.PerformLayout();
        clientPage.ResumeLayout(false);
        clientPage.PerformLayout();
        adminPage.ResumeLayout(false);
        adminPage.PerformLayout();
        masterPage.ResumeLayout(false);
        masterPage.PerformLayout();
        servicePage.ResumeLayout(false);
        servicePage.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)service_price).EndInit();
        ((System.ComponentModel.ISupportInitialize)service_duration).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}
