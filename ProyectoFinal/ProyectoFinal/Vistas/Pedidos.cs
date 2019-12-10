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
        private ControladorDesign ctrlDesigns;
        private ControladorMaterial ctrlBases;
        private Controlador.Ventas.ControladorCliente ctrlCliente;

        private List<Modelo.Ventas.DetallePedido> listDetalle;

        private DataTable DetallePedido;

        public Pedidos()
        {
            InitializeComponent();
            ctrlBases = new ControladorMaterial();
            ctrlDesigns = new ControladorDesign();
            ctrlCliente = new Controlador.Ventas.ControladorCliente();

        }

        private void Limpiar()
        {
            txtIdPedido.EditValue = "";
            CmbCliente.EditValue = null;

            DetallePedido = new DataTable();

            DetallePedido.Columns.Add(new DataColumn("Base", typeof(int)));
            DetallePedido.Columns.Add(new DataColumn("Design", typeof(int)));
            DetallePedido.Columns.Add(new DataColumn("Precio", typeof(double)));
            DetallePedido.Columns.Add(new DataColumn("Cantidad", typeof(int)));

            GcDetallePedido.DataSource = DetallePedido;
        }

        private Modelo.Ventas.Pedido GenerarPedido()
        {
            foreach (DataRow r in DetallePedido.Rows) {
                listDetalle.Add(new Modelo.Ventas.DetallePedido()
                {
                    Base = new Material() { IdMaterial = (int)r["Base"] },
                    Design = new Design() { IdDesign = (int)r["Design"] },
                    Precio = (double)r["Precio"],
                    Cantidad = (int)r["Cantidad"]
                });
            }

            return new Modelo.Ventas.Pedido() {
                Cliente = ctrlCliente.GetById((int)CmbCliente.EditValue),
                DetallePedido = listDetalle,
                FechaPedido = DateTime.Now,
                IdPedido = 0,
                Vendedor = Session.UsuarioEnCurso
            };
        }

        public void GuardarVenta()
        {
            Modelo.Ventas.Pedido p = GenerarPedido();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            GuardarVenta();
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            Limpiar();

            CmbBase.DataSource = ctrlBases.GetBy("WHERE Tipo = " + (int)Material.TiposMateriales.Base);
            CmbDesign.DataSource = ctrlDesigns.GetAll();
            CmbCliente.Properties.DataSource = ctrlCliente.GetAll();
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            cargarInterfaz();
        }

        public void cargarInterfaz()
        {
            ControladorCliente c = new ControladorCliente();
            cmbIdCliente.Properties.DataSource = c.GetAll();

            ControladorUsuario u = new ControladorUsuario();
            cmbIdVendedor.Properties.DataSource = u.GetAll();

            ControladorMaterial m = new ControladorMaterial();
            cmbBase.Properties.DataSource = m.GetBy("WHERE tipo = " + Material.TiposMateriales.Base);
            
            ControladorDesign d = new ControladorDesign();
            cmbDiseño.Properties.DataSource = d.GetAll();
        }
    }
}
