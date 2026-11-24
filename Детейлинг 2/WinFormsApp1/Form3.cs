using System.Data;

namespace WinFormsApp1;

public partial class Form3 : Form
{
    private Session? session;
    private string previousPlate="";
    private bool restoringPlate;
    public Form3()
    {
        InitializeComponent();
        plate.TextChanged += plate_TextChanged;
        year.KeyPress += (_,e) => { if (!char.IsControl(e.KeyChar) && (e.KeyChar<'0' || e.KeyChar>'9')) e.Handled=true; };
        Shown += (_,_) => name.Focus();
    }
    public Form3(Session user) : this()
    {
        session=user;
        var clients=user.IsAdmin ? Db.Read("SELECT ID_Client,LastName & ' ' & FirstName AS FullName FROM Clients ORDER BY LastName")
            : Db.Read("SELECT ID_Client,LastName & ' ' & FirstName AS FullName FROM Clients WHERE ID_Client=?",user.Id);
        Ui.Bind(owner,clients,"ID_Client","FullName"); owner.Enabled=user.IsAdmin;
    }
    private void plate_TextChanged(object? sender, EventArgs e)
    {
        if (restoringPlate) return;
        if (AppData.IsPlatePrefix(plate.Text)) { previousPlate=plate.Text; return; }
        int position=Math.Max(0,plate.SelectionStart-1);
        restoringPlate=true; plate.Text=previousPlate;
        plate.SelectionStart=Math.Min(position,plate.Text.Length); restoringPlate=false;
        MessageBox.Show(this,"Заполните номер по форме: A123BC63 или A123BC163.\nРегион — 2 или 3 цифры. Буквы: A B E K M H O P C T Y X.","Госномер");
    }
    private void Save()
    {
        if (session is null) throw new Exception("Сначала войдите в программу.");
        if (plate.Text.Length!=8 && plate.Text.Length!=9) throw new Exception("Заполните номер по форме: A123BC63 или A123BC163.");
        if (!int.TryParse(year.Text,out int productionYear) || productionYear<1886 || productionYear>DateTime.Today.Year)
            throw new Exception("Введите год выпуска от 1886 до текущего года.");
        AppData.AddCar(session,session.IsAdmin?Ui.Selected(owner):session.Id,name.Text,plate.Text,productionYear);
    }
    private void btnSave_Click(object? sender, EventArgs e) => Ui.Try(() => { Save(); DialogResult=DialogResult.OK; Close(); });
}
