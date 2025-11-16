using System;
using System.Windows.Forms;

namespace TravelAgencyApp
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Открываем форму логина
            Application.Run(new LoginForm());
        }
    }
}
