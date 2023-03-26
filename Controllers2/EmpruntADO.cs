using Models2;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Controllers2
{
    public class EmpruntADO
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
                string date_emprunt =reader["date_emprunt"].ToString();
                string date_retour = reader["date_retour"].ToString();


                Emprunt empruntObject = new Emprunt(id_emprunt, id_etudiant, id_livre, date_emprunt, date_retour);
                emprunts.Add(empruntObject);

            }
            reader.Close();
            conn.Close();
            return emprunts;



        }

        public bool Add_Emprunt(Emprunt emprunt)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-VPJMV81;Initial Catalog=Librairie;Integrated Security=True");
            string query = "INSERT INTO Emprunts (id_emprunt,id_etudiant,id_livre,date_emprunt,date_retour) VALUES (@id_emprunt,@id_etudiant, @id_livre, @date_emprunt,@date_retour)";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            command.Parameters.AddWithValue("@id_emprunt", emprunt.Id_emprunt);
            command.Parameters.AddWithValue("@id_etudiant", emprunt.Id_etudiant);
            command.Parameters.AddWithValue("@id_livre", emprunt.Id_livre);
            command.Parameters.AddWithValue("@date_emprunt", emprunt.Date_emprunt);
            command.Parameters.AddWithValue("@date_retour", emprunt.Date_retour);

            // Execute request
            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
                return true;
            else
                return false;

        }

        public bool delete_emprunt(int id)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-VPJMV81;Initial Catalog=Librairie;Integrated Security=True");
            conn.Open();
            string query = "Delete from Emprunts where id_emprunt = @id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", id);
            int rowAffected = command.ExecuteNonQuery();
            if (rowAffected > 0)
                return true;
            else
                return false;

        }

    }
}
