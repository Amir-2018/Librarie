using Models2;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Controllers2
{
    public class LivreADO
    {
        public bool Add_Livre(Livre livre)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-VPJMV81;Initial Catalog=Librairie;Integrated Security=True");

            string query = "INSERT INTO Livre (titre, auteur, nbpages,nbchapitre,date_edition,prix,category) VALUES (@titre, @auteur, @nbpages,@nbchapitre,@date_edition,@prix,@category)";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();

            command.Parameters.AddWithValue("@titre", livre.Titre);
            command.Parameters.AddWithValue("@auteur", livre.Auteur);
            command.Parameters.AddWithValue("@nbpages", livre.Nbpages);
            command.Parameters.AddWithValue("@nbchapitre", livre.Nbchapitre);
            command.Parameters.AddWithValue("@date_edition", livre.Date_edition);
            command.Parameters.AddWithValue("@prix", livre.Prix);
            command.Parameters.AddWithValue("@category", livre.Category);
            // Execute request
            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
                return true;
            else
                return false;

        }

        public List<Livre> Load_livres()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-VPJMV81;Initial Catalog=Librairie;Integrated Security=True");
            conn.Open();
            string query = "select * from Livre";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            // read data from the reader and insert it in datasource 
            List<Livre> livres = new List<Livre>();
            while (reader.Read())
            {
                int id_livre = int.Parse(reader["id_livre"].ToString());
                string titre = reader["titre"].ToString();
                string auteur = reader["auteur"].ToString();
                int nbpages = int.Parse(reader["nbpages"].ToString());
                int nbchapitre = int.Parse(reader["nbchapitre"].ToString());
                DateTime date_edition = DateTime.Parse(reader["date_edition"].ToString());
                float prix = float.Parse(reader["prix"].ToString()); 
                string category = reader["category"].ToString();


                Livre livreObject = new Livre(id_livre,titre,auteur,nbpages,nbchapitre,date_edition,prix,category);
                livres.Add(livreObject);

            }
            reader.Close();
            conn.Close();
            return livres;



        }

        public bool delete_livre(int id)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-VPJMV81;Initial Catalog=Librairie;Integrated Security=True");
            conn.Open();
            string query = "Delete from Livre where id_livre = @id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", id);
            int rowAffected = command.ExecuteNonQuery();
            if (rowAffected > 0)
                return true;
            else
                return false;

        }

        public bool update_livre(Livre livre)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-VPJMV81;Initial Catalog=Librairie;Integrated Security=True");
            conn.Open();
            string query = "Update Livre SET titre = @titre,auteur = @auteur,nbpages = @nbpages,nbchapitre = @nbchapitre,prix = @prix,category = @category where id_livre = @id";
            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@titre", livre.Titre);
            command.Parameters.AddWithValue("@auteur", livre.Auteur);
            command.Parameters.AddWithValue("@nbpages", livre.Nbpages);
            command.Parameters.AddWithValue("@nbchapitre", livre.Nbchapitre);
            command.Parameters.AddWithValue("@prix", livre.Prix);
            command.Parameters.AddWithValue("@category", livre.Category);
            command.Parameters.AddWithValue("@id", livre.Id_livre);

            // command.Parameters.AddWithValue("@id", etudiant.);

            int rowAffected = command.ExecuteNonQuery();
            conn.Close();
            if (rowAffected > 0)
                return true;
            else
                return false;



        }

        public List<Livre> Return_livres()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-VPJMV81;Initial Catalog=Librairie;Integrated Security=True");
            conn.Open();
            string query = "SELECT * FROM Livre WHERE date_retour = @today";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@today", DateTime.Today);
            SqlDataReader reader = command.ExecuteReader();
            // read data from the reader and insert it in datasource 
            List<Livre> livres = new List<Livre>();
            while (reader.Read())
            {
                int id_livre = int.Parse(reader["id_livre"].ToString());
                string titre = reader["titre"].ToString();
                string auteur = reader["auteur"].ToString();
                int nbpages = int.Parse(reader["nbpages"].ToString());
                int nbchapitre = int.Parse(reader["nbchapitre"].ToString());
                DateTime date_edition = DateTime.Parse(reader["date_edition"].ToString());
                float prix = float.Parse(reader["prix"].ToString());
                string category = reader["category"].ToString();

                Livre livreObject = new Livre(id_livre, titre, auteur, nbpages, nbchapitre, date_edition, prix, category);
                livres.Add(livreObject);
            }
            reader.Close();
            conn.Close();
            return livres;
        }


    }
}
