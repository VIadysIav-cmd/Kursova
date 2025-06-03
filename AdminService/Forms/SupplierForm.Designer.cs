namespace AdminService.Forms
{
    partial class SupplierForm
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
            components = new System.ComponentModel.Container();
            dataGridViewProduct_Supplier = new DataGridView();
            comboBoxProductName = new ComboBox();
            comboBoxSupplierName = new ComboBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            Add_Supplier = new ToolStripMenuItem();
            Deleate_Supplier = new ToolStripMenuItem();
            Add_Contract = new ToolStripMenuItem();
            Deleate_Contract = new ToolStripMenuItem();
            textBoxSupplierEmail = new TextBox();
            labelEmail = new Label();
            textBoxSupplierPhone = new TextBox();
            labelPhone = new Label();
            labelName = new Label();
            textBoxSupplierName = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct_Supplier).BeginInit();
            contextMenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewProduct_Supplier
            // 
            dataGridViewProduct_Supplier.AllowUserToAddRows = false;
            dataGridViewProduct_Supplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProduct_Supplier.BackgroundColor = SystemColors.Control;
            dataGridViewProduct_Supplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduct_Supplier.Location = new Point(97, 0);
            dataGridViewProduct_Supplier.Name = "dataGridViewProduct_Supplier";
            dataGridViewProduct_Supplier.ReadOnly = true;
            dataGridViewProduct_Supplier.RowHeadersWidth = 51;
            dataGridViewProduct_Supplier.Size = new Size(403, 276);
            dataGridViewProduct_Supplier.TabIndex = 0;
            // 
            // comboBoxProductName
            // 
            comboBoxProductName.FormattingEnabled = true;
            comboBoxProductName.Location = new Point(97, 317);
            comboBoxProductName.Name = "comboBoxProductName";
            comboBoxProductName.Size = new Size(175, 28);
            comboBoxProductName.TabIndex = 1;
            // 
            // comboBoxSupplierName
            // 
            comboBoxSupplierName.FormattingEnabled = true;
            comboBoxSupplierName.Location = new Point(329, 317);
            comboBoxSupplierName.Name = "comboBoxSupplierName";
            comboBoxSupplierName.Size = new Size(171, 28);
            comboBoxSupplierName.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { Add_Supplier, Deleate_Supplier, Add_Contract, Deleate_Contract });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(253, 100);
            // 
            // Add_Supplier
            // 
            Add_Supplier.Name = "Add_Supplier";
            Add_Supplier.Size = new Size(252, 24);
            Add_Supplier.Text = "Додати постачатьника";
            Add_Supplier.Click += Add_Supplier_Click;
            // 
            // Deleate_Supplier
            // 
            Deleate_Supplier.Name = "Deleate_Supplier";
            Deleate_Supplier.Size = new Size(252, 24);
            Deleate_Supplier.Text = "Видалити постачальника";
            Deleate_Supplier.Click += Deleate_Supplier_Click;
            // 
            // Add_Contract
            // 
            Add_Contract.Name = "Add_Contract";
            Add_Contract.Size = new Size(252, 24);
            Add_Contract.Text = "Сформувати контракт";
            Add_Contract.Click += Add_Contract_Click;
            // 
            // Deleate_Contract
            // 
            Deleate_Contract.Name = "Deleate_Contract";
            Deleate_Contract.Size = new Size(252, 24);
            Deleate_Contract.Text = "Розторгнути контракт";
            Deleate_Contract.Click += Deleate_Contract_Click;
            // 
            // textBoxSupplierEmail
            // 
            textBoxSupplierEmail.Location = new Point(36, 265);
            textBoxSupplierEmail.Name = "textBoxSupplierEmail";
            textBoxSupplierEmail.Size = new Size(199, 27);
            textBoxSupplierEmail.TabIndex = 5;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelEmail.Location = new Point(11, 235);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(247, 27);
            labelEmail.TabIndex = 8;
            labelEmail.Text = "Електронна адресса";
            // 
            // textBoxSupplierPhone
            // 
            textBoxSupplierPhone.Location = new Point(36, 156);
            textBoxSupplierPhone.Name = "textBoxSupplierPhone";
            textBoxSupplierPhone.Size = new Size(199, 27);
            textBoxSupplierPhone.TabIndex = 4;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelPhone.Location = new Point(30, 126);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(205, 27);
            labelPhone.TabIndex = 7;
            labelPhone.Text = "Номер телефону";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelName.Location = new Point(90, 23);
            labelName.Name = "labelName";
            labelName.Size = new Size(80, 27);
            labelName.TabIndex = 6;
            labelName.Text = "Назва";
            // 
            // textBoxSupplierName
            // 
            textBoxSupplierName.Location = new Point(36, 53);
            textBoxSupplierName.Name = "textBoxSupplierName";
            textBoxSupplierName.Size = new Size(199, 27);
            textBoxSupplierName.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBoxSupplierEmail);
            panel1.Controls.Add(labelEmail);
            panel1.Controls.Add(labelName);
            panel1.Controls.Add(labelPhone);
            panel1.Controls.Add(textBoxSupplierName);
            panel1.Controls.Add(textBoxSupplierPhone);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(604, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(261, 597);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo2;
            pictureBox1.Location = new Point(80, 456);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(comboBoxSupplierName);
            panel2.Controls.Add(comboBoxProductName);
            panel2.Controls.Add(dataGridViewProduct_Supplier);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(604, 455);
            panel2.TabIndex = 10;
            // 
            // SupplierForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 597);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SupplierForm";
            Text = "SupplierForm";
            Load += SupplierForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct_Supplier).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewProduct_Supplier;
        private ComboBox comboBoxProductName;
        private ComboBox comboBoxSupplierName;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem Add_Supplier;
        private ToolStripMenuItem Deleate_Supplier;
        private ToolStripMenuItem Add_Contract;
        private ToolStripMenuItem Deleate_Contract;
        private TextBox textBoxSupplierEmail;
        private Label labelEmail;
        private TextBox textBoxSupplierPhone;
        private Label labelPhone;
        private Label labelName;
        private TextBox textBoxSupplierName;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
    }
}