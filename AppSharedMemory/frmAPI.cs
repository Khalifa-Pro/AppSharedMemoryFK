using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSharedMemory
{
    public partial class frmAPI : Form
    {
        public frmAPI()
        {
            InitializeComponent();
            service = new ServiceMetier.Service1Client();
            
        }

        ServiceMetier.Service1Client service;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmUtilisateur frmUtilisateur = new FrmUtilisateur();
            frmUtilisateur.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCategorie frmCategorie = new FrmCategorie();
            frmCategorie.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmEncadreur frmEncadreur = new frmEncadreur();
            frmEncadreur.Show();
        }
    }
}
