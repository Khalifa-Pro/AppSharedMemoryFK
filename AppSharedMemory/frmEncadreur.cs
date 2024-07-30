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

    public partial class frmEncadreur : Form
    {
        public frmEncadreur()
        {
            InitializeComponent();
            service = new ServiceMetier.Service1Client();
        }

        ServiceMetier.Service1Client service;
        private void frmEncadreur_Load(object sender, EventArgs e)
        {
            
        }
    }
}
