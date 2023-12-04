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
        private string User;
        public Form3(string Username_exist)
        {
            InitializeComponent();
            label2.Text = Username_exist;

            this.User = Username_exist;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form = new Form4(User);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
