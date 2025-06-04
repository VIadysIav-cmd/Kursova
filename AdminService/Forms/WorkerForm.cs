using System.Data;
using System.Text;
using System.Security.Cryptography;
using AdminService.Interfaces;
using AdminService.Services;

namespace AdminService.Forms
{
    public partial class WorkerForm : Form
    {
        IDatabaseService WorkerDB;
        WorkerQueryBuilder queryBuilder;
        private string _query;

        public WorkerForm(IDatabaseService service, WorkerQueryBuilder queries)
        {
            WorkerDB = service;
            queryBuilder = queries;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            _query = queryBuilder.GetPublicQuery();
            var nameResult = LoadData(_query);
            dataGridViewUsers.DataSource = nameResult;
            LoadRoles();

        }

        private void WorkerDeleate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewUsers.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Будь ласка, виберіть користувача для видалення.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = dataGridViewUsers.SelectedRows[0];
                string username = selectedRow.Cells["Ім'я"].Value?.ToString();
                string passwordHash = selectedRow.Cells["Пароль"].Value?.ToString();

                if (string.IsNullOrWhiteSpace(username))
                {
                    MessageBox.Show("Невірне ім’я користувача.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var confirm = MessageBox.Show($"Ви дійсно хочете видалити користувача '{username}'?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes)
                    return;

                var deleteQuery = queryBuilder.DeleteUserQuery();
                WorkerDB.ExecuteNonQuery(deleteQuery, new Dictionary<string, object>
                {
                    { "@Username", username },
                    { "@Password", passwordHash }
                });

                MessageBox.Show("Користувач успішно видалений.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Обновление таблицы после удаления
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при видаленні користувача: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void findbutton_Click(object sender, EventArgs e)
        {
            string search = textBoxSearch.Text.Trim();
            if (string.IsNullOrWhiteSpace(search))
            {
                LoadData(_query);
            }
            else
            {
                var roleResult = LoadData(queryBuilder.SearchCategoryQuery(search)); 
                if (roleResult.Rows.Count > 0)
                {
                    dataGridViewUsers.DataSource = roleResult;
                }
                else
                {
                    var nameResult = LoadData(queryBuilder.SearchNameQuery(search));
                    dataGridViewUsers.DataSource = nameResult;
                }
            }
        }

        private DataTable LoadData(string query)
        {
            return WorkerDB.ExecuteQuery(query);
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            LoadUsers();
            textBoxSearch.Text = "";
        }

        private void WorkerAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBoxUsername.Text.Trim();
                string password = textBoxPassword.Text.Trim();
                string roleName = comboBoxRoles.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(roleName))
                {
                    MessageBox.Show("Заповніть усі поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Получаем RoleID по имени роли
                var roleIdQuery = queryBuilder.RoleIdByNameQuery();
                var roleTable = WorkerDB.ExecuteQuery(roleIdQuery, new Dictionary<string, object>
                {
                    { "@RoleName", roleName }
                });

                if (roleTable.Rows.Count == 0)
                {
                    MessageBox.Show("Роль не знайдена в базі", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int roleId = Convert.ToInt32(roleTable.Rows[0]["RoleID"]);
                string hashedPassword = HashPassword(password);

                var insertParams = new Dictionary<string, object>
                {
                    { "@Username", username },
                    { "@PasswordHash", hashedPassword },
                    { "@RoleID", roleId }
                };

                WorkerDB.ExecuteNonQuery(queryBuilder.InsertUserQuery(), insertParams);

                MessageBox.Show("Користувач успішно доданий!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBoxUsername.Clear();
                textBoxPassword.Clear();
                comboBoxRoles.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при додаванні користувача: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadUsers();
        }

        private void LoadUsers()
        {
            _query = queryBuilder.GetPublicQuery();
            var table = LoadData(_query);
            dataGridViewUsers.DataSource = table;
        }

        private void LoadRoles()
        {
            try
            {
                _query = queryBuilder.GetAllCateroryNamesQuery();
                var table = WorkerDB.ExecuteQuery(_query); // или просто databaseService.ExecuteQuery(query)

                comboBoxRoles.Items.Clear();

                foreach (DataRow row in table.Rows)
                {
                    comboBoxRoles.Items.Add(row["RoleName"].ToString());
                }

                if (comboBoxRoles.Items.Count > 0)
                    comboBoxRoles.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завантаженні ролей: " + ex.Message);
            }
        }

        private string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password.Trim()));
            return string.Concat(bytes.Select(b => b.ToString("x2")));
        }
    }
}
