namespace Library_Management
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            LblUsername = new Label();
            LblPassword = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(198, 100);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(269, 31);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(198, 150);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(269, 31);
            txtPassword.TabIndex = 1;
            // 
            // LblUsername
            // 
            LblUsername.AutoSize = true;
            LblUsername.BackColor = Color.Transparent;
            LblUsername.Location = new Point(76, 103);
            LblUsername.Name = "LblUsername";
            LblUsername.Size = new Size(116, 25);
            LblUsername.TabIndex = 2;
            LblUsername.Text = "Kullanıcı Adı :";
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
            LblPassword.BackColor = Color.Transparent;
            LblPassword.Location = new Point(136, 153);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(56, 25);
            LblPassword.TabIndex = 3;
            LblPassword.Text = "Şifre :";
            // 
            // btnLogin
            // 
            btnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogin.Location = new Point(198, 197);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(269, 55);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(562, 369);
            Controls.Add(btnLogin);
            Controls.Add(LblPassword);
            Controls.Add(LblUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentLoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label LblUsername;
        private Label LblPassword;
        private Button btnLogin;
    }
}