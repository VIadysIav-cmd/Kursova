namespace AdminService
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            InvoicesDataGridView = new DataGridView();
            menuStrip1 = new MenuStrip();
            WorkersToolStripMenuItem1 = new ToolStripMenuItem();
            ProductsToolStripMenuItem = new ToolStripMenuItem();
            InvoicesToolStripMenuItem = new ToolStripMenuItem();
            SuppliersToolStripMenuItem = new ToolStripMenuItem();
            ExitToolStripMenuItem1 = new ToolStripMenuItem();
            SendParts = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)InvoicesDataGridView).BeginInit();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // InvoicesDataGridView
            // 
            InvoicesDataGridView.AllowUserToAddRows = false;
            InvoicesDataGridView.BackgroundColor = SystemColors.ActiveCaption;
            InvoicesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InvoicesDataGridView.Dock = DockStyle.Left;
            InvoicesDataGridView.GridColor = SystemColors.ControlDark;
            InvoicesDataGridView.Location = new Point(0, 0);
            InvoicesDataGridView.Name = "InvoicesDataGridView";
            InvoicesDataGridView.RowHeadersVisible = false;
            InvoicesDataGridView.RowHeadersWidth = 51;
            InvoicesDataGridView.Size = new Size(467, 227);
            InvoicesDataGridView.TabIndex = 23;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { WorkersToolStripMenuItem1, ProductsToolStripMenuItem, InvoicesToolStripMenuItem, SuppliersToolStripMenuItem, ExitToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(797, 28);
            menuStrip1.TabIndex = 26;
            menuStrip1.Text = "menuStrip1";
            // 
            // WorkersToolStripMenuItem1
            // 
            WorkersToolStripMenuItem1.Name = "WorkersToolStripMenuItem1";
            WorkersToolStripMenuItem1.Size = new Size(106, 24);
            WorkersToolStripMenuItem1.Text = "Працівники";
            WorkersToolStripMenuItem1.Click += WorkersToolStripMenuItem1_Click;
            // 
            // ProductsToolStripMenuItem
            // 
            ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem";
            ProductsToolStripMenuItem.Size = new Size(74, 24);
            ProductsToolStripMenuItem.Text = "Товари";
            ProductsToolStripMenuItem.Click += ProductsToolStripMenuItem_Click;
            // 
            // InvoicesToolStripMenuItem
            // 
            InvoicesToolStripMenuItem.Name = "InvoicesToolStripMenuItem";
            InvoicesToolStripMenuItem.Size = new Size(86, 24);
            InvoicesToolStripMenuItem.Text = "Накладні";
            InvoicesToolStripMenuItem.Click += InvoicesToolStripMenuItem_Click_1;
            // 
            // SuppliersToolStripMenuItem
            // 
            SuppliersToolStripMenuItem.Name = "SuppliersToolStripMenuItem";
            SuppliersToolStripMenuItem.Size = new Size(130, 24);
            SuppliersToolStripMenuItem.Text = "Постачальники";
            SuppliersToolStripMenuItem.Click += SuppliersToolStripMenuItem_Click_1;
            // 
            // ExitToolStripMenuItem1
            // 
            ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1";
            ExitToolStripMenuItem1.Size = new Size(60, 24);
            ExitToolStripMenuItem1.Text = "Вихід";
            ExitToolStripMenuItem1.Click += ExitToolStripMenuItem1_Click;
            // 
            // SendParts
            // 
            SendParts.BackColor = Color.Black;
            SendParts.Dock = DockStyle.Right;
            SendParts.FlatStyle = FlatStyle.Flat;
            SendParts.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SendParts.ForeColor = SystemColors.Control;
            SendParts.Location = new Point(675, 0);
            SendParts.Name = "SendParts";
            SendParts.Size = new Size(122, 227);
            SendParts.TabIndex = 28;
            SendParts.Text = "Надіслати";
            SendParts.UseVisualStyleBackColor = false;
            SendParts.Click += SendParts_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(InvoicesDataGridView);
            panel1.Controls.Add(SendParts);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 182);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 227);
            panel1.TabIndex = 29;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(797, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(797, 409);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "AdminForm";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)InvoicesDataGridView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView InvoicesDataGridView;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem WorkersToolStripMenuItem1;
        private ToolStripMenuItem ProductsToolStripMenuItem;
        private ToolStripMenuItem InvoicesToolStripMenuItem;
        private ToolStripMenuItem SuppliersToolStripMenuItem;
        private Button SendParts;
        private ToolStripMenuItem ExitToolStripMenuItem1;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}
