namespace ProyectoFinal.Vistas
{
    partial class ViewDesign
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
            this.BtnDescargar = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.TxtNombre = new DevExpress.XtraEditors.TextEdit();
            this.GcDesigns = new DevExpress.XtraGrid.GridControl();
            this.GvDesigns = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GcDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BtnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.PicturBoxDesign = new DevExpress.XtraEditors.PictureEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.FileDialogSvg = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GcDesigns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvDesigns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicturBoxDesign.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.BtnDescargar);
            this.layoutControl1.Controls.Add(this.BtnNuevo);
            this.layoutControl1.Controls.Add(this.TxtNombre);
            this.layoutControl1.Controls.Add(this.GcDesigns);
            this.layoutControl1.Controls.Add(this.BtnCancelar);
            this.layoutControl1.Controls.Add(this.BtnAceptar);
            this.layoutControl1.Controls.Add(this.PicturBoxDesign);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(584, 413);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // BtnDescargar
            // 
            this.BtnDescargar.Image = global::ProyectoFinal.Properties.Resources.download_16x16;
            this.BtnDescargar.Location = new System.Drawing.Point(12, 278);
            this.BtnDescargar.Name = "BtnDescargar";
            this.BtnDescargar.Size = new System.Drawing.Size(122, 22);
            this.BtnDescargar.StyleController = this.layoutControl1;
            this.BtnDescargar.TabIndex = 10;
            this.BtnDescargar.Text = "Descargar";
            this.BtnDescargar.Click += new System.EventHandler(this.BtnDescargar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Image = global::ProyectoFinal.Properties.Resources.add_16x16;
            this.BtnNuevo.Location = new System.Drawing.Point(198, 12);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(63, 22);
            this.BtnNuevo.StyleController = this.layoutControl1;
            this.BtnNuevo.TabIndex = 9;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(52, 12);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(142, 20);
            this.TxtNombre.StyleController = this.layoutControl1;
            this.TxtNombre.TabIndex = 8;
            this.TxtNombre.EditValueChanged += new System.EventHandler(this.TxtNombre_EditValueChanged);
            // 
            // GcDesigns
            // 
            this.GcDesigns.Location = new System.Drawing.Point(265, 12);
            this.GcDesigns.MainView = this.GvDesigns;
            this.GcDesigns.Name = "GcDesigns";
            this.GcDesigns.Size = new System.Drawing.Size(307, 389);
            this.GcDesigns.TabIndex = 7;
            this.GcDesigns.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GvDesigns});
            // 
            // GvDesigns
            // 
            this.GvDesigns.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GcDescripcion});
            this.GvDesigns.GridControl = this.GcDesigns;
            this.GvDesigns.Name = "GvDesigns";
            this.GvDesigns.OptionsBehavior.Editable = false;
            this.GvDesigns.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GvDesigns_RowClick);
            // 
            // GcDescripcion
            // 
            this.GcDescripcion.Caption = "Nombre";
            this.GcDescripcion.FieldName = "Descripcion";
            this.GcDescripcion.Name = "GcDescripcion";
            this.GcDescripcion.Visible = true;
            this.GcDescripcion.VisibleIndex = 0;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(143, 242);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(118, 22);
            this.BtnCancelar.StyleController = this.layoutControl1;
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(12, 242);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(127, 22);
            this.BtnAceptar.StyleController = this.layoutControl1;
            this.BtnAceptar.TabIndex = 5;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // PicturBoxDesign
            // 
            this.PicturBoxDesign.Cursor = System.Windows.Forms.Cursors.Default;
            this.PicturBoxDesign.EditValue = global::ProyectoFinal.Properties.Resources.add_32x32;
            this.PicturBoxDesign.Location = new System.Drawing.Point(12, 38);
            this.PicturBoxDesign.Name = "PicturBoxDesign";
            this.PicturBoxDesign.Properties.InitialImage = global::ProyectoFinal.Properties.Resources.add_32x32;
            this.PicturBoxDesign.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.PicturBoxDesign.Properties.ZoomAccelerationFactor = 1D;
            this.PicturBoxDesign.Size = new System.Drawing.Size(249, 200);
            this.PicturBoxDesign.StyleController = this.layoutControl1;
            this.PicturBoxDesign.TabIndex = 4;
            this.PicturBoxDesign.Click += new System.EventHandler(this.PicturBoxDesign_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem1,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.emptySpaceItem2,
            this.layoutControlItem7,
            this.emptySpaceItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(584, 413);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.PicturBoxDesign;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(253, 204);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.BtnAceptar;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 230);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(131, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.BtnCancelar;
            this.layoutControlItem3.Location = new System.Drawing.Point(131, 230);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(122, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.GcDesigns;
            this.layoutControlItem4.Location = new System.Drawing.Point(253, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(311, 393);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 292);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(253, 101);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.TxtNombre;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(186, 26);
            this.layoutControlItem5.Text = "Nombre";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(37, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.BtnNuevo;
            this.layoutControlItem6.Location = new System.Drawing.Point(186, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(67, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(126, 266);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(127, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.BtnDescargar;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 266);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(126, 26);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 256);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(253, 10);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // FileDialogSvg
            // 
            this.FileDialogSvg.Title = "Selecciona archivo";
            this.FileDialogSvg.FileOk += new System.ComponentModel.CancelEventHandler(this.FileDialogSvg_FileOk);
            // 
            // ViewDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 413);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ViewDesign";
            this.Text = "ViewDesign";
            this.Load += new System.EventHandler(this.ViewDesign_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GcDesigns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvDesigns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicturBoxDesign.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit TxtNombre;
        private DevExpress.XtraGrid.GridControl GcDesigns;
        private DevExpress.XtraGrid.Views.Grid.GridView GvDesigns;
        private DevExpress.XtraEditors.SimpleButton BtnCancelar;
        private DevExpress.XtraEditors.SimpleButton BtnAceptar;
        private DevExpress.XtraEditors.PictureEdit PicturBoxDesign;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.OpenFileDialog FileDialogSvg;
        private DevExpress.XtraEditors.SimpleButton BtnNuevo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraGrid.Columns.GridColumn GcDescripcion;
        private DevExpress.XtraEditors.SimpleButton BtnDescargar;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
    }
}