using telas.util.layout;
namespace telas.estoque
{
    partial class frmClientes : frmBase
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
            this.gdvTabela = new DevExpress.XtraGrid.GridControl();
            this.gridTabela = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatricula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCelular = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFiltros.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOpcoes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesquisa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPanel)).BeginInit();
            this.tabPanel.SuspendLayout();
            this.tabConsulta.SuspendLayout();
            this.tabCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTabela)).BeginInit();
            this.pnlTabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloCadastro
            // 
            this.lblTituloCadastro.Appearance.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCadastro.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTituloCadastro.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.lblTituloCadastro.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            // 
            // cmbFiltros
            // 
            this.cmbFiltros.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbFiltros.Properties.Appearance.Options.UseFont = true;
            this.cmbFiltros.Properties.Items.AddRange(new object[] {
            "Matricula",
            "Nome"});
            // 
            // cmbOpcoes
            // 
            this.cmbOpcoes.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbOpcoes.Properties.Appearance.Options.UseFont = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtPesquisa.Properties.Appearance.BackColor2 = System.Drawing.Color.White;
            this.txtPesquisa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtPesquisa.Properties.Appearance.Options.UseBackColor = true;
            this.txtPesquisa.Properties.Appearance.Options.UseBorderColor = true;
            this.txtPesquisa.Properties.Appearance.Options.UseFont = true;
            this.txtPesquisa.Properties.Appearance.Options.UseForeColor = true;
            // 
            // tabPanel
            // 
            this.tabPanel.AppearancePage.Header.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tabPanel.AppearancePage.Header.Options.UseFont = true;
            this.tabPanel.SelectedTabPage = this.tabConsulta;
            // 
            // tabConsulta
            // 
            this.tabConsulta.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabConsulta.Appearance.Header.Options.UseFont = true;
            this.tabConsulta.Appearance.PageClient.BackColor = System.Drawing.Color.Black;
            this.tabConsulta.Appearance.PageClient.Options.UseBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Appearance.Options.UseFont = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Appearance.Options.UseFont = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Appearance.Options.UseFont = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            // 
            // btnCancelarPesquisa
            // 
            this.btnCancelarPesquisa.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPesquisa.Appearance.Options.UseFont = true;
            this.btnCancelarPesquisa.LookAndFeel.SkinName = "Seven Classic";
            // 
            // pnlTabela
            // 
            this.pnlTabela.Controls.Add(this.gdvTabela);
            // 
            // panel
            // 
            this.panel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panel.Appearance.Options.UseBackColor = true;
            // 
            // lblTituloPesquisa
            // 
            this.lblTituloPesquisa.Appearance.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPesquisa.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTituloPesquisa.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.lblTituloPesquisa.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            // 
            // styleController1
            // 
            this.styleController1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleController1.Appearance.Options.UseFont = true;
            this.styleController1.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleController1.AppearanceDisabled.Options.UseFont = true;
            // 
            // gdvTabela
            // 
            this.gdvTabela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdvTabela.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gdvTabela.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gdvTabela.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gdvTabela.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gdvTabela.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gdvTabela.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gdvTabela.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gdvTabela.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gdvTabela.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gdvTabela.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gdvTabela.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gdvTabela.Location = new System.Drawing.Point(2, 2);
            this.gdvTabela.MainView = this.gridTabela;
            this.gdvTabela.Name = "gdvTabela";
            this.gdvTabela.Size = new System.Drawing.Size(952, 469);
            this.gdvTabela.TabIndex = 29;
            this.gdvTabela.UseEmbeddedNavigator = true;
            this.gdvTabela.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridTabela});
            this.gdvTabela.DoubleClick += new System.EventHandler(this.gdvTabela_DoubleClick);
            // 
            // gridTabela
            // 
            this.gridTabela.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridTabela.Appearance.Empty.Options.UseBackColor = true;
            this.gridTabela.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridTabela.Appearance.EvenRow.BackColor2 = System.Drawing.Color.White;
            this.gridTabela.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridTabela.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridTabela.Appearance.OddRow.BackColor = System.Drawing.Color.CornflowerBlue;
            this.gridTabela.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gridTabela.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridTabela.Appearance.OddRow.Options.UseBackColor = true;
            this.gridTabela.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colMatricula,
            this.colNome,
            this.colTelefone,
            this.colCelular,
            this.colStatus});
            this.gridTabela.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridTabela.GridControl = this.gdvTabela;
            this.gridTabela.GroupPanelText = "Arraste a coluna até aqui para agrupar";
            this.gridTabela.Name = "gridTabela";
            this.gridTabela.OptionsBehavior.Editable = false;
            this.gridTabela.OptionsMenu.EnableColumnMenu = false;
            this.gridTabela.OptionsMenu.EnableFooterMenu = false;
            this.gridTabela.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridTabela.OptionsPrint.ExpandAllDetails = true;
            this.gridTabela.OptionsPrint.PrintFooter = false;
            this.gridTabela.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridTabela.OptionsView.EnableAppearanceEvenRow = true;
            this.gridTabela.OptionsView.EnableAppearanceOddRow = true;
            this.gridTabela.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridTabela.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridTabela.PaintStyleName = "Skin";
            // 
            // colID
            // 
            this.colID.Caption = "Código";
            this.colID.FieldName = "idClientes";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 79;
            // 
            // colMatricula
            // 
            this.colMatricula.Caption = "Matrícula";
            this.colMatricula.FieldName = "matricula";
            this.colMatricula.Name = "colMatricula";
            this.colMatricula.Visible = true;
            this.colMatricula.VisibleIndex = 1;
            this.colMatricula.Width = 111;
            // 
            // colNome
            // 
            this.colNome.Caption = "Nome";
            this.colNome.FieldName = "nome";
            this.colNome.Name = "colNome";
            this.colNome.Visible = true;
            this.colNome.VisibleIndex = 2;
            this.colNome.Width = 365;
            // 
            // colTelefone
            // 
            this.colTelefone.Caption = "Telefone";
            this.colTelefone.FieldName = "tel_fixo";
            this.colTelefone.Name = "colTelefone";
            this.colTelefone.Visible = true;
            this.colTelefone.VisibleIndex = 3;
            this.colTelefone.Width = 118;
            // 
            // colCelular
            // 
            this.colCelular.Caption = "Celular";
            this.colCelular.FieldName = "tel_celular";
            this.colCelular.Name = "colCelular";
            this.colCelular.Visible = true;
            this.colCelular.VisibleIndex = 4;
            this.colCelular.Width = 118;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 5;
            this.colStatus.Width = 132;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(960, 661);
            this.LookAndFeel.SkinName = "Blue";
            this.Name = "frmClientes";
            this.Load += new System.EventHandler(this.frmLocais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbFiltros.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOpcoes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesquisa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPanel)).EndInit();
            this.tabPanel.ResumeLayout(false);
            this.tabConsulta.ResumeLayout(false);
            this.tabCadastro.ResumeLayout(false);
            this.tabCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTabela)).EndInit();
            this.pnlTabela.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.validacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTabela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gdvTabela;
        private DevExpress.XtraGrid.Views.Grid.GridView gridTabela;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colMatricula;
        private DevExpress.XtraGrid.Columns.GridColumn colNome;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefone;
        private DevExpress.XtraGrid.Columns.GridColumn colCelular;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
    }
}
