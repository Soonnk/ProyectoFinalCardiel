namespace ProyectoFinal.Vistas
{
    partial class Pedido
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
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txtPersona = new DevExpress.XtraEditors.TextEdit();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.txtIdUsuario = new DevExpress.XtraEditors.TextEdit();
            this.cmbNivelUsuario = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtDepartamento = new DevExpress.XtraEditors.TextEdit();
            this.txtContrasenia = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersona.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNivelUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContrasenia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtIdUsuario);
            this.layoutControl1.Controls.Add(this.txtPersona);
            this.layoutControl1.Controls.Add(this.txtUsername);
            this.layoutControl1.Controls.Add(this.txtContrasenia);
            this.layoutControl1.Controls.Add(this.txtDepartamento);
            this.layoutControl1.Controls.Add(this.cmbNivelUsuario);
            this.layoutControl1.Location = new System.Drawing.Point(4, 7);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1146, 728);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1146, 728);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // txtPersona
            // 
            this.txtPersona.Location = new System.Drawing.Point(98, 44);
            this.txtPersona.Name = "txtPersona";
            this.txtPersona.Size = new System.Drawing.Size(1032, 22);
            this.txtPersona.StyleController = this.layoutControl1;
            this.txtPersona.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(98, 72);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(1032, 22);
            this.txtUsername.StyleController = this.layoutControl1;
            this.txtUsername.TabIndex = 6;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.EditValue = "";
            this.txtIdUsuario.Location = new System.Drawing.Point(98, 16);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(1032, 22);
            this.txtIdUsuario.StyleController = this.layoutControl1;
            this.txtIdUsuario.TabIndex = 4;
            // 
            // cmbNivelUsuario
            // 
            this.cmbNivelUsuario.Location = new System.Drawing.Point(102, 128);
            this.cmbNivelUsuario.Name = "cmbNivelUsuario";
            this.cmbNivelUsuario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbNivelUsuario.Properties.View = this.gridView1;
            this.cmbNivelUsuario.Size = new System.Drawing.Size(1028, 22);
            this.cmbNivelUsuario.StyleController = this.layoutControl1;
            this.cmbNivelUsuario.TabIndex = 17;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(102, 128);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(1028, 22);
            this.txtDepartamento.StyleController = this.layoutControl1;
            this.txtDepartamento.TabIndex = 9;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(98, 100);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(1032, 22);
            this.txtContrasenia.StyleController = this.layoutControl1;
            this.txtContrasenia.TabIndex = 7;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtIdUsuario;
            this.layoutControlItem1.CustomizationFormText = "ID de Usuario";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "campoUsuario";
            this.layoutControlItem1.Size = new System.Drawing.Size(1120, 702);
            this.layoutControlItem1.Text = "ID de Usuario";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(77, 16);
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 739);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Pedido";
            this.Text = "Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersona.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNivelUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContrasenia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtIdUsuario;
        private DevExpress.XtraEditors.TextEdit txtPersona;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.TextEdit txtContrasenia;
        private DevExpress.XtraEditors.TextEdit txtDepartamento;
        private DevExpress.XtraEditors.GridLookUpEdit cmbNivelUsuario;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}