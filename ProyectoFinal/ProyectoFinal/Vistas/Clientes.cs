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
    public partial class Clientes : Form
    {
        private Controlador.Ventas.ControladorCliente ctrlClientes;
        private Controlador.ControladorContacto ctrlContactos;

        private int IdCliente = 0;

        Modelo.ListaContactos lst;

        public Clientes()
        {
            InitializeComponent();

            try
            {
                CmbRegimen.Properties.DataSource = Controlador.Utils.GetCatalog("[Ventas].[c_RegimenesFiscales]");
                ctrlClientes = new Controlador.Ventas.ControladorCliente();
                ctrlContactos = new Controlador.ControladorContacto();
            }
            catch (NullReferenceException npe) when (Session.UsuarioEnCurso == null)
            {
                MessageBox.Show("No se inició sesión correctamente");
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar modulo de Clientes");
                this.Close();
            }
        }

        public void CargarClientes()
        {
            GcClientes.DataSource = ctrlClientes.GetAll();
        }

        public void Limpiar()
        {
            TxtIdCliente.ReadOnly = true; 

            TxtIdCliente.EditValue = "";
            TxtNombre.EditValue = "";
            txtTelefono.EditValue = "";
            txtCorreo.EditValue = "";
            txtCalle.EditValue = "";
            txtNumero.EditValue = "";
            txtColonia.EditValue = "";
            txtRfc.EditValue = "";
            CmbRegimen.EditValue = null;

            lst = new Modelo.ListaContactos()
            {
                IdListaContactos = 0
            };
            GcContactos.DataSource = lst;

            CargarClientes();
        }

        private void MostrarCliente(DataRow row)
        {
            if (row == null) return;

            Modelo.Ventas.Cliente c = ctrlClientes.GetById((int)row["IdCliente"]);

            if (c == null) return;

            this.IdCliente = c.IdCliente;

            this.TxtIdCliente.EditValue = c.IdCliente;
            this.TxtNombre.EditValue = c.Nombre;
            this.txtTelefono.EditValue = c.Telefono;
            this.txtCorreo.EditValue = c.CorreoElectronico;
            this.txtCalle.EditValue = c.Calle;
            this.txtNumero.EditValue = c.Numero;
            this.txtColonia.EditValue = c.Colonia;
            this.txtRfc.EditValue = c.RFC;
            this.CmbRegimen.EditValue = (int) c.RegimenFiscal;

            this.lst.IdListaContactos = c.ListaContactos.IdListaContactos;
            foreach (Modelo.Contacto contacto in c.ListaContactos)
                this.lst.Add(contacto);

            GcContactos.RefreshDataSource();
        }

        private Modelo.Ventas.Cliente GenerarCliente()
        {
            Modelo.Ventas.Cliente c = new Modelo.Ventas.Cliente();
            c. IdCliente = this.IdCliente;
            c.Nombre = (string)TxtNombre.EditValue;
            c.Calle = (string)txtCalle.EditValue;
            c.Colonia = (string)txtColonia.EditValue;
            c.CorreoElectronico = (string)txtCorreo.EditValue;
            c.Estatus = true;
            c.ListaContactos = lst;
            c.Numero = (string)txtNumero.EditValue;
            c.RegimenFiscal = (Modelo.Ventas.Cliente.RegimenesFiscales)CmbRegimen.EditValue;
            c.RFC = (string)txtRfc.EditValue;
            c.Telefono = (string)txtTelefono.EditValue;

            return c;
        }

        private void GuardarNuevo()
        {
            Modelo.Ventas.Cliente cliente = GenerarCliente();
            ctrlClientes.InsertarCliente(cliente);
        }

        private void GuardarCambios(bool Estatus = true)
        {
            Modelo.Ventas.Cliente cliente = GenerarCliente();
            cliente.Estatus = Estatus;
            ctrlClientes.UpdateCliente(cliente);

            MessageBox.Show("Cambios guardados con éxito");
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty("" + TxtIdCliente.EditValue))
                GuardarNuevo();
            else
                GuardarCambios();

            Limpiar();
        }

        

        private void Clientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
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
            CargarClientes();
        }

        private void CmbRegimen_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void GvClientes_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            MostrarCliente(((ColumnView)sender).GetDataRow(e.RowHandle));
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            GuardarCambios(false);
        }
    }
}
