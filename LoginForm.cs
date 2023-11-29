using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Library_Management
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE UserName = @p1 AND UserPassword = @p2 AND Deleted = 0 AND IsAdmin = 1", ConnectionString.connection());
                cmd.Parameters.AddWithValue("@p1", txtUsername.Text);
                cmd.Parameters.AddWithValue("@p2", txtPassword.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ManagerPageForm managerPageForm = new ManagerPageForm();
                    managerPageForm.Show();
                    this.Hide();
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show("Giriş Bilgileriniz Hatalı veya Bu Sayfaya Erişim Yetkiniz Yok.", "Başlık", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConnectionString.connection().Close();
            }
        }

    }
}
