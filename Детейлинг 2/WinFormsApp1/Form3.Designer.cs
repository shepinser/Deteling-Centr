namespace WinFormsApp1;

partial class Form3
{
    private System.ComponentModel.IContainer components = null;
    private Label lbl_owner;
    private ComboBox owner;
    private Label lbl_name;
    private TextBox name;
    private Label lbl_plate;
    private TextBox plate;
    private Label lbl_year;
    private TextBox year;
    private Button btnSave;
    private Button btnCancel;

    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lbl_owner = new Label();
        owner = new ComboBox();
        lbl_name = new Label();
        name = new TextBox();
        lbl_plate = new Label();
        plate = new TextBox();
        lbl_year = new Label();
        year = new TextBox();
        btnSave = new Button();
        btnCancel = new Button();
        SuspendLayout();
        // 
        // lbl_owner
        // 
        lbl_owner.Location = new Point(14, 22);
        lbl_owner.Name = "lbl_owner";
        lbl_owner.Size = new Size(140, 22);
        lbl_owner.TabIndex = 0;
        lbl_owner.Text = "Владелец";
        // 
        // owner
        // 
        owner.DropDownStyle = ComboBoxStyle.DropDownList;
        owner.Location = new Point(156, 18);
        owner.Name = "owner";
        owner.Size = new Size(290, 23);
        owner.TabIndex = 0;
        // 
        // lbl_name
        // 
        lbl_name.Location = new Point(14, 56);
        lbl_name.Name = "lbl_name";
        lbl_name.Size = new Size(140, 22);
        lbl_name.TabIndex = 0;
        lbl_name.Text = "Название машины";
        // 
        // name
        // 
        name.Location = new Point(156, 52);
        name.MaxLength = 100;
        name.Name = "name";
        name.Size = new Size(290, 23);
        name.TabIndex = 1;
        // 
        // lbl_plate
        // 
        lbl_plate.Location = new Point(14, 90);
        lbl_plate.Name = "lbl_plate";
        lbl_plate.Size = new Size(140, 22);
        lbl_plate.TabIndex = 0;
        lbl_plate.Text = "Госномер";
        // 
        // plate
        // 
        plate.CharacterCasing = CharacterCasing.Upper;
        plate.Location = new Point(156, 86);
        plate.MaxLength = 64;
        plate.Name = "plate";
        plate.Size = new Size(290, 23);
        plate.TabIndex = 2;
        // 
        // lbl_year
        // 
        lbl_year.Location = new Point(14, 124);
        lbl_year.Name = "lbl_year";
        lbl_year.Size = new Size(140, 22);
        lbl_year.TabIndex = 0;
        lbl_year.Text = "Год выпуска";
        // 
        // year
        // 
        year.Location = new Point(156, 120);
        year.MaxLength = 4;
        year.Name = "year";
        year.Size = new Size(290, 23);
        year.TabIndex = 3;
        // 
        // btnSave
        // 
        btnSave.Location = new Point(218, 166);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(134, 28);
        btnSave.TabIndex = 20;
        btnSave.Text = "Сохранить";
        btnSave.Click += btnSave_Click;
        // 
        // btnCancel
        // 
        btnCancel.DialogResult = DialogResult.Cancel;
        btnCancel.Location = new Point(360, 166);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(86, 28);
        btnCancel.TabIndex = 21;
        btnCancel.Text = "Отмена";
        // 
        // Form3
        // 
        AcceptButton = btnSave;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = btnCancel;
        ClientSize = new Size(460, 205);
        Controls.Add(lbl_owner);
        Controls.Add(owner);
        Controls.Add(lbl_name);
        Controls.Add(name);
        Controls.Add(lbl_plate);
        Controls.Add(plate);
        Controls.Add(lbl_year);
        Controls.Add(year);
        Controls.Add(btnSave);
        Controls.Add(btnCancel);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "Form3";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Добавить автомобиль";
        ResumeLayout(false);
        PerformLayout();
    }
}
