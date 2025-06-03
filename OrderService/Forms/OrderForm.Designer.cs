namespace OrderService
{
    partial class OrderForm
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
            BasketDataGridView = new DataGridView();
            textBox_BarCode = new TextBox();
            label1 = new Label();
            CreateOrderButton = new Button();
            DeleateProductButton = new Button();
            label_Name = new Label();
            label_Price = new Label();
            label6 = new Label();
            textBox_Quantity = new TextBox();
            ClearOrderButton = new Button();
            Find = new Button();
            AddProductButton = new Button();
            label_Total = new Label();
            ((System.ComponentModel.ISupportInitialize)BasketDataGridView).BeginInit();
            SuspendLayout();
            // 
            // BasketDataGridView
            // 
            BasketDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            BasketDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BasketDataGridView.Location = new Point(12, 12);
            BasketDataGridView.Name = "BasketDataGridView";
            BasketDataGridView.RowHeadersWidth = 51;
            BasketDataGridView.Size = new Size(666, 270);
            BasketDataGridView.TabIndex = 0;
            BasketDataGridView.CellClick += dataGridView1_CellClick;
            // 
            // textBox_BarCode
            // 
            textBox_BarCode.Location = new Point(38, 324);
            textBox_BarCode.Name = "textBox_BarCode";
            textBox_BarCode.Size = new Size(162, 27);
            textBox_BarCode.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(38, 296);
            label1.Name = "label1";
            label1.Size = new Size(162, 24);
            label1.TabIndex = 2;
            label1.Text = "Введіть штрих-код";
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CreateOrderButton.Location = new Point(313, 296);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(247, 55);
            CreateOrderButton.TabIndex = 3;
            CreateOrderButton.Text = "Сформувати";
            CreateOrderButton.UseVisualStyleBackColor = true;
            CreateOrderButton.Click += CreateOrderButton_Click;
            // 
            // DeleateProductButton
            // 
            DeleateProductButton.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DeleateProductButton.Location = new Point(854, 196);
            DeleateProductButton.Name = "DeleateProductButton";
            DeleateProductButton.Size = new Size(120, 55);
            DeleateProductButton.TabIndex = 6;
            DeleateProductButton.Text = "Видалити";
            DeleateProductButton.UseVisualStyleBackColor = true;
            DeleateProductButton.Click += button_DeleateFromBasket_Click;
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label_Name.Location = new Point(741, 28);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(224, 27);
            label_Name.TabIndex = 7;
            label_Name.Text = "Наименоание знач";
            label_Name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Price
            // 
            label_Price.AutoSize = true;
            label_Price.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label_Price.Location = new Point(817, 75);
            label_Price.Name = "label_Price";
            label_Price.Size = new Size(92, 24);
            label_Price.TabIndex = 9;
            label_Price.Text = "Цена знач";
            label_Price.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(703, 135);
            label6.Name = "label6";
            label6.Size = new Size(67, 24);
            label6.TabIndex = 10;
            label6.Text = "К - сть:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_Quantity
            // 
            textBox_Quantity.Location = new Point(795, 135);
            textBox_Quantity.Name = "textBox_Quantity";
            textBox_Quantity.Size = new Size(142, 27);
            textBox_Quantity.TabIndex = 11;
            // 
            // ClearOrderButton
            // 
            ClearOrderButton.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ClearOrderButton.Location = new Point(313, 369);
            ClearOrderButton.Name = "ClearOrderButton";
            ClearOrderButton.Size = new Size(247, 55);
            ClearOrderButton.TabIndex = 12;
            ClearOrderButton.Text = "Анулювати";
            ClearOrderButton.UseVisualStyleBackColor = true;
            ClearOrderButton.Click += ClearOrderButton_Click;
            // 
            // Find
            // 
            Find.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Find.Location = new Point(48, 369);
            Find.Name = "Find";
            Find.Size = new Size(142, 55);
            Find.TabIndex = 13;
            Find.Text = "Знайти";
            Find.UseVisualStyleBackColor = true;
            Find.Click += Find_Click;
            // 
            // AddProductButton
            // 
            AddProductButton.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AddProductButton.Location = new Point(694, 197);
            AddProductButton.Name = "AddProductButton";
            AddProductButton.Size = new Size(142, 55);
            AddProductButton.TabIndex = 14;
            AddProductButton.Text = "Додати в корзину";
            AddProductButton.UseVisualStyleBackColor = true;
            AddProductButton.Click += button_AddToBasket_Click;
            // 
            // label_Total
            // 
            label_Total.AutoSize = true;
            label_Total.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label_Total.Location = new Point(676, 311);
            label_Total.Name = "label_Total";
            label_Total.Size = new Size(160, 24);
            label_Total.TabIndex = 15;
            label_Total.Text = "Сума замовлення:";
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(986, 521);
            ControlBox = false;
            Controls.Add(label_Total);
            Controls.Add(AddProductButton);
            Controls.Add(Find);
            Controls.Add(ClearOrderButton);
            Controls.Add(textBox_Quantity);
            Controls.Add(label6);
            Controls.Add(label_Price);
            Controls.Add(label_Name);
            Controls.Add(DeleateProductButton);
            Controls.Add(CreateOrderButton);
            Controls.Add(label1);
            Controls.Add(textBox_BarCode);
            Controls.Add(BasketDataGridView);
            ForeColor = SystemColors.ControlText;
            Name = "OrderForm";
            Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)BasketDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView BasketDataGridView;
        private TextBox textBox_BarCode;
        private Label label1;
        private Button CreateOrderButton;
        private Button DeleateProductButton;
        private Label label_Name;
        private Label label_Price;
        private Label label6;
        private TextBox textBox_Quantity;
        private Button ClearOrderButton;
        private Button Find;
        private Button AddProductButton;
        private Label label_Total;
    }
}
