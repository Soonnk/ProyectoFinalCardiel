﻿using System;
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
    public partial class ListaDePedidos : Form
    {
        private Controlador.Ventas.ControladorPedido ctrl;

        public ListaDePedidos()
        {
            InitializeComponent();
            ctrl = new Controlador.Ventas.ControladorPedido();
        }

        private void CargarPedidos()
        {
            GcPedido.DataSource = ctrl.GetAll();
        }

        private void ListaDePedidos_Load(object sender, EventArgs e)
        {
            CargarPedidos();
        }
    }
}
