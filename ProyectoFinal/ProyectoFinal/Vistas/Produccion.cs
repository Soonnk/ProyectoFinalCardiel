using DevExpress.XtraGrid.Views.Base;
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
        private Controlador.Usuarios.ControladorUsuario ctrlUsuarios;
        private List<GastosMaterial> lst;

        private LoteProduccion CurrentLote;
        private int IdDetalleAsociado;

        public Produccion()
        {
            InitializeComponent();
            ctrlMateriales = new Controlador.Produccion.ControladorMaterial();
            ctrlLotes = new Controlador.Produccion.ControladorLote();
            ctrlEtapas = new Controlador.Produccion.ControladorLoteEtapa();
            ctrlUsuarios = new Controlador.Usuarios.ControladorUsuario();

        }

        public void CargarPendientes()
        {
            DataTable dt;
            try
            {
                if (Session.UsuarioEnCurso.Departamento == Modelo.Usuarios.Usuario.Departamentos.Administracion)
                    GcPendientes.DataSource = ctrlLotes.GetAll();
                else
                {
                    dt = ctrlLotes.GetAll();
                    if (dt.Rows.Count > 0)
                        GcPendientes.DataSource = dt.Select("[Etapa] = " + (((int)Session.UsuarioEnCurso.Departamento) - 2)).CopyToDataTable();
                    else
                    {
                        MessageBox.Show("No se encontró ninguna tarea para tu departamento");
                        GcPendientes.DataSource = null;
                    }
                }
            }
            catch (System.InvalidOperationException ex) //when (ex.Message == "El origen de datos no contiene DataRows")
            {
                MessageBox.Show("No se encontró ninguna tarea para tu departamento");
                GcPendientes.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Limpiar()
        {
            txtIdLoteEtapa.EditValue = "";
            txtIdLoteProduccion.EditValue = "";
            txtOrdenadoPor.EditValue = "";
            DtpFechaOrdenamiento.EditValue = DateTime.Today;
            DtpFechaAutorizacion.EditValue = DateTime.Today;
            txtAutorizadoPor.EditValue = "";
            CmbMaterial.EditValue = null;
            txtCantidad.EditValue = "";
            txtObservacion.EditValue = "";
            CmbTipoGasto.EditValue = null;

            lst = new List<GastosMaterial>();
            GcConsumos.DataSource = lst;
            GcConsumos.RefreshDataSource();

            btnAgregar.Text = "Terminar Etapa";
            btnAgregar.Enabled = false;
            BtnGuardar.Enabled = false;

            CargarPendientes();
        }

        private void MostrarAvance(DataRow row)
        {
            if (row == null) return;

            if (row.IsNull("Etapa"))
            {
                CurrentLote = null;
                txtIdLoteEtapa.EditValue = 0;
                txtIdLoteProduccion.EditValue = 0;
                txtOrdenadoPor.EditValue = Session.UsuarioEnCurso.Nombre + " " + Session.UsuarioEnCurso.ApellidoPaterno;
                DtpFechaOrdenamiento.EditValue = DateTime.Today;

                lst = new List<GastosMaterial>();
                lst.Add(
                    new GastosMaterial() {
                        Material = ctrlMateriales.GetById((int)row["Base"]),
                        Cantidad = (int)row["Cantidad"],
                        Observacion = "Consumo necesario generado",
                        Tipo = GastosMaterial.TiposGasto.Consumo
                    }
                );

                this.IdDetalleAsociado = (int)row["IdDetalle"];

                GcConsumos.DataSource = lst;
                GcConsumos.RefreshDataSource();

                btnAgregar.Text = "Iniciar Produccion";
                BtnGuardar.Enabled = false;
            }
            else
            {
                Modelo.Produccion.LoteProduccion l = ctrlLotes.GetById((int)row["IdLoteProduccion"]);

                if (l == null) return;

                Modelo.Produccion.LoteEtapa e = l[l.Count - 1];

                txtIdLoteEtapa.EditValue = e.IdLoteEtapa;
                txtIdLoteProduccion.EditValue = l.IdLoteProduccion;
                txtOrdenadoPor.EditValue = e.OrdenadoPor.Nombre + " " + e.OrdenadoPor.ApellidoPaterno;

                if (e.AutorizadoPor != null)
                    txtAutorizadoPor.EditValue = e.AutorizadoPor.Nombre + " " + e.AutorizadoPor.ApellidoPaterno;

                DtpFechaOrdenamiento.EditValue = e.FechaOrdemamiento;
                DtpFechaAutorizacion.EditValue = e.FechaAutorizacion;

                lst.Clear();
                foreach (GastosMaterial g in e.GastosMateriales)
                    lst.Add(g);
                
                GcConsumos.RefreshDataSource();
                btnAgregar.Text = "Terminar Etapa";

                CurrentLote = l;
                BtnGuardar.Enabled = true;
            }
            btnAgregar.Enabled = true;
        }

        private Modelo.Produccion.LoteProduccion GenerarLote()
        {
            Modelo.Produccion.LoteProduccion l = new LoteProduccion();
            l.IdLoteProduccion = 0;
            l.DetalleAsociado = new Modelo.Ventas.DetallePedido() { IdDetallePedido = this.IdDetalleAsociado };
            
            return l;
        }

        private void AgregarConsumo()
        {
            GastosMaterial g = new GastosMaterial();
            g.Cantidad = Double.Parse(txtCantidad.Text);
            g.IdGastoMaterial = 0;
            g.Material = ctrlMateriales.GetById((int)CmbMaterial.EditValue);
            g.Observacion = (string)txtObservacion.EditValue;
            g.Tipo = (GastosMaterial.TiposGasto)CmbTipoGasto.EditValue;

            lst.Add(g);
            GcConsumos.RefreshDataSource();

            txtCantidad.EditValue = "";
            CmbMaterial.EditValue = null;
            txtObservacion.EditValue = "";
            CmbTipoGasto.EditValue = null;
        }

        public void PasarAvance()
        {
            if (CurrentLote == null)
            {
                CurrentLote = GenerarLote();
                ctrlLotes.InsertarLote(CurrentLote);
                ctrlLotes.AgregarEtapa(CurrentLote, LoteEtapa.EtapasProduccion.Corte);
                foreach (GastosMaterial g in lst)
                    ctrlEtapas.AgregarGastoDeMaterial(CurrentLote[0], g);

                Limpiar();
            }
            else
            {
                ctrlLotes.CerrarEtapa(CurrentLote, CurrentLote[CurrentLote.Count - 1].Etapa);

                if (CurrentLote[CurrentLote.Count - 1].Etapa != LoteEtapa.EtapasProduccion.Entregado)
                    ctrlLotes.AgregarEtapa(CurrentLote, (LoteEtapa.EtapasProduccion)CurrentLote.Count+1);
            }
        }

        private void Produccion_Load(object sender, EventArgs e)
        {
            CmbTipoGasto.Properties.DataSource = Controlador.Utils.GetCatalog("[Produccion].[c_TipoGasto]");
            CmbMaterial.Properties.DataSource = ctrlMateriales.GetAll();

            Limpiar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            PasarAvance();
            Limpiar();
        }
        
        private void GvPendientes_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            MostrarAvance(((ColumnView)sender).GetDataRow(e.RowHandle));
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            CargarPendientes();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnAgregarConsumo_Click(object sender, EventArgs e)
        {
            AgregarConsumo();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            LoteEtapa etapa = CurrentLote[CurrentLote.Count - 1];

            foreach (GastosMaterial g in lst)
                if (g.IdGastoMaterial == 0)
                    ctrlEtapas.AgregarGastoDeMaterial(etapa, g);

            Limpiar();
        }
    }
}
