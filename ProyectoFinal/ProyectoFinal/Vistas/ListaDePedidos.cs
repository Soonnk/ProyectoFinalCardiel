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
    public partial class ListaDePedidos : Form
    {
        private Controlador.Ventas.ControladorPedido ctrl;

        public ListaDePedidos()
        {
            InitializeComponent();
            ctrl = new Controlador.Ventas.ControladorPedido();
        }

        private void MostrarDetallePedido(DataRow row)
        {
            Modelo.Ventas.Pedido p;

            p = ctrl.getById((int)row["IdPedido"]);

            ((Vistas.MDI)this.Parent.Parent).CargarFormulario(new Vistas.Pedidos(p));
        }

        private void CargarPedidos()
        {
            GcPedido.DataSource = ctrl.GetAll();
        }

        private void ListaDePedidos_Load(object sender, EventArgs e)
        {
            CargarPedidos();
        }


        private void GvPedido_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow row = GvPedido.GetDataRow(e.RowHandle);

            MostrarDetallePedido(row);
        }

        //private void GcPedidos_Click(object sender, EventArgs e)
        //{

        //}

        private void GcPedido_Click(object sender, EventArgs e)
        {
        }
    }
}
