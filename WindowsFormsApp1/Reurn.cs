using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers2;
using Models2; 

namespace WindowsFormsApp1
{
    public partial class Reurn : Form
    {
        public Reurn()
        {
            InitializeComponent();
        }

        private void Reurn_Load(object sender, EventArgs e)
        {
            // Call the Load_livres method to retrieve the list of books with a return date equal to today's date
            LivreADO lv = new LivreADO(); 
            List<Models2.Emprunt> livres = lv.Return_livres();

            // Bind the list of books to the DataGridView control
            dataGridView1.DataSource = livres;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<int> idList = new List<int>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int id;
                if (Int32.TryParse(row.Cells["id_etudiant"].Value.ToString(), out id))
                {
                    idList.Add(id);
                }
            }

            List<string> emails = new List<string>();

            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-VPJMV81;Initial Catalog=Librairie;Integrated Security=True"))
            {
                string query = "SELECT email FROM Etudiant WHERE id_etudiant IN ({0})";
                string idString = string.Join(",", idList);
                query = string.Format(query, idString);

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string email = reader.GetString(0);
                            emails.Add(email);
                        }
                    }
                }
            }

            // Envoyer en email de groupe : 
            MailMessage message = new MailMessage();
            message.From = new MailAddress("amir.maalaoui27@gmail.com");
            message.Subject = "Subject of your email";
            message.Body = "Body of your email";

            // loop through the emails list and add each email address to the To field
            foreach (string email in emails)
            {
                message.To.Add(email);
            }

            // create a SmtpClient object and set its properties
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.example.com";
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential("amir.maalaoui27@gmail.com", "allahallahyeselem?");

            // send the email
            smtpClient.Send(message);
            MessageBox.Show("Emails sended with success"); 



        }
    }
}
