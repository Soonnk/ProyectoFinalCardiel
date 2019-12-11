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
    public partial class ListaDeCompras : Form
    {
        private Controlador.Compras.ControladorCompra ctrl;

        public ListaDeCompras()
        {
            InitializeComponent();
            ctrl = new Controlador.Compras.ControladorCompra();
        }

        private void MostrarDetalleCompra(DataRow row)
        {
            Modelo.Compras.Compra c;

            c = ctrl.GetById((int)row["IdCompra"]);

            ((Vistas.MDI)this.Parent.Parent).CargarFormulario(new Vistas.Compras(c));
        }

        public void CargarCompras()
        {
            GcCompras.DataSource = ctrl.GetAll();
        }

        private void ListaDeCompras_Load(object sender, EventArgs e)
        {
            CargarCompras();
        }

        private void GvCompras_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

            DataRow row = GvCompras.GetDataRow(e.RowHandle);

            MostrarDetalleCompra(row);
        }

        private void GcCompras_Click(object sender, EventArgs e)
        {

        }
    }
}
