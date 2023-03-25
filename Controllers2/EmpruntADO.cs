using Models2;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Controllers2
{
    internal class EmpruntADO
    {
        public List<Emprunt> Load_emprunts()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-VPJMV81;Initial Catalog=Librairie;Integrated Security=True");
            conn.Open();
            string query = "select * from Emprunts";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            // read data from the reader and insert it in datasource 
            List<Emprunt> emprunts = new List<Emprunt>();
            while (reader.Read())
            {
                int id_emprunt = int.Parse(reader["id_emprunt"].ToString());
                int id_etudiant = int.Parse(reader["id_etudiant"].ToString());
                int id_livre = int.Parse(reader["id_livre"].ToString());
                DateTime date_emprunt = DateTime.Parse(reader["date_emprunt"].ToString());
                DateTime date_retour = DateTime.Parse(reader["date_retour"].ToString());


                Emprunt empruntObject = new Emprunt(id_emprunt, id_etudiant, id_livre, date_emprunt, date_retour);
                emprunts.Add(empruntObject);

            }
            reader.Close();
            conn.Close();
            return emprunts;



        }
    }
}
