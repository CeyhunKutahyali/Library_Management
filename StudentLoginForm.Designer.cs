namespace Library_Management
{
    partial class StudentLoginForm
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
            btnLogin = new Button();
            LblPassword = new Label();
            LblStudentNumber = new Label();
            txtPassword = new TextBox();
            txtStudentNumber = new TextBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogin.Location = new Point(194, 195);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(269, 55);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
            LblPassword.BackColor = Color.Transparent;
            LblPassword.Location = new Point(132, 151);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(46, 20);
            LblPassword.TabIndex = 8;
            LblPassword.Text = "Şifre :";
            // 
            // LblStudentNumber
            // 
            LblStudentNumber.AutoSize = true;
            LblStudentNumber.BackColor = Color.Transparent;
            LblStudentNumber.Location = new Point(72, 101);
            LblStudentNumber.Name = "LblStudentNumber";
            LblStudentNumber.Size = new Size(92, 20);
            LblStudentNumber.TabIndex = 7;
            LblStudentNumber.Text = "Öğrenci No :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(194, 148);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(269, 27);
            txtPassword.TabIndex = 6;
            // 
            // txtStudentNumber
            // 
            txtStudentNumber.Location = new Point(194, 98);
            txtStudentNumber.Name = "txtStudentNumber";
            txtStudentNumber.Size = new Size(269, 27);
            txtStudentNumber.TabIndex = 5;
            // 
            // StudentLoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(561, 371);
            Controls.Add(btnLogin);
            Controls.Add(LblPassword);
            Controls.Add(LblStudentNumber);
            Controls.Add(txtPassword);
            Controls.Add(txtStudentNumber);
            MaximizeBox = false;
            Name = "StudentLoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentLoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label LblPassword;
        private Label LblStudentNumber;
        private TextBox txtPassword;
        private TextBox txtStudentNumber;
    }
}