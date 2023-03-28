using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers2;
using Models2; 

namespace WindowsFormsApp1
{
    public partial class Reurn : Form
    {
        public Reurn()
        {
            InitializeComponent();
        }

        private void Reurn_Load(object sender, EventArgs e)
        {
            // Call the Load_livres method to retrieve the list of books with a return date equal to today's date
            LivreADO lv = new LivreADO(); 
            List<Models2.Emprunt> livres = lv.Return_livres();

            // Bind the list of books to the DataGridView control
            dataGridView1.DataSource = livres;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
