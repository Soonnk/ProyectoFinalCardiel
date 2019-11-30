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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int id = (int)cmbNivelUsuario.EditValue;
            MessageBox.Show(id+"");
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Usuario_Load(object sender, EventArgs e)
        {

            cargarInterfaz();
        }
        public void cargarInterfaz()
        {

            cmbNivelUsuario.Properties.DataSource = Controlador.Utils.GetCatalog("Usuarios.c_NivelesUsuario");
        }

        private void cmbNivelUsuario_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
