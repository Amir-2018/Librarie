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
    public partial class Liste : Form
    {
        public Liste()
        {
            InitializeComponent();
            LivreADO lv = new LivreADO();
            List<Models2.Livre> livres = lv.Load_livres();
            BindingList<Models2.Livre> bindingLivre = new BindingList<Models2.Livre>(livres);
            livreBindingSource.DataSource = bindingLivre;
        }

        private void Liste_Load(object sender, EventArgs e)
        {

        }
    }
}
