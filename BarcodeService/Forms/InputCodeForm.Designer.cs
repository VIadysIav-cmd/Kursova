namespace BarcodeService
{
    partial class InputCodeForm
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
            Искать = new Button();
            textBox1 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // Искать
            // 
            Искать.BackColor = Color.Transparent;
            Искать.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Искать.Location = new Point(275, 232);
            Искать.Name = "Искать";
            Искать.Size = new Size(175, 54);
            Искать.TabIndex = 6;
            Искать.Text = "Знайти";
            Искать.UseVisualStyleBackColor = false;
            Искать.Click += searchButton_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(275, 168);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 27);
            textBox1.TabIndex = 5;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(275, 99);
            label5.Name = "label5";
            label5.Size = new Size(175, 66);
            label5.TabIndex = 4;
            label5.Text = "Ведіть штрих-код";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InputCodeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = BarcodeScannerService.Properties.Resources.fon;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(732, 459);
            ControlBox = false;
            Controls.Add(Искать);
            Controls.Add(textBox1);
            Controls.Add(label5);
            MaximumSize = new Size(750, 506);
            MinimumSize = new Size(750, 506);
            Name = "InputCodeForm";
            Text = "Input_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Искать;
        private TextBox textBox1;
        private Label label5;
    }
}
