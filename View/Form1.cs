using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Controller; 
namespace View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*Connexion cn = new Connexion();
            label1.Text = cn.Connecter();*/
            
            

        }
        public void loadform(Object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0); 
            Form f = Form as Form;
            f.TopLevel = false; 
            f.Dock= DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

     

        private void Label1_Click(object sender, EventArgs e)
        {
         

        }

        

      

      

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new Client());
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
   
}

