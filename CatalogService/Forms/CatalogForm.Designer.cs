namespace CatalogService
{
    partial class CatalogForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            ProductdataGridView = new DataGridView();
            buttonSearch = new Button();
            buttonLogin = new Button();
            buttonClear = new Button();
            label2 = new Label();
            label3 = new Label();
            textBoxUsername = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBoxSearch = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogout = new Button();
            TabeProductButton = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductdataGridView).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(0, 150, 136);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.ForeColor = SystemColors.Control;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1150, 92);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.FromArgb(0, 150, 136);
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(372, 21);
            label1.Name = "label1";
            label1.Size = new Size(406, 49);
            label1.TabIndex = 2;
            label1.Text = "Асортимент товарів";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.UseCompatibleTextRendering = true;
            label1.UseMnemonic = false;
            // 
            // ProductdataGridView
            // 
            ProductdataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            ProductdataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ProductdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            ProductdataGridView.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            ProductdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ProductdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ProductdataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            ProductdataGridView.Location = new Point(49, 104);
            ProductdataGridView.MultiSelect = false;
            ProductdataGridView.Name = "ProductdataGridView";
            ProductdataGridView.ReadOnly = true;
            ProductdataGridView.RowHeadersVisible = false;
            ProductdataGridView.RowHeadersWidth = 51;
            ProductdataGridView.Size = new Size(529, 384);
            ProductdataGridView.TabIndex = 2;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.White;
            buttonSearch.Font = new Font("Arial", 9F, FontStyle.Bold);
            buttonSearch.Image = Properties.Resources.images3;
            buttonSearch.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSearch.Location = new Point(169, 3);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Padding = new Padding(15, 0, 0, 0);
            buttonSearch.Size = new Size(162, 57);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "     Пошук";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonLogin.ForeColor = SystemColors.Control;
            buttonLogin.Location = new Point(69, 303);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(145, 49);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Вхід";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.White;
            buttonClear.Dock = DockStyle.Left;
            buttonClear.Font = new Font("Arial", 9F, FontStyle.Bold);
            buttonClear.Image = Properties.Resources.images4;
            buttonClear.ImageAlign = ContentAlignment.MiddleLeft;
            buttonClear.Location = new Point(0, 0);
            buttonClear.Name = "buttonClear";
            buttonClear.Padding = new Padding(15, 0, 0, 0);
            buttonClear.Size = new Size(162, 57);
            buttonClear.TabIndex = 6;
            buttonClear.Text = "          Очистити";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(14, 14);
            label2.Name = "label2";
            label2.Size = new Size(251, 29);
            label2.TabIndex = 7;
            label2.Text = "Підвищений доступ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(114, 79);
            label3.Name = "label3";
            label3.Size = new Size(63, 24);
            label3.TabIndex = 4;
            label3.Text = "Login";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(57, 117);
            textBoxUsername.MaximumSize = new Size(200, 100);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(171, 27);
            textBoxUsername.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(93, 201);
            label4.Name = "label4";
            label4.Size = new Size(103, 24);
            label4.TabIndex = 9;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(386, 58);
            label5.Name = "label5";
            label5.Size = new Size(111, 24);
            label5.TabIndex = 12;
            label5.Text = "за назвою";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(503, 58);
            textBoxSearch.MaximumSize = new Size(200, 100);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(174, 27);
            textBoxSearch.TabIndex = 13;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(57, 228);
            textBoxPassword.MaximumSize = new Size(200, 100);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(171, 27);
            textBoxPassword.TabIndex = 5;
            // 
            // buttonLogout
            // 
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonLogout.ForeColor = SystemColors.Control;
            buttonLogout.Location = new Point(69, 303);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(145, 49);
            buttonLogout.TabIndex = 14;
            buttonLogout.Text = "Вихід";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Visible = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // TabeProductButton
            // 
            TabeProductButton.FlatStyle = FlatStyle.Flat;
            TabeProductButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TabeProductButton.ForeColor = SystemColors.Control;
            TabeProductButton.Location = new Point(69, 402);
            TabeProductButton.Name = "TabeProductButton";
            TabeProductButton.Size = new Size(145, 72);
            TabeProductButton.TabIndex = 15;
            TabeProductButton.Text = "Прийняти товар";
            TabeProductButton.UseVisualStyleBackColor = true;
            TabeProductButton.Visible = false;
            TabeProductButton.Click += TabeProductButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TabeProductButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(buttonLogout);
            panel1.Controls.Add(textBoxUsername);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(buttonLogin);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(882, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(268, 528);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonClear);
            panel2.Controls.Add(buttonSearch);
            panel2.Location = new Point(49, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(331, 57);
            panel2.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.Controls.Add(ProductdataGridView);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(textBoxSearch);
            panel3.Controls.Add(panel2);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 92);
            panel3.Name = "panel3";
            panel3.Size = new Size(876, 528);
            panel3.TabIndex = 18;
            // 
            // CatalogForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 58);
            ClientSize = new Size(1150, 620);
            ControlBox = false;
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(1168, 667);
            MinimumSize = new Size(1168, 667);
            Name = "CatalogForm";
            Text = "CatalogForm";
            Load += CatalogForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProductdataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private DataGridView ProductdataGridView;
        private Button buttonSearch;
        private Button buttonLogin;
        private Button buttonClear;
        private Label label2;
        private Label label3;
        private TextBox textBoxUsername;
        private Label label4;
        private Label label5;
        private TextBox textBoxSearch;
        private TextBox textBoxPassword;
        private Button buttonLogout;
        private Button TabeProductButton;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}
