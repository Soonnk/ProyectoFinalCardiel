namespace ProyectoFinal.Vistas
{
    partial class Compras
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
            this.ColBase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbBase = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ColCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtIdCompra = new DevExpress.XtraEditors.TextEdit();
            this.dtaFechaOrden = new DevExpress.XtraEditors.DateEdit();
            this.dtaFechaRecepcion = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.campoUsuario = new DevExpress.XtraLayout.LayoutControlItem();
            this.LciProveedor = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.CmbProveedor = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GcCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCompra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaFechaOrden.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaFechaOrden.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaFechaRecepcion.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaFechaRecepcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campoUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.GcCompras);
            this.layoutControl1.Controls.Add(this.simpleButton5);
            this.layoutControl1.Controls.Add(this.simpleButton4);
            this.layoutControl1.Controls.Add(this.simpleButton2);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.txtIdCompra);
            this.layoutControl1.Controls.Add(this.dtaFechaOrden);
            this.layoutControl1.Controls.Add(this.dtaFechaRecepcion);
            this.layoutControl1.Controls.Add(this.CmbProveedor);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(891, 598);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // GcCompras
            // 
            this.GcCompras.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.GcCompras.Location = new System.Drawing.Point(12, 180);
            this.GcCompras.MainView = this.GvCompras;
            this.GcCompras.Margin = new System.Windows.Forms.Padding(2);
            this.GcCompras.Name = "GcCompras";
            this.GcCompras.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbBase});
            this.GcCompras.Size = new System.Drawing.Size(857, 406);
            this.GcCompras.TabIndex = 36;
            this.GcCompras.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GvCompras});
            // 
            // GvCompras
            // 
            this.GvCompras.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColBase,
            this.ColCantidad,
            this.ColPrecio});
            this.GvCompras.GridControl = this.GcCompras;
            this.GvCompras.Name = "GvCompras";
            // 
            // ColBase
            // 
            this.ColBase.Caption = "Base";
            this.ColBase.ColumnEdit = this.cmbBase;
            this.ColBase.FieldName = "Base";
            this.ColBase.Name = "ColBase";
            this.ColBase.Visible = true;
            this.ColBase.VisibleIndex = 0;
            // 
            // cmbBase
            // 
            this.cmbBase.AutoHeight = false;
            this.cmbBase.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBase.DisplayMember = "Descripcion";
            this.cmbBase.Name = "cmbBase";
            this.cmbBase.ValueMember = "IdMaterial";
            // 
            // ColCantidad
            // 
            this.ColCantidad.Caption = "Cantidad";
            this.ColCantidad.FieldName = "Cantidad";
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.Visible = true;
            this.ColCantidad.VisibleIndex = 1;
            // 
            // ColPrecio
            // 
            this.ColPrecio.Caption = "Precio";
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.Visible = true;
            this.ColPrecio.VisibleIndex = 2;
            // 
            // simpleButton5
            // 
            this.simpleButton5.ImageUri.Uri = "Clear;Office2013";
            this.simpleButton5.Location = new System.Drawing.Point(376, 138);
            this.simpleButton5.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(503, 38);
            this.simpleButton5.StyleController = this.layoutControl1;
            this.simpleButton5.TabIndex = 34;
            this.simpleButton5.Text = "Limpiar";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Enabled = false;
            this.simpleButton4.ImageUri.Uri = "Cancel;Office2013";
            this.simpleButton4.Location = new System.Drawing.Point(376, 96);
            this.simpleButton4.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(503, 38);
            this.simpleButton4.StyleController = this.layoutControl1;
            this.simpleButton4.TabIndex = 33;
            this.simpleButton4.Text = "Eliminar";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Enabled = false;
            this.simpleButton2.ImageUri.Uri = "Redo;Office2013";
            this.simpleButton2.Location = new System.Drawing.Point(376, 54);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(503, 38);
            this.simpleButton2.StyleController = this.layoutControl1;
            this.simpleButton2.TabIndex = 32;
            this.simpleButton2.Text = "Actualizar";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageUri.Uri = "Add;Size32x32;Office2013";
            this.simpleButton1.Location = new System.Drawing.Point(376, 12);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(503, 38);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 31;
            this.simpleButton1.Text = "Agregar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtIdCompra
            // 
            this.txtIdCompra.EditValue = "";
            this.txtIdCompra.Location = new System.Drawing.Point(112, 12);
            this.txtIdCompra.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdCompra.Name = "txtIdCompra";
            this.txtIdCompra.Size = new System.Drawing.Size(260, 20);
            this.txtIdCompra.StyleController = this.layoutControl1;
            this.txtIdCompra.TabIndex = 4;
            // 
            // dtaFechaOrden
            // 
            this.dtaFechaOrden.EditValue = null;
            this.dtaFechaOrden.Location = new System.Drawing.Point(112, 60);
            this.dtaFechaOrden.Margin = new System.Windows.Forms.Padding(2);
            this.dtaFechaOrden.Name = "dtaFechaOrden";
            this.dtaFechaOrden.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtaFechaOrden.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtaFechaOrden.Size = new System.Drawing.Size(260, 20);
            this.dtaFechaOrden.StyleController = this.layoutControl1;
            this.dtaFechaOrden.TabIndex = 24;
            // 
            // dtaFechaRecepcion
            // 
            this.dtaFechaRecepcion.EditValue = null;
            this.dtaFechaRecepcion.Location = new System.Drawing.Point(112, 84);
            this.dtaFechaRecepcion.Margin = new System.Windows.Forms.Padding(2);
            this.dtaFechaRecepcion.Name = "dtaFechaRecepcion";
            this.dtaFechaRecepcion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtaFechaRecepcion.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtaFechaRecepcion.Size = new System.Drawing.Size(260, 20);
            this.dtaFechaRecepcion.StyleController = this.layoutControl1;
            this.dtaFechaRecepcion.TabIndex = 24;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.campoUsuario,
            this.LciProveedor,
            this.layoutControlItem7,
            this.emptySpaceItem1,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem6,
            this.layoutControlItem13,
            this.emptySpaceItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(891, 598);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // campoUsuario
            // 
            this.campoUsuario.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.campoUsuario.Control = this.txtIdCompra;
            this.campoUsuario.CustomizationFormText = "ID de Usuario";
            this.campoUsuario.Location = new System.Drawing.Point(0, 0);
            this.campoUsuario.Name = "campoUsuario";
            this.campoUsuario.Size = new System.Drawing.Size(364, 24);
            this.campoUsuario.Text = "Id de Compra";
            this.campoUsuario.TextSize = new System.Drawing.Size(96, 13);
            // 
            // LciProveedor
            // 
            this.LciProveedor.Control = this.CmbProveedor;
            this.LciProveedor.CustomizationFormText = "Persona";
            this.LciProveedor.Location = new System.Drawing.Point(0, 24);
            this.LciProveedor.Name = "LciProveedor";
            this.LciProveedor.Size = new System.Drawing.Size(364, 24);
            this.LciProveedor.Text = "Proveedor";
            this.LciProveedor.TextSize = new System.Drawing.Size(96, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.dtaFechaOrden;
            this.layoutControlItem7.CustomizationFormText = "Fecha de Pedido";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(364, 24);
            this.layoutControlItem7.Text = "Fecha de Orden";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(96, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(861, 168);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(10, 410);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.simpleButton1;
            this.layoutControlItem4.Location = new System.Drawing.Point(364, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(507, 42);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButton2;
            this.layoutControlItem3.Location = new System.Drawing.Point(364, 42);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(507, 42);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.simpleButton4;
            this.layoutControlItem2.Location = new System.Drawing.Point(364, 84);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(507, 42);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.simpleButton5;
            this.layoutControlItem1.Location = new System.Drawing.Point(364, 126);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(507, 42);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.dtaFechaRecepcion;
            this.layoutControlItem6.CustomizationFormText = "Fecha de Pedido";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(364, 24);
            this.layoutControlItem6.Text = "Fecha de Recepción";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(96, 13);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.GcCompras;
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 168);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(861, 410);
            this.layoutControlItem13.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem13.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 96);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(364, 72);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // CmbProveedor
            // 
            this.CmbProveedor.Location = new System.Drawing.Point(112, 36);
            this.CmbProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.CmbProveedor.Name = "CmbProveedor";
            this.CmbProveedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbProveedor.Properties.NullText = "";
            this.CmbProveedor.Properties.View = this.gridLookUpEdit1View;
            this.CmbProveedor.Size = new System.Drawing.Size(260, 20);
            this.CmbProveedor.StyleController = this.layoutControl1;
            this.CmbProveedor.TabIndex = 5;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 598);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Compras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GcCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCompra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaFechaOrden.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaFechaOrden.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaFechaRecepcion.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaFechaRecepcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campoUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtIdCompra;
        private DevExpress.XtraEditors.DateEdit dtaFechaOrden;
        private DevExpress.XtraLayout.LayoutControlItem campoUsuario;
        private DevExpress.XtraLayout.LayoutControlItem LciProveedor;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.DateEdit dtaFechaRecepcion;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraGrid.GridControl GcCompras;
        private DevExpress.XtraGrid.Views.Grid.GridView GvCompras;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraGrid.Columns.GridColumn ColBase;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cmbBase;
        private DevExpress.XtraGrid.Columns.GridColumn ColCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn ColPrecio;
        private DevExpress.XtraEditors.GridLookUpEdit CmbProveedor;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
    }
}