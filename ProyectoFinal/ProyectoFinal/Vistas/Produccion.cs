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

        //private Controlador.ControladorContacto ctrlContactos;
        private Controlador.Produccion.ControladorMaterial ctrlProduccionMat;
        private Controlador.Produccion.ControladorLote ctrlProduccionLote;
        private Controlador.Produccion.ControladorLoteEtapa ctrlProduccionLoteEt;


        private int IdTipoGasto = 0;

        private int IdGastoMaterial = 0;

        private int IdLoteEtapa = 0;

        Modelo.Produccion.GastosMaterial gtm;
        Modelo.Produccion.LoteEtapa lte;
        Modelo.Produccion.LoteProduccion ltp;


        public Produccion()
        {
            InitializeComponent();
            ctrlProduccionMat = new Controlador.Produccion.ControladorMaterial();
            ctrlProduccionLote = new Controlador.Produccion.ControladorLote();
            ctrlProduccionLoteEt = new Controlador.Produccion.ControladorLoteEtapa();

        }

        private Modelo.Produccion.GastosMaterial generarMaterial()
        {
            Modelo.Produccion.GastosMaterial gm = new Modelo.Produccion.GastosMaterial()
            {
                IdGastoMaterial = IdGastoMaterial,

                Material = (Modelo.Produccion.Material)txtMaterial.EditValue,


            };
            return gm;

        }
        /*private Modelo.Compras.Proveedor GenerarProveedor()
        {
            Modelo.Compras.Proveedor p = new Modelo.Compras.Proveedor()
            {
                IdProveedor = IdProveedor,
                Nombre = (string)TxtNombres.EditValue,
                Calle = (string)TxtCalle.EditValue,
                Colonia = (string)TxtColonia.EditValue,
                Contactos = lst,
                CorreoElectronico = (string)TxtCorreoElectronico.EditValue,
                Numero = (string)TxtNumero.EditValue,
                Telefono = (string)TxtTelefono.EditValue
            };

            return p;
        }

        private void GuardarNuevo()
        {
            Modelo.Compras.Proveedor proveedor = GenerarProveedor();
            ctrlProveedores.InsertarProveedor(proveedor);
        }

        private void GuardarCambios()
        {
            Modelo.Compras.Proveedor proveedor = GenerarProveedor();
            ctrlProveedores.UpdateProveedor(proveedor);

            MessageBox.Show("Cambios Guardados con éxito");

            Limpiar();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
        */

    }
}
