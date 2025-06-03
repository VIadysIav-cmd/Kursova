namespace AdminService.Forms
{
    partial class LoginForm
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
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            Namelabel = new Label();
            Passwordlabel = new Label();
            SuspendLayout();
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(81, 39);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(177, 27);
            LoginTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(81, 119);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(177, 27);
            PasswordTextBox.TabIndex = 1;
            // 
            // Namelabel
            // 
            Namelabel.AutoSize = true;
            Namelabel.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Namelabel.Location = new Point(139, 9);
            Namelabel.Name = "Namelabel";
            Namelabel.Size = new Size(61, 27);
            Namelabel.TabIndex = 3;
            Namelabel.Text = "Логін";
            // 
            // Passwordlabel
            // 
            Passwordlabel.AutoSize = true;
            Passwordlabel.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Passwordlabel.Location = new Point(130, 89);
            Passwordlabel.Name = "Passwordlabel";
            Passwordlabel.Size = new Size(84, 27);
            Passwordlabel.TabIndex = 4;
            Passwordlabel.Text = "Пароль";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(354, 174);
            Controls.Add(Passwordlabel);
            Controls.Add(Namelabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Name = "LoginForm";
            Text = "LoginForm";
            KeyDown += LoginForm_KeyDown;
            KeyPreview = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Label Namelabel;
        private Label Passwordlabel;
    }
}