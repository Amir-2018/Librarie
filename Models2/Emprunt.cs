using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models2
{
    public class Emprunt
    {
        private int id_emprunt;
        private int id_etudiant;
        private int  id_livre;
        private DateTime date_emprunt;
        private DateTime date_retour;

        public Emprunt(int id_emprunt, int id_etudiant, int id_livre, DateTime date_emprunt, DateTime date_retour)
        {

            this.Id_emprunt = id_emprunt;
            this.Id_etudiant = id_etudiant; 
            this.Id_livre = id_livre;
            this.Date_emprunt = date_emprunt;
            this.Date_retour = date_retour;
        }

        public Emprunt() { }    
        public int Id_emprunt { get => id_emprunt; set => id_emprunt = value; }

        public DateTime Date_emprunt { get => date_emprunt; set => date_emprunt = value; }
        public DateTime Date_retour { get => date_retour; set => date_retour = value; }
        public int Id_etudiant { get => id_etudiant; set => id_etudiant = value; }
        public int Id_livre { get => id_livre; set => id_livre = value; }
    }
}
