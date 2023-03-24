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

namespace View
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();

            
        }

        private void Update_Load(object sender, EventArgs e)
        {

        }
        public void UpdateTextBox1Value(string newValue)
        {
            upNum.Text = newValue;
        }

        public void upNum_Click(object sender, EventArgs e)
        {
            
        }
        
        public void update_client()
        {
            
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-VPJMV81;Initial Catalog=Gestion;Integrated Security=True");
            int id = int.Parse(upNum.Text);

            string query = "UPDATE Client SET nom = @nom, prenom = @prenom, email = @email, telephone = @tel WHERE code_client = @id;";

            //conn.Open();

            SqlCommand command = new SqlCommand(query, conn);

                // Add parameters to the command
            
                command.Parameters.AddWithValue("@nom", nom.Text);
                command.Parameters.AddWithValue("@prenom", lastname.Text);
                command.Parameters.AddWithValue("@email", email.Text);
                command.Parameters.AddWithValue("@tel", int.Parse(tel.Text));
                command.Parameters.AddWithValue("@id", id);



            // Open connection and execute query
            conn.Open();
                int rowsAffected = command.ExecuteNonQuery();

            // Check if any rows were affected
        
                if (rowsAffected > 0)
                {
                    MessageBox.Show("User Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
           

                



            conn.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            update_client();
        }
    }
}
