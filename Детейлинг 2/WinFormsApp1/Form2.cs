using System.Data;

namespace WinFormsApp1;

public partial class Form2 : Form
{
    public Form2()
    {
        InitializeComponent(); Ui.Phone(reg_phone);
        reg_chkShowPassword.CheckedChanged += (_,_) => reg_password.UseSystemPasswordChar=reg_confirm.UseSystemPasswordChar=!reg_chkShowPassword.Checked;
        Load += authTabs_SelectedIndexChanged;
    }
    private void authTabs_SelectedIndexChanged(object? sender,EventArgs e)
    {
        if (!IsHandleCreated) return;
        bool registering=authTabs.SelectedTab==registrationPage;
        AcceptButton=registering?reg_btnSave:btnLogin;
        CancelButton=registering?reg_btnCancel:null;
        ClientSize=registering?new Size(500,390):new Size(340,270);
        if (registering) reg_lastName.Focus(); else txtLogin.Focus();
    }
    private void chkShowPassword_CheckedChanged(object? sender,EventArgs e)
        => txtPassword.UseSystemPasswordChar=!chkShowPassword.Checked;
    private void btnLogin_Click(object? sender,EventArgs e)
    {
        Ui.Try(() =>
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text)||txtPassword.Text.Length==0) throw new Exception("Введите логин и пароль.");
            Session? user=AppData.Login(txtLogin.Text,txtPassword.Text);
            if (user is null) throw new Exception("Неверный логин или пароль.");
            Hide();
            try { using var main=new Form1(user); main.ShowDialog(); }
            finally { txtPassword.Clear(); chkShowPassword.Checked=false; Show(); txtPassword.Focus(); }
        });
    }
    private void lnkRegister_LinkClicked(object? sender,LinkLabelLinkClickedEventArgs e)
        => authTabs.SelectedTab=registrationPage;
    private void btnBack_Click(object? sender,EventArgs e) => authTabs.SelectedTab=loginPage;
    private void Register()
    {
        if (!reg_phone.MaskCompleted) throw new Exception("Введите телефон полностью: +7 (900) 123-45-67.");
        if (reg_password.Text!=reg_confirm.Text) throw new Exception("Пароли не совпадают.");
        AppData.Register(reg_lastName.Text,reg_firstName.Text,reg_middleName.Text,reg_phone.Text,reg_login.Text.Trim(),reg_password.Text);
    }
    private void btnRegister_Click(object? sender,EventArgs e) => Ui.Try(() =>
    {
        Register(); txtLogin.Text=reg_login.Text.Trim(); txtPassword.Clear();
        reg_password.Clear(); reg_confirm.Clear(); authTabs.SelectedTab=loginPage;
        MessageBox.Show(this,"Аккаунт создан. Теперь войдите с вашим логином и паролем.","Регистрация");
        txtPassword.Focus();
    });
}
