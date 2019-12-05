﻿using ProyectoFinal.AccesoDatos;
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
    public partial class MDI : Form
    {

        public MDI()
        {
            InitializeComponent();
            if (ConexionSQL.nivelUsuario == "User")
            {

            }
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Form ventanaUsuario = new Vistas.Usuario();
            CargarFormulario(ventanaUsuario);
        }

        private void MDI_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flyoutPanelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnProduccion_Click(object sender, EventArgs e)
        {
            // Produccion

            Form ventanaProduccion = new Vistas.Produccion();
            CargarFormulario(ventanaProduccion);
        }

        private void CargarFormulario(Form child)
        {
            if (child.Name.Equals(PanelContenedor.Tag))
                return;

            if (PanelContenedor.Controls.Count > 0)
                PanelContenedor.Controls.Clear();

            child.FormBorderStyle = FormBorderStyle.None;
            child.TopLevel = false;
            child.Dock = DockStyle.Fill;
            PanelContenedor.Controls.Add(child);
            PanelContenedor.Tag = child.Name;
            child.Show();
        }

        private void MDI_SizeChanged(object sender, EventArgs e)
        {
            PanelMenu.Size = new Size(188, this.Height);
            PanelContenedor.Size = new Size(this.Width - 200, this.Height);
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            new ViewDesign().ShowDialog(this);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            // Clientes

            Form ventanaClientes = new Vistas.Clientes();
            CargarFormulario(ventanaClientes);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            // Proveedores
            Form ventanaProveedores = new Vistas.Proveedores();
            CargarFormulario(ventanaProveedores);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            // Materiales

            Form ventanaMateriales = new Vistas.Materiales();
            CargarFormulario(ventanaMateriales);

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            // Pedido

            Form ventanaPedido = new Vistas.Pedidos();
            CargarFormulario(ventanaPedido);

        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            // Lista de pedidos

            Form ventanaListPedidos = new Vistas.ListaDePedidos();
            CargarFormulario(ventanaListPedidos);

        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            // Compra

            Form ventanaCompra = new Vistas.Compras();
            CargarFormulario(ventanaCompra);

        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            // Lista de compras

            Form ventanaListCompras = new Vistas.ListaDeCompras();
            CargarFormulario(ventanaListCompras);

        }

        private void BtnDesigns_Click(object sender, EventArgs e)
        {
            new ViewDesign().ShowDialog(this);
        }
        
        private void MDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
