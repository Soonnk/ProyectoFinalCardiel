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
        private Controlador.Usuarios.ControladorUsuario ctrlUsuarios;
        // private int IdUsuario = 0;
        Modelo.Usuarios.Usuario usu;
        Modelo.Persona per;
        //Usuario usua = new Usuario();
        //Controlador.Usuarios.ControladorUsuario controlUsu = new Controlador.Usuarios.ControladorUsuario();
        private int IdUsuario = 0;
        private int IdPersona = 0;



        public Usuario()
        {
            InitializeComponent();
            ctrlUsuarios = new Controlador.Usuarios.ControladorUsuario();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int idU = (int)cmbNivelUsuario.EditValue;
            int idD = (int)cmbDepartamento.EditValue;
            //MessageBox.Show(idU+""+idD+"");
            if (String.IsNullOrEmpty("" + txtIdUsuario.EditValue))
                GuardarNuevo();
            else
                GuardarCambios();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Usuario_Load(object sender, EventArgs e)
        {

            cargarInterfaz();
            limpiar();
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
            limpiar();
            
        }

        private void cmbDepartamento_EditValueChanged(object sender, EventArgs e)
        {

        }

        public void limpiar()
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
            txtEstatus.EditValue = "";
            cmbNivelUsuario.EditValue = "";
            cmbDepartamento.EditValue = "";

            usu = new Modelo.Usuarios.Usuario();

            gcUsuarios.DataSource = usu;
        }
        public void cargarUsuarios()
        {
            gcUsuarios.DataSource = ctrlUsuarios.GetAll();
        }


        /*private void mostrarUsuario(DataRow row)
        {
            if (row == null) return;

            Modelo.Usuarios.Usuario u = ctrlUsuarios.GetById((int)row["IdUsuario"]);
            Modelo.Persona p = ctrlUsuarios.GetById((int)row["IdPersona"]);

            if (p == null) return;

            if (u == null) return;
            
            
            
            this.IdProveedor = u.IdProveedor;

            this.TxtIdProveedor.EditValue = u.IdProveedor;
            this.TxtNombres.EditValue = u.Nombre;
            this.TxtTelefono.EditValue = u.Telefono;
            this.TxtCorreoElectronico.EditValue = u.CorreoElectronico;
            this.TxtCalle.EditValue = u.Calle;
            this.TxtNumero.EditValue = u.Numero;
            this.TxtColonia.EditValue = u.Colonia;
            foreach (Modelo.Contacto c in u.Contactos)
                this.lst.Add(c);

            GcContactos.RefreshDataSource();

            this.IdUsuario = u.IdUsuario;

        }*/

        private Modelo.Usuarios.Usuario generarUsuario()
        {
            Modelo.Usuarios.Usuario u = new Modelo.Usuarios.Usuario()
            {
                IdUsuario = IdUsuario,
                IdPersona = IdPersona,
                Username = (string)txtUsername.EditValue,
                Password = (string)txtContrasenia.EditValue,
                Estatus = (string)txtEstatus.EditValue,
                NivelUsuario = (int)cmbNivelUsuario.EditValue,
                Departamento = (int)cmbDepartamento.EditValue,

            };

            return u;
        }

        private Modelo.Persona generarPersona()
        {
            Modelo.Persona p = new Modelo.Persona()
            {
                
                IdPersona = IdPersona,
                Nombre = (string)txtNombre.EditValue,
                ApellidoPaterno = (string)txtAPaterno.EditValue,
                ApellidoMaterno = (string)txtAMaterno.EditValue,
                Telefono = (string)txtTelefono.EditValue,
                CorreoElectronico = (string)txtCorreo.EditValue,
                Calle = (string)txtCalle.EditValue,
                Numero = (string)txtNumero.EditValue,
                Colonia = (string)txtColonia.EditValue

            };

            return p;
        }

        private void GuardarNuevo()
        {
            Modelo.Persona persona = generarPersona();
            Modelo.Usuarios.Usuario usuario = generarUsuario();
            ctrlUsuarios.InsertarUsuario(persona, usuario);
        }

        private void GuardarCambios()
        {
            Modelo.Persona persona = generarPersona();
            Modelo.Usuarios.Usuario usuario = generarUsuario();
            ctrlUsuarios.UpdateProveedor(persona, usuario);

            MessageBox.Show("Cambios Guardados con éxito");

            limpiar();
        }

        
    }
}
