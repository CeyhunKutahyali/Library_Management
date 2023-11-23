namespace Library_Management
{
    partial class StudentPageForm
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
            groupBox2 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            LblAuthorsurname = new Label();
            label9 = new Label();
            LblAuthorname = new Label();
            label8 = new Label();
            LblBookgenre = new Label();
            label6 = new Label();
            label5 = new Label();
            CbxBookname = new ComboBox();
            btnBook = new Button();
            BtnRemove = new Button();
            groupBox1 = new GroupBox();
            LblStudentNumber = new Label();
            label2 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(LblAuthorsurname);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(LblAuthorname);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(LblBookgenre);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(CbxBookname);
            groupBox2.Location = new Point(12, 74);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(372, 209);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kitap Seçimi";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(134, 166);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(226, 31);
            dateTimePicker1.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 171);
            label1.Name = "label1";
            label1.Size = new Size(57, 25);
            label1.TabIndex = 26;
            label1.Text = "Tarih :";
            // 
            // LblAuthorsurname
            // 
            LblAuthorsurname.AutoSize = true;
            LblAuthorsurname.Location = new Point(171, 136);
            LblAuthorsurname.Name = "LblAuthorsurname";
            LblAuthorsurname.Size = new Size(19, 25);
            LblAuthorsurname.TabIndex = 25;
            LblAuthorsurname.Text = "-";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(8, 136);
            label9.Name = "label9";
            label9.Size = new Size(120, 25);
            label9.TabIndex = 24;
            label9.Text = "Yazar Soyadı :";
            // 
            // LblAuthorname
            // 
            LblAuthorname.AutoSize = true;
            LblAuthorname.Location = new Point(171, 104);
            LblAuthorname.Name = "LblAuthorname";
            LblAuthorname.Size = new Size(19, 25);
            LblAuthorname.TabIndex = 23;
            LblAuthorname.Text = "-";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 104);
            label8.Name = "label8";
            label8.Size = new Size(93, 25);
            label8.TabIndex = 22;
            label8.Text = "Yazar Adı :";
            // 
            // LblBookgenre
            // 
            LblBookgenre.AutoSize = true;
            LblBookgenre.Location = new Point(171, 68);
            LblBookgenre.Name = "LblBookgenre";
            LblBookgenre.Size = new Size(19, 25);
            LblBookgenre.TabIndex = 21;
            LblBookgenre.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 68);
            label6.Name = "label6";
            label6.Size = new Size(101, 25);
            label6.TabIndex = 20;
            label6.Text = "Kitap Türü :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 34);
            label5.Name = "label5";
            label5.Size = new Size(93, 25);
            label5.TabIndex = 19;
            label5.Text = "Kitap Adı :";
            // 
            // CbxBookname
            // 
            CbxBookname.FormattingEnabled = true;
            CbxBookname.Location = new Point(134, 30);
            CbxBookname.Name = "CbxBookname";
            CbxBookname.Size = new Size(226, 33);
            CbxBookname.TabIndex = 18;
            CbxBookname.SelectedIndexChanged += CbxBookname_SelectedIndexChanged;
            // 
            // btnBook
            // 
            btnBook.Location = new Point(12, 301);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(372, 50);
            btnBook.TabIndex = 2;
            btnBook.Text = "Rezerve Et";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // BtnRemove
            // 
            BtnRemove.Location = new Point(12, 357);
            BtnRemove.Name = "BtnRemove";
            BtnRemove.Size = new Size(372, 50);
            BtnRemove.TabIndex = 3;
            BtnRemove.Text = "İade Et";
            BtnRemove.UseVisualStyleBackColor = true;
            BtnRemove.Click += BtnRemove_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LblStudentNumber);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(373, 64);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // LblStudentNumber
            // 
            LblStudentNumber.AutoSize = true;
            LblStudentNumber.Location = new Point(175, 23);
            LblStudentNumber.Name = "LblStudentNumber";
            LblStudentNumber.Size = new Size(19, 25);
            LblStudentNumber.TabIndex = 1;
            LblStudentNumber.Text = "-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 23);
            label2.Name = "label2";
            label2.Size = new Size(163, 25);
            label2.TabIndex = 0;
            label2.Text = "Öğrenci Numarası :";
            // 
            // StudentPageForm
            // 
            AcceptButton = btnBook;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(397, 433);
            Controls.Add(groupBox1);
            Controls.Add(BtnRemove);
            Controls.Add(btnBook);
            Controls.Add(groupBox2);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "StudentPageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Öğrenci Sayfası";
            Load += StudentPageForm_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private Button btnBook;
        private Button BtnRemove;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label LblAuthorsurname;
        private Label label9;
        private Label LblAuthorname;
        private Label label8;
        private Label LblBookgenre;
        private Label label6;
        private Label label5;
        private ComboBox CbxBookname;
        private GroupBox groupBox1;
        private Label LblStudentNumber;
        private Label label2;
    }
}