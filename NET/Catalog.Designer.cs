namespace NET
{
    partial class Catalog
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            textBoxUsername = new TextBox();
            label2 = new Label();
            textBoxPassword = new TextBox();
            label3 = new Label();
            label4 = new Label();
            buttonLogin = new Button();
            buttonLogout = new Button();
            textBoxSearch = new TextBox();
            label5 = new Label();
            buttonSearch = new Button();
            button4 = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(372, 21);
            label1.Name = "label1";
            label1.Size = new Size(406, 49);
            label1.TabIndex = 0;
            label1.Text = "Ассортимент склада";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.UseCompatibleTextRendering = true;
            label1.UseMnemonic = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(0, 192, 192);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1150, 92);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 182);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(728, 384);
            dataGridView1.TabIndex = 2;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(942, 154);
            textBoxUsername.MaximumSize = new Size(200, 100);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(145, 27);
            textBoxUsername.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14F, FontStyle.Bold);
            label2.Location = new Point(882, 98);
            label2.Name = "label2";
            label2.Size = new Size(256, 29);
            label2.TabIndex = 4;
            label2.Text = "Повышеный доступ";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(942, 228);
            textBoxPassword.MaximumSize = new Size(200, 100);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(145, 27);
            textBoxPassword.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.Location = new Point(982, 127);
            label3.Name = "label3";
            label3.Size = new Size(63, 24);
            label3.TabIndex = 6;
            label3.Text = "Login\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold);
            label4.Location = new Point(967, 201);
            label4.Name = "label4";
            label4.Size = new Size(103, 24);
            label4.TabIndex = 7;
            label4.Text = "Password";
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("Arial", 9F, FontStyle.Bold);
            buttonLogin.Location = new Point(942, 273);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(145, 49);
            buttonLogin.TabIndex = 8;
            buttonLogin.Text = "Вход";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.Font = new Font("Arial", 9F, FontStyle.Bold);
            buttonLogout.Location = new Point(942, 328);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(145, 49);
            buttonLogout.TabIndex = 9;
            buttonLogout.Text = "Выход";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Visible = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(435, 137);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(174, 27);
            textBoxSearch.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F);
            label5.Location = new Point(259, 137);
            label5.Name = "label5";
            label5.Size = new Size(170, 23);
            label5.TabIndex = 12;
            label5.Text = "по наименованию";
            // 
            // buttonSearch
            // 
            buttonSearch.Font = new Font("Arial", 9F, FontStyle.Bold);
            buttonSearch.Location = new Point(142, 127);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(111, 49);
            buttonSearch.TabIndex = 13;
            buttonSearch.Text = "Поиск";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Arial", 9F, FontStyle.Bold);
            button4.Location = new Point(12, 127);
            button4.Name = "button4";
            button4.Size = new Size(111, 49);
            button4.TabIndex = 14;
            button4.Text = "Очистить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Catalog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 620);
            ControlBox = false;
            Controls.Add(button4);
            Controls.Add(buttonSearch);
            Controls.Add(label5);
            Controls.Add(textBoxSearch);
            Controls.Add(buttonLogout);
            Controls.Add(buttonLogin);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxPassword);
            Controls.Add(label2);
            Controls.Add(textBoxUsername);
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(1168, 667);
            MinimumSize = new Size(1168, 667);
            Name = "Catalog";
            Text = "Catalog";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private TextBox textBoxUsername;
        private Label label2;
        private TextBox textBoxPassword;
        private Label label3;
        private Label label4;
        private Button buttonLogin;
        private Button buttonLogout;
        private TextBox textBoxSearch;
        private Label label5;
        private Button buttonSearch;
        private Button button4;
    }
}
