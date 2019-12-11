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
    public partial class ViewReporte : Form
    {
        public ViewReporte()
        {
            InitializeComponent();
        }

        private void ViewReporte_Load(object sender, EventArgs e)
        {
            GcReporte.DataSource = Controlador.Utils.CargarProductividad();

            foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridView1.Columns)
                try
                {
                    c.Group();
                }
                catch
                {

                }
        }
    }
}
