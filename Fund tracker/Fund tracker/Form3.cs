using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fund_tracker
{
    public partial class Form3 : Form
    {
        private string account;
        public Form3(string account)
        {
            InitializeComponent();
            this.account = account;
            label4.Text = account;

            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=accounts_sql");
            conn.Open();
            MySqlCommand ID_check = new MySqlCommand("SELECT Auth_id FROM auth Where Auth_Email = @email OR Auth_User_Name = @email", conn);
            ID_check.Parameters.AddWithValue("@email", this.account);
            int ID_existed = (int)ID_check.ExecuteScalar();


            MySqlCommand per_check = new MySqlCommand("SELECT person_id from expenses where person_id = @id_pers", conn);
            per_check.Parameters.AddWithValue("@id_pers", ID_existed);
            object per_id_exist = per_check.ExecuteScalar();

            if (per_id_exist != null)
            {
                MySqlCommand selectCommand = new MySqlCommand("SELECT income, date_income, bills, date_bills, Included_bills, food, date_food, necessities, date_necessities, savings, date_savings FROM expenses WHERE person_id = @id_pers", conn);
                selectCommand.Parameters.AddWithValue("@id_pers", ID_existed);

                using (MySqlDataReader reader = selectCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int income_text = reader.GetInt32("income");
                        string date_income = reader.GetString("date_income");
                        int bills_text = reader.GetInt32("bills");
                        string date_bills = reader.GetString("date_bills");
                        string included_bills = reader.GetString("Included_bills");
                        int food_text = reader.GetInt32("food");
                        string date_food = reader.GetString("date_food");
                        int necessities_text = reader.GetInt32("necessities");
                        string date_necessities = reader.GetString("date_necessities");
                        int savings_text = reader.GetInt32("savings");
                        string date_savings = reader.GetString("date_savings");

                        label15.Text = Convert.ToString(income_text);
                        label18.Text = Convert.ToString(bills_text);
                        label19.Text = Convert.ToString(food_text);
                        label20.Text = Convert.ToString(necessities_text);
                        label21.Text = Convert.ToString(savings_text);

                        label17.Text = included_bills;

                        label10.Text = date_income;
                        label11.Text = date_bills;
                        label12.Text = date_food;
                        label13.Text = date_necessities;
                        label14.Text = date_savings;
                    }
                }
            }

            conn.Close();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form4 form = new Form4(account);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=accounts_sql");
            conn.Open();

            MySqlCommand ID_check = new MySqlCommand("SELECT Auth_id FROM auth Where Auth_Email = @email OR Auth_User_Name = @email", conn);
            ID_check.Parameters.AddWithValue("@email", this.account);
            int ID_existed = (int)ID_check.ExecuteScalar();

            MySqlCommand per_check = new MySqlCommand("SELECT person_id from expenses where person_id = @id_pers", conn);
            per_check.Parameters.AddWithValue("@id_pers", ID_existed);
            object per_id_exist = per_check.ExecuteScalar();

            if (per_id_exist != null)
            {
                MySqlCommand selectCommand = new MySqlCommand("SELECT income, date_income, bills, date_bills, Included_bills, food, date_food, necessities, date_necessities, savings, date_savings FROM expenses WHERE person_id = @id_pers", conn);
                selectCommand.Parameters.AddWithValue("@id_pers", ID_existed);

                using (MySqlDataReader reader = selectCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int income_text = reader.GetInt32("income");
                        string date_income = reader.GetString("date_income");
                        int bills_text = reader.GetInt32("bills");
                        string date_bills = reader.GetString("date_bills");
                        string included_bills = reader.GetString("Included_bills");
                        int food_text = reader.GetInt32("food");
                        string date_food = reader.GetString("date_food");
                        int necessities_text = reader.GetInt32("necessities");
                        string date_necessities = reader.GetString("date_necessities");
                        int savings_text = reader.GetInt32("savings");
                        string date_savings = reader.GetString("date_savings");

                        label15.Text = Convert.ToString(income_text);
                        label18.Text = Convert.ToString(bills_text);
                        label19.Text = Convert.ToString(food_text);
                        label20.Text = Convert.ToString(necessities_text);
                        label21.Text = Convert.ToString(savings_text);

                        label17.Text = included_bills;

                        label10.Text = date_income;
                        label11.Text = date_bills;
                        label12.Text = date_food;
                        label13.Text = date_necessities;
                        label14.Text = date_savings;
                    }
                }
            }

            conn.Close();
            MessageBox.Show("Funds Updated to latest record", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
