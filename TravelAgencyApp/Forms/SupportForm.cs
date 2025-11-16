using System;
using System.Windows.Forms;

namespace TravelAgencyApp
{
    public partial class SupportForm : Form
    {
        public SupportForm()
        {
            InitializeComponent();
        }

        // Изменение статуса заказа
        private void btnSetStatus_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите заказ");
                return;
            }

            string newStatus = comboStatus.Text;

            if (string.IsNullOrWhiteSpace(newStatus))
            {
                MessageBox.Show("Выберите статус");
                return;
            }

            dataGridViewOrders.SelectedRows[0].Cells["Status"].Value = newStatus;
        }

        // Выдача путёвки
        private void btnGiveVoucher_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Сначала выберите заказ");
                return;
            }

            MessageBox.Show("Путёвка выдана клиенту!");
        }

        // Загрузка предварительных заказов
        private void SupportForm_Load(object sender, EventArgs e)
        {
            if (dataGridViewOrders.Columns.Count == 0)
            {
                dataGridViewOrders.Columns.Add("Id", "ID");
                dataGridViewOrders.Columns.Add("Client", "Клиент");
                dataGridViewOrders.Columns.Add("Status", "Статус");
            }

            dataGridViewOrders.Rows.Add("101", "Иванов", "принят");
            dataGridViewOrders.Rows.Add("102", "Петров", "в работе");
            dataGridViewOrders.Rows.Add("103", "Сидоров", "завершен");
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
