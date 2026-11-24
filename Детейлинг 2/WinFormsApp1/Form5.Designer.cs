namespace WinFormsApp1;

partial class Form5
{
    private System.ComponentModel.IContainer components = null;
    private TabControl orderTabs;
    private TabPage newOrderPage;
    private TabPage statusPage;
    private TabPage detailsPage;
    private TabPage reviewPage;
    private Label lbl_client;
    private ComboBox client;
    private Label lbl_car;
    private ComboBox car;
    private Label lbl_master;
    private ComboBox master;
    private Label lbl_services;
    private CheckedListBox services;
    private Label total;
    private Label edit_lbl_status;
    private ComboBox edit_status;
    private Label edit_lbl_master;
    private ComboBox edit_master;
    private DataGridView details_grid;
    private Label review_lbl_rating;
    private NumericUpDown review_rating;
    private Label review_lbl_text;
    private TextBox review_text;
    private Button btnSave;
    private Button btnCancel;

    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        orderTabs = new TabControl();
        newOrderPage = new TabPage();
        statusPage = new TabPage();
        detailsPage = new TabPage();
        reviewPage = new TabPage();
        lbl_client = new Label();
        client = new ComboBox();
        lbl_car = new Label();
        car = new ComboBox();
        lbl_master = new Label();
        master = new ComboBox();
        lbl_services = new Label();
        services = new CheckedListBox();
        total = new Label();
        edit_lbl_status = new Label();
        edit_status = new ComboBox();
        edit_lbl_master = new Label();
        edit_master = new ComboBox();
        details_grid = new DataGridView();
        review_lbl_rating = new Label();
        review_rating = new NumericUpDown();
        review_lbl_text = new Label();
        review_text = new TextBox();
        btnSave = new Button();
        btnCancel = new Button();
        orderTabs.SuspendLayout();
        newOrderPage.SuspendLayout();
        statusPage.SuspendLayout();
        detailsPage.SuspendLayout();
        reviewPage.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)details_grid).BeginInit();
        ((System.ComponentModel.ISupportInitialize)review_rating).BeginInit();
        SuspendLayout();
        //
        // orderTabs
        //
        orderTabs.Name = "orderTabs";
        orderTabs.Location = new Point(8, 8);
        orderTabs.Size = new Size(564, 424);
        orderTabs.TabIndex = 0;
        orderTabs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        orderTabs.SelectedIndex = 0;
        //
        // newOrderPage
        //
        newOrderPage.Name = "newOrderPage";
        newOrderPage.Location = new Point(4, 24);
        newOrderPage.Size = new Size(556, 396);
        newOrderPage.TabIndex = 0;
        newOrderPage.Text = "Новый заказ";
        //
        // statusPage
        //
        statusPage.Name = "statusPage";
        statusPage.Location = new Point(4, 24);
        statusPage.Size = new Size(556, 396);
        statusPage.TabIndex = 0;
        statusPage.Text = "Статус";
        //
        // detailsPage
        //
        detailsPage.Name = "detailsPage";
        detailsPage.Location = new Point(4, 24);
        detailsPage.Size = new Size(556, 396);
        detailsPage.TabIndex = 0;
        detailsPage.Text = "Услуги заказа";
        //
        // reviewPage
        //
        reviewPage.Name = "reviewPage";
        reviewPage.Location = new Point(4, 24);
        reviewPage.Size = new Size(556, 396);
        reviewPage.TabIndex = 0;
        reviewPage.Text = "Отзыв";
        //
        // lbl_client
        //
        lbl_client.Name = "lbl_client";
        lbl_client.Location = new Point(14, 22);
        lbl_client.Size = new Size(140, 22);
        lbl_client.TabIndex = 0;
        lbl_client.Text = "Клиент";
        //
        // client
        //
        client.Name = "client";
        client.Location = new Point(156, 18);
        client.Size = new Size(370, 23);
        client.TabIndex = 0;
        client.DropDownStyle = ComboBoxStyle.DropDownList;
        //
        // lbl_car
        //
        lbl_car.Name = "lbl_car";
        lbl_car.Location = new Point(14, 56);
        lbl_car.Size = new Size(140, 22);
        lbl_car.TabIndex = 0;
        lbl_car.Text = "Автомобиль";
        //
        // car
        //
        car.Name = "car";
        car.Location = new Point(156, 52);
        car.Size = new Size(370, 23);
        car.TabIndex = 1;
        car.DropDownStyle = ComboBoxStyle.DropDownList;
        //
        // lbl_master
        //
        lbl_master.Name = "lbl_master";
        lbl_master.Location = new Point(14, 90);
        lbl_master.Size = new Size(140, 22);
        lbl_master.TabIndex = 0;
        lbl_master.Text = "Мастер";
        //
        // master
        //
        master.Name = "master";
        master.Location = new Point(156, 86);
        master.Size = new Size(370, 23);
        master.TabIndex = 2;
        master.DropDownStyle = ComboBoxStyle.DropDownList;
        //
        // lbl_services
        //
        lbl_services.Name = "lbl_services";
        lbl_services.Location = new Point(14, 128);
        lbl_services.Size = new Size(140, 22);
        lbl_services.TabIndex = 0;
        lbl_services.Text = "Выберите услуги";
        //
        // services
        //
        services.Name = "services";
        services.Location = new Point(156, 124);
        services.Size = new Size(370, 220);
        services.TabIndex = 3;
        services.CheckOnClick = true;
        services.IntegralHeight = false;
        //
        // total
        //
        total.Name = "total";
        total.Location = new Point(156, 358);
        total.Size = new Size(365, 24);
        total.TabIndex = 0;
        total.Text = "Итого: 0 ₽";
        //
        // edit_lbl_status
        //
        edit_lbl_status.Name = "edit_lbl_status";
        edit_lbl_status.Location = new Point(14, 22);
        edit_lbl_status.Size = new Size(140, 22);
        edit_lbl_status.TabIndex = 0;
        edit_lbl_status.Text = "Статус";
        //
        // edit_status
        //
        edit_status.Name = "edit_status";
        edit_status.Location = new Point(156, 18);
        edit_status.Size = new Size(290, 23);
        edit_status.TabIndex = 0;
        edit_status.DropDownStyle = ComboBoxStyle.DropDownList;
        //
        // edit_lbl_master
        //
        edit_lbl_master.Name = "edit_lbl_master";
        edit_lbl_master.Location = new Point(14, 56);
        edit_lbl_master.Size = new Size(140, 22);
        edit_lbl_master.TabIndex = 0;
        edit_lbl_master.Text = "Мастер";
        //
        // edit_master
        //
        edit_master.Name = "edit_master";
        edit_master.Location = new Point(156, 52);
        edit_master.Size = new Size(290, 23);
        edit_master.TabIndex = 1;
        edit_master.DropDownStyle = ComboBoxStyle.DropDownList;
        //
        // details_grid
        //
        details_grid.Name = "details_grid";
        details_grid.Location = new Point(12, 12);
        details_grid.Size = new Size(576, 265);
        details_grid.TabIndex = 0;
        details_grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        details_grid.ReadOnly = true;
        details_grid.AllowUserToAddRows = false;
        details_grid.RowHeadersVisible = false;
        //
        // review_lbl_rating
        //
        review_lbl_rating.Name = "review_lbl_rating";
        review_lbl_rating.Location = new Point(14, 22);
        review_lbl_rating.Size = new Size(140, 22);
        review_lbl_rating.TabIndex = 0;
        review_lbl_rating.Text = "Оценка от 1 до 5";
        //
        // review_rating
        //
        review_rating.Name = "review_rating";
        review_rating.Location = new Point(156, 18);
        review_rating.Size = new Size(290, 23);
        review_rating.TabIndex = 0;
        review_rating.Minimum = 1;
        review_rating.Maximum = 5;
        review_rating.Value = 5;
        //
        // review_lbl_text
        //
        review_lbl_text.Name = "review_lbl_text";
        review_lbl_text.Location = new Point(14, 56);
        review_lbl_text.Size = new Size(140, 22);
        review_lbl_text.TabIndex = 0;
        review_lbl_text.Text = "Ваш отзыв";
        //
        // review_text
        //
        review_text.Name = "review_text";
        review_text.Location = new Point(156, 52);
        review_text.Size = new Size(290, 130);
        review_text.TabIndex = 1;
        review_text.MaxLength = 2000;
        review_text.Multiline = true;
        //
        // btnSave
        //
        btnSave.Name = "btnSave";
        btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnSave.Location = new Point(338, 441);
        btnSave.Size = new Size(134, 28);
        btnSave.TabIndex = 20;
        btnSave.Text = "Сохранить";
        btnSave.Click += btnSave_Click;
        //
        // btnCancel
        //
        btnCancel.Name = "btnCancel";
        btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnCancel.Location = new Point(480, 441);
        btnCancel.Size = new Size(86, 28);
        btnCancel.TabIndex = 21;
        btnCancel.Text = "Отмена";
        btnCancel.DialogResult = DialogResult.Cancel;
        Controls.Add(orderTabs);
        orderTabs.Controls.Add(newOrderPage);
        orderTabs.Controls.Add(statusPage);
        orderTabs.Controls.Add(detailsPage);
        orderTabs.Controls.Add(reviewPage);
        newOrderPage.Controls.Add(lbl_client);
        newOrderPage.Controls.Add(client);
        newOrderPage.Controls.Add(lbl_car);
        newOrderPage.Controls.Add(car);
        newOrderPage.Controls.Add(lbl_master);
        newOrderPage.Controls.Add(master);
        newOrderPage.Controls.Add(lbl_services);
        newOrderPage.Controls.Add(services);
        newOrderPage.Controls.Add(total);
        statusPage.Controls.Add(edit_lbl_status);
        statusPage.Controls.Add(edit_status);
        statusPage.Controls.Add(edit_lbl_master);
        statusPage.Controls.Add(edit_master);
        detailsPage.Controls.Add(details_grid);
        reviewPage.Controls.Add(review_lbl_rating);
        reviewPage.Controls.Add(review_rating);
        reviewPage.Controls.Add(review_lbl_text);
        reviewPage.Controls.Add(review_text);
        Controls.Add(btnSave);
        Controls.Add(btnCancel);
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(580, 480);
        Name = "Form5";
        Text = "Заказ";
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = FormStartPosition.CenterParent;
        CancelButton = btnCancel;
        AcceptButton = btnSave;
        orderTabs.ResumeLayout(false);
        orderTabs.PerformLayout();
        newOrderPage.ResumeLayout(false);
        newOrderPage.PerformLayout();
        statusPage.ResumeLayout(false);
        statusPage.PerformLayout();
        detailsPage.ResumeLayout(false);
        detailsPage.PerformLayout();
        reviewPage.ResumeLayout(false);
        reviewPage.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)details_grid).EndInit();
        ((System.ComponentModel.ISupportInitialize)review_rating).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}
