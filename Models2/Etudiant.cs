using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models2
{
    public class Etudiant
    {   
    
         private string nom; 
         private string  prenom ;
         private string email; 
         private int telephone ;
         private string filiere ;
         private string groupe;
         private int code_inscription;
         private int id_etudiant;
        // Constructeur par défaut


        public Etudiant( string nom, string prenom, string email, int telephone, string filiere ,int code_inscription, int id_etudiant, string groupe)
        {
            
            this.Nom = nom;
            this.Prenom = prenom;
            this.Email = email;
            this.Telephone = telephone;
            this.Filiere = filiere;
            this.Code_inscription = code_inscription;
            this.Id_etudiant = id_etudiant;
            this.Groupe = groupe;
            
        }

        
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Email { get => email; set => email = value; }
        public int Telephone { get => telephone; set => telephone = value; }
        public string Filiere { get => filiere; set => filiere = value; }
        public int Code_inscription { get => code_inscription; set => code_inscription = value; }
        public int Id_etudiant { get => id_etudiant; set => id_etudiant = value; }

        public string Groupe { get =>groupe; set => groupe = value; }

    }
}
