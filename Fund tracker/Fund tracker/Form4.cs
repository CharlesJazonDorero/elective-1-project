using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Fund_tracker
{
    public partial class Form4 : Form
    {
        private string Email;
        public Form4(string Email)
        {
            InitializeComponent();
            this.Email = Email;
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form = new Form3(Email);
            form.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label8.Text = this.Email;
            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=accounts_sql");
            conn.Open();
            MySqlCommand ID_check = new MySqlCommand("SELECT Auth_id FROM auth Where Auth_Email = @email", conn);
            ID_check.Parameters.AddWithValue("@email", this.Email);
            string ID_existed = (string)ID_check.ExecuteScalar();
            MySqlCommand Email_check = new MySqlCommand("SELECT Auth_Email from auth where Auth_id = @id", conn);
            Email_check.Parameters.AddWithValue("@id", ID_existed);
            string email_run = (string)Email_check.ExecuteScalar();
            MySqlCommand per_check = new MySqlCommand("SELECT person_id from expesnes where person_id = @id_pers", conn);
            per_check.Parameters.AddWithValue("@id_pers", ID_existed);
            string per_id_exist = (string)per_check.ExecuteScalar();

            if (per_id_exist != null ) {
                MySqlCommand sql_string = new MySqlCommand("UPDATE expenses SET bills = @bills, Included_bills, date_bills, food, necessities, date_necessities, income, date_income, savings, date_savings " +
               "SELECT @ID, @bills, @included_bills, @date_bills, @food, @date_food, @necessities, @date_necessities, @income, @date_income, @savings, @date_savings;", conn);
            } else
            {

            }

            


           
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
