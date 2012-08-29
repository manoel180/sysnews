namespace telas.util.layout
{
    partial class frmBase
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
        protected virtual void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTipoPesquisa = new DevExpress.XtraEditors.LabelControl();
            this.styleController1 = new DevExpress.XtraEditors.StyleController(this.components);
            this.gboxParametro = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelarPesquisa = new DevExpress.XtraEditors.SimpleButton();
            this.btnPesquisar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            this.btnNovo = new DevExpress.XtraEditors.SimpleButton();
            this.cmbFiltros = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbOpcoes = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtPesquisa = new DevExpress.XtraEditors.TextEdit();
            this.lblTituloPesquisa = new DevExpress.XtraEditors.LabelControl();
            this.tabPanel = new DevExpress.XtraTab.XtraTabControl();
            this.tabConsulta = new DevExpress.XtraTab.XtraTabPage();
            this.pnlTabela = new DevExpress.XtraEditors.PanelControl();
            this.tabCadastro = new DevExpress.XtraTab.XtraTabPage();
            this.lblTituloCadastro = new DevExpress.XtraEditors.LabelControl();
            this.panelRodape = new DevExpress.XtraEditors.PanelControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.panel = new DevExpress.XtraEditors.XtraScrollableControl();
            this.validacao = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).BeginInit();
            this.gboxParametro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFiltros.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOpcoes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesquisa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPanel)).BeginInit();
            this.tabPanel.SuspendLayout();
            this.tabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTabela)).BeginInit();
            this.tabCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelRodape)).BeginInit();
            this.panelRodape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validacao)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipoPesquisa
            // 
            this.lblTipoPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipoPesquisa.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPesquisa.Location = new System.Drawing.Point(16, 36);
            this.lblTipoPesquisa.Name = "lblTipoPesquisa";
            this.lblTipoPesquisa.Size = new System.Drawing.Size(96, 19);
            this.lblTipoPesquisa.StyleController = this.styleController1;
            this.lblTipoPesquisa.TabIndex = 25;
            this.lblTipoPesquisa.Text = "Pesquisar por";
            // 
            // styleController1
            // 
            this.styleController1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleController1.Appearance.Options.UseFont = true;
            this.styleController1.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleController1.AppearanceDisabled.Options.UseFont = true;
            // 
            // gboxParametro
            // 
            this.gboxParametro.Controls.Add(this.btnExcluir);
            this.gboxParametro.Controls.Add(this.lblTipoPesquisa);
            this.gboxParametro.Controls.Add(this.btnCancelarPesquisa);
            this.gboxParametro.Controls.Add(this.btnPesquisar);
            this.gboxParametro.Controls.Add(this.btnEditar);
            this.gboxParametro.Controls.Add(this.btnNovo);
            this.gboxParametro.Controls.Add(this.cmbFiltros);
            this.gboxParametro.Controls.Add(this.cmbOpcoes);
            this.gboxParametro.Controls.Add(this.txtPesquisa);
            this.gboxParametro.Dock = System.Windows.Forms.DockStyle.Top;
            this.gboxParametro.ForeColor = System.Drawing.Color.Blue;
            this.gboxParametro.Location = new System.Drawing.Point(0, 24);
            this.gboxParametro.Name = "gboxParametro";
            this.gboxParametro.Size = new System.Drawing.Size(954, 116);
            this.gboxParametro.TabIndex = 28;
            this.gboxParametro.TabStop = false;
            this.gboxParametro.Text = "Opções de Pesquisa";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Appearance.Options.UseFont = true;
            this.btnExcluir.Image = global::telas.Properties.Resources.btn_excluir;
            this.btnExcluir.Location = new System.Drawing.Point(735, 64);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(103, 32);
            this.btnExcluir.TabIndex = 32;
            this.btnExcluir.Text = "Excluir";
            // 
            // btnCancelarPesquisa
            // 
            this.btnCancelarPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarPesquisa.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPesquisa.Appearance.Options.UseFont = true;
            this.btnCancelarPesquisa.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarPesquisa.Image = global::telas.Properties.Resources.btn_sair;
            this.btnCancelarPesquisa.Location = new System.Drawing.Point(844, 64);
            this.btnCancelarPesquisa.LookAndFeel.SkinName = "Seven Classic";
            this.btnCancelarPesquisa.Name = "btnCancelarPesquisa";
            this.btnCancelarPesquisa.Size = new System.Drawing.Size(103, 32);
            this.btnCancelarPesquisa.TabIndex = 31;
            this.btnCancelarPesquisa.Text = "Cancelar";
            this.btnCancelarPesquisa.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.Image = global::telas.Properties.Resources.btn_pesquisar;
            this.btnPesquisar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnPesquisar.Location = new System.Drawing.Point(918, 29);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(28, 26);
            this.btnPesquisar.StyleController = this.styleController1;
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Appearance.Options.UseFont = true;
            this.btnEditar.Image = global::telas.Properties.Resources.btn_editar;
            this.btnEditar.Location = new System.Drawing.Point(626, 64);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(103, 32);
            this.btnEditar.TabIndex = 29;
            this.btnEditar.Text = "Editar";
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Appearance.Options.UseFont = true;
            this.btnNovo.Location = new System.Drawing.Point(517, 64);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(103, 32);
            this.btnNovo.TabIndex = 28;
            this.btnNovo.Text = "Novo";
            // 
            // cmbFiltros
            // 
            this.cmbFiltros.EditValue = "Todos";
            this.cmbFiltros.Location = new System.Drawing.Point(118, 29);
            this.cmbFiltros.Name = "cmbFiltros";
            this.cmbFiltros.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cmbFiltros.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbFiltros.Properties.Appearance.Options.UseFont = true;
            this.cmbFiltros.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFiltros.Properties.Items.AddRange(new object[] {
            "Todos",
            "Código"});
            this.cmbFiltros.Properties.NullValuePromptShowForEmptyValue = true;
            this.cmbFiltros.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbFiltros.Properties.EditValueChanged += new System.EventHandler(this.cmbFiltros_Modified);
            this.cmbFiltros.Size = new System.Drawing.Size(129, 26);
            this.cmbFiltros.StyleController = this.styleController1;
            this.cmbFiltros.TabIndex = 27;
            this.cmbFiltros.Modified += new System.EventHandler(this.cmbFiltros_Modified);
            // 
            // cmbOpcoes
            // 
            this.cmbOpcoes.EditValue = "Começa com";
            this.cmbOpcoes.Enabled = false;
            this.cmbOpcoes.Location = new System.Drawing.Point(253, 29);
            this.cmbOpcoes.Name = "cmbOpcoes";
            this.cmbOpcoes.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbOpcoes.Properties.Appearance.Options.UseFont = true;
            this.cmbOpcoes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbOpcoes.Properties.Items.AddRange(new object[] {
            "Começa com",
            "Contém",
            "Termina com"});
            this.cmbOpcoes.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbOpcoes.Size = new System.Drawing.Size(123, 26);
            this.cmbOpcoes.StyleController = this.styleController1;
            this.cmbOpcoes.TabIndex = 26;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.EditValue = "";
            this.txtPesquisa.EnterMoveNextControl = true;
            this.txtPesquisa.Location = new System.Drawing.Point(382, 29);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtPesquisa.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtPesquisa.Properties.Appearance.BackColor2 = System.Drawing.Color.White;
            this.txtPesquisa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPesquisa.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtPesquisa.Properties.Appearance.Options.UseBackColor = true;
            this.txtPesquisa.Properties.Appearance.Options.UseBorderColor = true;
            this.txtPesquisa.Properties.Appearance.Options.UseFont = true;
            this.txtPesquisa.Properties.Appearance.Options.UseForeColor = true;
            this.txtPesquisa.Properties.MaxLength = 50;
            this.txtPesquisa.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtPesquisa.Size = new System.Drawing.Size(530, 26);
            this.txtPesquisa.StyleController = this.styleController1;
            this.txtPesquisa.TabIndex = 2;
            this.txtPesquisa.EditValueChanged += new System.EventHandler(this.txtPesquisa_EditValueChanged);
            // 
            // lblTituloPesquisa
            // 
            this.lblTituloPesquisa.Appearance.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPesquisa.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTituloPesquisa.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.lblTituloPesquisa.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTituloPesquisa.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lblTituloPesquisa.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloPesquisa.LineColor = System.Drawing.Color.Gainsboro;
            this.lblTituloPesquisa.Location = new System.Drawing.Point(0, 0);
            this.lblTituloPesquisa.Name = "lblTituloPesquisa";
            this.lblTituloPesquisa.Size = new System.Drawing.Size(954, 24);
            this.lblTituloPesquisa.TabIndex = 27;
            this.lblTituloPesquisa.Text = "Pesquisar ";
            // 
            // tabPanel
            // 
            this.tabPanel.AppearancePage.Header.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tabPanel.AppearancePage.Header.Options.UseFont = true;
            this.tabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanel.Location = new System.Drawing.Point(0, 0);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.SelectedTabPage = this.tabConsulta;
            this.tabPanel.Size = new System.Drawing.Size(960, 661);
            this.tabPanel.TabIndex = 32;
            this.tabPanel.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabConsulta,
            this.tabCadastro});
            // 
            // tabConsulta
            // 
            this.tabConsulta.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabConsulta.Appearance.Header.Options.UseFont = true;
            this.tabConsulta.Appearance.PageClient.BackColor = System.Drawing.Color.Black;
            this.tabConsulta.Appearance.PageClient.Options.UseBackColor = true;
            this.tabConsulta.Controls.Add(this.pnlTabela);
            this.tabConsulta.Controls.Add(this.gboxParametro);
            this.tabConsulta.Controls.Add(this.lblTituloPesquisa);
            this.tabConsulta.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            this.tabConsulta.Size = new System.Drawing.Size(954, 630);
            this.tabConsulta.Text = "Consulta";
            // 
            // pnlTabela
            // 
            this.pnlTabela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTabela.Location = new System.Drawing.Point(0, 140);
            this.pnlTabela.Name = "pnlTabela";
            this.pnlTabela.Size = new System.Drawing.Size(954, 490);
            this.pnlTabela.TabIndex = 29;
            // 
            // tabCadastro
            // 
            this.tabCadastro.Controls.Add(this.lblTituloCadastro);
            this.tabCadastro.Controls.Add(this.panelRodape);
            this.tabCadastro.Controls.Add(this.panel);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.PageVisible = false;
            this.tabCadastro.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.tabCadastro.Size = new System.Drawing.Size(954, 630);
            this.tabCadastro.Text = "Cadastro";
            // 
            // lblTituloCadastro
            // 
            this.lblTituloCadastro.Appearance.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCadastro.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTituloCadastro.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.lblTituloCadastro.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTituloCadastro.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lblTituloCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloCadastro.LineColor = System.Drawing.Color.Gainsboro;
            this.lblTituloCadastro.Location = new System.Drawing.Point(0, 0);
            this.lblTituloCadastro.Name = "lblTituloCadastro";
            this.lblTituloCadastro.ShowToolTips = false;
            this.lblTituloCadastro.Size = new System.Drawing.Size(954, 24);
            this.lblTituloCadastro.TabIndex = 29;
            this.lblTituloCadastro.Text = "Cadastro";
            // 
            // panelRodape
            // 
            this.panelRodape.AutoSize = true;
            this.panelRodape.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelRodape.Controls.Add(this.btnCancelar);
            this.panelRodape.Controls.Add(this.btnSalvar);
            this.panelRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRodape.Location = new System.Drawing.Point(0, 592);
            this.panelRodape.Name = "panelRodape";
            this.panelRodape.Size = new System.Drawing.Size(954, 38);
            this.panelRodape.TabIndex = 32;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::telas.Properties.Resources.btn_sair;
            this.btnCancelar.Location = new System.Drawing.Point(844, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 32);
            this.btnCancelar.StyleController = this.styleController1;
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Appearance.Options.UseFont = true;
            this.btnSalvar.Image = global::telas.Properties.Resources.btn_salvar;
            this.btnSalvar.Location = new System.Drawing.Point(735, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(103, 32);
            this.btnSalvar.StyleController = this.styleController1;
            this.btnSalvar.TabIndex = 31;
            this.btnSalvar.Text = "Salvar";
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panel.Appearance.Options.UseBackColor = true;
            this.panel.Location = new System.Drawing.Point(0, 30);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(951, 556);
            this.panel.TabIndex = 30;
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.btnCancelarPesquisa;
            this.ClientSize = new System.Drawing.Size(960, 661);
            this.Controls.Add(this.tabPanel);
            this.KeyPreview = true;
            this.LookAndFeel.SkinName = "Blue";
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frmBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).EndInit();
            this.gboxParametro.ResumeLayout(false);
            this.gboxParametro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFiltros.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOpcoes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesquisa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPanel)).EndInit();
            this.tabPanel.ResumeLayout(false);
            this.tabConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlTabela)).EndInit();
            this.tabCadastro.ResumeLayout(false);
            this.tabCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelRodape)).EndInit();
            this.panelRodape.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.validacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTipoPesquisa;
        protected DevExpress.XtraEditors.LabelControl lblTituloCadastro;
        protected DevExpress.XtraEditors.ComboBoxEdit cmbFiltros;
        protected DevExpress.XtraEditors.TextEdit txtPesquisa;
        protected DevExpress.XtraTab.XtraTabControl tabPanel;
        protected DevExpress.XtraTab.XtraTabPage tabConsulta;
        protected DevExpress.XtraTab.XtraTabPage tabCadastro;
        protected DevExpress.XtraEditors.SimpleButton btnEditar;
        protected DevExpress.XtraEditors.SimpleButton btnNovo;
        
        protected DevExpress.XtraEditors.SimpleButton btnPesquisar;
        protected DevExpress.XtraEditors.SimpleButton btnSalvar;
        protected DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.PanelControl panelRodape;
        protected DevExpress.XtraEditors.SimpleButton btnCancelarPesquisa;
        protected DevExpress.XtraEditors.PanelControl pnlTabela;
        protected DevExpress.XtraEditors.XtraScrollableControl panel;
        protected DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validacao;
        protected DevExpress.XtraEditors.LabelControl lblTituloPesquisa;
        private System.Windows.Forms.GroupBox gboxParametro;
        protected DevExpress.XtraEditors.StyleController styleController1;
        protected DevExpress.XtraEditors.ComboBoxEdit cmbOpcoes;
        protected DevExpress.XtraEditors.SimpleButton btnExcluir;
    }
}