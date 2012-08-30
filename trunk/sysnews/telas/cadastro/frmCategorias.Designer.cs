using telas.util.layout;
namespace telas.estoque
{
    partial class frmCategorias :frmBase
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
        protected void InitializeComponent()
        {
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.gdvTabela = new DevExpress.XtraGrid.GridControl();
            this.gridTabela = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.txtCategoria = new DevExpress.XtraEditors.TextEdit();
            this.lblCategoria = new DevExpress.XtraEditors.LabelControl();
            this.lblCodigo = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFiltros.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesquisa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPanel)).BeginInit();
            this.tabPanel.SuspendLayout();
            this.tabConsulta.SuspendLayout();
            this.tabCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTabela)).BeginInit();
            this.pnlTabela.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOpcoes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloCadastro
            // 
            this.lblTituloCadastro.Appearance.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCadastro.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTituloCadastro.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.lblTituloCadastro.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTituloCadastro.Text = "Cadastro Categoria";
            // 
            // cmbFiltros
            // 
            this.cmbFiltros.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbFiltros.Properties.Appearance.Options.UseFont = true;
            this.cmbFiltros.Properties.Items.AddRange(new object[] {
            "Descrição"});
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtPesquisa.Properties.Appearance.BackColor2 = System.Drawing.Color.White;
            this.txtPesquisa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
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
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Appearance.Options.UseFont = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Appearance.Options.UseFont = true;
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.TabIndex = 1;
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
            this.panel.Controls.Add(this.txtCodigo);
            this.panel.Controls.Add(this.lblCodigo);
            this.panel.Controls.Add(this.txtCategoria);
            this.panel.Controls.Add(this.lblCategoria);
            this.panel.TabIndex = 0;
            // 
            // lblTituloPesquisa
            // 
            this.lblTituloPesquisa.Appearance.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPesquisa.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTituloPesquisa.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.lblTituloPesquisa.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTituloPesquisa.Text = "Pesquisar Categorias";
            // 
            // styleController1
            // 
            this.styleController1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleController1.Appearance.Options.UseFont = true;
            this.styleController1.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleController1.AppearanceDisabled.Options.UseFont = true;
            // 
            // cmbOpcoes
            // 
            this.cmbOpcoes.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbOpcoes.Properties.Appearance.Options.UseFont = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Appearance.Options.UseFont = true;
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
            this.gdvTabela.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit1});
            this.gdvTabela.Size = new System.Drawing.Size(950, 486);
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
            this.colCategoria});
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
            this.colID.FieldName = "idCategorias";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 120;
            // 
            // colCategoria
            // 
            this.colCategoria.Caption = "Categoria";
            this.colCategoria.FieldName = "descricao";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.Visible = true;
            this.colCategoria.VisibleIndex = 1;
            this.colCategoria.Width = 970;
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategoria.EditValue = "";
            this.txtCategoria.EnterMoveNextControl = true;
            this.txtCategoria.Location = new System.Drawing.Point(120, 82);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtCategoria.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtCategoria.Properties.Appearance.BackColor2 = System.Drawing.Color.White;
            this.txtCategoria.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtCategoria.Properties.Appearance.Options.UseBackColor = true;
            this.txtCategoria.Properties.Appearance.Options.UseBorderColor = true;
            this.txtCategoria.Properties.Appearance.Options.UseFont = true;
            this.txtCategoria.Properties.Appearance.Options.UseForeColor = true;
            this.txtCategoria.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtCategoria.Properties.Mask.IgnoreMaskBlank = false;
            this.txtCategoria.Properties.MaxLength = 50;
            this.txtCategoria.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtCategoria.Properties.ValidateOnEnterKey = true;
            this.txtCategoria.Size = new System.Drawing.Size(824, 28);
            this.txtCategoria.StyleController = this.styleController1;
            this.txtCategoria.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Categoria é campo obrigatório";
            this.validacao.SetValidationRule(this.txtCategoria, conditionValidationRule1);
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoria.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(47, 88);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(67, 19);
            this.lblCategoria.TabIndex = 9;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigo.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(64, 56);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(50, 19);
            this.lblCodigo.TabIndex = 10;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigo.EditValue = "";
            this.txtCodigo.Enabled = false;
            this.txtCodigo.EnterMoveNextControl = true;
            this.txtCodigo.Location = new System.Drawing.Point(120, 48);
            this.txtCodigo.MaximumSize = new System.Drawing.Size(168, 26);
            this.txtCodigo.MinimumSize = new System.Drawing.Size(168, 26);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtCodigo.Properties.Appearance.Options.UseForeColor = true;
            this.txtCodigo.Size = new System.Drawing.Size(168, 26);
            this.txtCodigo.StyleController = this.styleController1;
            this.txtCodigo.TabIndex = 11;
            this.txtCodigo.TabStop = false;
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(960, 661);
            this.Location = new System.Drawing.Point(0, 0);
            this.LookAndFeel.SkinName = "Blue";
            this.Name = "frmCategorias";
            this.Text = "Cadastro de Categorias";
            this.Load += new System.EventHandler(this.frmCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbFiltros.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesquisa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPanel)).EndInit();
            this.tabPanel.ResumeLayout(false);
            this.tabConsulta.ResumeLayout(false);
            this.tabCadastro.ResumeLayout(false);
            this.tabCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTabela)).EndInit();
            this.pnlTabela.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOpcoes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gdvTabela;
        private DevExpress.XtraGrid.Views.Grid.GridView gridTabela;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoria;
        private DevExpress.XtraEditors.TextEdit txtCategoria;
        private DevExpress.XtraEditors.LabelControl lblCategoria;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.LabelControl lblCodigo;
    }
}
