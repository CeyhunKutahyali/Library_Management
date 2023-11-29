
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Management
{
    public partial class ManagerPageForm : Form
    {
        public ManagerPageForm()
        {
            InitializeComponent();
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public ComboboxItem(string text, string value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        public void ShowData()
        {
            try
            {
                string q = "SELECT b.BookId,b.BookName, b.AuthorName, b.AuthorSurname,b.ISBN,b.BookStatu,b.RenterNumber,b.RenterDate,b.BookGenreCode,bg.BookGenreId,bg.BookDefinition FROM Books b INNER JOIN BookGenre bg ON b.BookGenreCode = bg.BookGenreId WHERE b.Deleted = 0 AND bg.Deleted = 0";
                SqlDataAdapter da = new SqlDataAdapter(q, ConnectionString.connection());
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem sırasında bir hata oluştu" + ex.Message);
            }
            finally
            {
                ConnectionString.connection().Close();
            }
        }



        private void ManagerPageForm_Load(object sender, EventArgs e)
        {
            ShowData();

            try
            {
                string query = "SELECT BookGenreId, BookDefinition FROM BookGenre";

                using (SqlCommand command = new SqlCommand(query, ConnectionString.connection()))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ComboboxItem item = new ComboboxItem(reader["BookDefinition"].ToString(), reader["BookGenreId"].ToString());
                        CbxBookGenre.Items.Add(item);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                ConnectionString.connection().Close();
            }
        }

        private void CbxBookGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxBookGenre.SelectedItem != null)
            {
                ComboboxItem selectedValue = (ComboboxItem)CbxBookGenre.SelectedItem;
                LblBookGenreId.Text = selectedValue.Value;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowSelect = dataGridView1.SelectedCells[0].RowIndex;
                LblBookID.Text = dataGridView1.Rows[rowSelect].Cells[0].Value.ToString();
                txtBookname.Text = dataGridView1.Rows[rowSelect].Cells[1].Value.ToString();
                txtAuthorname.Text = dataGridView1.Rows[rowSelect].Cells[2].Value.ToString();
                txtAuthorsurname.Text = dataGridView1.Rows[rowSelect].Cells[3].Value.ToString();
                txtISBN.Text = dataGridView1.Rows[rowSelect].Cells[4].Value.ToString();
                txtStudentNumber.Text = dataGridView1.Rows[rowSelect].Cells[6].Value.ToString();
                LblBookGenreId.Text = dataGridView1.Rows[rowSelect].Cells[9].Value.ToString();
                CbxBookGenre.Text = dataGridView1.Rows[rowSelect].Cells[10].Value.ToString();

                if (txtStudentNumber != null)
                {
                    LblRzrStudentNumber.Text = txtStudentNumber.Text;
                    LblRzrBookname.Text = txtBookname.Text;
                    LblRzrBookdate.Text = DtpStudentDate.Text.ToString();
                }

                if (dataGridView1.Rows[rowSelect].Cells[7].Value != DBNull.Value)
                {
                    DtpStudentDate.Value = (DateTime)dataGridView1.Rows[rowSelect].Cells[7].Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DataGrid'de bir sorun oluştu" + ex.Message);
            }
            finally
            {
                ConnectionString.connection().Close();
            }
        }

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Books (BookName, AuthorName, AuthorSurname, ISBN, BookStatu, RenterNumber, RenterDate, BookGenreCode, Deleted) VALUES (@p1, @p2, @p3, @p4, 0, null, null, @p5, 0)", ConnectionString.connection());
                cmd.Parameters.AddWithValue("@p1", txtBookname.Text);
                cmd.Parameters.AddWithValue("@p2", txtAuthorname.Text);
                cmd.Parameters.AddWithValue("@p3", txtAuthorsurname.Text);
                cmd.Parameters.AddWithValue("@p4", txtISBN.Text);
                cmd.Parameters.AddWithValue("@p5", LblBookGenreId.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt İşlemi Sırasında Hata Oluştu" + ex.Message);
            }
            finally
            {
                ConnectionString.connection().Close();
            }
        }

        private void btnBookEdit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Books SET BookName=@p1, AuthorName=@p2, AuthorSurname=@p3, ISBN=@p4, BookGenreCode=@p5 WHERE BookId=@p6", ConnectionString.connection());
                cmd.Parameters.AddWithValue("@p1", txtBookname.Text);
                cmd.Parameters.AddWithValue("@p2", txtAuthorname.Text);
                cmd.Parameters.AddWithValue("@p3", txtAuthorsurname.Text);
                cmd.Parameters.AddWithValue("@p4", txtISBN.Text);
                cmd.Parameters.AddWithValue("@p5", LblBookGenreId.Text);
                cmd.Parameters.AddWithValue("@p6", LblBookID.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Güncelleme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme İşlemi Sırasında Hata Oluştu" + ex.Message);
            }
            finally
            {
                ConnectionString.connection().Close();
            }
        }

        private void btnBookDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Books SET Deleted=1 WHERE BookId=@p1", ConnectionString.connection());
                cmd.Parameters.AddWithValue("@p1", LblBookID.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Silme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme İşlemi Sırasında Hata Oluştu" + ex.Message);
            }
            finally
            {
                ConnectionString.connection().Close();
            }
        }

        private void btnRzrAdd_Click(object sender, EventArgs e)
        {
            try
            {
              if(!String.IsNullOrEmpty(txtStudentNumber.Text) && txtStudentNumber.Text != "0")
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Books SET BookName = @p1, AuthorName = @p2, AuthorSurname = @p3, ISBN = @p4, BookStatu = 1, RenterNumber = @p5, RenterDate = @p6, BookGenreCode = @p7 WHERE BookId = @p8", ConnectionString.connection());
                    cmd.Parameters.AddWithValue("@p1", txtBookname.Text);
                    cmd.Parameters.AddWithValue("@p2", txtAuthorname.Text);
                    cmd.Parameters.AddWithValue("@p3", txtAuthorsurname.Text);
                    cmd.Parameters.AddWithValue("@p4", txtISBN.Text);
                    cmd.Parameters.AddWithValue("@p5", txtStudentNumber.Text);
                    cmd.Parameters.AddWithValue("@p6", SqlDbType.Date).Value = DtpStudentDate.Value.Date;
                    cmd.Parameters.AddWithValue("@p7", LblBookGenreId.Text);
                    cmd.Parameters.AddWithValue("@p8", LblBookID.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rezervasyon oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rezervasyon Sırasıında Bir Hata Oluştu." + ex.Message);
            }
            finally
            {
                ConnectionString.connection().Close();
            }
        }

        private void btnRzrEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if(!String.IsNullOrEmpty(txtStudentNumber.Text) && txtStudentNumber.Text != "0")
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Books SET RenterDate=@p1 WHERE BookId=@p2", ConnectionString.connection());
                    cmd.Parameters.AddWithValue("@p1", SqlDbType.Date).Value = DtpStudentDate.Value.Date;
                    cmd.Parameters.AddWithValue("@p2", LblBookID.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rezervasyon Güncelleme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rezervasyon Güncelleme İşlemi Sırasında Hata Oluştu" + ex.Message);
            }
            finally
            {
                ConnectionString.connection().Close();
            }
        }

        private void btnRzrDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Books SET BookStatu=0,RenterNumber=null,RenterDate=null WHERE BookId=@p1", ConnectionString.connection());
                cmd.Parameters.AddWithValue("@p1", LblBookID.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Rezervasyon Silme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rezervasyon Silme İşlemi Sırasında Hata Oluştu" + ex.Message);
            }
            finally
            {
                ConnectionString.connection().Close();
            }
        }

        private void btnCalculateDelay_Click(object sender, EventArgs e)
        {
            if (LblBookID != null)
            {
                DateTime dateTime = DateTime.Now;
                int differenceDay = (int)(dateTime - DtpStudentDate.Value.Date).TotalDays;
                if (differenceDay > 15)
                {
                    int delay = (differenceDay - 15) * 2;
                    LblDelay.Text = delay.ToString();
                }

            }
        }

        private void btnRzrRemove_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Books SET BookStatu=0,RenterNumber=null,RenterDate=null WHERE BookId=@p1", ConnectionString.connection());
                cmd.Parameters.AddWithValue("@p1", LblBookID.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("İade İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("İade İşlemi Sırasında Hata Oluştu" + ex.Message);
            }
            finally
            {
                ConnectionString.connection().Close();
            }
        }
    }
}





