namespace telas.seguranca
{
    partial class frmUsuario : telas.util.layout.frmBase
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule compareAgainstControlValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule();
            this.txtSenha = new DevExpress.XtraEditors.TextEdit();
            this.gdvTabela = new DevExpress.XtraGrid.GridControl();
            this.gridTabela = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPerfil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSenha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtNome = new DevExpress.XtraEditors.TextEdit();
            this.txtLogin = new DevExpress.XtraEditors.TextEdit();
            this.lblNome = new DevExpress.XtraEditors.LabelControl();
            this.lblLogin = new DevExpress.XtraEditors.LabelControl();
            this.lblSenha = new DevExpress.XtraEditors.LabelControl();
            this.lblRepetirSenha = new DevExpress.XtraEditors.LabelControl();
            this.txtRepetirSenha = new DevExpress.XtraEditors.TextEdit();
            this.lblPerfil = new DevExpress.XtraEditors.LabelControl();
            this.cmbPerfis = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepetirSenha.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloCadastro
            // 
            this.lblTituloCadastro.Appearance.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCadastro.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTituloCadastro.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.lblTituloCadastro.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTituloCadastro.Text = "Cadastro Usuários";
            // 
            // cmbFiltros
            // 
            this.cmbFiltros.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbFiltros.Properties.Appearance.Options.UseFont = true;
            this.cmbFiltros.Properties.Items.AddRange(new object[] {
            "Nome",
            "Login"});
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
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
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
            this.panel.Controls.Add(this.cmbPerfis);
            this.panel.Controls.Add(this.txtNome);
            this.panel.Controls.Add(this.lblPerfil);
            this.panel.Controls.Add(this.txtRepetirSenha);
            this.panel.Controls.Add(this.lblRepetirSenha);
            this.panel.Controls.Add(this.lblSenha);
            this.panel.Controls.Add(this.lblLogin);
            this.panel.Controls.Add(this.lblNome);
            this.panel.Controls.Add(this.txtSenha);
            this.panel.Controls.Add(this.txtLogin);
            // 
            // lblTituloPesquisa
            // 
            this.lblTituloPesquisa.Appearance.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPesquisa.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTituloPesquisa.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.lblTituloPesquisa.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTituloPesquisa.Text = "Pesquisar Usuários";
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
            // txtSenha
            // 
            this.txtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenha.Location = new System.Drawing.Point(150, 127);
            this.txtSenha.MinimumSize = new System.Drawing.Size(300, 26);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Properties.MaxLength = 10;
            this.txtSenha.Properties.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(300, 26);
            this.txtSenha.StyleController = this.styleController1;
            this.txtSenha.TabIndex = 2;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "O campo senha é obrigatório";
            this.validacao.SetValidationRule(this.txtSenha, conditionValidationRule2);
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
            this.gdvTabela.Size = new System.Drawing.Size(950, 486);
            this.gdvTabela.TabIndex = 30;
            this.gdvTabela.UseEmbeddedNavigator = true;
            this.gdvTabela.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridTabela});
            this.gdvTabela.DoubleClick += new System.EventHandler(this.btnEditar_Click);
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
            this.colNome,
            this.colLogin,
            this.colPerfil,
            this.colSenha});
            this.gridTabela.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridTabela.GridControl = this.gdvTabela;
            this.gridTabela.GroupPanelText = "Arraste a coluna até aqui para agrupar";
            this.gridTabela.Name = "gridTabela";
            this.gridTabela.OptionsBehavior.Editable = false;
            this.gridTabela.OptionsBehavior.ReadOnly = true;
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
            this.colID.FieldName = "idUsuarios";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 90;
            // 
            // colNome
            // 
            this.colNome.Caption = "Nome";
            this.colNome.FieldName = "nome";
            this.colNome.Name = "colNome";
            this.colNome.Visible = true;
            this.colNome.VisibleIndex = 1;
            this.colNome.Width = 595;
            // 
            // colLogin
            // 
            this.colLogin.Caption = "Login";
            this.colLogin.FieldName = "login";
            this.colLogin.Name = "colLogin";
            this.colLogin.Visible = true;
            this.colLogin.VisibleIndex = 2;
            this.colLogin.Width = 122;
            // 
            // colPerfil
            // 
            this.colPerfil.Caption = "Perfil";
            this.colPerfil.FieldName = "Perfis.descricao";
            this.colPerfil.Name = "colPerfil";
            this.colPerfil.Visible = true;
            this.colPerfil.VisibleIndex = 3;
            this.colPerfil.Width = 125;
            // 
            // colSenha
            // 
            this.colSenha.Caption = "Senha";
            this.colSenha.FieldName = "senha";
            this.colSenha.Name = "colSenha";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.EnterMoveNextControl = true;
            this.txtNome.Location = new System.Drawing.Point(150, 37);
            this.txtNome.MinimumSize = new System.Drawing.Size(300, 26);
            this.txtNome.Name = "txtNome";
            this.txtNome.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Properties.MaxLength = 50;
            this.txtNome.Size = new System.Drawing.Size(300, 26);
            this.txtNome.StyleController = this.styleController1;
            this.txtNome.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "O campo Nome é obrigatório";
            this.validacao.SetValidationRule(this.txtNome, conditionValidationRule1);
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogin.Location = new System.Drawing.Point(150, 82);
            this.txtLogin.MinimumSize = new System.Drawing.Size(300, 26);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Properties.MaxLength = 30;
            this.txtLogin.Size = new System.Drawing.Size(300, 26);
            this.txtLogin.StyleController = this.styleController1;
            this.txtLogin.TabIndex = 1;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "O campo login é obrigatório";
            this.validacao.SetValidationRule(this.txtLogin, conditionValidationRule3);
            // 
            // lblNome
            // 
            this.lblNome.Location = new System.Drawing.Point(96, 40);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(48, 19);
            this.lblNome.StyleController = this.styleController1;
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // lblLogin
            // 
            this.lblLogin.Location = new System.Drawing.Point(99, 85);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(45, 19);
            this.lblLogin.StyleController = this.styleController1;
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "Login:";
            // 
            // lblSenha
            // 
            this.lblSenha.Location = new System.Drawing.Point(95, 130);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(49, 19);
            this.lblSenha.StyleController = this.styleController1;
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha:";
            // 
            // lblRepetirSenha
            // 
            this.lblRepetirSenha.Location = new System.Drawing.Point(40, 175);
            this.lblRepetirSenha.Name = "lblRepetirSenha";
            this.lblRepetirSenha.Size = new System.Drawing.Size(104, 19);
            this.lblRepetirSenha.StyleController = this.styleController1;
            this.lblRepetirSenha.TabIndex = 6;
            this.lblRepetirSenha.Text = "Repetir Senha:";
            // 
            // txtRepetirSenha
            // 
            this.txtRepetirSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRepetirSenha.Location = new System.Drawing.Point(150, 172);
            this.txtRepetirSenha.MinimumSize = new System.Drawing.Size(300, 26);
            this.txtRepetirSenha.Name = "txtRepetirSenha";
            this.txtRepetirSenha.Properties.MaxLength = 10;
            this.txtRepetirSenha.Properties.PasswordChar = '*';
            this.txtRepetirSenha.Size = new System.Drawing.Size(300, 26);
            this.txtRepetirSenha.StyleController = this.styleController1;
            this.txtRepetirSenha.TabIndex = 7;
            compareAgainstControlValidationRule1.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.Equals;
            compareAgainstControlValidationRule1.Control = this.txtSenha;
            compareAgainstControlValidationRule1.ErrorText = "O campo Repetir Senha é diferente de Senha";
            this.validacao.SetValidationRule(this.txtRepetirSenha, compareAgainstControlValidationRule1);
            // 
            // lblPerfil
            // 
            this.lblPerfil.Location = new System.Drawing.Point(102, 220);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(42, 19);
            this.lblPerfil.StyleController = this.styleController1;
            this.lblPerfil.TabIndex = 9;
            this.lblPerfil.Text = "Perfil:";
            // 
            // cmbPerfis
            // 
            this.cmbPerfis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPerfis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerfis.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPerfis.FormattingEnabled = true;
            this.cmbPerfis.Location = new System.Drawing.Point(150, 217);
            this.cmbPerfis.MinimumSize = new System.Drawing.Size(300, 0);
            this.cmbPerfis.Name = "cmbPerfis";
            this.cmbPerfis.Size = new System.Drawing.Size(300, 27);
            this.cmbPerfis.Sorted = true;
            this.cmbPerfis.TabIndex = 10;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(960, 661);
            this.Location = new System.Drawing.Point(0, 0);
            this.LookAndFeel.SkinName = "Blue";
            this.Name = "frmUsuario";
            this.Text = "Usuários";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvTabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepetirSenha.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gdvTabela;
        private DevExpress.XtraGrid.Views.Grid.GridView gridTabela;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colNome;
        private DevExpress.XtraGrid.Columns.GridColumn colLogin;
        private DevExpress.XtraGrid.Columns.GridColumn colPerfil;
        private DevExpress.XtraEditors.TextEdit txtRepetirSenha;
        private DevExpress.XtraEditors.LabelControl lblRepetirSenha;
        private DevExpress.XtraEditors.LabelControl lblSenha;
        private DevExpress.XtraEditors.LabelControl lblLogin;
        private DevExpress.XtraEditors.LabelControl lblNome;
        private DevExpress.XtraEditors.TextEdit txtSenha;
        private DevExpress.XtraEditors.TextEdit txtLogin;
        private DevExpress.XtraEditors.TextEdit txtNome;
        private DevExpress.XtraEditors.LabelControl lblPerfil;
        private DevExpress.XtraGrid.Columns.GridColumn colSenha;
        private System.Windows.Forms.ComboBox cmbPerfis;

        
      
    }
}