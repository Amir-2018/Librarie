using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Statistiques : Form
    {
        public Statistiques()
        {
            InitializeComponent();

        }

        private void Statistiques_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-VPJMV81;Initial Catalog=Librairie;Integrated Security=True");
            conn.Open();
            string query = "select count(*) from Emprunts";
            SqlCommand command = new SqlCommand(query, conn);
            int count = (int)command.ExecuteScalar();
            label2.Text = count.ToString();


            string query1= "select count(*) from Livre";
            SqlCommand command1 = new SqlCommand(query1, conn);
            int count1 = (int)command1.ExecuteScalar();
            nblivres.Text = count1.ToString();

            string query2 = "select count(*) from Etudiant";
            SqlCommand command2 = new SqlCommand(query2, conn);
            int count2 = (int)command2.ExecuteScalar();
            label1.Text = count2.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
