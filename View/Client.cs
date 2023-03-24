using System;
using System.Collections;
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
    public partial class Client : Form
    {
        public static Client instance; 
        
        
        public Client()
        {
            InitializeComponent();
            instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Connect to the database 
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-VPJMV81;Initial Catalog=Gestion;Integrated Security=True");

            // the sql command 
            string query = "INSERT INTO Client (nom, prenom, email,telephone) VALUES (@nom, @prenom, @email,@telephone)";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            // Values to add in the database
            command.Parameters.AddWithValue("@nom", name.Text);
            command.Parameters.AddWithValue("@prenom", lastname.Text);
            command.Parameters.AddWithValue("@email", em.Text);
            command.Parameters.AddWithValue("@telephone", int.Parse(tel.Text));

            try
            {
                // Execute the command to add the user to the database
                int rowsAffected = command.ExecuteNonQuery();

                // Check if any rows were affected
                if (rowsAffected > 0)
                {
                    // Display a success message box
                    MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Display a warning message box if no rows were affected
                    MessageBox.Show("No rows affected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Display an error message box if there is an exception
                MessageBox.Show("Error adding user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




            // After adding the user to the database
            conn.Close();
        }
        public void delete_client(int code_client)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-VPJMV81;Initial Catalog=Gestion;Integrated Security=True");
            string query = "DELETE FROM Client WHERE code_client = @code_client";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            cmd.Parameters.AddWithValue("@code_client", code_client);

            // Execute the SQL DELETE statement and get the number of rows affected
            int rowsAffected = cmd.ExecuteNonQuery();

            // Check if the user was successfully deleted
            if (rowsAffected > 0)
            {
                MessageBox.Show("Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Not deleted There is some error!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-VPJMV81;Initial Catalog=Gestion;Integrated Security=True");
            string query = "SELECT * FROM Client";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            // Create a DataTable object to hold the data
            DataTable dataTable = new DataTable();

            // Load the data from the SqlDataReader into the DataTable
            dataTable.Load(reader);
            table_data.DataSource = dataTable;
            reader.Close();
            conn.Close();
        }

        private void table_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (table_data.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = table_data.SelectedRows[0];
                object[] rowValues = new object[selectedRow.Cells.Count];

                for (int i = 0; i < selectedRow.Cells.Count; i++)
                {
                    rowValues[i] = selectedRow.Cells[i].Value;
                }
 ;
                delete_client(int.Parse(rowValues[0].ToString())); 
                

                // Now you can use the rowValues array to access the values of the selected row
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form forBackground = new Form(); 
          

            if (table_data.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = table_data.SelectedRows[0];
                object[] rowValues = new object[selectedRow.Cells.Count];

                for (int i = 0; i < selectedRow.Cells.Count; i++)
                {
                    rowValues[i] = selectedRow.Cells[i].Value;
                }




                try
                 {
                     using (Update uu = new Update())
                     {
                         forBackground.StartPosition = FormStartPosition.Manual;
                         forBackground.FormBorderStyle = FormBorderStyle.None;
                         forBackground.Opacity = .0d;
                         forBackground.BackColor = Color.Black;
                         forBackground.WindowState = FormWindowState.Maximized;
                         forBackground.TopMost = true;
                         forBackground.Location = this.Location;
                         forBackground.ShowInTaskbar = false;
                        
                         forBackground.Show();
                        uu.UpdateTextBox1Value(rowValues[0].ToString());
                        uu.Owner = forBackground;
                        
                        uu.ShowDialog();
                         
                         forBackground.Dispose();

                     }
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }
                 finally
                 {
                     forBackground.Dispose();
                 }


                // Now you can use the rowValues array to access the values of the selected row
            }

        }

        private void Client_Load(object sender, EventArgs e)
        {

        }
    }
}
