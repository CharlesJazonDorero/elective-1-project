using MySql.Data.MySqlClient;

namespace Fund_tracker
{
    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=accounts_sql");
            conn.Open();
            MySqlCommand user_exist = new MySqlCommand("SELECT Username from main where Username='" + textBox1.Text + "'", conn);
            string u_exist = (string)user_exist.ExecuteScalar();

            if (u_exist == textBox1.Text)
            {
                MessageBox.Show("this username is already taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                textBox8.Text = textBox8.Text.ToUpper().TrimEnd();
                textBox7.Text = textBox7.Text.ToUpper().TrimEnd();
                textBox9.Text = textBox9.Text.ToUpper().TrimEnd();
                MySqlCommand gender_selection = new MySqlCommand("SELECT Gender FROM gender_ where Gender='" + textBox9.Text + "'", conn);
                string gen_select = (string)gender_selection.ExecuteScalar();
                if (gen_select == textBox9.Text)
                {
                    MySqlCommand City_text = new MySqlCommand("SELECT City_Name from city where City_Name='" + textBox7.Text + "'", conn);
                    string exist = (string)City_text.ExecuteScalar();
                    if (exist == textBox7.Text)
                    {

                        MySqlCommand Province_text = new MySqlCommand("SELECT Province_Name from province where Province_Name='" + textBox8.Text + "'", conn);
                        string Province_exist = (string)Province_text.ExecuteScalar();
                        if (Province_exist == textBox8.Text)
                        {
                            string insert_all = "INSERT INTO details(First_Name, Middle_Name, Last_Name, Street, City, Province) SELECT @first_name, @middle_name, @last_name, @street, City_id, Province_id FROM city, province WHERE City_Name=@city_name and Province_Name=@province_name;" + 
                            "INSERT INTO main(Username, birthday, email, Gender) SELECT @username, @birthday, @email, Gender_id FROM gender_ WHERE Gender=@gender;" +
                            "INSERT INTO auth(Auth_User_Name, Auth_Email, Auth_Password) VALUES (@username, @email, @password);";

                            using (MySqlCommand insert_them = new MySqlCommand(insert_all, conn))
                            {
                                insert_them.Parameters.AddWithValue("@username", textBox1.Text);
                                insert_them.Parameters.AddWithValue("@birthday", dateTimePicker1.Text);
                                insert_them.Parameters.AddWithValue("@email", textBox5.Text);
                                insert_them.Parameters.AddWithValue("@gender", textBox9.Text);
                                insert_them.Parameters.AddWithValue("@first_name", textBox2.Text);
                                insert_them.Parameters.AddWithValue("@middle_name", textBox3.Text);
                                insert_them.Parameters.AddWithValue("@last_name", textBox4.Text);
                                insert_them.Parameters.AddWithValue("@street", textBox6.Text);
                                insert_them.Parameters.AddWithValue("@city_name", textBox7.Text);
                                insert_them.Parameters.AddWithValue("@province_name", textBox8.Text);
                                insert_them.Parameters.AddWithValue("@password", textBox10.Text);
                                insert_them.ExecuteNonQuery();
                                MessageBox.Show("Succesfully Signed up", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                Form1 form = new Form1();
                                form.Show();
                            }
                        }
                        else
                        {
                            string insert_all = "INSERT INTO province(Province_Name) VALUES(@province_name);" +
                            "INSERT INTO main(Username, birthday, email, Gender) SELECT @username, @birthday, @email, Gender_id FROM gender_ WHERE Gender=@gender;" +
                            "INSERT INTO details(First_Name, Middle_Name, Last_Name, Street, City, Province) SELECT @first_name, @middle_name, @last_name, @street, City_id, Province_id FROM city, province WHERE City_Name=@city_name and Province_Name=@province_name;"+
                            "INSERT INTO auth(Auth_User_Name, Auth_Email, Auth_Password) VALUES (@username, @email, @password);";

                            using (MySqlCommand insert_them = new MySqlCommand(insert_all, conn))
                            {
                                insert_them.Parameters.AddWithValue("@username", textBox1.Text);
                                insert_them.Parameters.AddWithValue("@birthday", dateTimePicker1.Text);
                                insert_them.Parameters.AddWithValue("@email", textBox5.Text);
                                insert_them.Parameters.AddWithValue("@gender", textBox9.Text);
                                insert_them.Parameters.AddWithValue("@first_name", textBox2.Text);
                                insert_them.Parameters.AddWithValue("@middle_name", textBox3.Text);
                                insert_them.Parameters.AddWithValue("@last_name", textBox4.Text);
                                insert_them.Parameters.AddWithValue("@street", textBox6.Text);
                                insert_them.Parameters.AddWithValue("@city_name", textBox7.Text);
                                insert_them.Parameters.AddWithValue("@province_name", textBox8.Text);
                                insert_them.Parameters.AddWithValue("@password", textBox10.Text);
                                insert_them.ExecuteNonQuery();
                                MessageBox.Show("Succesfully Signed up", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                Form1 form = new Form1();
                                form.Show();
                            }
                        }

                    }
                    else
                    {
                        MySqlCommand Province_text = new MySqlCommand("SELECT Province_Name from province where Province_Name='" + textBox8.Text + "'", conn);
                        string Province_exist = (string)Province_text.ExecuteScalar();
                        if (Province_exist == textBox8.Text)
                        {
                            string insert_all = "INSERT INTO province(Province_Name) VALUES(@province_name);" +
                            "INSERT INTO city(City_Name) VALUES(@city_name);" +
                            "INSERT INTO main(Username, birthday, email, Gender) SELECT @username, @birthday, @email, Gender_id FROM gender_ WHERE Gender=@gender;" +
                            "INSERT INTO details(First_Name, Middle_Name, Last_Name, Street, City, Province) SELECT @first_name, @middle_name, @last_name, @street, City_id, Province_id FROM city, province WHERE City_Name=@city_name and Province_Name=@province_name;" +
                            "INSERT INTO auth(Auth_User_Name, Auth_Email, Auth_Password) VALUES (@username, @email, @password);";

                            using (MySqlCommand insert_them = new MySqlCommand(insert_all, conn))
                            {
                                insert_them.Parameters.AddWithValue("@username", textBox1.Text);
                                insert_them.Parameters.AddWithValue("@birthday", dateTimePicker1.Text);
                                insert_them.Parameters.AddWithValue("@email", textBox5.Text);
                                insert_them.Parameters.AddWithValue("@gender", textBox9.Text);
                                insert_them.Parameters.AddWithValue("@first_name", textBox2.Text);
                                insert_them.Parameters.AddWithValue("@middle_name", textBox3.Text);
                                insert_them.Parameters.AddWithValue("@last_name", textBox4.Text);
                                insert_them.Parameters.AddWithValue("@street", textBox6.Text);
                                insert_them.Parameters.AddWithValue("@city_name", textBox7.Text);
                                insert_them.Parameters.AddWithValue("@province_name", textBox8.Text);
                                insert_them.Parameters.AddWithValue("@password", textBox10.Text);
                                insert_them.ExecuteNonQuery();
                                MessageBox.Show("Succesfully Signed up", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                Form1 form = new Form1();
                                form.Show();
                            }

                        }
                        else
                        {
                            string insert_all = "INSERT INTO province(Province_Name) VALUES(@province_name);" +
                            "INSERT INTO city(City_Name) VALUES(@city_name);" +
                            "INSERT INTO main(Username, birthday, email, Gender) SELECT @username, @birthday, @email, Gender_id FROM gender_ WHERE Gender=@gender;" +
                            "INSERT INTO details(First_Name, Middle_Name, Last_Name, Street, City, Province) SELECT @first_name, @middle_name, @last_name, @street, City_id, Province_id FROM city, province WHERE City_Name=@city_name and Province_Name=@province_name;" +
                            "INSERT INTO auth(Auth_User_Name, Auth_Email, Auth_Password) VALUES (@username, @email, @password);";

                            using (MySqlCommand insert_them = new MySqlCommand(insert_all, conn))
                            {
                                insert_them.Parameters.AddWithValue("@username", textBox1.Text);
                                insert_them.Parameters.AddWithValue("@birthday", dateTimePicker1.Text);
                                insert_them.Parameters.AddWithValue("@email", textBox5.Text);
                                insert_them.Parameters.AddWithValue("@gender", textBox9.Text);
                                insert_them.Parameters.AddWithValue("@first_name", textBox2.Text);
                                insert_them.Parameters.AddWithValue("@middle_name", textBox3.Text);
                                insert_them.Parameters.AddWithValue("@last_name", textBox4.Text);
                                insert_them.Parameters.AddWithValue("@street", textBox6.Text);
                                insert_them.Parameters.AddWithValue("@city_name", textBox7.Text);
                                insert_them.Parameters.AddWithValue("@province_name", textBox8.Text);
                                insert_them.Parameters.AddWithValue("@password", textBox10.Text);
                                insert_them.ExecuteNonQuery();
                                MessageBox.Show("Succesfully Signed up", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                Form1 form = new Form1();
                                form.Show();
                            }
                        }
                    }


                }
                else
                {
                    MySqlCommand City_text = new MySqlCommand("SELECT City_Name from city where City_Name='" + textBox7.Text + "'", conn);
                    string exist = (string)City_text.ExecuteScalar();
                    if (exist == textBox7.Text)
                    {

                        MySqlCommand Province_text = new MySqlCommand("SELECT Province_Name from province where Province_Name='" + textBox8.Text + "'", conn);
                        string Province_exist = (string)Province_text.ExecuteScalar();
                        if (Province_exist == textBox8.Text)
                        {
                            string insert_all = "INSERT INTO gender_(Gender) VALUES(@gender);" +
                            "INSERT INTO main(Username, birthday, email, Gender) SELECT @username, @birthday, @email, Gender_id FROM gender_ WHERE Gender=@gender;" +
                             "INSERT INTO details(First_Name, Middle_Name, Last_Name, Street, City, Province) SELECT @first_name, @middle_name, @last_name, @street, City_id, Province_id FROM city, province WHERE City_Name=@city_name and Province_Name=@province_name;" +
                            "INSERT INTO auth(Auth_User_Name, Auth_Email, Auth_Password) VALUES (@username, @email, @password);";

                            using (MySqlCommand insert_them = new MySqlCommand(insert_all, conn))
                            {
                                insert_them.Parameters.AddWithValue("@username", textBox1.Text);
                                insert_them.Parameters.AddWithValue("@birthday", dateTimePicker1.Text);
                                insert_them.Parameters.AddWithValue("@email", textBox5.Text);
                                insert_them.Parameters.AddWithValue("@gender", textBox9.Text);
                                insert_them.Parameters.AddWithValue("@first_name", textBox2.Text);
                                insert_them.Parameters.AddWithValue("@middle_name", textBox3.Text);
                                insert_them.Parameters.AddWithValue("@last_name", textBox4.Text);
                                insert_them.Parameters.AddWithValue("@street", textBox6.Text);
                                insert_them.Parameters.AddWithValue("@city_name", textBox7.Text);
                                insert_them.Parameters.AddWithValue("@province_name", textBox8.Text);
                                insert_them.Parameters.AddWithValue("@password", textBox10.Text);
                                insert_them.ExecuteNonQuery();
                                MessageBox.Show("Succesfully Signed up", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                Form1 form = new Form1();
                                form.Show();
                            }

                        }
                        else
                        {
                            string insert_all = "INSERT INTO province(Province_Name) VALUES(@province_name);" +
                            "INSERT INTO gender_(Gender) VALUES(@gender);" +
                            "INSERT INTO main(Username, birthday, email, Gender) SELECT @username, @birthday, @email, Gender_id FROM gender_ WHERE Gender=@gender;" +
                            "INSERT INTO details(First_Name, Middle_Name, Last_Name, Street, City, Province) SELECT @first_name, @middle_name, @last_name, @street, City_id, Province_id FROM city, province WHERE City_Name=@city_name and Province_Name=@province_name;" +
                            "INSERT INTO auth(Auth_User_Name, Auth_Email, Auth_Password) VALUES (@username, @email, @password);";

                            using (MySqlCommand insert_them = new MySqlCommand(insert_all, conn))
                            {
                                insert_them.Parameters.AddWithValue("@username", textBox1.Text);
                                insert_them.Parameters.AddWithValue("@birthday", dateTimePicker1.Text);
                                insert_them.Parameters.AddWithValue("@email", textBox5.Text);
                                insert_them.Parameters.AddWithValue("@gender", textBox9.Text);
                                insert_them.Parameters.AddWithValue("@first_name", textBox2.Text);
                                insert_them.Parameters.AddWithValue("@middle_name", textBox3.Text);
                                insert_them.Parameters.AddWithValue("@last_name", textBox4.Text);
                                insert_them.Parameters.AddWithValue("@street", textBox6.Text);
                                insert_them.Parameters.AddWithValue("@city_name", textBox7.Text);
                                insert_them.Parameters.AddWithValue("@province_name", textBox8.Text);
                                insert_them.Parameters.AddWithValue("@password", textBox10.Text);
                                insert_them.ExecuteNonQuery();
                                MessageBox.Show("Succesfully Signed up", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                Form1 form = new Form1();
                                form.Show();
                            }
                        }

                    }
                    else
                    {
                        MySqlCommand Province_text = new MySqlCommand("SELECT Province_Name from province where Province_Name='" + textBox8.Text + "'", conn);
                        string Province_exist = (string)Province_text.ExecuteScalar();
                        if (Province_exist == textBox8.Text)
                        {
                            string insert_all = "INSERT INTO gender_(Gender) VALUES(@gender);" +
                            "INSERT INTO city(City_Name) VALUES(@city_name);" +
                            "INSERT INTO main(Username, birthday, email, Gender) SELECT @username, @birthday, @email, Gender_id FROM gender_ WHERE Gender=@gender;" +
                            "INSERT INTO details(First_Name, Middle_Name, Last_Name, Street, City, Province) SELECT @first_name, @middle_name, @last_name, @street, City_id, Province_id FROM city, province WHERE City_Name=@city_name and Province_Name=@province_name;" +
                            "INSERT INTO auth(Auth_User_Name, Auth_Email, Auth_Password) VALUES (@username, @email, @password);";

                            using (MySqlCommand insert_them = new MySqlCommand(insert_all, conn))
                            {
                                insert_them.Parameters.AddWithValue("@username", textBox1.Text);
                                insert_them.Parameters.AddWithValue("@birthday", dateTimePicker1.Text);
                                insert_them.Parameters.AddWithValue("@email", textBox5.Text);
                                insert_them.Parameters.AddWithValue("@gender", textBox9.Text);
                                insert_them.Parameters.AddWithValue("@first_name", textBox2.Text);
                                insert_them.Parameters.AddWithValue("@middle_name", textBox3.Text);
                                insert_them.Parameters.AddWithValue("@last_name", textBox4.Text);
                                insert_them.Parameters.AddWithValue("@street", textBox6.Text);
                                insert_them.Parameters.AddWithValue("@city_name", textBox7.Text);
                                insert_them.Parameters.AddWithValue("@province_name", textBox8.Text);
                                insert_them.Parameters.AddWithValue("@password", textBox10.Text);
                                insert_them.ExecuteNonQuery();
                                MessageBox.Show("Succesfully Signed up", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                Form1 form = new Form1();
                                form.Show();
                            }

                        }
                        else
                        {
                            string insert_all = "INSERT INTO province(Province_Name) VALUES(@province_name);" +
                                "INSERT INTO gender_(Gender) VALUES(@gender);" +
                            "INSERT INTO city(City_Name) VALUES(@city_name);" +
                            "INSERT INTO main(Username, birthday, email, Gender) SELECT @username, @birthday, @email, Gender_id FROM gender_ WHERE Gender=@gender;" +
                             "INSERT INTO details(First_Name, Middle_Name, Last_Name, Street, City, Province) SELECT @first_name, @middle_name, @last_name, @street, City_id, Province_id FROM city, province WHERE City_Name=@city_name and Province_Name=@province_name;" +
                            "INSERT INTO auth(Auth_User_Name, Auth_Email, Auth_Password) VALUES (@username, @email, @password);";

                            using (MySqlCommand insert_them = new MySqlCommand(insert_all, conn))
                            {
                                insert_them.Parameters.AddWithValue("@username", textBox1.Text);
                                insert_them.Parameters.AddWithValue("@birthday", dateTimePicker1.Text);
                                insert_them.Parameters.AddWithValue("@email", textBox5.Text);
                                insert_them.Parameters.AddWithValue("@gender", textBox9.Text);
                                insert_them.Parameters.AddWithValue("@first_name", textBox2.Text);
                                insert_them.Parameters.AddWithValue("@middle_name", textBox3.Text);
                                insert_them.Parameters.AddWithValue("@last_name", textBox4.Text);
                                insert_them.Parameters.AddWithValue("@street", textBox6.Text);
                                insert_them.Parameters.AddWithValue("@city_name", textBox7.Text);
                                insert_them.Parameters.AddWithValue("@province_name", textBox8.Text);
                                insert_them.Parameters.AddWithValue("@password", textBox10.Text);
                                insert_them.ExecuteNonQuery();
                                MessageBox.Show("Succesfully Signed up", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                Form1 form = new Form1();
                                form.Show();
                            }
                        }
                    }

                }
            }


            conn.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
