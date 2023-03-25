using Controllers2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Commande : Form
    {
        public Commande()
        {
            InitializeComponent();
            LivreADO lv = new LivreADO();
            List<Models2.Livre> livres = lv.Load_livres();
            BindingList<Models2.Livre> bindingLivre = new BindingList<Models2.Livre>(livres);
            livreBindingSource.DataSource = bindingLivre;

            EtudiantADO etud = new EtudiantADO();
            List<Models2.Etudiant> etudiants = etud.Load_etudiants();
            BindingList<Models2.Etudiant> bindingEtudiants = new BindingList<Models2.Etudiant>(etudiants);
            etudiantBindingSource.DataSource = bindingEtudiants;

        }

        private void Commande_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomRecherche = textBox1.Text;
            foreach (var item in etudiantBindingSource.List)
            {
                // Convertir l'élément actuel en un objet de type Etudiant
                Models2.Etudiant etudiant = (Models2.Etudiant)item;
               ;

                // Vérifiez si le nom de l'étudiant correspond au nom recherché
                if (etudiant.Code_inscription == int.Parse(nomRecherche))
                {
                    etudiantBindingSource.Position = etudiantBindingSource.IndexOf(item);
                    break;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nomRecherche = textBox2.Text;
            foreach (var item in livreBindingSource.List)
            {
                // Convertir l'élément actuel en un objet de type Etudiant
                Models2.Livre livre = (Models2.Livre)item;
                ;

                // Vérifiez si le nom de l'étudiant correspond au nom recherché
                if (livre.Titre == nomRecherche)
                {
                    livreBindingSource.Position = livreBindingSource.IndexOf(item);
                    break;
                }
            }
        }
    }
}
