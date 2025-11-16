using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace TravelAgencyApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtLogin.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Введите логин и пароль");
                return;
            }

            string query = @"
                SELECT Role FROM Users
                WHERE Username = @u AND PasswordHash = @p";

            DataTable result = Database.ExecuteQuery(query,
                new SqlParameter("@u", username),
                new SqlParameter("@p", password));

            if (result.Rows.Count == 0)
            {
                MessageBox.Show("Неверный логин или пароль");
                return;
            }

            string role = result.Rows[0]["Role"].ToString();

            // открываем нужное окно
            switch (role)
            {
                case "Manager":
                    new ManagerForm().Show();
                    break;
                case "Support":
                    new SupportForm().Show();
                    break;
                case "Operator":
                    new OperatorForm().Show();
                    break;
            }

            this.Hide();
        }
    }
}
