namespace CatalogService.Forms
{
    partial class GoodsReceptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoodsReceptionForm));
            dataGridView1 = new DataGridView();
            ExitButton = new Button();
            SendButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(782, 267);
            dataGridView1.TabIndex = 0;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = SystemColors.Window;
            ExitButton.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ExitButton.Image = Properties.Resources.images2;
            ExitButton.ImageAlign = ContentAlignment.MiddleLeft;
            ExitButton.Location = new Point(12, 364);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(209, 74);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "Вихід";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // SendButton
            // 
            SendButton.BackColor = SystemColors.Window;
            SendButton.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SendButton.Image = (Image)resources.GetObject("SendButton.Image");
            SendButton.ImageAlign = ContentAlignment.MiddleLeft;
            SendButton.Location = new Point(585, 364);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(209, 74);
            SendButton.TabIndex = 2;
            SendButton.Text = "Відправити";
            SendButton.UseVisualStyleBackColor = false;
            SendButton.Click += SendButton_Click;
            // 
            // GoodsReceptionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(806, 450);
            ControlBox = false;
            Controls.Add(SendButton);
            Controls.Add(ExitButton);
            Controls.Add(dataGridView1);
            Name = "GoodsReceptionForm";
            Text = "GoodsReceptionForm";
            Load += GoodsReceptionForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button ExitButton;
        private Button SendButton;
    }
}