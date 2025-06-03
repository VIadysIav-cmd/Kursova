using AdminService.Forms;
using AdminService.Models;


namespace AdminService
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            string catalogConnection = MultiConnectionProvider.Instance.CatalogDb;
            string usersConnection = MultiConnectionProvider.Instance.WorkerDb;
            var services = new ServiceManager(catalogConnection, usersConnection, 5001, "192.168.0.143");
            ApplicationConfiguration.Initialize();

            // Показываем LoginForm как диалог
            using var loginForm = new LoginForm(services.Auth);
            var result = loginForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Запускаем основную форму
                Application.Run(new MainForm(services));
            }
            else
            {
                // Завершаем, если отмена/неудача
                Application.Exit();
            }

            //Application.Run(new LoginForm(services));
        }
    }
}