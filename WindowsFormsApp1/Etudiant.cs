using Models2;
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

namespace WindowsFormsApp1
{
    public partial class Etudiant : Form
    {
        public Etudiant()
        {
            InitializeComponent();
            EtudiantADO etud = new EtudiantADO();
            List<Models2.Etudiant> etudiants = etud.Load_etudiants();
            BindingList<Models2.Etudiant> bindingEtudiants = new BindingList<Models2.Etudiant>(etudiants);
            etudiantBindingSource.DataSource = bindingEtudiants;


        }

        private void Client_Load(object sender, EventArgs e)
        {
            
           
            //etudiantBindingSource.AddNew(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Définition de AllowNew à true
            etudiantBindingSource.AllowNew = true;
            etudiantBindingSource.AddNew(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EtudiantADO etud = new EtudiantADO();
            Models2.Etudiant currentEtudiant = etudiantBindingSource.Current as Models2.Etudiant;

            if (currentEtudiant != null && etud.Add_Etudiant(currentEtudiant))
            {
                List<Models2.Etudiant> etudiants = etud.Load_etudiants();
                BindingList<Models2.Etudiant> bindingEtudiants = new BindingList<Models2.Etudiant>(etudiants);
                etudiantBindingSource.DataSource = bindingEtudiants;
                MessageBox.Show("Operation succeeded!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operation failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Models2.Etudiant currentEtudiant = (Models2.Etudiant)etudiantBindingSource.Current;
            EtudiantADO etudiant = new EtudiantADO();
            DialogResult result = MessageBox.Show("Are you sure you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                bool test = etudiant.delete_etudiant(currentEtudiant.Id_etudiant);
                if (test)
                {
                    EtudiantADO etud = new EtudiantADO();
                    List<Models2.Etudiant> etudiants = etud.Load_etudiants();
                    BindingList<Models2.Etudiant> bindingEtudiants = new BindingList<Models2.Etudiant>(etudiants);
                    etudiantBindingSource.DataSource = bindingEtudiants;
                    MessageBox.Show("Deleted with success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Operation of delete failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
  

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Models2.Etudiant currentEtudiant = (Models2.Etudiant)etudiantBindingSource.Current;
            EtudiantADO etudiant = new EtudiantADO();
            DialogResult result = MessageBox.Show("Are you sure you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                bool test = etudiant.update_etudiant(currentEtudiant);
                if (test)
                {
                    EtudiantADO etud = new EtudiantADO();
                    List<Models2.Etudiant> etudiants = etud.Load_etudiants();
                    BindingList<Models2.Etudiant> bindingEtudiants = new BindingList<Models2.Etudiant>(etudiants);
                    etudiantBindingSource.DataSource = bindingEtudiants;
                    MessageBox.Show("Updated with success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Operation of delete failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void code_inscriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void code_inscriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
