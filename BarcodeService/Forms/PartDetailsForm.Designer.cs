namespace BarcodeService
{
    partial class PartDetailsForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            quantityValue = new Label();
            quantityLabel = new Label();
            typeValue = new Label();
            typeLabel = new Label();
            priceValue = new Label();
            priceLabel = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            nameValue = new Label();
            backButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.2857132F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.7142868F));
            tableLayoutPanel1.Controls.Add(quantityValue, 1, 2);
            tableLayoutPanel1.Controls.Add(quantityLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(typeValue, 1, 1);
            tableLayoutPanel1.Controls.Add(typeLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(priceValue, 1, 0);
            tableLayoutPanel1.Controls.Add(priceLabel, 0, 0);
            tableLayoutPanel1.Location = new Point(382, 98);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(350, 277);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // quantityValue
            // 
            quantityValue.Anchor = AnchorStyles.None;
            quantityValue.AutoSize = true;
            quantityValue.Font = new Font("Arial", 18F, FontStyle.Bold);
            quantityValue.ForeColor = SystemColors.ButtonFace;
            quantityValue.Location = new Point(226, 213);
            quantityValue.Name = "quantityValue";
            quantityValue.Size = new Size(81, 35);
            quantityValue.TabIndex = 7;
            quantityValue.Text = "знач";
            // 
            // quantityLabel
            // 
            quantityLabel.Anchor = AnchorStyles.None;
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new Font("Arial", 18F, FontStyle.Bold);
            quantityLabel.ForeColor = SystemColors.ButtonFace;
            quantityLabel.Location = new Point(9, 213);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(165, 35);
            quantityLabel.TabIndex = 6;
            quantityLabel.Text = "Наявність";
            // 
            // typeValue
            // 
            typeValue.Anchor = AnchorStyles.None;
            typeValue.AutoSize = true;
            typeValue.Font = new Font("Arial", 18F, FontStyle.Bold);
            typeValue.ForeColor = SystemColors.ButtonFace;
            typeValue.Location = new Point(226, 120);
            typeValue.Name = "typeValue";
            typeValue.Size = new Size(81, 35);
            typeValue.TabIndex = 5;
            typeValue.Text = "знач";
            // 
            // typeLabel
            // 
            typeLabel.Anchor = AnchorStyles.None;
            typeLabel.AutoSize = true;
            typeLabel.Font = new Font("Arial", 18F, FontStyle.Bold);
            typeLabel.ForeColor = SystemColors.ButtonFace;
            typeLabel.Location = new Point(57, 120);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(68, 35);
            typeLabel.TabIndex = 4;
            typeLabel.Text = "Тип";
            // 
            // priceValue
            // 
            priceValue.Anchor = AnchorStyles.None;
            priceValue.AutoSize = true;
            priceValue.Font = new Font("Arial", 18F, FontStyle.Bold);
            priceValue.ForeColor = SystemColors.ButtonFace;
            priceValue.Location = new Point(226, 28);
            priceValue.Name = "priceValue";
            priceValue.Size = new Size(81, 35);
            priceValue.TabIndex = 3;
            priceValue.Text = "знач";
            // 
            // priceLabel
            // 
            priceLabel.Anchor = AnchorStyles.None;
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Arial", 18F, FontStyle.Bold);
            priceLabel.ForeColor = SystemColors.ButtonFace;
            priceLabel.Location = new Point(51, 28);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(80, 35);
            priceLabel.TabIndex = 2;
            priceLabel.Text = "Ціна";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(nameValue, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50.4F));
            tableLayoutPanel2.Size = new Size(732, 92);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // nameValue
            // 
            nameValue.Anchor = AnchorStyles.None;
            nameValue.AutoSize = true;
            nameValue.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameValue.ForeColor = SystemColors.Control;
            nameValue.Location = new Point(276, 26);
            nameValue.Name = "nameValue";
            nameValue.Size = new Size(179, 40);
            nameValue.TabIndex = 3;
            nameValue.Text = "Название";
            // 
            // backButton
            // 
            backButton.BackColor = Color.Transparent;
            backButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            backButton.Location = new Point(382, 392);
            backButton.Name = "backButton";
            backButton.Size = new Size(338, 49);
            backButton.TabIndex = 2;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // PartDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            BackgroundImage = BarcodeScannerService.Properties.Resources.fon;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(732, 453);
            ControlBox = false;
            Controls.Add(backButton);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(750, 500);
            MinimumSize = new Size(750, 500);
            Name = "PartDetailsForm";
            Text = "DetailesForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label quantityValue;
        private Label quantityLabel;
        private Label typeValue;
        private Label typeLabel;
        private Label priceValue;
        private Label priceLabel;
        private TableLayoutPanel tableLayoutPanel2;
        private Label nameValue;
        private Button backButton;
    }
}