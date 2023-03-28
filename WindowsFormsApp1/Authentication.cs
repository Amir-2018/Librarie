using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models2;
using Controllers2; 

namespace WindowsFormsApp1
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Authentication_Load(object sender, EventArgs e)
        {
                
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string email_admin = email.Text;
            string password_admin = password.Text;
            AuthenticateAdmin cntr_admin = new AuthenticateAdmin();
            bool tes_auth = cntr_admin.Auth_client(email_admin, password_admin);


            if (tes_auth)
                {
                this.Hide();
                Form1 form = new Form1();
                form.Show();
                

            }
            else
                MessageBox.Show("Verify your cridentials please");
           

        }
        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
