using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Загружаем данные из БД при старте программы
            this.servicesTableAdapter.Fill(this.database61DataSet.Services);
            this.ordersTableAdapter.Fill(this.database61DataSet.Orders);
            this.mastersTableAdapter.Fill(this.database61DataSet.Masters);
            this.managersTableAdapter.Fill(this.database61DataSet.Managers);
            this.clientsTableAdapter.Fill(this.database61DataSet.Clients);
        }

        // КНОПКА: ДОБАВИТЬ
        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0: clientsBindingSource.AddNew(); clientsDataGridView.Focus(); break;
                case 1: managersBindingSource.AddNew(); break;
                case 2: mastersBindingSource.AddNew(); break;
                case 3: ordersBindingSource.AddNew(); break;
                case 4: servicesBindingSource.AddNew(); break;
            }
        }

        // КНОПКА: УДАЛИТЬ
        private void btnDelete_Click(object sender, EventArgs e)
        {
            BindingSource currentBindingSource = null;
            string entityName = "";

            switch (tabControl1.SelectedIndex)
            {
                case 0: currentBindingSource = clientsBindingSource; entityName = "клиента"; break;
                case 1: currentBindingSource = managersBindingSource; entityName = "менеджера"; break;
                case 2: currentBindingSource = mastersBindingSource; entityName = "мастера"; break;
                case 3: currentBindingSource = ordersBindingSource; entityName = "заказ"; break;
                case 4: currentBindingSource = servicesBindingSource; entityName = "услугу"; break;
            }

            if (currentBindingSource != null && currentBindingSource.Current != null)
            {
                DialogResult result = MessageBox.Show(
                    $"Вы точно хотите удалить выбранного {entityName} и все связанные данные?",
                    "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    currentBindingSource.RemoveCurrent();

                    switch (tabControl1.SelectedIndex)
                    {
                        case 0: this.clientsTableAdapter.Update(this.database61DataSet.Clients); break;
                        case 1: this.managersTableAdapter.Update(this.database61DataSet.Managers); break;
                        case 2: this.mastersTableAdapter.Update(this.database61DataSet.Masters); break;
                        case 3: this.ordersTableAdapter.Update(this.database61DataSet.Orders); break;
                        case 4: this.servicesTableAdapter.Update(this.database61DataSet.Services); break;
                    }
                    MessageBox.Show("Запись успешно удалена!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Сначала выберите строку для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // КНОПКА: СОХРАНИТЬ ВСЁ
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();

                switch (tabControl1.SelectedIndex)
                {
                    case 0:
                        foreach (DataRow row in this.database61DataSet.Clients.Rows)
                        {
                            if (row.RowState != DataRowState.Deleted && string.IsNullOrWhiteSpace(row["LastName"].ToString()))
                            {
                                MessageBox.Show("Заполнение Фамилии клиента обязательно!", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        this.clientsBindingSource.EndEdit();
                        this.clientsTableAdapter.Update(this.database61DataSet.Clients);
                        break;
                    case 1:
                        this.managersBindingSource.EndEdit();
                        this.managersTableAdapter.Update(this.database61DataSet.Managers);
                        break;
                    case 2:
                        this.mastersBindingSource.EndEdit();
                        this.mastersTableAdapter.Update(this.database61DataSet.Masters);
                        break;
                    case 3:
                        this.ordersBindingSource.EndEdit();
                        this.ordersTableAdapter.Update(this.database61DataSet.Orders);
                        break;
                    case 4:
                        this.servicesBindingSource.EndEdit();
                        this.servicesTableAdapter.Update(this.database61DataSet.Services);
                        break;
                }
                MessageBox.Show("Данные успешно сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // КНОПКА: ОБНОВИТЬ
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0: this.clientsTableAdapter.Fill(this.database61DataSet.Clients); break;
                case 1: this.managersTableAdapter.Fill(this.database61DataSet.Managers); break;
                case 2: this.mastersTableAdapter.Fill(this.database61DataSet.Masters); break;
                case 3: this.ordersTableAdapter.Fill(this.database61DataSet.Orders); break;
                case 4: this.servicesTableAdapter.Fill(this.database61DataSet.Services); break;
            }
            MessageBox.Show("Данные успешно обновлены!", "Обновление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        // ЖИВОЙ ПОИСК КЛИЕНТОВ (ВЫЗЫВАЕТСЯ ИЗ ДИЗАЙНЕРА)
        private void txtSearchClient_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchClient.Text))
            {
                clientsBindingSource.Filter = "";
            }
            else
            {
                string filterText = txtSearchClient.Text.Replace("'", "''");
                clientsBindingSource.Filter = $"LastName LIKE '%{filterText}%' OR CarNumber LIKE '%{filterText}%'";
            }
        }

        // ПОДСВЕТКА СТАТУСОВ (ВЫЗЫВАЕТСЯ ИЗ ДИЗАЙНЕРА)
        private void dataGridView3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView3.Columns[e.ColumnIndex].Name == "statusDataGridViewTextBoxColumn" && e.Value != null)
            {
                string status = e.Value.ToString().Trim().ToLower();
                DataGridViewRow row = dataGridView3.Rows[e.RowIndex];

                switch (status)
                {
                    case "новый":
                    case "в обработке":
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 243, 205); // Желтый
                        break;
                    case "в работе":
                        row.DefaultCellStyle.BackColor = Color.FromArgb(209, 236, 241); // Синий
                        break;
                    case "выполнен":
                    case "завершен":
                        row.DefaultCellStyle.BackColor = Color.FromArgb(212, 239, 223); // Зеленый
                        break;
                    case "отменен":
                        row.DefaultCellStyle.BackColor = Color.FromArgb(248, 215, 218); // Красный
                        break;
                }
            }
        }
    }
}
