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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadForm(new Description());

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupePropComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupePropLabel1_Click(object sender, EventArgs e)
        {

        }
        public void loadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Load client page 
            loadForm(new Etudiant());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadForm(new Livre());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadForm(new Commande());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadForm(new Statistiques());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadForm(new Liste());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            loadForm(new Reurn());
        }
    }
}
