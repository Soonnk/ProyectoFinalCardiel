namespace ProyectoFinal.Vistas
{
    partial class Pedidos
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
            this.GcDetallePedido = new DevExpress.XtraGrid.GridControl();
            this.GvDetallePedido = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColBase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CmbBase = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.GvCmbBase = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColBaseNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColBasePrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDesign = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CmbDesign = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.txtIdPedido = new DevExpress.XtraEditors.TextEdit();
            this.cmbIdCliente = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColClienteNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColClienteRfc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtpFecha = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.campoUsuario = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.LciCliente = new DevExpress.XtraLayout.LayoutControlItem();
            this.campoUsuario1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GcDetallePedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvDetallePedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvCmbBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbDesign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdPedido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIdCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campoUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campoUsuario1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.GcDetallePedido);
            this.layoutControl1.Controls.Add(this.simpleButton5);
            this.layoutControl1.Controls.Add(this.simpleButton4);
            this.layoutControl1.Controls.Add(this.BtnGuardar);
            this.layoutControl1.Controls.Add(this.txtIdPedido);
            this.layoutControl1.Controls.Add(this.cmbIdCliente);
            this.layoutControl1.Controls.Add(this.dtpFecha);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1189, 725);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // GcDetallePedido
            // 
            this.GcDetallePedido.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GcDetallePedido.Location = new System.Drawing.Point(16, 154);
            this.GcDetallePedido.MainView = this.GvDetallePedido;
            this.GcDetallePedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GcDetallePedido.Name = "GcDetallePedido";
            this.GcDetallePedido.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.CmbBase,
            this.CmbDesign});
            this.GcDetallePedido.Size = new System.Drawing.Size(1157, 555);
            this.GcDetallePedido.TabIndex = 23;
            this.GcDetallePedido.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GvDetallePedido});
            // 
            // GvDetallePedido
            // 
            this.GvDetallePedido.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColBase,
            this.ColDesign,
            this.ColCantidad,
            this.ColPrecio});
            this.GvDetallePedido.GridControl = this.GcDetallePedido;
            this.GvDetallePedido.Name = "GvDetallePedido";
            this.GvDetallePedido.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.GvDetallePedido.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.GvDetallePedido.OptionsView.ShowGroupPanel = false;
            // 
            // ColBase
            // 
            this.ColBase.Caption = "Base";
            this.ColBase.ColumnEdit = this.CmbBase;
            this.ColBase.FieldName = "Material";
            this.ColBase.Name = "ColBase";
            this.ColBase.Visible = true;
            this.ColBase.VisibleIndex = 0;
            // 
            // CmbBase
            // 
            this.CmbBase.AutoHeight = false;
            this.CmbBase.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbBase.DisplayMember = "Descripcion";
            this.CmbBase.Name = "CmbBase";
            this.CmbBase.SuppressMouseEventOnOuterMouseClick = true;
            this.CmbBase.ValueMember = "IdMaterial";
            this.CmbBase.View = this.GvCmbBase;
            // 
            // GvCmbBase
            // 
            this.GvCmbBase.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColBaseNombre,
            this.ColBasePrecio});
            this.GvCmbBase.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.GvCmbBase.Name = "GvCmbBase";
            this.GvCmbBase.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GvCmbBase.OptionsView.ShowAutoFilterRow = true;
            this.GvCmbBase.OptionsView.ShowGroupPanel = false;
            // 
            // ColBaseNombre
            // 
            this.ColBaseNombre.Caption = "Nombre";
            this.ColBaseNombre.DisplayFormat.FormatString = "n2";
            this.ColBaseNombre.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ColBaseNombre.FieldName = "Descripcion";
            this.ColBaseNombre.Name = "ColBaseNombre";
            this.ColBaseNombre.Visible = true;
            this.ColBaseNombre.VisibleIndex = 0;
            this.ColBaseNombre.Width = 613;
            // 
            // ColBasePrecio
            // 
            this.ColBasePrecio.Caption = "Precio";
            this.ColBasePrecio.FieldName = "Costo";
            this.ColBasePrecio.Name = "ColBasePrecio";
            this.ColBasePrecio.Visible = true;
            this.ColBasePrecio.VisibleIndex = 1;
            this.ColBasePrecio.Width = 211;
            // 
            // ColDesign
            // 
            this.ColDesign.Caption = "Diseño";
            this.ColDesign.ColumnEdit = this.CmbDesign;
            this.ColDesign.FieldName = "Design";
            this.ColDesign.Name = "ColDesign";
            this.ColDesign.Visible = true;
            this.ColDesign.VisibleIndex = 1;
            // 
            // CmbDesign
            // 
            this.CmbDesign.AutoHeight = false;
            this.CmbDesign.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbDesign.DisplayMember = "Descripcion";
            this.CmbDesign.Name = "CmbDesign";
            this.CmbDesign.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.StartsWith;
            this.CmbDesign.ValueMember = "IdDesign";
            this.CmbDesign.View = this.repositoryItemGridLookUpEdit2View;
            // 
            // repositoryItemGridLookUpEdit2View
            // 
            this.repositoryItemGridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.repositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit2View.Name = "repositoryItemGridLookUpEdit2View";
            this.repositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Diseño";
            this.gridColumn1.FieldName = "Descripcion";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // ColCantidad
            // 
            this.ColCantidad.Caption = "Cantidad";
            this.ColCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ColCantidad.FieldName = "Cantidad";
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.Visible = true;
            this.ColCantidad.VisibleIndex = 2;
            // 
            // ColPrecio
            // 
            this.ColPrecio.Caption = "Precio";
            this.ColPrecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ColPrecio.FieldName = "Precio";
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.Visible = true;
            this.ColPrecio.VisibleIndex = 3;
            // 
            // simpleButton5
            // 
            this.simpleButton5.ImageUri.Uri = "Clear;Office2013";
            this.simpleButton5.Location = new System.Drawing.Point(487, 108);
            this.simpleButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(686, 40);
            this.simpleButton5.StyleController = this.layoutControl1;
            this.simpleButton5.TabIndex = 21;
            this.simpleButton5.Text = "Limpiar";
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageUri.Uri = "Cancel;Office2013";
            this.simpleButton4.Location = new System.Drawing.Point(487, 62);
            this.simpleButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(686, 40);
            this.simpleButton4.StyleController = this.layoutControl1;
            this.simpleButton4.TabIndex = 20;
            this.simpleButton4.Text = "Eliminar";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Image = global::ProyectoFinal.Properties.Resources.save_32x32;
            this.BtnGuardar.ImageUri.Uri = "Add;Size32x32;Office2013";
            this.BtnGuardar.Location = new System.Drawing.Point(487, 16);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(686, 40);
            this.BtnGuardar.StyleController = this.layoutControl1;
            this.BtnGuardar.TabIndex = 18;
            this.BtnGuardar.Text = "Agregar";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.EditValue = "";
            this.txtIdPedido.Location = new System.Drawing.Point(92, 16);
            this.txtIdPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(389, 22);
            this.txtIdPedido.StyleController = this.layoutControl1;
            this.txtIdPedido.TabIndex = 4;
            // 
            // cmbIdCliente
            // 
            this.cmbIdCliente.Location = new System.Drawing.Point(92, 44);
            this.cmbIdCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbIdCliente.Name = "cmbIdCliente";
            this.cmbIdCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbIdCliente.Properties.DisplayMember = "Nombre";
            this.cmbIdCliente.Properties.NullText = "";
            this.cmbIdCliente.Properties.ValueMember = "IdCliente";
            this.cmbIdCliente.Properties.View = this.gridLookUpEdit1View;
            this.cmbIdCliente.Size = new System.Drawing.Size(389, 22);
            this.cmbIdCliente.StyleController = this.layoutControl1;
            this.cmbIdCliente.TabIndex = 5;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColClienteNombre,
            this.ColClienteRfc});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ColClienteNombre
            // 
            this.ColClienteNombre.Caption = "Nombre";
            this.ColClienteNombre.FieldName = "Nombre";
            this.ColClienteNombre.Name = "ColClienteNombre";
            this.ColClienteNombre.Visible = true;
            this.ColClienteNombre.VisibleIndex = 0;
            this.ColClienteNombre.Width = 647;
            // 
            // ColClienteRfc
            // 
            this.ColClienteRfc.Caption = "RFC";
            this.ColClienteRfc.FieldName = "RFC";
            this.ColClienteRfc.Name = "ColClienteRfc";
            this.ColClienteRfc.Visible = true;
            this.ColClienteRfc.VisibleIndex = 1;
            this.ColClienteRfc.Width = 177;
            // 
            // dtpFecha
            // 
            this.dtpFecha.EditValue = "";
            this.dtpFecha.Location = new System.Drawing.Point(92, 72);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFecha.Properties.DisplayFormat.FormatString = "";
            this.dtpFecha.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpFecha.Properties.EditFormat.FormatString = "";
            this.dtpFecha.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpFecha.Properties.Mask.EditMask = "";
            this.dtpFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dtpFecha.Size = new System.Drawing.Size(389, 22);
            this.dtpFecha.StyleController = this.layoutControl1;
            this.dtpFecha.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.campoUsuario,
            this.layoutControlItem1,
            this.layoutControlItem6,
            this.layoutControlItem4,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.LciCliente,
            this.campoUsuario1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1189, 725);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // campoUsuario
            // 
            this.campoUsuario.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.campoUsuario.Control = this.txtIdPedido;
            this.campoUsuario.CustomizationFormText = "ID de Usuario";
            this.campoUsuario.Location = new System.Drawing.Point(0, 0);
            this.campoUsuario.Name = "campoUsuario";
            this.campoUsuario.Size = new System.Drawing.Size(471, 28);
            this.campoUsuario.Text = "ID de Pedido";
            this.campoUsuario.TextSize = new System.Drawing.Size(72, 16);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.simpleButton5;
            this.layoutControlItem1.Location = new System.Drawing.Point(471, 92);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(692, 46);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.GcDetallePedido;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 138);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(1163, 561);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.BtnGuardar;
            this.layoutControlItem4.Location = new System.Drawing.Point(471, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(692, 46);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.simpleButton4;
            this.layoutControlItem2.Location = new System.Drawing.Point(471, 46);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(692, 46);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 84);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(471, 54);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // LciCliente
            // 
            this.LciCliente.Control = this.cmbIdCliente;
            this.LciCliente.CustomizationFormText = "Persona";
            this.LciCliente.Location = new System.Drawing.Point(0, 28);
            this.LciCliente.Name = "LciCliente";
            this.LciCliente.Size = new System.Drawing.Size(471, 28);
            this.LciCliente.Text = "Id Cliente";
            this.LciCliente.TextSize = new System.Drawing.Size(72, 16);
            // 
            // campoUsuario1
            // 
            this.campoUsuario1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.campoUsuario1.Control = this.dtpFecha;
            this.campoUsuario1.CustomizationFormText = "ID de Usuario";
            this.campoUsuario1.Location = new System.Drawing.Point(0, 56);
            this.campoUsuario1.Name = "campoUsuario1";
            this.campoUsuario1.Size = new System.Drawing.Size(471, 28);
            this.campoUsuario1.Text = "Fecha";
            this.campoUsuario1.TextSize = new System.Drawing.Size(72, 16);
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 725);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GcDetallePedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvDetallePedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvCmbBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbDesign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdPedido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIdCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campoUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campoUsuario1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtIdPedido;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem campoUsuario;
        private DevExpress.XtraLayout.LayoutControlItem LciCliente;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton BtnGuardar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.GridControl GcDetallePedido;
        private DevExpress.XtraGrid.Views.Grid.GridView GvDetallePedido;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraGrid.Columns.GridColumn ColBase;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit CmbBase;
        private DevExpress.XtraGrid.Views.Grid.GridView GvCmbBase;
        private DevExpress.XtraGrid.Columns.GridColumn ColDesign;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit CmbDesign;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn ColCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn ColPrecio;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.GridLookUpEdit cmbIdCliente;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn ColClienteNombre;
        private DevExpress.XtraGrid.Columns.GridColumn ColClienteRfc;
        private DevExpress.XtraGrid.Columns.GridColumn ColBaseNombre;
        private DevExpress.XtraGrid.Columns.GridColumn ColBasePrecio;
        private DevExpress.XtraEditors.DateEdit dtpFecha;
        private DevExpress.XtraLayout.LayoutControlItem campoUsuario1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}