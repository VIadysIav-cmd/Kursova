namespace AdminService.Forms
{
    partial class WorkerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridViewUsers = new DataGridView();
            WorkerAdd = new Button();
            WorkerDeleate = new Button();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            WorkerName = new Label();
            WorkerPassword = new Label();
            WorkerStatus = new Label();
            comboBoxRoles = new ComboBox();
            searchlabel = new Label();
            textBoxSearch = new TextBox();
            findbutton = new Button();
            clearbutton = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AllowUserToAddRows = false;
            dataGridViewUsers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewUsers.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewUsers.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewUsers.Location = new Point(12, 85);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.RowHeadersWidth = 51;
            dataGridViewUsers.Size = new Size(434, 188);
            dataGridViewUsers.TabIndex = 0;
            // 
            // WorkerAdd
            // 
            WorkerAdd.FlatAppearance.BorderColor = Color.White;
            WorkerAdd.FlatAppearance.BorderSize = 5;
            WorkerAdd.FlatStyle = FlatStyle.Flat;
            WorkerAdd.Font = new Font("Arial", 12F, FontStyle.Bold);
            WorkerAdd.ForeColor = SystemColors.ButtonHighlight;
            WorkerAdd.Location = new Point(483, 154);
            WorkerAdd.Name = "WorkerAdd";
            WorkerAdd.Size = new Size(139, 51);
            WorkerAdd.TabIndex = 1;
            WorkerAdd.Text = "Додати";
            WorkerAdd.UseVisualStyleBackColor = true;
            WorkerAdd.Click += WorkerAdd_Click;
            // 
            // WorkerDeleate
            // 
            WorkerDeleate.FlatAppearance.BorderColor = Color.White;
            WorkerDeleate.FlatAppearance.BorderSize = 5;
            WorkerDeleate.FlatStyle = FlatStyle.Flat;
            WorkerDeleate.Font = new Font("Arial", 12F, FontStyle.Bold);
            WorkerDeleate.ForeColor = SystemColors.ButtonHighlight;
            WorkerDeleate.Location = new Point(483, 222);
            WorkerDeleate.Name = "WorkerDeleate";
            WorkerDeleate.Size = new Size(139, 51);
            WorkerDeleate.TabIndex = 2;
            WorkerDeleate.Text = "Видалити";
            WorkerDeleate.UseVisualStyleBackColor = true;
            WorkerDeleate.Click += WorkerDeleate_Click;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(53, 56);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(151, 27);
            textBoxUsername.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(53, 135);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(151, 27);
            textBoxPassword.TabIndex = 4;
            // 
            // WorkerName
            // 
            WorkerName.AutoSize = true;
            WorkerName.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            WorkerName.Location = new Point(102, 26);
            WorkerName.Name = "WorkerName";
            WorkerName.Size = new Size(52, 27);
            WorkerName.TabIndex = 6;
            WorkerName.Text = "Ім'я";
            // 
            // WorkerPassword
            // 
            WorkerPassword.AutoSize = true;
            WorkerPassword.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            WorkerPassword.Location = new Point(87, 105);
            WorkerPassword.Name = "WorkerPassword";
            WorkerPassword.Size = new Size(98, 27);
            WorkerPassword.TabIndex = 7;
            WorkerPassword.Text = "Пароль";
            // 
            // WorkerStatus
            // 
            WorkerStatus.AutoSize = true;
            WorkerStatus.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            WorkerStatus.Location = new Point(87, 207);
            WorkerStatus.Name = "WorkerStatus";
            WorkerStatus.Size = new Size(97, 27);
            WorkerStatus.TabIndex = 8;
            WorkerStatus.Text = "Посада";
            // 
            // comboBoxRoles
            // 
            comboBoxRoles.FormattingEnabled = true;
            comboBoxRoles.Location = new Point(53, 237);
            comboBoxRoles.Name = "comboBoxRoles";
            comboBoxRoles.Size = new Size(151, 28);
            comboBoxRoles.TabIndex = 9;
            // 
            // searchlabel
            // 
            searchlabel.AutoSize = true;
            searchlabel.FlatStyle = FlatStyle.Flat;
            searchlabel.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            searchlabel.ForeColor = SystemColors.ControlLightLight;
            searchlabel.Location = new Point(156, 21);
            searchlabel.Name = "searchlabel";
            searchlabel.Size = new Size(154, 27);
            searchlabel.TabIndex = 10;
            searchlabel.Text = "поле пошуку";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(127, 52);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(205, 27);
            textBoxSearch.TabIndex = 11;
            // 
            // findbutton
            // 
            findbutton.FlatAppearance.BorderColor = Color.White;
            findbutton.FlatAppearance.BorderSize = 5;
            findbutton.FlatStyle = FlatStyle.Flat;
            findbutton.Font = new Font("Arial", 12F, FontStyle.Bold);
            findbutton.ForeColor = SystemColors.ButtonHighlight;
            findbutton.Location = new Point(483, 21);
            findbutton.Name = "findbutton";
            findbutton.Size = new Size(139, 51);
            findbutton.TabIndex = 12;
            findbutton.Text = "Знайти";
            findbutton.UseVisualStyleBackColor = true;
            findbutton.Click += findbutton_Click;
            // 
            // clearbutton
            // 
            clearbutton.FlatAppearance.BorderColor = Color.White;
            clearbutton.FlatAppearance.BorderSize = 5;
            clearbutton.FlatStyle = FlatStyle.Flat;
            clearbutton.Font = new Font("Arial", 12F, FontStyle.Bold);
            clearbutton.ForeColor = SystemColors.ButtonHighlight;
            clearbutton.Location = new Point(483, 85);
            clearbutton.Name = "clearbutton";
            clearbutton.Size = new Size(139, 51);
            clearbutton.TabIndex = 13;
            clearbutton.Text = "Очистити";
            clearbutton.UseVisualStyleBackColor = true;
            clearbutton.Click += clearbutton_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 467);
            panel1.Name = "panel1";
            panel1.Size = new Size(905, 125);
            panel1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.Controls.Add(WorkerName);
            panel2.Controls.Add(textBoxUsername);
            panel2.Controls.Add(WorkerPassword);
            panel2.Controls.Add(comboBoxRoles);
            panel2.Controls.Add(textBoxPassword);
            panel2.Controls.Add(WorkerStatus);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(655, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 467);
            panel2.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(39, 39, 40);
            panel3.Controls.Add(WorkerDeleate);
            panel3.Controls.Add(WorkerAdd);
            panel3.Controls.Add(searchlabel);
            panel3.Controls.Add(textBoxSearch);
            panel3.Controls.Add(findbutton);
            panel3.Controls.Add(clearbutton);
            panel3.Controls.Add(dataGridViewUsers);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(655, 291);
            panel3.TabIndex = 16;
            // 
            // WorkerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 592);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "WorkerForm";
            Text = "WorkersForm";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewUsers;
        private Button WorkerAdd;
        private Button WorkerDeleate;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Label WorkerName;
        private Label WorkerPassword;
        private Label WorkerStatus;
        private ComboBox comboBoxRoles;
        private Label searchlabel;
        private TextBox textBoxSearch;
        private Button findbutton;
        private Button clearbutton;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}