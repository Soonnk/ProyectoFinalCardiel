using DevExpress.XtraGrid.Views.Base;
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
            ctrlContactos = new Controlador.ControladorContacto();
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
            TxtTelefono.EditValue = "";
            TxtCorreoElectronico.EditValue = "";
            TxtCalle.EditValue  = "";
            TxtNumero.EditValue = "";
            TxtColonia.EditValue = "";

            lst = new Modelo.ListaContactos
            {
                IdListaContactos = 0
            };
            GcContactos.DataSource = lst;

            CargarProveedores();
        }

        private void MostrarProveedor(DataRow row)
        {
            if (row == null) return;

            Modelo.Compras.Proveedor p = ctrlProveedores.GetById((int)row["IdProveedor"]);

            if (p == null) return;

            this.IdProveedor = p.IdProveedor;

            this.TxtIdProveedor.EditValue = p.IdProveedor;
            this.TxtNombres.EditValue = p.Nombre;
            this.TxtTelefono.EditValue = p.Telefono;
            this.TxtCorreoElectronico.EditValue = p.CorreoElectronico;
            this.TxtCalle.EditValue = p.Calle;
            this.TxtNumero.EditValue = p.Numero;
            this.TxtColonia.EditValue = p.Colonia;

            this.lst.IdListaContactos = p.Contactos.IdListaContactos;
            foreach(Modelo.Contacto c in p.Contactos)
                this.lst.Add(c);

            GcContactos.RefreshDataSource();
        }

        private Modelo.Compras.Proveedor GenerarProveedor()
        {
            Modelo.Compras.Proveedor p = new Modelo.Compras.Proveedor()
            {
                IdProveedor = this.IdProveedor,
                Nombre = (string)TxtNombres.EditValue,
                Calle = (string)TxtCalle.EditValue,
                Colonia = (string)TxtColonia.EditValue,
                Contactos = lst,
                CorreoElectronico = (string)TxtCorreoElectronico.EditValue,
                Numero = (string)TxtNumero.EditValue,
                Telefono = (string)TxtTelefono.EditValue
            };

            return p;
        }

        private void GuardarNuevo()
        {
            Modelo.Compras.Proveedor proveedor = GenerarProveedor();
            ctrlProveedores.InsertarProveedor(proveedor);
        }

        private void GuardarCambios(bool Estatus = true)
        {
            Modelo.Compras.Proveedor proveedor = GenerarProveedor();
            proveedor.Estatus = Estatus;
            ctrlProveedores.UpdateProveedor(proveedor);

            MessageBox.Show("Cambios Guardados con éxito");
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            CargarProveedores();
            Limpiar();
        }

        private void GcProveedores_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            MostrarProveedor(((ColumnView)sender).GetDataRow(e.RowHandle));
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(""+TxtIdProveedor.EditValue))
                GuardarNuevo();
            else
                GuardarCambios();

            Limpiar();
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
                if (ventanaContacto.Contacto.IdContacto != 0) ctrlContactos.UpdateContacto(ventanaContacto.Contacto);
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

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            GuardarCambios(false);
        }
    }
}
