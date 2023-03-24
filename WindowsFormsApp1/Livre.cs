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
    }
}
