using DevExpress.Utils.Svg;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Vistas
{
    public partial class ViewDesign : Form
    {
        private bool _edited;
        private bool Edited
        {
            get
            {
                return _edited;
            }
            set
            {
                _edited = value;
                if (value)
                {
                    BtnAceptar.Enabled = true;
                    BtnDescargar.Enabled = true;
                }
                else
                {
                    BtnAceptar.Enabled = false;
                    BtnDescargar.Enabled = false;
                }
            }
        }
        private bool nuevo = true;
        private int idActual = -1;

        private byte[] archivo;

        private Controlador.Produccion.ControladorDesign ctrl;

        public ViewDesign()
        {
            InitializeComponent();
            ctrl = new Controlador.Produccion.ControladorDesign();
        }

        private void Limpiar()
        {
            TxtNombre.EditValue = "";
            PicturBoxDesign.Image = global::ProyectoFinal.Properties.Resources.add_32x32;

            Edited = false;
            nuevo = true;

            idActual = 0;
            archivo = null;
            CargarDesigns();
        }

        public void CargarDesigns()
        {
            GcDesigns.DataSource = ctrl.GetAll();
        }

        private void MostrarFilePicker()
        {
            FileDialogSvg.AddExtension = true;
            FileDialogSvg.Filter = "Vector Escalable|*.svg";

            FileDialogSvg.ShowDialog(this);
        }

        private Modelo.Produccion.Design GenerarEntidad()
        {
            Modelo.Produccion.Design d = new Modelo.Produccion.Design() {
                IdDesign = idActual,
                Archivo = archivo,
                Descripcion = (string) TxtNombre.EditValue
            };

            return d;
        }

        public void ValidarGuardado()
        {
            if (String.IsNullOrEmpty(TxtNombre.Text))
            {
                MessageBox.Show("No puedes guardar sin nombre");
                return;
            }

            if (archivo == null)
            {
                MessageBox.Show("No se pudo detectar imagen, vuelve a cargarla por favor");
                return;
            }

            if (!Edited) return;

            if (nuevo)
                GuardarNuevo();
            else
                GuardarCambios();
        }

        public void GuardarNuevo()
        {
            Modelo.Produccion.Design d = GenerarEntidad();


            ctrl.InsertarDesign(d);
            Limpiar();
        }

        public void GuardarCambios()
        {
            Modelo.Produccion.Design d = GenerarEntidad();

            ctrl.UpdateDesign(d);
            MessageBox.Show("Cambios Guardados con exito", "Guardar diseño");
        }

        public void MostrarDesign(DataRow row)
        {
            if (row == null) return;

            Modelo.Produccion.Design d = ctrl.GetById((int)row["IdDesign"]);

            if (d == null) return;

            idActual = d.IdDesign;
            TxtNombre.EditValue = d.Descripcion;
            archivo = d.Archivo;
            CargarSvg(new MemoryStream(archivo));

            nuevo = false;
        }

        public void CargarSvg(Stream stream)
        {
            SvgBitmap svg = DevExpress.Utils.Svg.SvgBitmap.FromStream(stream);

            double heigth = svg.SvgImage.Height;
            double width = svg.SvgImage.Width;

            double scale = (PicturBoxDesign.Height > PicturBoxDesign.Height ? PicturBoxDesign.Width : PicturBoxDesign.Width) / (heigth > width ? heigth : width);

            PicturBoxDesign.Image = svg.Render(null, scale);

            stream.Position = 0;

            using (MemoryStream ms = new MemoryStream())
            {
                stream.CopyTo(ms);

                archivo = ms.ToArray();
            }

            stream.Close();

            stream.Dispose();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (Edited)
                ValidarGuardado();
        }
        
        private void PicturBoxDesign_Click(object sender, EventArgs e)
        {
            FileDialogSvg = new OpenFileDialog();

            FileDialogSvg.FileOk += new CancelEventHandler(this.FileDialogSvg_FileOk);

            FileDialogSvg.AddExtension = true;
            FileDialogSvg.Filter = "Vector Escalable|*.svg";
            
            FileDialogSvg.ShowDialog(this);
        }

        private void FileDialogSvg_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                Stream stream = ((OpenFileDialog)sender).OpenFile();

                CargarSvg(stream);

                Edited = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GvDesigns_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            MostrarDesign(((ColumnView)sender).GetDataRow(e.RowHandle));
        }

        private void BtnDescargar_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/Download";
            dialog.AddExtension = true;

            dialog.Filter = "Vector escalable|*svg";

            dialog.FileOk += new CancelEventHandler(this.GuardarArchivo);

            dialog.ShowDialog();
            dialog.Dispose();
        }

        private void GuardarArchivo(object sender, CancelEventArgs e) {
            SaveFileDialog dialog = (SaveFileDialog)sender;

            string path = dialog.FileName;

            path = path.EndsWith(".svg") ? path : path + ".svg";

            File.WriteAllBytes(path, archivo);
        }

        private void ViewDesign_Load(object sender, EventArgs e)
        {
            Limpiar();
            PicturBoxDesign.Properties.ContextMenuStrip = null;
        }

        private void TxtNombre_EditValueChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty((string)((TextEdit)sender).EditValue))
                Edited = false;
            else
                Edited = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
