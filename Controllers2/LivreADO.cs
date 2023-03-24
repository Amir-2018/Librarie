﻿using Models2;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Controllers2
{
    public class LivreADO
    {
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

        public bool delete_livret(int id)
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

        public bool update_livre(Etudiant etudiant)
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
