using System;
using System.Collections.Generic;
using System.Text;

namespace Models2
{
    public class Admin
    {
        private int id_admin;
        private string nom;
        private string prenom;
        private string email;
        private string password;

        public Admin(int id_admin, string nom, string prenom, string email, string password)
        {
            this.Id_admin = id_admin;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Email = email;
            this.Password = password;
        }
        public Admin(){}

        public int Id_admin { get => id_admin; set => id_admin = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
    }
}
