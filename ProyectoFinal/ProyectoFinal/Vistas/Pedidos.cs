using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.Controlador.Ventas;
using ProyectoFinal.Controlador.Usuarios;
using ProyectoFinal.Controlador.Produccion;
using ProyectoFinal.Modelo.Produccion;

using ProyectoFinal.Controlador.Produccion;
using ProyectoFinal.Modelo.Produccion;

namespace ProyectoFinal.Vistas
{
    public partial class Pedidos : Form
    {
        private Modelo.Ventas.Pedido CurrentPedido { get; set; }
        private Controlador.Ventas.ControladorPedido ctrlPedido;
        private ControladorDesign ctrlDesigns;
        private ControladorMaterial ctrlBases;
        private Controlador.Ventas.ControladorCliente ctrlCliente;
        
        private DataTable DetallePedido;

        public Pedidos()
        {
            InitializeComponent();
            ctrlPedido = new Controlador.Ventas.ControladorPedido();
            ctrlBases = new Controlador.Produccion.ControladorMaterial();
            ctrlDesigns = new Controlador.Produccion.ControladorDesign();
            ctrlCliente = new Controlador.Ventas.ControladorCliente();

            this.CurrentPedido = null;

            Limpiar();
        }

        public Pedidos(Modelo.Ventas.Pedido p) : this()
        {
            if (p == null) return;

            this.CurrentPedido = p;

            txtIdPedido.EditValue = p.IdPedido;
            cmbIdCliente.EditValue = p.Cliente.IdCliente;

            dtpFecha.EditValue = p.FechaPedido;
            foreach (Modelo.Ventas.DetallePedido d in p.DetallePedido)
            {
                DataRow row = DetallePedido.NewRow();
                row["Material"] = d.Base.IdMaterial;
                row["Design"] = d.Design.IdDesign;
                row["Cantidad"] = d.Cantidad;
                row["Precio"] = d.Precio;
                DetallePedido.Rows.Add(row);
            }

            GcDetallePedido.DataSource = DetallePedido;

            dtpFecha.ReadOnly = true;
            cmbIdCliente.ReadOnly = true;
            LciCliente.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            
            GvDetallePedido.OptionsBehavior.Editable = false;
        }

        private void Limpiar()
        {
            this.CurrentPedido = null;
            txtIdPedido.EditValue = null;
            cmbIdCliente.EditValue = null;
            cmbIdCliente.ReadOnly = false;
            dtpFecha.ReadOnly = false;
            dtpFecha.Properties.MinValue = DateTime.Today;
            LciCliente.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;

            dtpFecha.EditValue = DateTime.Today;
            InitGrid();
        }

        private void InitGrid()
        {
            DetallePedido = new DataTable();

            DetallePedido.Columns.Add(new DataColumn("Material", typeof(int)));
            DetallePedido.Columns.Add(new DataColumn("Design", typeof(int)));
            DetallePedido.Columns.Add(new DataColumn("Cantidad", typeof(int)));
            DetallePedido.Columns.Add(new DataColumn("Precio", typeof(double)));

            GcDetallePedido.DataSource = DetallePedido;
        }

        private Modelo.Ventas.Pedido GenerarPedido()
        {
            Modelo.Ventas.Pedido p = new Modelo.Ventas.Pedido()
            {
                Cliente = ctrlCliente.GetById((int)cmbIdCliente.EditValue),
                Vendedor = Session.UsuarioEnCurso,
                DetallePedido = new List<Modelo.Ventas.DetallePedido>(),
                FechaPedido = DateTime.Today
            };

            foreach (DataRow row in DetallePedido.Rows)
            {
                Modelo.Ventas.DetallePedido d = new Modelo.Ventas.DetallePedido();
                d.Base = ctrlBases.GetById((int)row["Material"]);
                d.Design = ctrlDesigns.GetById((int)row["Design"]);
                d.Cantidad = (double)(int)row["Cantidad"];
                d.Precio = (double)row["Precio"];

                p.DetallePedido.Add(d);
            }

            return p;
        }

        public void GuardarVenta()
        {
            Modelo.Ventas.Pedido p = GenerarPedido();
            ctrlPedido.insert(p);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            GuardarVenta();
            ((Vistas.MDI)this.Parent.Parent).CargarFormulario(new Vistas.ListaDePedidos());
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            cargarInterfaz();

            CmbBase.DataSource = ctrlBases.GetBy("WHERE Tipo = " + (int)Material.TiposMateriales.Base);
            CmbDesign.DataSource = ctrlDesigns.GetAll();
            cmbIdCliente.Properties.DataSource = ctrlCliente.GetAll();
        }

        public void cargarInterfaz()
        {
            ControladorCliente c = new ControladorCliente();
            cmbIdCliente.Properties.DataSource = c.GetAll();

            //ControladorUsuario u = new ControladorUsuario();
            //cmbIdVendedor.Properties.DataSource = u.GetAll();

            //ControladorMaterial m = new ControladorMaterial();
            //cmbBase.Properties.DataSource = m.GetBy("WHERE tipo = " + Material.TiposMateriales.Base);
            
            //ControladorDesign d = new ControladorDesign();
            //cmbDiseño.Properties.DataSource = d.GetAll();
        }


        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
