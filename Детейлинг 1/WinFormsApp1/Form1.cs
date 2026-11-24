using System;
using System.Data;
using System.Windows.Forms;
// Подключаем библиотеку для работы с базой данных MS Access
using System.Data.OleDb;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // Строка подключения к БД. Файл Detailing.accdb должен лежать в папке bin/Debug/ вашего проекта
        private string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Detailing.accdb;";

        public Form1()
        {
            InitializeComponent();

            // Явно привязываем событие загрузки формы на случай, если в дизайнере не кликнули дважды
            this.Load += new System.EventHandler(this.Form1_Load);
        }

        // Событие, которое автоматически срабатывает при запуске программы
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadOrders();    // Загрузка вкладки "Заказы"
            LoadClients();   // Загрузка вкладки "Клиенты"
            LoadManagers();  // Загрузка вкладки "Менеджеры"
            LoadMasters();   // Загрузка вкладки "Мастера"
            LoadServices();  // Загрузка вкладки "Услуги"
        }

        // 1. Загрузка вкладки "Заказы" (со склейкой текстовых данных вместо ID)
        private void LoadOrders()
        {
            using (OleDbConnection connection = new OleDbConnection(connString))
            {
                string query = @"SELECT o.ID_Order AS [ID Заказа], 
                                        c.LastName & ' ' & c.FirstName AS [Клиент], 
                                        m.FullName AS [Менеджер], 
                                        mas.FullName AS [Мастер], 
                                        s.ServiceName AS [Услуга], 
                                        o.OrderDate AS [Дата создания], 
                                        o.Status AS [Статус заказа],
                                        o.Rating AS [Отзыв (Оценка)]
                                 FROM ((((Orders o
                                 LEFT JOIN Clients c ON o.ClientID = c.ID_Client)
                                 LEFT JOIN Managers m ON o.ManagerID = m.ID_Manager)
                                 LEFT JOIN Masters mas ON o.MasterID = mas.ID_Master)
                                 LEFT JOIN Services s ON o.ServiceID = s.ID_Service)";

                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                DataTable dt = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dt);
                    dgvOrders.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки заказов: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 2. Загрузка вкладки "Клиенты"
        private void LoadClients()
        {
            using (OleDbConnection connection = new OleDbConnection(connString))
            {
                string query = "SELECT ID_Client AS [ID], LastName AS [Фамилия], FirstName AS [Имя], Phone AS [Телефон], CarModel AS [Марка авто], CarNumber AS [Гос. номер] FROM Clients";
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                DataTable dt = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dt);
                    dgvClients.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки клиентов: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 3. Загрузка вкладки "Менеджеры"
        private void LoadManagers()
        {
            using (OleDbConnection connection = new OleDbConnection(connString))
            {
                string query = "SELECT ID_Manager AS [ID], FullName AS [ФИО Менеджера], Position AS [Должность] FROM Managers";
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                DataTable dt = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dt);
                    dgvManagers.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки менеджеров: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 4. Загрузка вкладки "Мастера"
        private void LoadMasters()
        {
            using (OleDbConnection connection = new OleDbConnection(connString))
            {
                string query = "SELECT ID_Master AS [ID], FullName AS [ФИО Мастера], Specialization AS [Специализация] FROM Masters";
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                DataTable dt = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dt);
                    dgvMasters.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки мастеров: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 5. Загрузка вкладки "Услуги"
        private void LoadServices()
        {
            using (OleDbConnection connection = new OleDbConnection(connString))
            {
                string query = "SELECT ID_Service AS [ID], ServiceName AS [Название услуги], Price AS [Стоимость] FROM Services";
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                DataTable dt = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dt);
                    dgvServices.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки услуг: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}