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
        private string Email;
        public Form3(string Email_exist)
        {
            InitializeComponent();
            this.Email = Email_exist;
            label2.Text = Email;          
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Form4 form = new Form4(Email);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
