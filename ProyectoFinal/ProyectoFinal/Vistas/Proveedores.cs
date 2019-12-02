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
    public partial class Proveedores : Form
    {
        private Controlador.Compras.ControladorProveedor ctrlProveedores;
        private Controlador.ControladorContacto ctrlContactos;

        private int IdProveedor = 0;

        Modelo.ListaContactos lst;

        public Proveedores()
        {
            InitializeComponent();
            ctrlProveedores = new Controlador.Compras.ControladorProveedor();
        }

        public void CargarProveedores()
        {
            GcProveedores.DataSource = ctrlProveedores.GetAll();
        }

        public void Limpiar()
        {
            TxtIdProveedor.ReadOnly = true;

            TxtIdProveedor.EditValue = "";
            TxtNombres.EditValue = "";
            TxtApellidoMaterno.EditValue = "";
            TxtApellidoPaterno.EditValue = "";
            TxtTelefono.EditValue = "";
            TxtCorreoElectronico.EditValue = "";
            TxtCalle.EditValue  = "";
            TxtNumero.EditValue = "";
            TxtColonia.EditValue = "";

            lst = new Modelo.ListaContactos();

            GcContactos.DataSource = lst;
        }

        private Modelo.Compras.Proveedor GenerarProveedor()
        {
            Modelo.Compras.Proveedor p = new Modelo.Compras.Proveedor()
            {
                IdProveedor = IdProveedor,
                Nombre = (string)TxtNombres.EditValue,
                Calle = (string)TxtCalle.EditValue,
                Colonia = (string)TxtColonia.EditValue,
                Contactos = lst,
                CorreoElectronico = (string)TxtCorreoElectronico.EditValue,
                Numero = (string)TxtNumero.EditValue,
                Telefono = (string)TxtNumero.EditValue
            };

            return p;
        }

        private void GuardarNuevo()
        {

        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            CargarProveedores();
            Limpiar();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            GuardarNuevo();
        }

        private void BtnNuevoContacto_Click(object sender, EventArgs e)
        {
            ViewContacto ventanaContacto = new ViewContacto();
            var res = ventanaContacto.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                lst.Add(ventanaContacto.Contacto);
                GcContactos.RefreshDataSource();
            }
        }

        private void BtnEditarContacto_Click(object sender, EventArgs e)
        {
            if (lst.Count < 0) return;

            ViewContacto ventanaContacto = new ViewContacto(lst[GvContactos.FocusedRowHandle]);
            var res = ventanaContacto.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                lst[GvContactos.FocusedRowHandle] = ventanaContacto.Contacto;
                GcContactos.RefreshDataSource();
            }
        }

        private void BtnEliminarContacto_Click(object sender, EventArgs e)
        {
            if (lst.Count < 0) return;

            var obj = lst[GvContactos.FocusedRowHandle];

            if (lst.IdListaContactos != 0)
            {
                ctrlContactos.DropContacto(obj, lst.IdListaContactos);
            }

            lst.Remove(obj);
            GcContactos.RefreshDataSource();
        }
    }
}
