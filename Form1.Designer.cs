namespace Library_Management
{
    partial class Form1
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
            btnStudentLogin = new Button();
            BtnManagerLogin = new Button();
            SuspendLayout();
            // 
            // btnStudentLogin
            // 
            btnStudentLogin.BackColor = Color.White;
            btnStudentLogin.Location = new Point(12, 12);
            btnStudentLogin.Name = "btnStudentLogin";
            btnStudentLogin.Size = new Size(294, 344);
            btnStudentLogin.TabIndex = 0;
            btnStudentLogin.Text = "Öğrenci Girişi";
            btnStudentLogin.UseVisualStyleBackColor = false;
            btnStudentLogin.Click += btnStudentLogin_Click;
            // 
            // BtnManagerLogin
            // 
            BtnManagerLogin.BackColor = Color.White;
            BtnManagerLogin.Location = new Point(312, 12);
            BtnManagerLogin.Name = "BtnManagerLogin";
            BtnManagerLogin.Size = new Size(294, 344);
            BtnManagerLogin.TabIndex = 1;
            BtnManagerLogin.Text = "Yönetici Girişi";
            BtnManagerLogin.UseVisualStyleBackColor = false;
            BtnManagerLogin.Click += BtnManagerLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(616, 368);
            Controls.Add(BtnManagerLogin);
            Controls.Add(btnStudentLogin);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnStudentLogin;
        private Button BtnManagerLogin;
    }
}