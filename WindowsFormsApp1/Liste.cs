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
using System.Diagnostics;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

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
        private void btnGeneratePDF_Click()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = "Emprunts.pdf";
            string path = Path.Combine(desktopPath, fileName);

            try
            {
                PdfDocument document = new PdfDocument();
                PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);

                // Add a title to the table
                XFont fontTitle = new XFont("Verdana", 16, XFontStyle.Bold);
                gfx.DrawString("Liste des Emprunts", fontTitle, XBrushes.Black, new XRect(0, 40, page.Width, fontTitle.Height), XStringFormats.Center);

                // Define the table border
                XPen pen = new XPen(XColors.Black, 1);

                XFont fontTable = new XFont("Verdana", 14, XFontStyle.Regular);
                int currentY = 100;

                // Draw the table header
                gfx.DrawString("ID Emprunt", fontTable, XBrushes.Black, new XRect(0, currentY, page.Width / 4, fontTable.Height), XStringFormats.TopLeft);
                gfx.DrawString("ID Etudiant", fontTable, XBrushes.Black, new XRect(page.Width / 4, currentY, page.Width / 4, fontTable.Height), XStringFormats.TopLeft);
                gfx.DrawString("Date Emprunt", fontTable, XBrushes.Black, new XRect(page.Width / 2, currentY, page.Width / 4, fontTable.Height), XStringFormats.TopLeft);
                gfx.DrawString("Date Retour", fontTable, XBrushes.Black, new XRect((page.Width / 4) * 3, currentY, page.Width / 4, fontTable.Height), XStringFormats.TopLeft);
                currentY += (int)fontTable.Height;

                // Draw the table border
                gfx.DrawRectangle(pen, new XRect(0, currentY, page.Width, fontTable.Height));

                // Draw the table data
                foreach (var item in empruntBindingSource.List)
                {
                    var emprunt = (Emprunt)item;
                    gfx.DrawString(emprunt.Id_emprunt.ToString(), fontTable, XBrushes.Black, new XRect(0, currentY, page.Width / 4, fontTable.Height), XStringFormats.TopLeft);
                    gfx.DrawString(emprunt.Id_etudiant.ToString(), fontTable, XBrushes.Black, new XRect(page.Width / 4, currentY, page.Width / 4, fontTable.Height), XStringFormats.TopLeft);
                    gfx.DrawString(emprunt.Date_emprunt.ToString(), fontTable, XBrushes.Black, new XRect(page.Width / 2, currentY, page.Width / 4, fontTable.Height), XStringFormats.TopLeft);
                    gfx.DrawString(emprunt.Date_retour.ToString(), fontTable, XBrushes.Black, new XRect((page.Width / 4) * 3, currentY, page.Width / 4, fontTable.Height), XStringFormats.TopLeft);
                    currentY += (int)fontTable.Height;

                    // Draw the table border for each row
                    gfx.DrawRectangle(pen, new XRect(0, currentY, page.Width, fontTable.Height));
                }

                document.Save(path);

                Process.Start(path);

                MessageBox.Show("File downloaded successfully to desktop.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while downloading the file: {ex.Message}");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            btnGeneratePDF_Click();



        }
    }
}
