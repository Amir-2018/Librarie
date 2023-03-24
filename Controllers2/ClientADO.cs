
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Xml.Linq;
using Models2;



namespace Controllers2
{
    public class AdminController
    {

        private string nom;
        private string prenom; 
        private string email;
        private string password;

        public AdminController(string nom, string prenom, string email, string password)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Email = email;
            this.Password = password;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
    }
}

