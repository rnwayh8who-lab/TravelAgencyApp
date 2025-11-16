using System;
using System.Windows.Forms;

namespace TravelAgencyApp
{
    public partial class OperatorForm : Form
    {
        public OperatorForm()
        {
            InitializeComponent();
        }

        private void OperatorForm_Load(object sender, EventArgs e)
        {
            // Создаем колонки если их нет
            if (dataGridViewOrders.Columns.Count == 0)
            {
                dataGridViewOrders.Columns.Add("OrderId", "ID заказа");
                dataGridViewOrders.Columns.Add("ClientName", "Клиент");
                dataGridViewOrders.Columns.Add("Tour", "Тур");
                dataGridViewOrders.Columns.Add("Status", "Статус");
            }

            // Добавим примерные заказы
            dataGridViewOrders.Rows.Add("1", "Иванов", "Греция", "принят");
            dataGridViewOrders.Rows.Add("2", "Петров", "Турция", "оплачен");
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            string clientName = txtClientName.Text.Trim();
            if (string.IsNullOrEmpty(clientName))
            {
                MessageBox.Show("Введите имя клиента");
                return;
            }
            MessageBox.Show($"Клиент {clientName} добавлен в систему!");
            txtClientName.Clear();
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            string client = txtClientNameOrder.Text.Trim();
            string tour = txtTour.Text.Trim();
            if (string.IsNullOrEmpty(client) || string.IsNullOrEmpty(tour))
            {
                MessageBox.Show("Заполните данные заказа");
                return;
            }

            int newId = dataGridViewOrders.Rows.Count + 1;
            dataGridViewOrders.Rows.Add(newId.ToString(), client, tour, "принят");
            MessageBox.Show("Заказ создан!");
            txtClientNameOrder.Clear();
            txtTour.Clear();
        }

        private void btnSetStatus_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите заказ");
                return;
            }

            string status = comboStatus.Text;
            if (string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Выберите статус");
                return;
            }

            dataGridViewOrders.SelectedRows[0].Cells["Status"].Value = status;
        }

        private void btnPickTour_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тур подобран для клиента!");
        }

        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
