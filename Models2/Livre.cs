using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models2
{
    public class Livre
    {
        private int id_livre; 
        private string titre;
        private string auteur;
        private int nbpages;
        private int nbchapitre;
        private DateTime date_edition;
        private float prix;
        private string category; 

        public Livre(int id_livre, string titre, string auteur, int nbpages, int nbchapitre, DateTime date_edition, float prix,string category)
        {
            this.id_livre = id_livre;
            this.titre = titre;
            this.auteur = auteur;
            this.nbpages = nbpages;
            this.nbchapitre = nbchapitre;
            this.date_edition = date_edition;
            this.prix = prix;
            this.category = category;
        }
        public Livre() { }
        public int Id_livre { get => id_livre; set => id_livre = value; }
        public string Titre { get => titre; set => titre = value; }
        public string Auteur { get => auteur; set => auteur = value; }
        public int Nbpages { get => nbpages; set => nbpages = value; }
        public int Nbchapitre { get => nbchapitre; set => nbchapitre = value; }
        public DateTime Date_edition { get => date_edition; set => date_edition = value; }
        public float Prix { get => prix; set => prix = value; }
        public string Category { get => category; set => category = value; }
    }
}
