namespace ProyectoFinal.Vistas
{
    partial class ListaDeCompras
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.GcCompras = new DevExpress.XtraGrid.GridControl();
            this.GvCompras = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNombreProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColFechaOrden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColFechaRecepcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNombreComprador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GcCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.GcCompras);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(875, 574);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // GcCompras
            // 
            this.GcCompras.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.GcCompras.Location = new System.Drawing.Point(12, 12);
            this.GcCompras.MainView = this.GvCompras;
            this.GcCompras.Margin = new System.Windows.Forms.Padding(2);
            this.GcCompras.Name = "GcCompras";
            this.GcCompras.Size = new System.Drawing.Size(851, 540);
            this.GcCompras.TabIndex = 25;
            this.GcCompras.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GvCompras});
            this.GcCompras.Click += new System.EventHandler(this.GcCompras_Click);
            // 
            // GvCompras
            // 
            this.GvCompras.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdCompra,
            this.ColNombreProveedor,
            this.ColFechaOrden,
            this.ColFechaRecepcion,
            this.ColNombreComprador});
            this.GvCompras.GridControl = this.GcCompras;
            this.GvCompras.Name = "GvCompras";
            this.GvCompras.OptionsBehavior.Editable = false;
            this.GvCompras.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GvCompras_RowClick);
            // 
            // ColIdCompra
            // 
            this.ColIdCompra.Caption = "Numero de Compra";
            this.ColIdCompra.FieldName = "IdCompra";
            this.ColIdCompra.Name = "ColIdCompra";
            this.ColIdCompra.Visible = true;
            this.ColIdCompra.VisibleIndex = 0;
            this.ColIdCompra.Width = 104;
            // 
            // ColNombreProveedor
            // 
            this.ColNombreProveedor.Caption = "Proveedor";
            this.ColNombreProveedor.FieldName = "NombreProveedor";
            this.ColNombreProveedor.Name = "ColNombreProveedor";
            this.ColNombreProveedor.Visible = true;
            this.ColNombreProveedor.VisibleIndex = 1;
            this.ColNombreProveedor.Width = 162;
            // 
            // ColFechaOrden
            // 
            this.ColFechaOrden.Caption = "Fecha de Orden";
            this.ColFechaOrden.FieldName = "FechaOrden";
            this.ColFechaOrden.Name = "ColFechaOrden";
            this.ColFechaOrden.Visible = true;
            this.ColFechaOrden.VisibleIndex = 2;
            this.ColFechaOrden.Width = 127;
            // 
            // ColFechaRecepcion
            // 
            this.ColFechaRecepcion.Caption = "Fecha de Recepción";
            this.ColFechaRecepcion.FieldName = "FechaRecepcion";
            this.ColFechaRecepcion.Name = "ColFechaRecepcion";
            this.ColFechaRecepcion.Visible = true;
            this.ColFechaRecepcion.VisibleIndex = 3;
            this.ColFechaRecepcion.Width = 127;
            // 
            // ColNombreComprador
            // 
            this.ColNombreComprador.Caption = "Ordenado Por";
            this.ColNombreComprador.FieldName = "NombreComprador";
            this.ColNombreComprador.Name = "ColNombreComprador";
            this.ColNombreComprador.Visible = true;
            this.ColNombreComprador.VisibleIndex = 4;
            this.ColNombreComprador.Width = 176;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(875, 574);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 544);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(855, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.GcCompras;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(855, 544);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageUri.Uri = "Zoom;Office2013";
            this.simpleButton3.Location = new System.Drawing.Point(550, 16);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(574, 40);
            this.simpleButton3.TabIndex = 23;
            this.simpleButton3.Text = "Consultar";
            // 
            // ListaDeCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 574);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListaDeCompras";
            this.Text = "ListaDeCompras";
            this.Load += new System.EventHandler(this.ListaDeCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GcCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraGrid.GridControl GcCompras;
        private DevExpress.XtraGrid.Views.Grid.GridView GvCompras;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdCompra;
        private DevExpress.XtraGrid.Columns.GridColumn ColNombreProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn ColFechaOrden;
        private DevExpress.XtraGrid.Columns.GridColumn ColFechaRecepcion;
        private DevExpress.XtraGrid.Columns.GridColumn ColNombreComprador;
    }
}