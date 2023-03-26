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
    public partial class Liste : Form
    {
        public Liste()
        {
            InitializeComponent();
            EmpruntADO em = new EmpruntADO();
            List<Models2.Emprunt> emprunts = em.Load_emprunts();
            BindingList<Models2.Emprunt> bindingEmprunt = new BindingList<Models2.Emprunt>(emprunts);
            empruntBindingSource.DataSource = bindingEmprunt;
        }

        private void Liste_Load(object sender, EventArgs e)
        {

        }

        private void empruntDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Models2.Emprunt currentEmprunt = (Models2.Emprunt)empruntBindingSource.Current;
            EmpruntADO em = new EmpruntADO();
            DialogResult result = MessageBox.Show("Are you sure you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                bool test = em.delete_emprunt(currentEmprunt.Id_emprunt);
                if (test)
                {
                    EmpruntADO ems = new EmpruntADO();
                    List<Models2.Emprunt> emprunts = ems.Load_emprunts();
                    BindingList<Models2.Emprunt> bindingEmprunt = new BindingList<Models2.Emprunt>(emprunts);
                    empruntBindingSource.DataSource = bindingEmprunt;
                    MessageBox.Show("Deleted with success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Operation of delete failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
