namespace ProyectoFinal.Vistas
{
    partial class MDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.btnTaza = new DevExpress.XtraEditors.SimpleButton();
            this.btnListaCompras = new DevExpress.XtraEditors.SimpleButton();
            this.btnCompra = new DevExpress.XtraEditors.SimpleButton();
            this.btnListaPedidos = new DevExpress.XtraEditors.SimpleButton();
            this.btnPedido = new DevExpress.XtraEditors.SimpleButton();
            this.btnProduccion = new DevExpress.XtraEditors.SimpleButton();
            this.btnMateriales = new DevExpress.XtraEditors.SimpleButton();
            this.btnProveedores = new DevExpress.XtraEditors.SimpleButton();
            this.btnClientes = new DevExpress.XtraEditors.SimpleButton();
            this.btnUsuario = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.AutoSize = true;
            this.PanelMenu.BackColor = System.Drawing.Color.DarkOrange;
            this.PanelMenu.Controls.Add(this.btnTaza);
            this.PanelMenu.Controls.Add(this.btnListaCompras);
            this.PanelMenu.Controls.Add(this.btnCompra);
            this.PanelMenu.Controls.Add(this.btnListaPedidos);
            this.PanelMenu.Controls.Add(this.btnPedido);
            this.PanelMenu.Controls.Add(this.btnProduccion);
            this.PanelMenu.Controls.Add(this.btnMateriales);
            this.PanelMenu.Controls.Add(this.btnProveedores);
            this.PanelMenu.Controls.Add(this.btnClientes);
            this.PanelMenu.Controls.Add(this.btnUsuario);
            this.PanelMenu.Controls.Add(this.pictureBox1);
            this.PanelMenu.Location = new System.Drawing.Point(3, 2);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(251, 690);
            this.PanelMenu.TabIndex = 0;
            // 
            // btnTaza
            // 
            this.btnTaza.Location = new System.Drawing.Point(48, 601);
            this.btnTaza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaza.Name = "btnTaza";
            this.btnTaza.Size = new System.Drawing.Size(143, 37);
            this.btnTaza.TabIndex = 10;
            this.btnTaza.Text = "Diseño de Taza";
            this.btnTaza.Click += new System.EventHandler(this.simpleButton10_Click_1);
            // 
            // btnListaCompras
            // 
            this.btnListaCompras.ImageUri.Uri = "Chart;Office2013";
            this.btnListaCompras.Location = new System.Drawing.Point(11, 543);
            this.btnListaCompras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListaCompras.Name = "btnListaCompras";
            this.btnListaCompras.Size = new System.Drawing.Size(235, 38);
            this.btnListaCompras.TabIndex = 9;
            this.btnListaCompras.Text = "Lista de compras";
            this.btnListaCompras.Click += new System.EventHandler(this.simpleButton9_Click);
            // 
            // btnCompra
            // 
            this.btnCompra.ImageUri.Uri = "Chart;Office2013";
            this.btnCompra.Location = new System.Drawing.Point(13, 498);
            this.btnCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(235, 38);
            this.btnCompra.TabIndex = 7;
            this.btnCompra.Text = "Compra";
            this.btnCompra.Click += new System.EventHandler(this.simpleButton7_Click);
            // 
            // btnListaPedidos
            // 
            this.btnListaPedidos.ImageUri.Uri = "DeleteDataSource;Office2013";
            this.btnListaPedidos.Location = new System.Drawing.Point(11, 455);
            this.btnListaPedidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListaPedidos.Name = "btnListaPedidos";
            this.btnListaPedidos.Size = new System.Drawing.Size(235, 38);
            this.btnListaPedidos.TabIndex = 8;
            this.btnListaPedidos.Text = "Lista de pedidos";
            this.btnListaPedidos.Click += new System.EventHandler(this.simpleButton8_Click);
            // 
            // btnPedido
            // 
            this.btnPedido.ImageUri.Uri = "DeleteDataSource;Office2013";
            this.btnPedido.Location = new System.Drawing.Point(11, 411);
            this.btnPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(235, 38);
            this.btnPedido.TabIndex = 6;
            this.btnPedido.Text = "Pedido";
            this.btnPedido.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // btnProduccion
            // 
            this.btnProduccion.ImageUri.Uri = "AddNewDataSource;Office2013";
            this.btnProduccion.Location = new System.Drawing.Point(11, 367);
            this.btnProduccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProduccion.Name = "btnProduccion";
            this.btnProduccion.Size = new System.Drawing.Size(235, 38);
            this.btnProduccion.TabIndex = 5;
            this.btnProduccion.Text = "Producción";
            this.btnProduccion.Click += new System.EventHandler(this.BtnProduccion_Click);
            // 
            // btnMateriales
            // 
            this.btnMateriales.ImageUri.Uri = "EditDataSource;Office2013";
            this.btnMateriales.Location = new System.Drawing.Point(11, 322);
            this.btnMateriales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMateriales.Name = "btnMateriales";
            this.btnMateriales.Size = new System.Drawing.Size(235, 38);
            this.btnMateriales.TabIndex = 4;
            this.btnMateriales.Text = "Materiales";
            this.btnMateriales.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.ImageUri.Uri = "CustomizeGrid;Office2013";
            this.btnProveedores.Location = new System.Drawing.Point(11, 279);
            this.btnProveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(235, 38);
            this.btnProveedores.TabIndex = 3;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnClientes.ImageUri.Uri = "AddItem;Office2013";
            this.btnClientes.Location = new System.Drawing.Point(11, 235);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(235, 38);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnUsuario.Image = global::ProyectoFinal.Properties.Resources.naranja;
            this.btnUsuario.ImageUri.Uri = "Add;Office2013";
            this.btnUsuario.Location = new System.Drawing.Point(11, 191);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(235, 38);
            this.btnUsuario.TabIndex = 1;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Peru;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources.sgp;
            this.pictureBox1.Location = new System.Drawing.Point(21, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.AutoSize = true;
            this.PanelContenedor.Location = new System.Drawing.Point(253, 2);
            this.PanelContenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelContenedor.MinimumSize = new System.Drawing.Size(955, 690);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(955, 690);
            this.PanelContenedor.TabIndex = 3;
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1209, 697);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.PanelMenu);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MDI";
            this.Text = "MDI";
            this.Load += new System.EventHandler(this.MDI_Load);
            this.SizeChanged += new System.EventHandler(this.MDI_SizeChanged);
            this.PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton btnListaCompras;
        private DevExpress.XtraEditors.SimpleButton btnListaPedidos;
        private DevExpress.XtraEditors.SimpleButton btnCompra;
        private DevExpress.XtraEditors.SimpleButton btnPedido;
        private DevExpress.XtraEditors.SimpleButton btnProduccion;
        private DevExpress.XtraEditors.SimpleButton btnMateriales;
        private DevExpress.XtraEditors.SimpleButton btnProveedores;
        private DevExpress.XtraEditors.SimpleButton btnClientes;
        private DevExpress.XtraEditors.SimpleButton btnUsuario;
        private System.Windows.Forms.Panel PanelContenedor;
        private DevExpress.XtraEditors.SimpleButton btnTaza;
    }
}