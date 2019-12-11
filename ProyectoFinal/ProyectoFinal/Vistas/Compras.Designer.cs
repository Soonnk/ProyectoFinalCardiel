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
            this.TxtTotal = new DevExpress.XtraEditors.TextEdit();
            this.GcCompras = new DevExpress.XtraGrid.GridControl();
            this.GvCompras = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColMaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbMaterial = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ColCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColImporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BtnLimpiar = new DevExpress.XtraEditors.SimpleButton();
            this.BtnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEntregado = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.txtIdCompra = new DevExpress.XtraEditors.TextEdit();
            this.DtpFechaOrden = new DevExpress.XtraEditors.DateEdit();
            this.DtpFechaRecepcion = new DevExpress.XtraEditors.DateEdit();
            this.CmbProveedor = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.campoUsuario = new DevExpress.XtraLayout.LayoutControlItem();
            this.LciProveedor = new DevExpress.XtraLayout.LayoutControlItem();
            this.LciFechaOrden = new DevExpress.XtraLayout.LayoutControlItem();
            this.LciGuardar = new DevExpress.XtraLayout.LayoutControlItem();
            this.LciEntregar = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.LciFechaRecepcion = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.LciTotal = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GcCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCompra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaOrden.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaOrden.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaRecepcion.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaRecepcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campoUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciFechaOrden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciEntregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciFechaRecepcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.TxtTotal);
            this.layoutControl1.Controls.Add(this.GcCompras);
            this.layoutControl1.Controls.Add(this.BtnLimpiar);
            this.layoutControl1.Controls.Add(this.BtnCancelar);
            this.layoutControl1.Controls.Add(this.BtnEntregado);
            this.layoutControl1.Controls.Add(this.BtnGuardar);
            this.layoutControl1.Controls.Add(this.txtIdCompra);
            this.layoutControl1.Controls.Add(this.DtpFechaOrden);
            this.layoutControl1.Controls.Add(this.DtpFechaRecepcion);
            this.layoutControl1.Controls.Add(this.CmbProveedor);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1188, 736);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(894, 698);
            this.TxtTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Properties.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(278, 22);
            this.TxtTotal.StyleController = this.layoutControl1;
            this.TxtTotal.TabIndex = 37;
            // 
            // GcCompras
            // 
            this.GcCompras.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GcCompras.Location = new System.Drawing.Point(16, 200);
            this.GcCompras.MainView = this.GvCompras;
            this.GcCompras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GcCompras.Name = "GcCompras";
            this.GcCompras.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbMaterial});
            this.GcCompras.Size = new System.Drawing.Size(1156, 492);
            this.GcCompras.TabIndex = 36;
            this.GcCompras.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GvCompras});
            this.GcCompras.Layout += new System.Windows.Forms.LayoutEventHandler(this.GcCompras_Layout);
            // 
            // GvCompras
            // 
            this.GvCompras.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColMaterial,
            this.ColCantidad,
            this.ColImporte,
            this.ColPrecio});
            this.GvCompras.GridControl = this.GcCompras;
            this.GvCompras.Name = "GvCompras";
            this.GvCompras.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.GvCompras.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.GvCompras.OptionsView.ShowAutoFilterRow = true;
            this.GvCompras.OptionsView.ShowGroupPanel = false;
            // 
            // ColMaterial
            // 
            this.ColMaterial.Caption = "Producto";
            this.ColMaterial.ColumnEdit = this.cmbMaterial;
            this.ColMaterial.FieldName = "Material";
            this.ColMaterial.Name = "ColMaterial";
            this.ColMaterial.Visible = true;
            this.ColMaterial.VisibleIndex = 0;
            this.ColMaterial.Width = 330;
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.AutoHeight = false;
            this.cmbMaterial.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMaterial.DisplayMember = "Descripcion";
            this.cmbMaterial.KeyMember = "Descripcion";
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.ValueMember = "IdMaterial";
            // 
            // ColCantidad
            // 
            this.ColCantidad.Caption = "Cantidad";
            this.ColCantidad.FieldName = "Cantidad";
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.Visible = true;
            this.ColCantidad.VisibleIndex = 1;
            this.ColCantidad.Width = 168;
            // 
            // ColImporte
            // 
            this.ColImporte.Caption = "Importe";
            this.ColImporte.FieldName = "Importe";
            this.ColImporte.Name = "ColImporte";
            this.ColImporte.Visible = true;
            this.ColImporte.VisibleIndex = 3;
            this.ColImporte.Width = 149;
            // 
            // ColPrecio
            // 
            this.ColPrecio.Caption = "Precio";
            this.ColPrecio.FieldName = "Precio";
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.Visible = true;
            this.ColPrecio.VisibleIndex = 2;
            this.ColPrecio.Width = 192;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.ImageUri.Uri = "Clear;Office2013";
            this.BtnLimpiar.Location = new System.Drawing.Point(502, 154);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(670, 40);
            this.BtnLimpiar.StyleController = this.layoutControl1;
            this.BtnLimpiar.TabIndex = 34;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.ImageUri.Uri = "Cancel;Office2013";
            this.BtnCancelar.Location = new System.Drawing.Point(502, 108);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(670, 40);
            this.BtnCancelar.StyleController = this.layoutControl1;
            this.BtnCancelar.TabIndex = 33;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // BtnEntregado
            // 
            this.BtnEntregado.ImageUri.Uri = "Apply;Office2013";
            this.BtnEntregado.Location = new System.Drawing.Point(502, 62);
            this.BtnEntregado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEntregado.Name = "BtnEntregado";
            this.BtnEntregado.Size = new System.Drawing.Size(670, 40);
            this.BtnEntregado.StyleController = this.layoutControl1;
            this.BtnEntregado.TabIndex = 32;
            this.BtnEntregado.Text = "Marcar Como Entregado";
            this.BtnEntregado.Click += new System.EventHandler(this.BtnEntregado_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.ImageUri.Uri = "Save;Size32x32;Office2013";
            this.BtnGuardar.Location = new System.Drawing.Point(502, 16);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(670, 40);
            this.BtnGuardar.StyleController = this.layoutControl1;
            this.BtnGuardar.TabIndex = 31;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // txtIdCompra
            // 
            this.txtIdCompra.EditValue = "";
            this.txtIdCompra.Location = new System.Drawing.Point(134, 16);
            this.txtIdCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdCompra.Name = "txtIdCompra";
            this.txtIdCompra.Properties.ReadOnly = true;
            this.txtIdCompra.Size = new System.Drawing.Size(362, 22);
            this.txtIdCompra.StyleController = this.layoutControl1;
            this.txtIdCompra.TabIndex = 4;
            // 
            // DtpFechaOrden
            // 
            this.DtpFechaOrden.EditValue = null;
            this.DtpFechaOrden.Location = new System.Drawing.Point(134, 72);
            this.DtpFechaOrden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtpFechaOrden.Name = "DtpFechaOrden";
            this.DtpFechaOrden.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtpFechaOrden.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtpFechaOrden.Size = new System.Drawing.Size(362, 22);
            this.DtpFechaOrden.StyleController = this.layoutControl1;
            this.DtpFechaOrden.TabIndex = 24;
            // 
            // DtpFechaRecepcion
            // 
            this.DtpFechaRecepcion.EditValue = null;
            this.DtpFechaRecepcion.Location = new System.Drawing.Point(134, 100);
            this.DtpFechaRecepcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtpFechaRecepcion.Name = "DtpFechaRecepcion";
            this.DtpFechaRecepcion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtpFechaRecepcion.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtpFechaRecepcion.Size = new System.Drawing.Size(362, 22);
            this.DtpFechaRecepcion.StyleController = this.layoutControl1;
            this.DtpFechaRecepcion.TabIndex = 24;
            // 
            // CmbProveedor
            // 
            this.CmbProveedor.Location = new System.Drawing.Point(134, 44);
            this.CmbProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbProveedor.Name = "CmbProveedor";
            this.CmbProveedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbProveedor.Properties.DisplayMember = "Nombre";
            this.CmbProveedor.Properties.NullText = "";
            this.CmbProveedor.Properties.ValueMember = "IdProveedor";
            this.CmbProveedor.Properties.View = this.gridLookUpEdit1View;
            this.CmbProveedor.Size = new System.Drawing.Size(362, 22);
            this.CmbProveedor.StyleController = this.layoutControl1;
            this.CmbProveedor.TabIndex = 5;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColNombre});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ColNombre
            // 
            this.ColNombre.Caption = "Nombre";
            this.ColNombre.FieldName = "Nombre";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.Visible = true;
            this.ColNombre.VisibleIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.campoUsuario,
            this.LciProveedor,
            this.LciFechaOrden,
            this.LciGuardar,
            this.LciEntregar,
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.LciFechaRecepcion,
            this.layoutControlItem13,
            this.emptySpaceItem2,
            this.LciTotal,
            this.emptySpaceItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1188, 736);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // campoUsuario
            // 
            this.campoUsuario.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.campoUsuario.Control = this.txtIdCompra;
            this.campoUsuario.CustomizationFormText = "ID de Usuario";
            this.campoUsuario.Location = new System.Drawing.Point(0, 0);
            this.campoUsuario.Name = "campoUsuario";
            this.campoUsuario.Size = new System.Drawing.Size(486, 28);
            this.campoUsuario.Text = "Id de Compra";
            this.campoUsuario.TextSize = new System.Drawing.Size(114, 16);
            // 
            // LciProveedor
            // 
            this.LciProveedor.Control = this.CmbProveedor;
            this.LciProveedor.CustomizationFormText = "Persona";
            this.LciProveedor.Location = new System.Drawing.Point(0, 28);
            this.LciProveedor.Name = "LciProveedor";
            this.LciProveedor.Size = new System.Drawing.Size(486, 28);
            this.LciProveedor.Text = "Proveedor";
            this.LciProveedor.TextSize = new System.Drawing.Size(114, 16);
            // 
            // LciFechaOrden
            // 
            this.LciFechaOrden.Control = this.DtpFechaOrden;
            this.LciFechaOrden.CustomizationFormText = "Fecha de Pedido";
            this.LciFechaOrden.Location = new System.Drawing.Point(0, 56);
            this.LciFechaOrden.Name = "LciFechaOrden";
            this.LciFechaOrden.Size = new System.Drawing.Size(486, 28);
            this.LciFechaOrden.Text = "Fecha de Orden";
            this.LciFechaOrden.TextSize = new System.Drawing.Size(114, 16);
            // 
            // LciGuardar
            // 
            this.LciGuardar.Control = this.BtnGuardar;
            this.LciGuardar.Location = new System.Drawing.Point(486, 0);
            this.LciGuardar.Name = "LciGuardar";
            this.LciGuardar.Size = new System.Drawing.Size(676, 46);
            this.LciGuardar.TextSize = new System.Drawing.Size(0, 0);
            this.LciGuardar.TextVisible = false;
            // 
            // LciEntregar
            // 
            this.LciEntregar.Control = this.BtnEntregado;
            this.LciEntregar.Location = new System.Drawing.Point(486, 46);
            this.LciEntregar.Name = "LciEntregar";
            this.LciEntregar.Size = new System.Drawing.Size(676, 46);
            this.LciEntregar.TextSize = new System.Drawing.Size(0, 0);
            this.LciEntregar.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.BtnCancelar;
            this.layoutControlItem2.Location = new System.Drawing.Point(486, 92);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(676, 46);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.BtnLimpiar;
            this.layoutControlItem1.Location = new System.Drawing.Point(486, 138);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(676, 46);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // LciFechaRecepcion
            // 
            this.LciFechaRecepcion.Control = this.DtpFechaRecepcion;
            this.LciFechaRecepcion.CustomizationFormText = "Fecha de Pedido";
            this.LciFechaRecepcion.Location = new System.Drawing.Point(0, 84);
            this.LciFechaRecepcion.Name = "LciFechaRecepcion";
            this.LciFechaRecepcion.Size = new System.Drawing.Size(486, 28);
            this.LciFechaRecepcion.Text = "Fecha de Recepción";
            this.LciFechaRecepcion.TextSize = new System.Drawing.Size(114, 16);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.GcCompras;
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 184);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(1162, 498);
            this.layoutControlItem13.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem13.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 112);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(486, 72);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // LciTotal
            // 
            this.LciTotal.Control = this.TxtTotal;
            this.LciTotal.Location = new System.Drawing.Point(760, 682);
            this.LciTotal.Name = "LciTotal";
            this.LciTotal.Size = new System.Drawing.Size(402, 28);
            this.LciTotal.Text = "Total";
            this.LciTotal.TextSize = new System.Drawing.Size(114, 16);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 682);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(760, 28);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 736);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Compras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GcCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCompra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaOrden.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaOrden.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaRecepcion.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaRecepcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campoUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciFechaOrden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciEntregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciFechaRecepcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtIdCompra;
        private DevExpress.XtraEditors.DateEdit DtpFechaOrden;
        private DevExpress.XtraLayout.LayoutControlItem campoUsuario;
        private DevExpress.XtraLayout.LayoutControlItem LciProveedor;
        private DevExpress.XtraLayout.LayoutControlItem LciFechaOrden;
        private DevExpress.XtraEditors.SimpleButton BtnLimpiar;
        private DevExpress.XtraEditors.SimpleButton BtnCancelar;
        private DevExpress.XtraEditors.SimpleButton BtnEntregado;
        private DevExpress.XtraEditors.SimpleButton BtnGuardar;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem LciEntregar;
        private DevExpress.XtraLayout.LayoutControlItem LciGuardar;
        private DevExpress.XtraEditors.DateEdit DtpFechaRecepcion;
        private DevExpress.XtraLayout.LayoutControlItem LciFechaRecepcion;
        private DevExpress.XtraGrid.GridControl GcCompras;
        private DevExpress.XtraGrid.Views.Grid.GridView GvCompras;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraGrid.Columns.GridColumn ColMaterial;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cmbMaterial;
        private DevExpress.XtraGrid.Columns.GridColumn ColCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn ColPrecio;
        private DevExpress.XtraEditors.GridLookUpEdit CmbProveedor;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn ColImporte;
        private DevExpress.XtraEditors.TextEdit TxtTotal;
        private DevExpress.XtraLayout.LayoutControlItem LciTotal;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraGrid.Columns.GridColumn ColNombre;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}