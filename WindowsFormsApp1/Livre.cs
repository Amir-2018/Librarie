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
using Models2;

namespace WindowsFormsApp1
{
    public partial class Livre : Form
    {
        public Livre()
        {
            InitializeComponent();
            LivreADO lv = new LivreADO();
            List<Models2.Livre> livres = lv.Load_livres();
            BindingList<Models2.Livre> bindingLivre = new BindingList<Models2.Livre>(livres);
            livreBindingSource.DataSource = bindingLivre;

          
        }

        private void date_editionDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void date_editionLabel_Click(object sender, EventArgs e)
        {

        }

        private void Livre_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LivreADO lv = new LivreADO();
            Models2.Livre currentLivre = livreBindingSource.Current as Models2.Livre;

            if (currentLivre != null && lv.Add_Livre(currentLivre))
            {
                List<Models2.Livre> livres = lv.Load_livres();
                BindingList<Models2.Livre> bindingLivres = new BindingList<Models2.Livre>(livres);
                livreBindingSource.DataSource = bindingLivres;
                MessageBox.Show("Operation succeeded!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operation failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Models2.Livre currentLivre = (Models2.Livre)livreBindingSource.Current;
            LivreADO livre = new LivreADO();
            DialogResult result = MessageBox.Show("Are you sure you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                bool test = livre.delete_livre(currentLivre.Id_livre);
                if (test)
                {
                    LivreADO lv = new LivreADO();
                    List<Models2.Livre> livres = lv.Load_livres();
                    BindingList<Models2.Livre> bindingLivres = new BindingList<Models2.Livre>(livres);
                    livreBindingSource.DataSource = bindingLivres;
                    MessageBox.Show("Deleted with success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Operation of delete failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void livreBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Models2.Livre currentLivre = (Models2.Livre)livreBindingSource.Current;
            LivreADO livre = new LivreADO();
            DialogResult result = MessageBox.Show("Are you sure you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                bool test = livre.update_livre(currentLivre);
                if (test)
                {
                    LivreADO etud = new LivreADO();
                    List<Models2.Livre> livres = etud.Load_livres();
                    BindingList<Models2.Livre> bindingLivres = new BindingList<Models2.Livre>(livres);
                    livreBindingSource.DataSource = bindingLivres;
                    MessageBox.Show("Updated with success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Operation of delete failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
