using ProyectoFinal.Modelo.Produccion;
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
    public partial class Produccion : Form
    {
        private Controlador.Produccion.ControladorMaterial ctrlMateriales;
        private Controlador.Produccion.ControladorLote ctrlLotes;
        private Controlador.Produccion.ControladorLoteEtapa ctrlEtapas;
        
        public Produccion()
        {
            InitializeComponent();
            ctrlMateriales = new Controlador.Produccion.ControladorMaterial();
            ctrlLotes = new Controlador.Produccion.ControladorLote();
            ctrlEtapas = new Controlador.Produccion.ControladorLoteEtapa();

        }

        public void CargarPendientes()
        {
            GcPendientes.DataSource = ctrlLotes.GetAll();
        }

        private Modelo.Produccion.GastosMaterial generarMaterial()
        {
            return null;
        }

        private void Produccion_Load(object sender, EventArgs e)
        {
            CargarPendientes();
        }
    }
}
