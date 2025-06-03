namespace AdminService.Forms
{
    partial class PartForm
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
            dataGridViewProducts = new DataGridView();
            clearbutton = new Button();
            findbutton = new Button();
            textBoxSearch = new TextBox();
            searchlabel = new Label();
            comboBoxCategiries = new ComboBox();
            ProductCategory = new Label();
            ProductBarcoe = new Label();
            ProductName = new Label();
            textBoxBarCode = new TextBox();
            textBoxProductname = new TextBox();
            ProductDeleate = new Button();
            ProductAdd = new Button();
            textBoxLocation = new TextBox();
            Location = new Label();
            Price = new Label();
            textBoxPrice = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.BackgroundColor = SystemColors.Control;
            dataGridViewProducts.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Dock = DockStyle.Fill;
            dataGridViewProducts.Location = new Point(0, 0);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.Size = new Size(778, 300);
            dataGridViewProducts.TabIndex = 0;
            // 
            // clearbutton
            // 
            clearbutton.FlatAppearance.BorderSize = 5;
            clearbutton.FlatStyle = FlatStyle.Flat;
            clearbutton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            clearbutton.ForeColor = SystemColors.Control;
            clearbutton.Location = new Point(197, 18);
            clearbutton.Name = "clearbutton";
            clearbutton.Size = new Size(139, 58);
            clearbutton.TabIndex = 17;
            clearbutton.Text = "Очистити";
            clearbutton.UseVisualStyleBackColor = true;
            clearbutton.Click += clearbutton_Click;
            clearbutton.MouseEnter += clearbutton_MouseEnter;
            clearbutton.MouseLeave += clearbutton_MouseLeave;
            // 
            // findbutton
            // 
            findbutton.FlatAppearance.BorderSize = 5;
            findbutton.FlatStyle = FlatStyle.Flat;
            findbutton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            findbutton.ForeColor = SystemColors.Control;
            findbutton.Location = new Point(363, 18);
            findbutton.Name = "findbutton";
            findbutton.Size = new Size(139, 58);
            findbutton.TabIndex = 16;
            findbutton.Text = "Знайти";
            findbutton.UseVisualStyleBackColor = true;
            findbutton.Click += findbutton_Click;
            findbutton.MouseEnter += findbutton_MouseEnter;
            findbutton.MouseLeave += findbutton_MouseLeave;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(14, 49);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(154, 27);
            textBoxSearch.TabIndex = 15;
            // 
            // searchlabel
            // 
            searchlabel.AutoSize = true;
            searchlabel.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            searchlabel.ForeColor = SystemColors.Control;
            searchlabel.Location = new Point(14, 12);
            searchlabel.Name = "searchlabel";
            searchlabel.Size = new Size(154, 27);
            searchlabel.TabIndex = 14;
            searchlabel.Text = "поле пошуку";
            // 
            // comboBoxCategiries
            // 
            comboBoxCategiries.FormattingEnabled = true;
            comboBoxCategiries.Location = new Point(406, 54);
            comboBoxCategiries.Name = "comboBoxCategiries";
            comboBoxCategiries.Size = new Size(151, 28);
            comboBoxCategiries.TabIndex = 23;
            // 
            // ProductCategory
            // 
            ProductCategory.AutoSize = true;
            ProductCategory.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ProductCategory.ForeColor = SystemColors.Control;
            ProductCategory.Location = new Point(417, 24);
            ProductCategory.Name = "ProductCategory";
            ProductCategory.Size = new Size(121, 27);
            ProductCategory.TabIndex = 22;
            ProductCategory.Text = "Категорія";
            // 
            // ProductBarcoe
            // 
            ProductBarcoe.AutoSize = true;
            ProductBarcoe.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ProductBarcoe.ForeColor = SystemColors.Control;
            ProductBarcoe.Location = new Point(208, 24);
            ProductBarcoe.Name = "ProductBarcoe";
            ProductBarcoe.Size = new Size(147, 27);
            ProductBarcoe.TabIndex = 21;
            ProductBarcoe.Text = "Штрих - код";
            // 
            // ProductName
            // 
            ProductName.AutoSize = true;
            ProductName.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ProductName.ForeColor = SystemColors.Control;
            ProductName.Location = new Point(45, 24);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(80, 27);
            ProductName.TabIndex = 20;
            ProductName.Text = "Назва";
            // 
            // textBoxBarCode
            // 
            textBoxBarCode.Location = new Point(198, 54);
            textBoxBarCode.Name = "textBoxBarCode";
            textBoxBarCode.Size = new Size(167, 27);
            textBoxBarCode.TabIndex = 19;
            // 
            // textBoxProductname
            // 
            textBoxProductname.Location = new Point(14, 54);
            textBoxProductname.Name = "textBoxProductname";
            textBoxProductname.Size = new Size(143, 27);
            textBoxProductname.TabIndex = 18;
            // 
            // ProductDeleate
            // 
            ProductDeleate.BackColor = SystemColors.ScrollBar;
            ProductDeleate.Cursor = Cursors.No;
            ProductDeleate.FlatStyle = FlatStyle.Flat;
            ProductDeleate.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ProductDeleate.Location = new Point(3, 274);
            ProductDeleate.Name = "ProductDeleate";
            ProductDeleate.Size = new Size(206, 51);
            ProductDeleate.TabIndex = 25;
            ProductDeleate.Text = "Видалити";
            ProductDeleate.UseVisualStyleBackColor = false;
            ProductDeleate.Click += ProductDeleate_Click;
            // 
            // ProductAdd
            // 
            ProductAdd.BackColor = SystemColors.ScrollBar;
            ProductAdd.Cursor = Cursors.Hand;
            ProductAdd.FlatStyle = FlatStyle.Popup;
            ProductAdd.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ProductAdd.ForeColor = SystemColors.ActiveCaptionText;
            ProductAdd.Location = new Point(3, 161);
            ProductAdd.Name = "ProductAdd";
            ProductAdd.Size = new Size(203, 51);
            ProductAdd.TabIndex = 24;
            ProductAdd.Text = "Додати";
            ProductAdd.UseVisualStyleBackColor = false;
            ProductAdd.Click += ProductAdd_Click;
            // 
            // textBoxLocation
            // 
            textBoxLocation.Location = new Point(198, 142);
            textBoxLocation.Name = "textBoxLocation";
            textBoxLocation.Size = new Size(167, 27);
            textBoxLocation.TabIndex = 26;
            // 
            // Location
            // 
            Location.AutoSize = true;
            Location.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Location.ForeColor = SystemColors.Control;
            Location.Location = new Point(188, 112);
            Location.Name = "Location";
            Location.Size = new Size(192, 27);
            Location.TabIndex = 27;
            Location.Text = "Місце на складі";
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Price.ForeColor = SystemColors.Control;
            Price.Location = new Point(55, 112);
            Price.Name = "Price";
            Price.Size = new Size(63, 27);
            Price.TabIndex = 28;
            Price.Text = "Ціна";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(14, 142);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(143, 27);
            textBoxPrice.TabIndex = 29;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(ProductDeleate);
            panel1.Controls.Add(ProductAdd);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(778, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 602);
            panel1.TabIndex = 30;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo2;
            pictureBox1.Location = new Point(58, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(searchlabel);
            panel2.Controls.Add(textBoxSearch);
            panel2.Controls.Add(findbutton);
            panel2.Controls.Add(clearbutton);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(778, 91);
            panel2.TabIndex = 31;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.WindowText;
            panel3.Controls.Add(ProductName);
            panel3.Controls.Add(textBoxProductname);
            panel3.Controls.Add(Price);
            panel3.Controls.Add(comboBoxCategiries);
            panel3.Controls.Add(textBoxLocation);
            panel3.Controls.Add(ProductCategory);
            panel3.Controls.Add(Location);
            panel3.Controls.Add(textBoxPrice);
            panel3.Controls.Add(ProductBarcoe);
            panel3.Controls.Add(textBoxBarCode);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 392);
            panel3.Name = "panel3";
            panel3.Size = new Size(778, 210);
            panel3.TabIndex = 26;
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridViewProducts);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 92);
            panel4.Name = "panel4";
            panel4.Size = new Size(778, 300);
            panel4.TabIndex = 27;
            // 
            // PartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(987, 602);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "PartForm";
            Text = "PartForm";
            Load += PartForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewProducts;
        private Button clearbutton;
        private Button findbutton;
        private TextBox textBoxSearch;
        private Label searchlabel;
        private ComboBox comboBoxCategiries;
        private Label ProductCategory;
        private Label ProductBarcoe;
        private Label ProductName;
        private TextBox textBoxBarCode;
        private TextBox textBoxProductname;
        private Button ProductDeleate;
        private Button ProductAdd;
        private TextBox textBoxLocation;
        private Label Location;
        private Label Price;
        private TextBox textBoxPrice;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private PictureBox pictureBox1;
    }
}