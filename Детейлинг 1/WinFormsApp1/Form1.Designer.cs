namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            dgvOrders = new TabPage();
            btnCreateOrder = new Button();
            tabPage1 = new DataGridView();
            dgvClients = new TabPage();
            dataGridView2 = new DataGridView();
            dgvManagers = new TabPage();
            dataGridView3 = new DataGridView();
            dgvMasters = new TabPage();
            dataGridView4 = new DataGridView();
            dgvServices = new TabPage();
            dataGridView5 = new DataGridView();
            tabControl1.SuspendLayout();
            dgvOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabPage1).BeginInit();
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
            tabControl1.Controls.Add(dgvOrders);
            tabControl1.Controls.Add(dgvClients);
            tabControl1.Controls.Add(dgvManagers);
            tabControl1.Controls.Add(dgvMasters);
            tabControl1.Controls.Add(dgvServices);
            tabControl1.Location = new Point(0, -2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(801, 452);
            tabControl1.TabIndex = 0;
            // 
            // dgvOrders
            // 
            dgvOrders.Controls.Add(btnCreateOrder);
            dgvOrders.Controls.Add(tabPage1);
            dgvOrders.Location = new Point(4, 24);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.Padding = new Padding(3);
            dgvOrders.Size = new Size(793, 424);
            dgvOrders.TabIndex = 0;
            dgvOrders.Text = "Заказы";
            dgvOrders.UseVisualStyleBackColor = true;
            // 
            // btnCreateOrder
            // 
            btnCreateOrder.Location = new Point(6, 384);
            btnCreateOrder.Name = "btnCreateOrder";
            btnCreateOrder.Size = new Size(119, 34);
            btnCreateOrder.TabIndex = 1;
            btnCreateOrder.Text = "button1";
            btnCreateOrder.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabPage1.Location = new Point(0, 0);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(793, 377);
            tabPage1.TabIndex = 0;
            // 
            // dgvClients
            // 
            dgvClients.Controls.Add(dataGridView2);
            dgvClients.Location = new Point(4, 24);
            dgvClients.Name = "dgvClients";
            dgvClients.Padding = new Padding(3);
            dgvClients.Size = new Size(793, 424);
            dgvClients.TabIndex = 1;
            dgvClients.Text = "Клиенты";
            dgvClients.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(793, 377);
            dataGridView2.TabIndex = 1;
            // 
            // dgvManagers
            // 
            dgvManagers.Controls.Add(dataGridView3);
            dgvManagers.Location = new Point(4, 24);
            dgvManagers.Name = "dgvManagers";
            dgvManagers.Padding = new Padding(3);
            dgvManagers.Size = new Size(793, 424);
            dgvManagers.TabIndex = 2;
            dgvManagers.Text = "Менеджеры";
            dgvManagers.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(0, 0);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(793, 377);
            dataGridView3.TabIndex = 2;
            // 
            // dgvMasters
            // 
            dgvMasters.Controls.Add(dataGridView4);
            dgvMasters.Location = new Point(4, 24);
            dgvMasters.Name = "dgvMasters";
            dgvMasters.Padding = new Padding(3);
            dgvMasters.Size = new Size(793, 424);
            dgvMasters.TabIndex = 3;
            dgvMasters.Text = "Мастера";
            dgvMasters.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(0, 0);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(793, 377);
            dataGridView4.TabIndex = 2;
            // 
            // dgvServices
            // 
            dgvServices.Controls.Add(dataGridView5);
            dgvServices.Location = new Point(4, 24);
            dgvServices.Name = "dgvServices";
            dgvServices.Padding = new Padding(3);
            dgvServices.Size = new Size(793, 424);
            dgvServices.TabIndex = 4;
            dgvServices.Text = "Услуги";
            dgvServices.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(0, 0);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.Size = new Size(793, 377);
            dataGridView5.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "\\";
            tabControl1.ResumeLayout(false);
            dgvOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tabPage1).EndInit();
            dgvClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            dgvManagers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            dgvMasters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            dgvServices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage dgvOrders;
        private TabPage dgvClients;
        private TabPage dgvManagers;
        private TabPage dgvMasters;
        private TabPage dgvServices;
        private DataGridView tabPage1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private DataGridView dataGridView4;
        private DataGridView dataGridView5;
        private Button btnCreateOrder;
    }
}
