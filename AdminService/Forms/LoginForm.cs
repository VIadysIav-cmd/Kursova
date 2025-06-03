using System;
using System.Collections.Generic;
using System.ComponentModel;

using AdminService.Interfaces;


namespace AdminService.Forms
{
    public partial class LoginForm : Form
    {

        IAuthService _service;
        public LoginForm(IAuthService service)
        {
            _service = service;
            InitializeComponent();

        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true; // чтобы Enter не "переходил" дальше

                AttemptLogin();
            }
        }


        private void AttemptLogin()
        {
            string login = LoginTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Є пусті поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_service.CheckAdmin(login, password))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Невірний логін або пароль", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
