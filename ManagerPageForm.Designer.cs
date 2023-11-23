namespace Library_Management
{
    partial class ManagerPageForm
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
            groupBox1 = new GroupBox();
            LblBookGenreId = new Label();
            btnBookDelete = new Button();
            CbxBookGenre = new ComboBox();
            btnBookEdit = new Button();
            label6 = new Label();
            btnBookAdd = new Button();
            txtISBN = new TextBox();
            label5 = new Label();
            txtAuthorsurname = new TextBox();
            label4 = new Label();
            txtAuthorname = new TextBox();
            label2 = new Label();
            txtBookname = new TextBox();
            label3 = new Label();
            LblBookID = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            DtpStudentDate = new DateTimePicker();
            btnRzrDelete = new Button();
            btnRzrEdit = new Button();
            btnRzrAdd = new Button();
            label7 = new Label();
            txtStudentNumber = new TextBox();
            label10 = new Label();
            groupBox3 = new GroupBox();
            LblDelay = new Label();
            LblRzrBookdate = new Label();
            LblRzrBookname = new Label();
            LblRzrStudentNumber = new Label();
            label12 = new Label();
            btnCalculateDelay = new Button();
            btnRzrRemove = new Button();
            label11 = new Label();
            label9 = new Label();
            label8 = new Label();
            LblRzrDetailStudentNumber = new Label();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LblBookGenreId);
            groupBox1.Controls.Add(btnBookDelete);
            groupBox1.Controls.Add(CbxBookGenre);
            groupBox1.Controls.Add(btnBookEdit);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnBookAdd);
            groupBox1.Controls.Add(txtISBN);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtAuthorsurname);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtAuthorname);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtBookname);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(LblBookID);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(15, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(389, 378);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kitap Bilgileri";
            // 
            // LblBookGenreId
            // 
            LblBookGenreId.AutoSize = true;
            LblBookGenreId.Location = new Point(316, 27);
            LblBookGenreId.Name = "LblBookGenreId";
            LblBookGenreId.Size = new Size(59, 25);
            LblBookGenreId.TabIndex = 17;
            LblBookGenreId.Text = "label8";
            LblBookGenreId.Visible = false;
            // 
            // btnBookDelete
            // 
            btnBookDelete.Location = new Point(262, 264);
            btnBookDelete.Name = "btnBookDelete";
            btnBookDelete.Size = new Size(123, 59);
            btnBookDelete.TabIndex = 16;
            btnBookDelete.Text = "Kitap Sil";
            btnBookDelete.UseVisualStyleBackColor = true;
            btnBookDelete.Click += btnBookDelete_Click;
            // 
            // CbxBookGenre
            // 
            CbxBookGenre.FormattingEnabled = true;
            CbxBookGenre.Location = new Point(130, 214);
            CbxBookGenre.Name = "CbxBookGenre";
            CbxBookGenre.Size = new Size(245, 33);
            CbxBookGenre.TabIndex = 11;
            CbxBookGenre.SelectedIndexChanged += CbxBookGenre_SelectedIndexChanged;
            // 
            // btnBookEdit
            // 
            btnBookEdit.Location = new Point(133, 264);
            btnBookEdit.Name = "btnBookEdit";
            btnBookEdit.Size = new Size(123, 59);
            btnBookEdit.TabIndex = 15;
            btnBookEdit.Text = "Kitap Güncelle";
            btnBookEdit.UseVisualStyleBackColor = true;
            btnBookEdit.Click += btnBookEdit_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 217);
            label6.Name = "label6";
            label6.Size = new Size(101, 25);
            label6.TabIndex = 10;
            label6.Text = "Kitap Türü :";
            // 
            // btnBookAdd
            // 
            btnBookAdd.Location = new Point(4, 265);
            btnBookAdd.Name = "btnBookAdd";
            btnBookAdd.Size = new Size(123, 59);
            btnBookAdd.TabIndex = 14;
            btnBookAdd.Text = "Kitap Ekle";
            btnBookAdd.UseVisualStyleBackColor = true;
            btnBookAdd.Click += btnBookAdd_Click;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(130, 177);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(245, 31);
            txtISBN.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 180);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 8;
            label5.Text = "ISBN :";
            // 
            // txtAuthorsurname
            // 
            txtAuthorsurname.Location = new Point(130, 140);
            txtAuthorsurname.Name = "txtAuthorsurname";
            txtAuthorsurname.Size = new Size(245, 31);
            txtAuthorsurname.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 143);
            label4.Name = "label4";
            label4.Size = new Size(125, 25);
            label4.TabIndex = 6;
            label4.Text = "Yazar Soyadı : ";
            // 
            // txtAuthorname
            // 
            txtAuthorname.Location = new Point(130, 103);
            txtAuthorname.Name = "txtAuthorname";
            txtAuthorname.Size = new Size(245, 31);
            txtAuthorname.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 106);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 4;
            label2.Text = "Yazar Adı : ";
            // 
            // txtBookname
            // 
            txtBookname.Location = new Point(130, 66);
            txtBookname.Name = "txtBookname";
            txtBookname.Size = new Size(245, 31);
            txtBookname.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 69);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 2;
            label3.Text = "Kitap Adı : ";
            // 
            // LblBookID
            // 
            LblBookID.AutoSize = true;
            LblBookID.Location = new Point(132, 37);
            LblBookID.Name = "LblBookID";
            LblBookID.Size = new Size(19, 25);
            LblBookID.TabIndex = 1;
            LblBookID.Text = "-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 37);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 0;
            label1.Text = "Kitap ID : ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DtpStudentDate);
            groupBox2.Controls.Add(btnRzrDelete);
            groupBox2.Controls.Add(btnRzrEdit);
            groupBox2.Controls.Add(btnRzrAdd);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtStudentNumber);
            groupBox2.Controls.Add(label10);
            groupBox2.Location = new Point(410, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(389, 378);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kitap Rezervasyon";
            // 
            // DtpStudentDate
            // 
            DtpStudentDate.Location = new Point(130, 105);
            DtpStudentDate.Name = "DtpStudentDate";
            DtpStudentDate.Size = new Size(245, 31);
            DtpStudentDate.TabIndex = 14;
            // 
            // btnRzrDelete
            // 
            btnRzrDelete.Location = new Point(262, 264);
            btnRzrDelete.Name = "btnRzrDelete";
            btnRzrDelete.Size = new Size(123, 59);
            btnRzrDelete.TabIndex = 13;
            btnRzrDelete.Text = "Rezervasyon İptal";
            btnRzrDelete.UseVisualStyleBackColor = true;
            btnRzrDelete.Click += btnRzrDelete_Click;
            // 
            // btnRzrEdit
            // 
            btnRzrEdit.Location = new Point(133, 264);
            btnRzrEdit.Name = "btnRzrEdit";
            btnRzrEdit.Size = new Size(123, 59);
            btnRzrEdit.TabIndex = 12;
            btnRzrEdit.Text = "Rezervasyon Güncelle";
            btnRzrEdit.UseVisualStyleBackColor = true;
            btnRzrEdit.Click += btnRzrEdit_Click;
            // 
            // btnRzrAdd
            // 
            btnRzrAdd.Location = new Point(4, 264);
            btnRzrAdd.Name = "btnRzrAdd";
            btnRzrAdd.Size = new Size(123, 59);
            btnRzrAdd.TabIndex = 1;
            btnRzrAdd.Text = "Rezervasyon Ekle";
            btnRzrAdd.UseVisualStyleBackColor = true;
            btnRzrAdd.Click += btnRzrAdd_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(66, 110);
            label7.Name = "label7";
            label7.Size = new Size(57, 25);
            label7.TabIndex = 10;
            label7.Text = "Tarih :";
            // 
            // txtStudentNumber
            // 
            txtStudentNumber.Location = new Point(130, 68);
            txtStudentNumber.Name = "txtStudentNumber";
            txtStudentNumber.Size = new Size(245, 31);
            txtStudentNumber.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 71);
            label10.Name = "label10";
            label10.Size = new Size(112, 25);
            label10.TabIndex = 4;
            label10.Text = "Öğrenci No :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(LblDelay);
            groupBox3.Controls.Add(LblRzrBookdate);
            groupBox3.Controls.Add(LblRzrBookname);
            groupBox3.Controls.Add(LblRzrStudentNumber);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(btnCalculateDelay);
            groupBox3.Controls.Add(btnRzrRemove);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(LblRzrDetailStudentNumber);
            groupBox3.Location = new Point(805, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(389, 378);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Rezervasyon Bilgileri";
            // 
            // LblDelay
            // 
            LblDelay.AutoSize = true;
            LblDelay.Location = new Point(180, 174);
            LblDelay.Name = "LblDelay";
            LblDelay.Size = new Size(19, 25);
            LblDelay.TabIndex = 19;
            LblDelay.Text = "-";
            // 
            // LblRzrBookdate
            // 
            LblRzrBookdate.AutoSize = true;
            LblRzrBookdate.Location = new Point(170, 139);
            LblRzrBookdate.Name = "LblRzrBookdate";
            LblRzrBookdate.Size = new Size(19, 25);
            LblRzrBookdate.TabIndex = 18;
            LblRzrBookdate.Text = "-";
            // 
            // LblRzrBookname
            // 
            LblRzrBookname.AutoSize = true;
            LblRzrBookname.Location = new Point(180, 105);
            LblRzrBookname.Name = "LblRzrBookname";
            LblRzrBookname.Size = new Size(19, 25);
            LblRzrBookname.TabIndex = 17;
            LblRzrBookname.Text = "-";
            // 
            // LblRzrStudentNumber
            // 
            LblRzrStudentNumber.AutoSize = true;
            LblRzrStudentNumber.Location = new Point(180, 74);
            LblRzrStudentNumber.Name = "LblRzrStudentNumber";
            LblRzrStudentNumber.Size = new Size(19, 25);
            LblRzrStudentNumber.TabIndex = 16;
            LblRzrStudentNumber.Text = "-";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(34, 174);
            label12.Name = "label12";
            label12.Size = new Size(138, 25);
            label12.TabIndex = 15;
            label12.Text = "Gecikme Ücreti :";
            // 
            // btnCalculateDelay
            // 
            btnCalculateDelay.Location = new Point(202, 264);
            btnCalculateDelay.Name = "btnCalculateDelay";
            btnCalculateDelay.Size = new Size(123, 59);
            btnCalculateDelay.TabIndex = 15;
            btnCalculateDelay.Text = "Gecikme Hesapla";
            btnCalculateDelay.UseVisualStyleBackColor = true;
            btnCalculateDelay.Click += btnCalculateDelay_Click;
            // 
            // btnRzrRemove
            // 
            btnRzrRemove.Location = new Point(73, 264);
            btnRzrRemove.Name = "btnRzrRemove";
            btnRzrRemove.Size = new Size(123, 59);
            btnRzrRemove.TabIndex = 14;
            btnRzrRemove.Text = "İade Al";
            btnRzrRemove.UseVisualStyleBackColor = true;
            btnRzrRemove.Click += btnRzrRemove_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 139);
            label11.Name = "label11";
            label11.Size = new Size(166, 25);
            label11.TabIndex = 5;
            label11.Text = "Kitap Alınma Tarihi :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(37, 139);
            label9.Name = "label9";
            label9.Size = new Size(0, 25);
            label9.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(79, 105);
            label8.Name = "label8";
            label8.Size = new Size(93, 25);
            label8.TabIndex = 3;
            label8.Text = "Kitap Adı :";
            // 
            // LblRzrDetailStudentNumber
            // 
            LblRzrDetailStudentNumber.AutoSize = true;
            LblRzrDetailStudentNumber.Location = new Point(60, 72);
            LblRzrDetailStudentNumber.Name = "LblRzrDetailStudentNumber";
            LblRzrDetailStudentNumber.Size = new Size(117, 25);
            LblRzrDetailStudentNumber.TabIndex = 2;
            LblRzrDetailStudentNumber.Text = "Öğrenci No : ";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(15, 401);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1179, 239);
            groupBox4.TabIndex = 16;
            groupBox4.TabStop = false;
            groupBox4.Text = "Kitap Listesi";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1173, 209);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // ManagerPageForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1208, 652);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "ManagerPageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yönetici Paneli";
            Load += ManagerPageForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label LblBookID;
        private Label label1;
        private ComboBox CbxBookGenre;
        private Label label6;
        private TextBox txtISBN;
        private Label label5;
        private TextBox txtAuthorsurname;
        private Label label4;
        private TextBox txtAuthorname;
        private Label label2;
        private TextBox txtBookname;
        private GroupBox groupBox2;
        private Button btnRzrAdd;
        private ComboBox comboBox1;
        private Label label7;
        private TextBox txtStudentNumber;
        private Label label10;
        private Button btnRzrDelete;
        private Button btnRzrEdit;
        private Button btnBookDelete;
        private Button btnBookEdit;
        private Button btnBookAdd;
        private GroupBox groupBox3;
        private DateTimePicker DtpStudentDate;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private Button button4;
        private Label LblBookGenreId;
        private Label LblRzrDetailStudentNumber;
        private Label label9;
        private Label label8;
        private Label label11;
        private Label label12;
        private Button btnCalculateDelay;
        private Button btnRzrRemove;
        private Label LblDelay;
        private Label LblRzrBookdate;
        private Label LblRzrBookname;
        private Label LblRzrStudentNumber;
    }
}