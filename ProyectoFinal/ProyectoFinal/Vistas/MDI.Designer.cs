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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.BtnListaCompras = new DevExpress.XtraEditors.SimpleButton();
            this.btnCompra = new DevExpress.XtraEditors.SimpleButton();
            this.btnListaPedidos = new DevExpress.XtraEditors.SimpleButton();
            this.btnPedido = new DevExpress.XtraEditors.SimpleButton();
            this.btnProduccion = new DevExpress.XtraEditors.SimpleButton();
            this.btnMateriales = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.LciMateriales = new DevExpress.XtraLayout.LayoutControlItem();
            this.LciProduccion = new DevExpress.XtraLayout.LayoutControlItem();
            this.LciPedidos = new DevExpress.XtraLayout.LayoutControlItem();
            this.LciListaPedidos = new DevExpress.XtraLayout.LayoutControlItem();
            this.LciCompra = new DevExpress.XtraLayout.LayoutControlItem();
            this.LciListaCompras = new DevExpress.XtraLayout.LayoutControlItem();
            this.LciReportes = new DevExpress.XtraLayout.LayoutControlItem();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.btnTaza = new DevExpress.XtraEditors.SimpleButton();
            this.btnUsuario = new DevExpress.XtraEditors.SimpleButton();
            this.btnClientes = new DevExpress.XtraEditors.SimpleButton();
            this.btnProveedores = new DevExpress.XtraEditors.SimpleButton();
            this.LciUsuarios = new DevExpress.XtraLayout.LayoutControlItem();
            this.LciClientes = new DevExpress.XtraLayout.LayoutControlItem();
            this.LciProveedores = new DevExpress.XtraLayout.LayoutControlItem();
            this.LciDesigns = new DevExpress.XtraLayout.LayoutControlItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciMateriales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciProduccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciListaPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciListaCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciDesigns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.AutoSize = true;
            this.PanelMenu.BackColor = System.Drawing.Color.DarkOrange;
            this.PanelMenu.Controls.Add(this.layoutControl1);
            this.PanelMenu.Controls.Add(this.pictureBox1);
            this.PanelMenu.Location = new System.Drawing.Point(2, 2);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(188, 561);
            this.PanelMenu.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.btnTaza);
            this.layoutControl1.Controls.Add(this.BtnListaCompras);
            this.layoutControl1.Controls.Add(this.btnCompra);
            this.layoutControl1.Controls.Add(this.btnListaPedidos);
            this.layoutControl1.Controls.Add(this.btnUsuario);
            this.layoutControl1.Controls.Add(this.btnPedido);
            this.layoutControl1.Controls.Add(this.btnClientes);
            this.layoutControl1.Controls.Add(this.btnProduccion);
            this.layoutControl1.Controls.Add(this.btnProveedores);
            this.layoutControl1.Controls.Add(this.btnMateriales);
            this.layoutControl1.Location = new System.Drawing.Point(3, 144);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(180, 409);
            this.layoutControl1.TabIndex = 11;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageUri.Uri = "Show;Office2013";
            this.simpleButton1.Location = new System.Drawing.Point(12, 390);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(139, 38);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 11;
            this.simpleButton1.Text = "Productividad";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // BtnListaCompras
            // 
            this.BtnListaCompras.ImageUri.Uri = "Chart;Office2013";
            this.BtnListaCompras.Location = new System.Drawing.Point(12, 348);
            this.BtnListaCompras.Margin = new System.Windows.Forms.Padding(2);
            this.BtnListaCompras.Name = "BtnListaCompras";
            this.BtnListaCompras.Size = new System.Drawing.Size(139, 38);
            this.BtnListaCompras.StyleController = this.layoutControl1;
            this.BtnListaCompras.TabIndex = 9;
            this.BtnListaCompras.Text = "Lista de compras";
            this.BtnListaCompras.Click += new System.EventHandler(this.simpleButton9_Click);
            // 
            // btnCompra
            // 
            this.btnCompra.ImageUri.Uri = "Chart;Office2013";
            this.btnCompra.Location = new System.Drawing.Point(12, 306);
            this.btnCompra.Margin = new System.Windows.Forms.Padding(2);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(139, 38);
            this.btnCompra.StyleController = this.layoutControl1;
            this.btnCompra.TabIndex = 7;
            this.btnCompra.Text = "Compra";
            this.btnCompra.Click += new System.EventHandler(this.simpleButton7_Click);
            // 
            // btnListaPedidos
            // 
            this.btnListaPedidos.ImageUri.Uri = "DeleteDataSource;Office2013";
            this.btnListaPedidos.Location = new System.Drawing.Point(12, 264);
            this.btnListaPedidos.Margin = new System.Windows.Forms.Padding(2);
            this.btnListaPedidos.Name = "btnListaPedidos";
            this.btnListaPedidos.Size = new System.Drawing.Size(139, 38);
            this.btnListaPedidos.StyleController = this.layoutControl1;
            this.btnListaPedidos.TabIndex = 8;
            this.btnListaPedidos.Text = "Lista de pedidos";
            this.btnListaPedidos.Click += new System.EventHandler(this.simpleButton8_Click);
            // 
            // btnPedido
            // 
            this.btnPedido.ImageUri.Uri = "DeleteDataSource;Office2013";
            this.btnPedido.Location = new System.Drawing.Point(12, 222);
            this.btnPedido.Margin = new System.Windows.Forms.Padding(2);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(139, 38);
            this.btnPedido.StyleController = this.layoutControl1;
            this.btnPedido.TabIndex = 6;
            this.btnPedido.Text = "Pedido";
            this.btnPedido.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // btnProduccion
            // 
            this.btnProduccion.ImageUri.Uri = "Today;Office2013";
            this.btnProduccion.Location = new System.Drawing.Point(12, 180);
            this.btnProduccion.Margin = new System.Windows.Forms.Padding(2);
            this.btnProduccion.Name = "btnProduccion";
            this.btnProduccion.Size = new System.Drawing.Size(139, 38);
            this.btnProduccion.StyleController = this.layoutControl1;
            this.btnProduccion.TabIndex = 5;
            this.btnProduccion.Text = "Producción";
            this.btnProduccion.Click += new System.EventHandler(this.BtnProduccion_Click);
            // 
            // btnMateriales
            // 
            this.btnMateriales.ImageUri.Uri = "CustomizeGrid;Office2013";
            this.btnMateriales.Location = new System.Drawing.Point(12, 138);
            this.btnMateriales.Margin = new System.Windows.Forms.Padding(2);
            this.btnMateriales.Name = "btnMateriales";
            this.btnMateriales.Size = new System.Drawing.Size(139, 38);
            this.btnMateriales.StyleController = this.layoutControl1;
            this.btnMateriales.TabIndex = 4;
            this.btnMateriales.Text = "Materiales";
            this.btnMateriales.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.LciUsuarios,
            this.LciClientes,
            this.LciProveedores,
            this.LciMateriales,
            this.LciProduccion,
            this.LciPedidos,
            this.LciListaPedidos,
            this.LciCompra,
            this.LciListaCompras,
            this.LciDesigns,
            this.LciReportes});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(163, 482);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // LciMateriales
            // 
            this.LciMateriales.Control = this.btnMateriales;
            this.LciMateriales.Location = new System.Drawing.Point(0, 126);
            this.LciMateriales.Name = "LciMateriales";
            this.LciMateriales.Size = new System.Drawing.Size(143, 42);
            this.LciMateriales.TextSize = new System.Drawing.Size(0, 0);
            this.LciMateriales.TextVisible = false;
            // 
            // LciProduccion
            // 
            this.LciProduccion.Control = this.btnProduccion;
            this.LciProduccion.Location = new System.Drawing.Point(0, 168);
            this.LciProduccion.Name = "LciProduccion";
            this.LciProduccion.Size = new System.Drawing.Size(143, 42);
            this.LciProduccion.TextSize = new System.Drawing.Size(0, 0);
            this.LciProduccion.TextVisible = false;
            // 
            // LciPedidos
            // 
            this.LciPedidos.Control = this.btnPedido;
            this.LciPedidos.Location = new System.Drawing.Point(0, 210);
            this.LciPedidos.Name = "LciPedidos";
            this.LciPedidos.Size = new System.Drawing.Size(143, 42);
            this.LciPedidos.TextSize = new System.Drawing.Size(0, 0);
            this.LciPedidos.TextVisible = false;
            // 
            // LciListaPedidos
            // 
            this.LciListaPedidos.Control = this.btnListaPedidos;
            this.LciListaPedidos.Location = new System.Drawing.Point(0, 252);
            this.LciListaPedidos.Name = "LciListaPedidos";
            this.LciListaPedidos.Size = new System.Drawing.Size(143, 42);
            this.LciListaPedidos.TextSize = new System.Drawing.Size(0, 0);
            this.LciListaPedidos.TextVisible = false;
            // 
            // LciCompra
            // 
            this.LciCompra.Control = this.btnCompra;
            this.LciCompra.Location = new System.Drawing.Point(0, 294);
            this.LciCompra.Name = "LciCompra";
            this.LciCompra.Size = new System.Drawing.Size(143, 42);
            this.LciCompra.TextSize = new System.Drawing.Size(0, 0);
            this.LciCompra.TextVisible = false;
            // 
            // LciListaCompras
            // 
            this.LciListaCompras.Control = this.BtnListaCompras;
            this.LciListaCompras.Location = new System.Drawing.Point(0, 336);
            this.LciListaCompras.Name = "LciListaCompras";
            this.LciListaCompras.Size = new System.Drawing.Size(143, 42);
            this.LciListaCompras.TextSize = new System.Drawing.Size(0, 0);
            this.LciListaCompras.TextVisible = false;
            // 
            // LciReportes
            // 
            this.LciReportes.Control = this.simpleButton1;
            this.LciReportes.Location = new System.Drawing.Point(0, 378);
            this.LciReportes.Name = "LciReportes";
            this.LciReportes.Size = new System.Drawing.Size(143, 42);
            this.LciReportes.TextSize = new System.Drawing.Size(0, 0);
            this.LciReportes.TextVisible = false;
            this.LciReportes.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.AutoSize = true;
            this.PanelContenedor.Location = new System.Drawing.Point(190, 2);
            this.PanelContenedor.Margin = new System.Windows.Forms.Padding(2);
            this.PanelContenedor.MinimumSize = new System.Drawing.Size(716, 561);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(716, 561);
            this.PanelContenedor.TabIndex = 3;
            // 
            // btnTaza
            // 
            this.btnTaza.Image = global::ProyectoFinal.Properties.Resources.image_32x32;
            this.btnTaza.Location = new System.Drawing.Point(12, 432);
            this.btnTaza.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaza.Name = "btnTaza";
            this.btnTaza.Size = new System.Drawing.Size(139, 38);
            this.btnTaza.StyleController = this.layoutControl1;
            this.btnTaza.TabIndex = 10;
            this.btnTaza.Text = "Diseño de Taza";
            this.btnTaza.Click += new System.EventHandler(this.BtnDesigns_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Image = global::ProyectoFinal.Properties.Resources.assignto_32x32;
            this.btnUsuario.Location = new System.Drawing.Point(12, 12);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(139, 38);
            this.btnUsuario.StyleController = this.layoutControl1;
            this.btnUsuario.TabIndex = 1;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Image = global::ProyectoFinal.Properties.Resources.usergroup_32x32;
            this.btnClientes.Location = new System.Drawing.Point(12, 54);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(139, 38);
            this.btnClientes.StyleController = this.layoutControl1;
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Image = global::ProyectoFinal.Properties.Resources.team_32x32;
            this.btnProveedores.Location = new System.Drawing.Point(12, 96);
            this.btnProveedores.Margin = new System.Windows.Forms.Padding(2);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(139, 38);
            this.btnProveedores.StyleController = this.layoutControl1;
            this.btnProveedores.TabIndex = 3;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // LciUsuarios
            // 
            this.LciUsuarios.Control = this.btnUsuario;
            this.LciUsuarios.Location = new System.Drawing.Point(0, 0);
            this.LciUsuarios.Name = "LciUsuarios";
            this.LciUsuarios.Size = new System.Drawing.Size(143, 42);
            this.LciUsuarios.Text = "lciUsuarios";
            this.LciUsuarios.TextSize = new System.Drawing.Size(0, 0);
            this.LciUsuarios.TextVisible = false;
            // 
            // LciClientes
            // 
            this.LciClientes.Control = this.btnClientes;
            this.LciClientes.Location = new System.Drawing.Point(0, 42);
            this.LciClientes.Name = "LciClientes";
            this.LciClientes.Size = new System.Drawing.Size(143, 42);
            this.LciClientes.TextSize = new System.Drawing.Size(0, 0);
            this.LciClientes.TextVisible = false;
            // 
            // LciProveedores
            // 
            this.LciProveedores.Control = this.btnProveedores;
            this.LciProveedores.Location = new System.Drawing.Point(0, 84);
            this.LciProveedores.Name = "LciProveedores";
            this.LciProveedores.Size = new System.Drawing.Size(143, 42);
            this.LciProveedores.TextSize = new System.Drawing.Size(0, 0);
            this.LciProveedores.TextVisible = false;
            // 
            // LciDesigns
            // 
            this.LciDesigns.Control = this.btnTaza;
            this.LciDesigns.Location = new System.Drawing.Point(0, 420);
            this.LciDesigns.Name = "LciDesigns";
            this.LciDesigns.Size = new System.Drawing.Size(143, 42);
            this.LciDesigns.TextSize = new System.Drawing.Size(0, 0);
            this.LciDesigns.TextVisible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Peru;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources.sgp;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(907, 566);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.PanelMenu);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MDI";
            this.Text = "MDI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MDI_FormClosing);
            this.Load += new System.EventHandler(this.MDI_Load);
            this.SizeChanged += new System.EventHandler(this.MDI_SizeChanged);
            this.PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciMateriales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciProduccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciListaPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciListaCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciDesigns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton BtnListaCompras;
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
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem LciUsuarios;
        private DevExpress.XtraLayout.LayoutControlItem LciClientes;
        private DevExpress.XtraLayout.LayoutControlItem LciProveedores;
        private DevExpress.XtraLayout.LayoutControlItem LciMateriales;
        private DevExpress.XtraLayout.LayoutControlItem LciProduccion;
        private DevExpress.XtraLayout.LayoutControlItem LciPedidos;
        private DevExpress.XtraLayout.LayoutControlItem LciListaPedidos;
        private DevExpress.XtraLayout.LayoutControlItem LciCompra;
        private DevExpress.XtraLayout.LayoutControlItem LciListaCompras;
        private DevExpress.XtraLayout.LayoutControlItem LciDesigns;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem LciReportes;
    }
}