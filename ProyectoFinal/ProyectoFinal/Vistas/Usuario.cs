﻿using DevExpress.XtraGrid.Views.Base;
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

        //Usuario usua = new Usuario();
        //Controlador.Usuarios.ControladorUsuario controlUsu = new Controlador.Usuarios.ControladorUsuario();
        private int IdUsuario = 0;
        private int IdPersona = 0;

        Modelo.Usuarios.Usuario usu;
        Modelo.Persona per;

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
                Nombre = (string)txtNombre.EditValue,
                ApellidoPaterno = (string)txtAPaterno.EditValue,
                ApellidoMaterno = (string)txtAMaterno.EditValue,
                Telefono = (string)txtTelefono.EditValue,
                CorreoElectronico = (string)txtCorreo.EditValue,
                Calle = (string)txtCalle.EditValue,
                Numero = (string)txtNumero.EditValue,
                Colonia = (string)txtColonia.EditValue,
                Username = (string)txtUsername.EditValue,
                Password = (string)txtContrasenia.EditValue,
                Estatus = (bool)txtEstatus.EditValue,
                NivelUsuario = (Modelo.Usuarios.Usuario.NivelesUsuario)cmbNivelUsuario.EditValue,
                Departamento = (Modelo.Usuarios.Usuario.Departamentos)cmbDepartamento.EditValue,

            };

            return u;
        }

       

        private void GuardarNuevo()
        {
            Modelo.Usuarios.Usuario usuario = generarUsuario();
            ctrlUsuarios.InsertarUsuario(usuario);
        }

        private void GuardarCambios()
        {
            Modelo.Usuarios.Usuario usuario = generarUsuario();
            ctrlUsuarios.UpdateUsuario(usuario);

            MessageBox.Show("Cambios Guardados con éxito");

            limpiar();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            /*if (usu.Count < 0) return;

            ViewContacto ventanaContacto = new ViewContacto(usu[GvContactos.FocusedRowHandle]);
            var res = ventanaContacto.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                usu[GvContactos.FocusedRowHandle] = ventanaContacto.Contacto;
                if (ventanaContacto.Contacto.IdContacto != 0) ctrlUsuarios.UpdateUsuario(ventanaContacto.Contacto);
                GcContactos.RefreshDataSource();
            }*/
        }

        private void gridView3_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            MostrarUsuario(((ColumnView)sender).GetDataRow(e.RowHandle));
        }

        private void MostrarUsuario(DataRow row)
        {
            if (row == null) return;

            Modelo.Usuarios.Usuario u = ctrlUsuarios.GetById((int)row["IdUsuario"]);

            if (u == null) return;

            this.IdUsuario = u.IdUsuario;

            this.txtIdUsuario.EditValue = u.IdUsuario;
            this.txtNombre.EditValue = u.Nombre;
            this.txtAPaterno.EditValue = u.ApellidoPaterno;
            this.txtAMaterno.EditValue = u.ApellidoMaterno;
            this.txtTelefono.EditValue = u.Telefono;
            this.txtCorreo.EditValue = u.CorreoElectronico;
            this.txtCalle.EditValue = u.Calle;
            this.txtNumero.EditValue = u.Numero;
            this.txtColonia.EditValue = u.Colonia;
            this.txtUsername.EditValue = u.Username;
            this.txtContrasenia.EditValue = u.Password;
            this.txtEstatus.EditValue = u.Estatus;
            this.cmbNivelUsuario.EditValue = u.NivelUsuario;
            this.cmbDepartamento.EditValue = u.Departamento;
            

            gcUsuarios.RefreshDataSource();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            /*if (lst.Count < 0) return;

            var obj = lst[GvContactos.FocusedRowHandle];

            if (lst.IdListaContactos != 0)
            {
                ctrlContactos.DropContacto(obj, lst.IdListaContactos);
            }

            lst.Remove(obj);
            GcContactos.RefreshDataSource();*/
        }
    }
}
