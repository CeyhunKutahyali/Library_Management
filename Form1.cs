namespace Library_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStudentLogin_Click(object sender, EventArgs e)
        {
            StudentLoginForm studentLoginForm = new StudentLoginForm();
            studentLoginForm.Show();
            this.Hide();
        }

        private void BtnManagerLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}