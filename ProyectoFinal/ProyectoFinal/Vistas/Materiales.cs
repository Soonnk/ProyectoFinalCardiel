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
    public partial class Materiales : Form
    {
        private Controlador.Produccion.ControladorMaterial ctrlMaterial;


        private int IdMaterial = 0;
        Modelo.Produccion.Material mat;

        public Materiales()
        {
            InitializeComponent();
            ctrlMaterial = new Controlador.Produccion.ControladorMaterial();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty("" + txtIdMaterial.EditValue))
                GuardarNuevo();
            else
                GuardarCambios();
        }

        public void cargarInterfaz()
        {
            cmbMaterial.Properties.DataSource = Controlador.Utils.GetCatalog("Produccion.c_TiposMateriales");
        }

        

        private void cmbMaterial_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Materiales_Load(object sender, EventArgs e)
        {
            cargarInterfaz();
            limpiar();
            cargarMateriales();
        }

        private void limpiar()
        {
            txtIdMaterial.ReadOnly = true;
            txtDescripcion.EditValue = "";
            txtCosto.EditValue = "";
            txtExistencia.EditValue = "";
            cmbMaterial.EditValue = "";

            gcMaterial.DataSource = mat;

        }

        private void cargarMateriales()
        {
            gcMaterial.DataSource = ctrlMaterial.GetAll();

        }

        private Modelo.Produccion.Material GenerarMaterial()
        {
            Modelo.Produccion.Material m = new Modelo.Produccion.Material();
            

                m.IdMaterial = this.IdMaterial;
                m.Descripcion = (string)txtDescripcion.EditValue;
                m.Costo = Double.Parse(txtCosto.Text);
                m.Existencia = Double.Parse(txtExistencia.Text);
                m.Tipo = (Modelo.Produccion.Material.TiposMateriales)cmbMaterial.EditValue;
            

            return m;

        }
        
        private void GuardarNuevo()
        {
            Modelo.Produccion.Material material = GenerarMaterial();
            ctrlMaterial.InsertarMaterial(material);
        }

        private void GuardarCambios()
        {
            Modelo.Produccion.Material material = GenerarMaterial();
            ctrlMaterial.UpdateMaterial(material);

            MessageBox.Show("Cambios Guardados con éxito");

            limpiar();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            cargarMateriales();
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            mostrarMateriales(((ColumnView)sender).GetDataRow(e.RowHandle));
        }

        private void mostrarMateriales(DataRow row)
        {
            if (row == null) return;
            
            Modelo.Produccion.Material m = ctrlMaterial.GetById((int)row["IdMaterial"]);

            if (m == null) return;

            this.txtDescripcion.EditValue = m.Descripcion;
            this.txtCosto.EditValue = m.Costo;
            this.txtExistencia.EditValue = m.Existencia;
            this.cmbMaterial.EditValue = m.Tipo;

            gcMaterial.RefreshDataSource();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            // btn eliminar
            GuardarCambios();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            // btn Limpiar
            limpiar();
        }

        private void txtIdMaterial_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
