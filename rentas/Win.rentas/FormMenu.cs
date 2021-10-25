using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.rentas
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void ingresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            var formLogin = new Formlogin();
            formLogin.ShowDialog();
        }

        private void vinilosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formvinilos = new Vinilos();
            formvinilos.MdiParent = this;
            formvinilos.Show();
        }

        private void camisasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formclientes = new Formclientes();
            formclientes.MdiParent = this;
            formclientes.Show(); 
        }

        private void accesoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formacce = new Formacce();
            formacce.MdiParent = this;
            formacce.Show();
        }

        private void coleccionablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void conciertosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            login();
    }

        private void apartadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formapart = new Formapart();
            formapart.MdiParent = this;
            formapart.Show();
        }

        private void deliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formdel = new Formdel();
            formdel.MdiParent = this;
            formdel.Show();
        }
    }
}
