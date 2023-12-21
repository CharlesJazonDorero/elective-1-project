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
        private string account;
        public Form4(string account)
        {
            InitializeComponent();
            this.account = account;
            label12.Text = account;
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form = new Form3(account);
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
            
            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=accounts_sql");
            conn.Open();

            MySqlCommand ID_check = new MySqlCommand("SELECT Auth_id FROM auth Where Auth_User_name or Auth_User_Name = @email", conn);
            ID_check.Parameters.AddWithValue("@email", this.account);
            int ID_existed = (int)ID_check.ExecuteScalar();


            MySqlCommand per_check = new MySqlCommand("SELECT person_id from expenses where person_id = @id_pers", conn);
            per_check.Parameters.AddWithValue("@id_pers", ID_existed);
            object per_id_exist = per_check.ExecuteScalar();

            if (per_id_exist != null ) {
                MySqlCommand sql_string = new MySqlCommand("UPDATE expenses SET bills = @bills, Included_bills=@included_bills, date_bills = @date_bills, food = @food, date_food = @date_food, necessities = @necessities, date_necessities = @date_necessities, income = @income, date_income = @date_income, savings = @savings, date_savings = @date_savings WHERE person_id=@person_id" , conn);
                sql_string.Parameters.AddWithValue("@person_id", ID_existed );
                sql_string.Parameters.AddWithValue("@income", Convert.ToInt32(textBox1.Text));
                sql_string.Parameters.AddWithValue("@date_income", dateTimePicker1.Text);
                sql_string.Parameters.AddWithValue("@bills", Convert.ToInt32(textBox2.Text));
                if (checkBox1.Checked & checkBox2.Checked & checkBox3.Checked)
                {
                    sql_string.Parameters.AddWithValue("@included_bills", "Electicity, Water, Rent");
                } 
                else if (checkBox1.Checked & checkBox2.Checked)
                {
                    sql_string.Parameters.AddWithValue("@included_bills", "Electicity, Water");
                }
                else if (checkBox1.Checked & checkBox3.Checked)
                {
                    sql_string.Parameters.AddWithValue("@included_bills", "Electicity, Rent");
                }
                else if (checkBox3.Checked & checkBox2.Checked)
                {
                    sql_string.Parameters.AddWithValue("@included_bills", "Water, Rent");
                }
                else if (checkBox1.Checked)
                {
                    sql_string.Parameters.AddWithValue("@included_bills", "Electicity");
                }
                else if (checkBox2.Checked)
                {
                    sql_string.Parameters.AddWithValue("@included_bills", "Water");
                }
                else if (checkBox3.Checked)
                {
                    sql_string.Parameters.AddWithValue("@included_bills", "Rent");
                }
                sql_string.Parameters.AddWithValue("@date_bills", dateTimePicker2.Text);
                sql_string.Parameters.AddWithValue("@food", Convert.ToInt32(textBox3.Text));
                sql_string.Parameters.AddWithValue("@date_food", dateTimePicker3.Text);
                sql_string.Parameters.AddWithValue("@necessities", Convert.ToInt32(textBox4.Text));
                sql_string.Parameters.AddWithValue("@date_necessities", dateTimePicker4.Text);
                sql_string.Parameters.AddWithValue("@savings", Convert.ToInt32(textBox5.Text));
                sql_string.Parameters.AddWithValue("@date_savings", dateTimePicker5.Text);
                sql_string.ExecuteNonQuery();
                this.Hide();
                Form3 form = new Form3(account);
                form.Show();

            } else
            {
                MySqlCommand sql_string = new MySqlCommand("INSERT INTO expenses( bills, Included_bills, date_bills, food, date_food, necessities, date_necessities, income, date_income, savings, date_savings, person_id) SELECT @bills, @included_bills, @date_bills, @food, @date_food, @necessities, @date_necessities, @income, @date_income, @savings, @date_savings, Auth_id FROM auth WHERE Auth_Email = @email OR Auth_User_Name = @email ", conn);
                sql_string.Parameters.AddWithValue("@email", this.account);
                sql_string.Parameters.AddWithValue("@income", Convert.ToInt32(textBox1.Text));
                sql_string.Parameters.AddWithValue("@date_income", dateTimePicker1.Text);
                sql_string.Parameters.AddWithValue("@bills", Convert.ToInt32(textBox2.Text));
                if (checkBox1.Checked & checkBox2.Checked & checkBox3.Checked)
                {
                    sql_string.Parameters.AddWithValue("@included_bills", "Electicity, Water, Rent");
                }
                else if (checkBox1.Checked & checkBox2.Checked)
                {
                    sql_string.Parameters.AddWithValue("@included_bills", "Electicity, Water");
                }
                else if (checkBox1.Checked & checkBox3.Checked)
                {
                    sql_string.Parameters.AddWithValue("@included_bills", "Electicity, Rent");
                }
                else if (checkBox3.Checked & checkBox2.Checked)
                {
                    sql_string.Parameters.AddWithValue("@included_bills", "Water, Rent");
                }
                else if (checkBox1.Checked)
                {
                    sql_string.Parameters.AddWithValue("@included_bills", "Electicity");
                }
                else if (checkBox2.Checked)
                {
                    sql_string.Parameters.AddWithValue("@included_bills", "Water");
                }
                else if (checkBox3.Checked)
                {
                    sql_string.Parameters.AddWithValue("@included_bills", "Rent");
                }
                sql_string.Parameters.AddWithValue("@date_bills", dateTimePicker2.Text);
                sql_string.Parameters.AddWithValue("@food", Convert.ToInt32(textBox3.Text));
                sql_string.Parameters.AddWithValue("@date_food", dateTimePicker3.Text);
                sql_string.Parameters.AddWithValue("@necessities", Convert.ToInt32(textBox4.Text));
                sql_string.Parameters.AddWithValue("@date_necessities", dateTimePicker4.Text);
                sql_string.Parameters.AddWithValue("@savings", Convert.ToInt32(textBox5.Text));
                sql_string.Parameters.AddWithValue("@date_savings", dateTimePicker5.Text);
                sql_string.ExecuteNonQuery();
                MessageBox.Show("Expenses Added", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form3 form = new Form3(account);
                form.Show();


            }

            conn.Close();
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
