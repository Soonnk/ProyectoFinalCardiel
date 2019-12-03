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
        //private Controlador.Usuarios.ControladorUsuario ctrlUsuarios;
        //private int IdUsuario = 0;
        //Modelo.Usuarios.Usuario usu;

        public Usuario()
        {
            InitializeComponent();
            //ctrlUsuarios = new Controlador.Usuarios.ControladorUsuario();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int idU = (int)cmbNivelUsuario.EditValue;
            int idD = (int)cmbDepartamento.EditValue;
            MessageBox.Show(idU+""+idD+"");
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
            cmbDepartamento.Properties.DataSource = Controlador.Utils.GetCatalog("Usuarios.Departamentos");
        }

        private void cmbNivelUsuario_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            // Btn Limpiar
            //limpiar();
            
        }

        private void cmbDepartamento_EditValueChanged(object sender, EventArgs e)
        {

        }

        /*public void limpiar()
        {
            txtIdUsuario.ReadOnly = true;
            txtNombre.EditValue = "";
            txtAPaterno.EditValue = "";
            txtAMaterno.EditValue = "";
            txtTelefono.EditValue = "";
            txtCorreo.EditValue = "";
            txtCalle.EditValue = "";
            txtNumero.EditValue = "";
            txtColonia.EditValue = "";
            txtUsername.EditValue = "";
            txtContrasenia.EditValue = "";
            cmbNivelUsuario.EditValue = "";
            cmbDepartamento.EditValue = "";

            usu = new Modelo.Usuarios.Usuario();

            gcUsuarios.DataSource = usu;
        }
        public void cargarUsuarios()
        {
            gcUsuarios.DataSource = ctrlUsuarios.GetAll();
        }*/
    }
}
