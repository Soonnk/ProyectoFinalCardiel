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
        private Controlador.Produccion.ControladorMaterial ctrlMaterial;
        private Controlador.Compras.ControladorProveedor ctrlProveedor;

        public Compras()
        {
            InitializeComponent();
            ctrlMaterial = new Controlador.Produccion.ControladorMaterial();
            ctrlProveedor = new Controlador.Compras.ControladorProveedor();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void Compras_Load(object sender, EventArgs e)
        {
            cmbBase.DataSource = ctrlMaterial.GetAll();
            CmbProveedor.Properties.DataSource = ctrlProveedor.GetAll();
            //cmbBase.DataSource = ctrlMaterial.GetBy("WHERE Tipo = " + (int)Modelo.Produccion.Material.TiposMateriales.Base);
        }
    }
}
