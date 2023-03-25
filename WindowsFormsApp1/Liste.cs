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
    }
}
