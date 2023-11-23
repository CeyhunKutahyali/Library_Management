using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Management
{
    public partial class StudentPageForm : Form
    {
        public StudentPageForm()
        {
            InitializeComponent();
        }


        public string studentNumber;

        private void StudentPageForm_Load(object sender, EventArgs e)
        {

            LblStudentNumber.Text = studentNumber;
            using (SqlConnection connect = new SqlConnection())
            {
                SqlCommand command = new SqlCommand("select BookId,BookName from Books Where Deleted=0", ConnectionString.connection());
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int BookId = reader.GetInt32(0);
                    string BookName = reader.GetString(1);
                    CbxBookname.Items.Add(new KeyValuePair<int, string>(BookId, BookName));
                }
                reader.Close();
            }
        }

        private void CbxBookname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CbxBookname.SelectedItem != null)
                {
                    KeyValuePair<int, string> selectedBook = (KeyValuePair<int, string>)CbxBookname.SelectedItem;
                    int selectedBookId = selectedBook.Key;

                    using (SqlConnection connection = new SqlConnection())
                    {
                        SqlCommand command = new SqlCommand("SELECT b.AuthorName, b.AuthorSurname, bg.BookDefinition FROM Books b INNER JOIN BookGenre bg on b.BookId = bg.BookGenreId WHERE b.BookId = @BookId", ConnectionString.connection());
                        command.Parameters.AddWithValue("@BookID", selectedBookId);
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            LblAuthorname.Text = reader["AuthorName"].ToString();
                            LblAuthorsurname.Text = reader["AuthorSurname"].ToString();
                            LblBookgenre.Text = reader["BookDefinition"].ToString();
                        }
                        reader.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            try
            {
                KeyValuePair<int, string> selectedBook = (KeyValuePair<int, string>)CbxBookname.SelectedItem;
                int selectedBookId = selectedBook.Key;

                SqlCommand cmd = new SqlCommand("UPDATE Books SET BookStatu = @p1, RenterNumber = @p2, RenterDate = @p3 WHERE BookId = @p4", ConnectionString.connection());
                cmd.Parameters.AddWithValue("@p1", "True");
                cmd.Parameters.AddWithValue("@p2", LblStudentNumber.Text);
                cmd.Parameters.AddWithValue("@p3", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                cmd.Parameters.AddWithValue("@p4", selectedBookId);
                cmd.ExecuteNonQuery();
                MessageBox.Show("İşlem Başarılı", "Başlık", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap Rezervasyon İşlemi Esnasında Bir Hata Oluştu.", MessageBoxIcon.Error + ex.Message);
            }

        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                KeyValuePair<int, string> selectedBook = (KeyValuePair<int, string>)CbxBookname.SelectedItem;
                int selectedBookId = selectedBook.Key;

                SqlCommand cmd = new SqlCommand("UPDATE Books SET BookStatu = @p1, RenterNumber = @p2, RenterDate = @p3 WHERE BookId = @p4", ConnectionString.connection());
                cmd.Parameters.AddWithValue("@p1", "False");
                cmd.Parameters.AddWithValue("@p2", 0);
                cmd.Parameters.AddWithValue("@p3", "1900-01-01");
                cmd.Parameters.AddWithValue("@p4", selectedBookId);
                cmd.ExecuteNonQuery();
                MessageBox.Show("İade İşlemi Başarılı", "Başlık", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap İade İşlemi Esnasında Bir Hata Oluştu.", MessageBoxIcon.Error + ex.Message);
            }
        }
    }
}



