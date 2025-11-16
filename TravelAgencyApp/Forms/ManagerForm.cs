using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TravelAgencyApp
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        // Добавить сотрудника
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string position = txtPosition.Text.Trim();

            if (name == "" || position == "")
            {
                MessageBox.Show("Введите имя и должность");
                return;
            }

            // создаём колонки если их нет
            if (dataGridViewEmployees.Columns.Count == 0)
            {
                dataGridViewEmployees.Columns.Add("Name", "ФИО");
                dataGridViewEmployees.Columns.Add("Position", "Должность");
                dataGridViewEmployees.Columns.Add("Status", "Статус");
            }

            dataGridViewEmployees.Rows.Add(name, position, "работает");
            txtName.Text = "";
            txtPosition.Text = "";
        }

        // Уволить
        private void btnFire_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите сотрудника");
                return;
            }

            dataGridViewEmployees.SelectedRows[0].Cells["Status"].Value = "уволен";
        }

        // Назначить кассиром
        private void btnSetCashier_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите сотрудника");
                return;
            }

            dataGridViewEmployees.SelectedRows[0].Cells["Position"].Value = "кассир";
        }

        // Назначить оператором
        private void btnSetOperator_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите сотрудника");
                return;
            }

            dataGridViewEmployees.SelectedRows[0].Cells["Position"].Value = "оператор call-центра";
        }

        // Назначить на смену
        private void btnSetShift_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите сотрудника");
                return;
            }

            dataGridViewEmployees.SelectedRows[0].Cells["Status"].Value = "на смене";
        }

        private void dataGridViewEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
