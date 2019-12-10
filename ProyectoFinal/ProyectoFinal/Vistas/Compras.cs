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
    public partial class Compras : Form
    {
        private Modelo.Compras.Compra CurrentCompra { get; set; }

        private Controlador.Produccion.ControladorMaterial ctrlMaterial;
        private Controlador.Compras.ControladorProveedor ctrlProveedor;
        private Controlador.Compras.ControladorCompra ctrlCompra;

        private DataTable DetalleCompra;

        public Compras()
        {
            InitializeComponent();
            ctrlMaterial = new Controlador.Produccion.ControladorMaterial();
            ctrlProveedor = new Controlador.Compras.ControladorProveedor();
            ctrlCompra = new Controlador.Compras.ControladorCompra();

            this.CurrentCompra = null;

            Limpiar();
        }

        public Compras(Modelo.Compras.Compra c): this()
        {
            if (c == null) return;

            this.CurrentCompra = c;

            txtIdCompra.EditValue = c.IdCompra;
            CmbProveedor.EditValue = c.Proveedor.IdProveedor;
            DtpFechaOrden.EditValue = c.FechaOrden;
            foreach (Modelo.Compras.DetalleCompra d in c.DetalleCompras)
            {
                DataRow row = DetalleCompra.NewRow();
                row["Material"] = d.Material.IdMaterial;
                row["Cantidad"] = d.Cantidad;
                row["Precio"] = d.Costo;
                DetalleCompra.Rows.Add(row);
            }

            DtpFechaOrden.ReadOnly = true;
            CmbProveedor.ReadOnly = true;
            LciEntregar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            LciGuardar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            LciFechaRecepcion.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;

            GvCompras.OptionsBehavior.Editable = false;
        }

        public void Limpiar()
        {
            this.CurrentCompra = null;

            DtpFechaOrden.ReadOnly = false;
            DtpFechaOrden.Properties.MinValue = DateTime.Today;
            DtpFechaRecepcion.Properties.MinValue = DateTime.Today;
            CmbProveedor.ReadOnly = false;
            LciEntregar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            LciGuardar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            LciFechaRecepcion.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

            DtpFechaOrden.EditValue = DateTime.Today;
            DtpFechaRecepcion.EditValue = DateTime.Today;

            txtIdCompra.EditValue = null;
            CmbProveedor.EditValue = null;
            InitGrid();
        }

        private void InitGrid()
        {
            DetalleCompra = new DataTable();

            DetalleCompra.Columns.Add(new DataColumn("Material", typeof(int)));
            DetalleCompra.Columns.Add(new DataColumn("Cantidad", typeof(int)));
            DetalleCompra.Columns.Add(new DataColumn("Precio", typeof(double)));
            DetalleCompra.Columns.Add(new DataColumn("Importe", typeof(double), "[Cantidad]*[Precio]"));

            GcCompras.DataSource = DetalleCompra;
        }

        private Modelo.Compras.Compra GenerarCompra()
        {
            Modelo.Compras.Compra c = new Modelo.Compras.Compra()
            {
                CompradoPor = Session.UsuarioEnCurso,
                Proveedor = ctrlProveedor.GetById((int)CmbProveedor.EditValue),
                DetalleCompras = new List<Modelo.Compras.DetalleCompra>()
            };

            foreach (DataRow row in DetalleCompra.Rows)
            {
                Modelo.Compras.DetalleCompra d = new Modelo.Compras.DetalleCompra();
                d.Material = ctrlMaterial.GetById((int)row["Material"]);
                d.Cantidad = (double)(int)row["Cantidad"];
                d.Costo = (double)row["Precio"];

                c.DetalleCompras.Add(d);
            }

            return c;
        }

        private void GuardarCompra()
        {
            Modelo.Compras.Compra c = GenerarCompra();

            ctrlCompra.InsertarCompra(c);
        }

        public void CalcularTotal()
        {
            double total = 0;

            foreach (DataRow r in DetalleCompra.Rows)
                total += (double)(r["Importe"] == DBNull.Value ? 0.00 : r["Importe"]);

            TxtTotal.EditValue = total;
        }

        public void ActualizarEntrega()
        {
            if (CurrentCompra != null)
            {
                CurrentCompra.FechaRecepcion = (DateTime)DtpFechaRecepcion.EditValue;
                //Ignorar esta advertencia, solo la puse para que no se fueran a confiar y editar toda la compra
                ctrlCompra.UpdateCompra(CurrentCompra);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            GuardarCompra();
            ((Vistas.MDI)this.Parent.Parent).CargarFormulario(new Vistas.ListaDeCompras());
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            cmbMaterial.DataSource = ctrlMaterial.GetAll();
            CmbProveedor.Properties.DataSource = ctrlProveedor.GetAll();
        }

        private void GcCompras_Layout(object sender, LayoutEventArgs e)
        {
            CalcularTotal();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnEntregado_Click(object sender, EventArgs e)
        {
            ActualizarEntrega();
        }
    }
}
