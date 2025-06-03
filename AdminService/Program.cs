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

            // ���������� LoginForm ��� ������
            using var loginForm = new LoginForm(services.Auth);
            var result = loginForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                // ��������� �������� �����
                Application.Run(new MainForm(services));
            }
            else
            {
                // ���������, ���� ������/�������
                Application.Exit();
            }

            //Application.Run(new LoginForm(services));
        }
    }
}