using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class StudentLoginForm : Form
    {
        public StudentLoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE StudentNumber = @p1 AND UserPassword = @p2 AND Deleted = 0 AND IsAdmin = 0", ConnectionString.connection());
                cmd.Parameters.AddWithValue("@p1", txtStudentNumber.Text);
                cmd.Parameters.AddWithValue("@p2", txtPassword.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    StudentPageForm studentPageForm = new StudentPageForm();
                    studentPageForm.studentNumber = txtStudentNumber.Text;
                    studentPageForm.Show();
                    this.Hide();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriş Bilgileriniz Hatalı veya Bu Sayfaya Erişim Yetkiniz Yok.", MessageBoxIcon.Error + ex.Message);
            }
        }
    }
}
