using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Vistas
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
            mdiPrincipal.MdiParent = this;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Form ventanaUsuario = new Vistas.Usuario();
            ventanaUsuario.MdiParent = this;
            ventanaUsuario.Show();
        }

        private void MDI_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flyoutPanelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
