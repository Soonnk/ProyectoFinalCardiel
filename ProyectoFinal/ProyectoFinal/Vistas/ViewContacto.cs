using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.Modelo;

namespace ProyectoFinal.Vistas
{
    public partial class ViewContacto : Form
    {
        
        public Contacto Contacto { get; set; }
        private int IdContacto { get; set; }
        
        public ViewContacto()
        {
            InitializeComponent();
            Contacto = new Contacto();
        }

        public ViewContacto(Contacto contacto)
        {
            InitializeComponent();
            this.Contacto = contacto;
            this.IdContacto = contacto.IdContacto;
        }

        public void GenerarContacto()
        {
            if (String.IsNullOrEmpty((string)TxtNombre.EditValue) || String.IsNullOrEmpty((string)TxtTelefono.EditValue)) {
                MessageBox.Show("El contacto debe tener por lo menos un nombre y un correo");
            }

            this.Contacto = new Modelo.Contacto()
            {
                IdContacto = this.Contacto.IdContacto,
                IdPersona = this.Contacto.IdPersona,
                Nombre = String.IsNullOrEmpty((string)TxtNombre.EditValue) ? null : (string)TxtNombre.EditValue,
                ApellidoPaterno = String.IsNullOrEmpty((string)TxtApellidoPaterno.EditValue) ? null : (string)TxtApellidoPaterno.EditValue,
                ApellidoMaterno = String.IsNullOrEmpty((string)TxtApellidoMaterno.EditValue) ? null : (string)TxtApellidoMaterno.EditValue,
                Telefono = String.IsNullOrEmpty((string)TxtTelefono.EditValue) ? null : (string)TxtTelefono.EditValue,
                CorreoElectronico = String.IsNullOrEmpty((string)TxtCorreoElectronico.EditValue) ? null : (string)TxtCorreoElectronico.EditValue,
                Calle = String.IsNullOrEmpty((string)TxtCalle.EditValue) ? null : (string)TxtCalle.EditValue,
                Numero = String.IsNullOrEmpty((string)TxtNumero.EditValue) ? null : (string)TxtNumero.EditValue,
                Colonia = String.IsNullOrEmpty((string)TxtColonia.EditValue) ? null : (string)TxtColonia.EditValue
            };            
        }

        private void ViewContacto_Load(object sender, EventArgs e)
        {
            if (Contacto != null)
            {
                TxtNombre.EditValue = Contacto.Nombre;
                TxtApellidoPaterno.EditValue = Contacto.ApellidoPaterno;
                TxtApellidoMaterno.EditValue = Contacto.ApellidoMaterno;
                TxtTelefono.EditValue = Contacto.Telefono;
                TxtCorreoElectronico.EditValue = Contacto.CorreoElectronico;
                TxtCalle.EditValue = Contacto.Calle;
                TxtNumero.EditValue = Contacto.Numero;
                TxtColonia.EditValue = Contacto.Colonia;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            GenerarContacto();
            this.DialogResult = DialogResult.OK;
        }
    }
}
