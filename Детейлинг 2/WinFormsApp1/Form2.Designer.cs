namespace WinFormsApp1;

partial class Form2
{
    private System.ComponentModel.IContainer components = null;
    private TabControl authTabs;
    private TabPage loginPage;
    private TabPage registrationPage;
    private Label lblLogin;
    private Label lblPassword;
    private TextBox txtLogin;
    private TextBox txtPassword;
    private CheckBox chkShowPassword;
    private Button btnLogin;
    private LinkLabel lnkRegister;
    private Label reg_lbl_lastName;
    private TextBox reg_lastName;
    private Label reg_lbl_firstName;
    private TextBox reg_firstName;
    private Label reg_lbl_middleName;
    private TextBox reg_middleName;
    private Label reg_lbl_phone;
    private MaskedTextBox reg_phone;
    private Label reg_lbl_login;
    private TextBox reg_login;
    private Label reg_lbl_password;
    private TextBox reg_password;
    private Label reg_lbl_confirm;
    private TextBox reg_confirm;
    private CheckBox reg_chkShowPassword;
    private Button reg_btnSave;
    private Button reg_btnCancel;

    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        authTabs = new TabControl();
        loginPage = new TabPage();
        lblLogin = new Label();
        lblPassword = new Label();
        txtLogin = new TextBox();
        txtPassword = new TextBox();
        chkShowPassword = new CheckBox();
        btnLogin = new Button();
        lnkRegister = new LinkLabel();
        registrationPage = new TabPage();
        reg_lbl_lastName = new Label();
        reg_lastName = new TextBox();
        reg_lbl_firstName = new Label();
        reg_firstName = new TextBox();
        reg_lbl_middleName = new Label();
        reg_middleName = new TextBox();
        reg_lbl_phone = new Label();
        reg_phone = new MaskedTextBox();
        reg_lbl_login = new Label();
        reg_login = new TextBox();
        reg_lbl_password = new Label();
        reg_password = new TextBox();
        reg_lbl_confirm = new Label();
        reg_confirm = new TextBox();
        reg_chkShowPassword = new CheckBox();
        reg_btnSave = new Button();
        reg_btnCancel = new Button();
        authTabs.SuspendLayout();
        loginPage.SuspendLayout();
        registrationPage.SuspendLayout();
        SuspendLayout();
        // 
        // authTabs
        // 
        authTabs.Controls.Add(loginPage);
        authTabs.Controls.Add(registrationPage);
        authTabs.Dock = DockStyle.Fill;
        authTabs.Location = new Point(0, 0);
        authTabs.Name = "authTabs";
        authTabs.SelectedIndex = 0;
        authTabs.Size = new Size(499, 375);
        authTabs.TabIndex = 0;
        authTabs.SelectedIndexChanged += authTabs_SelectedIndexChanged;
        // 
        // loginPage
        // 
        loginPage.Controls.Add(lblLogin);
        loginPage.Controls.Add(lblPassword);
        loginPage.Controls.Add(txtLogin);
        loginPage.Controls.Add(txtPassword);
        loginPage.Controls.Add(chkShowPassword);
        loginPage.Controls.Add(btnLogin);
        loginPage.Controls.Add(lnkRegister);
        loginPage.Location = new Point(4, 24);
        loginPage.Name = "loginPage";
        loginPage.Size = new Size(382, 298);
        loginPage.TabIndex = 0;
        loginPage.Text = "Вход";
        // 
        // lblLogin
        // 
        lblLogin.AutoSize = true;
        lblLogin.Location = new Point(20, 27);
        lblLogin.Name = "lblLogin";
        lblLogin.Size = new Size(41, 15);
        lblLogin.TabIndex = 1;
        lblLogin.Text = "Логин";
        // 
        // lblPassword
        // 
        lblPassword.AutoSize = true;
        lblPassword.Location = new Point(20, 68);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new Size(49, 15);
        lblPassword.TabIndex = 2;
        lblPassword.Text = "Пароль";
        // 
        // txtLogin
        // 
        txtLogin.Location = new Point(85, 24);
        txtLogin.MaxLength = 50;
        txtLogin.Name = "txtLogin";
        txtLogin.Size = new Size(205, 23);
        txtLogin.TabIndex = 0;
        // 
        // txtPassword
        // 
        txtPassword.Location = new Point(85, 65);
        txtPassword.MaxLength = 100;
        txtPassword.Name = "txtPassword";
        txtPassword.Size = new Size(205, 23);
        txtPassword.TabIndex = 1;
        txtPassword.UseSystemPasswordChar = true;
        // 
        // chkShowPassword
        // 
        chkShowPassword.Location = new Point(85, 100);
        chkShowPassword.Name = "chkShowPassword";
        chkShowPassword.Size = new Size(205, 24);
        chkShowPassword.TabIndex = 2;
        chkShowPassword.Text = "Показать пароль";
        chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
        // 
        // btnLogin
        // 
        btnLogin.Location = new Point(85, 139);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(90, 28);
        btnLogin.TabIndex = 3;
        btnLogin.Text = "Войти";
        btnLogin.Click += btnLogin_Click;
        // 
        // lnkRegister
        // 
        lnkRegister.Location = new Point(20, 190);
        lnkRegister.Name = "lnkRegister";
        lnkRegister.Size = new Size(280, 24);
        lnkRegister.TabIndex = 4;
        lnkRegister.TabStop = true;
        lnkRegister.Text = "Нет аккаунта? Зарегистрироваться";
        lnkRegister.LinkClicked += lnkRegister_LinkClicked;
        // 
        // registrationPage
        // 
        registrationPage.Controls.Add(reg_lbl_lastName);
        registrationPage.Controls.Add(reg_lastName);
        registrationPage.Controls.Add(reg_lbl_firstName);
        registrationPage.Controls.Add(reg_firstName);
        registrationPage.Controls.Add(reg_lbl_middleName);
        registrationPage.Controls.Add(reg_middleName);
        registrationPage.Controls.Add(reg_lbl_phone);
        registrationPage.Controls.Add(reg_phone);
        registrationPage.Controls.Add(reg_lbl_login);
        registrationPage.Controls.Add(reg_login);
        registrationPage.Controls.Add(reg_lbl_password);
        registrationPage.Controls.Add(reg_password);
        registrationPage.Controls.Add(reg_lbl_confirm);
        registrationPage.Controls.Add(reg_confirm);
        registrationPage.Controls.Add(reg_chkShowPassword);
        registrationPage.Controls.Add(reg_btnSave);
        registrationPage.Controls.Add(reg_btnCancel);
        registrationPage.Location = new Point(4, 24);
        registrationPage.Name = "registrationPage";
        registrationPage.Size = new Size(491, 347);
        registrationPage.TabIndex = 0;
        registrationPage.Text = "Регистрация";
        // 
        // reg_lbl_lastName
        // 
        reg_lbl_lastName.Location = new Point(14, 22);
        reg_lbl_lastName.Name = "reg_lbl_lastName";
        reg_lbl_lastName.Size = new Size(140, 22);
        reg_lbl_lastName.TabIndex = 0;
        reg_lbl_lastName.Text = "Фамилия";
        // 
        // reg_lastName
        // 
        reg_lastName.Location = new Point(156, 18);
        reg_lastName.MaxLength = 100;
        reg_lastName.Name = "reg_lastName";
        reg_lastName.Size = new Size(290, 23);
        reg_lastName.TabIndex = 0;
        // 
        // reg_lbl_firstName
        // 
        reg_lbl_firstName.Location = new Point(14, 56);
        reg_lbl_firstName.Name = "reg_lbl_firstName";
        reg_lbl_firstName.Size = new Size(140, 22);
        reg_lbl_firstName.TabIndex = 0;
        reg_lbl_firstName.Text = "Имя";
        // 
        // reg_firstName
        // 
        reg_firstName.Location = new Point(156, 52);
        reg_firstName.MaxLength = 100;
        reg_firstName.Name = "reg_firstName";
        reg_firstName.Size = new Size(290, 23);
        reg_firstName.TabIndex = 1;
        // 
        // reg_lbl_middleName
        // 
        reg_lbl_middleName.Location = new Point(14, 90);
        reg_lbl_middleName.Name = "reg_lbl_middleName";
        reg_lbl_middleName.Size = new Size(140, 22);
        reg_lbl_middleName.TabIndex = 0;
        reg_lbl_middleName.Text = "Отчество";
        // 
        // reg_middleName
        // 
        reg_middleName.Location = new Point(156, 86);
        reg_middleName.MaxLength = 100;
        reg_middleName.Name = "reg_middleName";
        reg_middleName.Size = new Size(290, 23);
        reg_middleName.TabIndex = 2;
        // 
        // reg_lbl_phone
        // 
        reg_lbl_phone.Location = new Point(14, 124);
        reg_lbl_phone.Name = "reg_lbl_phone";
        reg_lbl_phone.Size = new Size(140, 22);
        reg_lbl_phone.TabIndex = 0;
        reg_lbl_phone.Text = "Телефон";
        // 
        // reg_phone
        // 
        reg_phone.Location = new Point(156, 120);
        reg_phone.Mask = "+7 (000) 000-00-00";
        reg_phone.Name = "reg_phone";
        reg_phone.ResetOnSpace = false;
        reg_phone.Size = new Size(290, 23);
        reg_phone.TabIndex = 3;
        // 
        // reg_lbl_login
        // 
        reg_lbl_login.Location = new Point(14, 158);
        reg_lbl_login.Name = "reg_lbl_login";
        reg_lbl_login.Size = new Size(140, 22);
        reg_lbl_login.TabIndex = 0;
        reg_lbl_login.Text = "Логин";
        // 
        // reg_login
        // 
        reg_login.Location = new Point(156, 154);
        reg_login.MaxLength = 100;
        reg_login.Name = "reg_login";
        reg_login.Size = new Size(290, 23);
        reg_login.TabIndex = 4;
        // 
        // reg_lbl_password
        // 
        reg_lbl_password.Location = new Point(14, 192);
        reg_lbl_password.Name = "reg_lbl_password";
        reg_lbl_password.Size = new Size(140, 22);
        reg_lbl_password.TabIndex = 0;
        reg_lbl_password.Text = "Пароль";
        // 
        // reg_password
        // 
        reg_password.Location = new Point(156, 188);
        reg_password.MaxLength = 100;
        reg_password.Name = "reg_password";
        reg_password.Size = new Size(290, 23);
        reg_password.TabIndex = 5;
        reg_password.UseSystemPasswordChar = true;
        // 
        // reg_lbl_confirm
        // 
        reg_lbl_confirm.Location = new Point(14, 226);
        reg_lbl_confirm.Name = "reg_lbl_confirm";
        reg_lbl_confirm.Size = new Size(140, 22);
        reg_lbl_confirm.TabIndex = 0;
        reg_lbl_confirm.Text = "Повторите пароль";
        // 
        // reg_confirm
        // 
        reg_confirm.Location = new Point(156, 222);
        reg_confirm.MaxLength = 100;
        reg_confirm.Name = "reg_confirm";
        reg_confirm.Size = new Size(290, 23);
        reg_confirm.TabIndex = 6;
        reg_confirm.UseSystemPasswordChar = true;
        // 
        // reg_chkShowPassword
        // 
        reg_chkShowPassword.Location = new Point(156, 256);
        reg_chkShowPassword.Name = "reg_chkShowPassword";
        reg_chkShowPassword.Size = new Size(250, 24);
        reg_chkShowPassword.TabIndex = 8;
        reg_chkShowPassword.Text = "Показать пароль";
        // 
        // reg_btnSave
        // 
        reg_btnSave.Location = new Point(210, 301);
        reg_btnSave.Name = "reg_btnSave";
        reg_btnSave.Size = new Size(165, 28);
        reg_btnSave.TabIndex = 20;
        reg_btnSave.Text = "Зарегистрироваться";
        reg_btnSave.Click += btnRegister_Click;
        // 
        // reg_btnCancel
        // 
        reg_btnCancel.Location = new Point(385, 301);
        reg_btnCancel.Name = "reg_btnCancel";
        reg_btnCancel.Size = new Size(86, 28);
        reg_btnCancel.TabIndex = 21;
        reg_btnCancel.Text = "Назад";
        reg_btnCancel.Click += btnBack_Click;
        // 
        // Form2
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(499, 375);
        Controls.Add(authTabs);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "Form2";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Вход и регистрация";
        authTabs.ResumeLayout(false);
        loginPage.ResumeLayout(false);
        loginPage.PerformLayout();
        registrationPage.ResumeLayout(false);
        registrationPage.PerformLayout();
        ResumeLayout(false);
    }
}
