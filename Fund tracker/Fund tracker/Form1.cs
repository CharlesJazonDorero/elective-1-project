using MySql.Data.MySqlClient;
namespace Fund_tracker

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=accounts_sql");
            try
            {
                conn.Open();
                textBox1.Text = textBox1.Text.TrimEnd();
                MySqlCommand User_exist = new MySqlCommand("SELECT Auth_User_Name from auth where Auth_User_Name=@username", conn);
                User_exist.Parameters.AddWithValue("@username", textBox1.Text);
                string Username_exist = (string)User_exist.ExecuteScalar();
                MySqlCommand E_exist = new MySqlCommand("SELECT Auth_Email from auth where Auth_Email=@email", conn);
                E_exist.Parameters.AddWithValue("@email", textBox1.Text);
                string Email_exist = (string)E_exist.ExecuteScalar();

                if (Username_exist == textBox1.Text)
                {
                    MySqlCommand Pass_exist = new MySqlCommand("SELECT Auth_Password from auth where Auth_User_Name=@username", conn);
                    Pass_exist.Parameters.AddWithValue("@username", textBox1.Text);
                    string password_exist = (string)Pass_exist.ExecuteScalar();
                    if ((password_exist == textBox2.Text))
                    {
                        MessageBox.Show("Welcome " + Username_exist, "Log in Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Form3 form = new Form3(Username_exist);
                        form.Show();
                    } else
                    {
                        MessageBox.Show("Password Doesn't match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                } else if (Email_exist == textBox1.Text)
                {
                    MySqlCommand Pass_exist = new MySqlCommand("SELECT Auth_Password from auth where Auth_Email=@email", conn);
                    Pass_exist.Parameters.AddWithValue("@email", textBox1.Text);
                    string password_exist = (string)Pass_exist.ExecuteScalar();
                    if ((password_exist == textBox2.Text))
                    {
                        MySqlCommand U_email = new MySqlCommand("SELECT Auth_User_Name from auth where Auth_Email=@email", conn);
                        U_email.Parameters.AddWithValue("@email", textBox1.Text);
                        string User_email = (string)E_exist.ExecuteScalar();
                        MessageBox.Show("Welcome " + User_email, "Log in Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form3 form = new Form3(Username_exist);
                        form.Show();
                        this.Hide();
                    } else
                    {
                        MessageBox.Show("Password Doesn't match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                } else
                {
                    MessageBox.Show("Invalid Username/Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        

        }
    }
}