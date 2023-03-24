
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Xml.Linq;
using Models2;



namespace Controllers2
{
    public class EtudiantADO
    {

        // Crud functions add/delete/update and get data from database to insert its in the datasource
        public bool Add_Etudiant(Etudiant etudiant)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-VPJMV81;Initial Catalog=Librairie;Integrated Security=True");

            string query = "INSERT INTO Etudiant (nom, prenom, email,telephone,filiere,groupe,code_inscription) VALUES (@nom, @prenom, @email,@telephone,@filiere,@groupe,@code_inscription )";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();

            command.Parameters.AddWithValue("@nom", etudiant.Nom);
            command.Parameters.AddWithValue("@prenom", etudiant.Prenom);
            command.Parameters.AddWithValue("@email", etudiant.Email);
            command.Parameters.AddWithValue("@telephone", etudiant.Telephone);
            command.Parameters.AddWithValue("@filiere", etudiant.Filiere);
            command.Parameters.AddWithValue("@groupe", etudiant.Groupe);
            command.Parameters.AddWithValue("@code_inscription", etudiant.Code_inscription);
            // Execute request
            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
                return true;
            else
                return false;

        }

        public List<Etudiant> Load_etudiants()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-VPJMV81;Initial Catalog=Librairie;Integrated Security=True");
            conn.Open();
            string query = "select * from Etudiant";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            // read data from the reader and insert it in datasource 
            List<Etudiant> etudiants = new List<Etudiant>();
            while (reader.Read())   
            {
               
                string nom = reader["nom"].ToString();
                string prenom = reader["prenom"].ToString();
                string email = reader["email"].ToString();
                int tel = int.Parse(reader["telephone"].ToString());
                string filiere = reader["filiere"].ToString();
                string groupe = reader["groupe"].ToString();
                int code_inscription = int.Parse(reader["code_inscription"].ToString());
                int id_etudiant = int.Parse(reader["id_etudiant"].ToString());
                Etudiant clientObject = new Etudiant(nom, prenom, email, tel,filiere, code_inscription,id_etudiant, groupe);
                etudiants.Add(clientObject);

            }
            reader.Close();
            conn.Close();
            return etudiants;



        }

        public bool delete_etudiant(int id)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-VPJMV81;Initial Catalog=Librairie;Integrated Security=True");
            conn.Open();
            string query = "Delete from Etudiant where id_etudiant = @id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", id);
            int rowAffected = command.ExecuteNonQuery();
            if (rowAffected > 0)
                return true;
            else
                return false;

        }

        public bool update_etudiant(Etudiant etudiant)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-VPJMV81;Initial Catalog=Librairie;Integrated Security=True");
            conn.Open();
            string query = "Update Etudiant SET nom = @nom,prenom = @prenom,email = @email,telephone = @telephone,filiere = @filiere,groupe = @groupe,code_inscription = @code_inscription where id_etudiant = @id";
            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@nom", etudiant.Nom);
            command.Parameters.AddWithValue("@prenom", etudiant.Prenom);
            command.Parameters.AddWithValue("@email", etudiant.Email);
            command.Parameters.AddWithValue("@telephone", etudiant.Telephone);
            command.Parameters.AddWithValue("@filiere", etudiant.Filiere);
            command.Parameters.AddWithValue("@groupe", etudiant.Groupe);
            command.Parameters.AddWithValue("@code_inscription", etudiant.Code_inscription);
            command.Parameters.AddWithValue("@id", etudiant.Id_etudiant);

            // command.Parameters.AddWithValue("@id", etudiant.);

            int rowAffected = command.ExecuteNonQuery();
            conn.Close();
            if (rowAffected > 0)
                return true;
            else
                return false;

           

        }
    }
}
