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

namespace ProyectoFinal.Vistas
{
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
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
