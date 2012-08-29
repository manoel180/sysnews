using telas.util.layout;
namespace telas.estoque
{
    partial class frmProdutos : frmBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.txtPreco = new DevExpress.XtraEditors.SpinEdit();
            this.txt_preco_compra = new DevExpress.XtraEditors.SpinEdit();
            this.cmbTipoLucro = new System.Windows.Forms.ComboBox();
            this.txt_Quantidade = new System.Windows.Forms.NumericUpDown();
            this.txt_Quantidade_Minimo = new System.Windows.Forms.NumericUpDown();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Quantidade = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_Fornecedor = new System.Windows.Forms.ComboBox();
            this.lbl_fornecedor = new DevExpress.XtraEditors.LabelControl();
            this.txt_idProduto = new DevExpress.XtraEditors.TextEdit();
            this.lblCodigo = new DevExpress.XtraEditors.LabelControl();
            this.txtCoddeBarra = new DevExpress.XtraEditors.TextEdit();
            this.lblCodBarras = new DevExpress.XtraEditors.LabelControl();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbLocal = new System.Windows.Forms.ComboBox();
            this.lblDtVencimento = new DevExpress.XtraEditors.LabelControl();
            this.lblLocal = new DevExpress.XtraEditors.LabelControl();
            this.lblCategoria = new DevExpress.XtraEditors.LabelControl();
            this.lblQuantidade_Minimo = new DevExpress.XtraEditors.LabelControl();
            this.lblPreco = new DevExpress.XtraEditors.LabelControl();
            this.txtDescricao = new DevExpress.XtraEditors.TextEdit();
            this.lblDescricao = new DevExpress.XtraEditors.LabelControl();
            this.txtDTVencimento = new DevExpress.XtraEditors.DateEdit();
            this.txt_lucro_valor = new DevExpress.XtraEditors.SpinEdit();
            this.txt_lucro_porcentagem = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFiltros.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesquisa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPanel)).BeginInit();
            this.tabPanel.SuspendLayout();
            this.tabConsulta.SuspendLayout();
            this.tabCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTabela)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOpcoes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_preco_compra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Quantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Quantidade_Minimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_idProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCoddeBarra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDTVencimento.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDTVencimento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_lucro_valor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_lucro_porcentagem.Properties)).BeginInit();
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
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            // 
            // btnNovo
            // 
            this.btnNovo.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Appearance.Options.UseFont = true;
            this.btnNovo.Image = global::telas.Properties.Resources.btn_add_produto;
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
            // panel
            // 
            this.panel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panel.Appearance.Options.UseBackColor = true;
            this.panel.Controls.Add(this.txtPreco);
            this.panel.Controls.Add(this.txt_preco_compra);
            this.panel.Controls.Add(this.cmbTipoLucro);
            this.panel.Controls.Add(this.txt_Quantidade);
            this.panel.Controls.Add(this.txt_Quantidade_Minimo);
            this.panel.Controls.Add(this.labelControl2);
            this.panel.Controls.Add(this.lbl_Quantidade);
            this.panel.Controls.Add(this.labelControl1);
            this.panel.Controls.Add(this.cmb_Fornecedor);
            this.panel.Controls.Add(this.lbl_fornecedor);
            this.panel.Controls.Add(this.txt_idProduto);
            this.panel.Controls.Add(this.lblCodigo);
            this.panel.Controls.Add(this.txtCoddeBarra);
            this.panel.Controls.Add(this.lblCodBarras);
            this.panel.Controls.Add(this.cmbCategoria);
            this.panel.Controls.Add(this.cmbLocal);
            this.panel.Controls.Add(this.lblDtVencimento);
            this.panel.Controls.Add(this.lblLocal);
            this.panel.Controls.Add(this.lblCategoria);
            this.panel.Controls.Add(this.lblQuantidade_Minimo);
            this.panel.Controls.Add(this.lblPreco);
            this.panel.Controls.Add(this.txtDescricao);
            this.panel.Controls.Add(this.lblDescricao);
            this.panel.Controls.Add(this.txtDTVencimento);
            this.panel.Controls.Add(this.txt_lucro_valor);
            this.panel.Controls.Add(this.txt_lucro_porcentagem);
            // 
            // lblTituloPesquisa
            // 
            this.lblTituloPesquisa.Appearance.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPesquisa.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTituloPesquisa.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.lblTituloPesquisa.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTituloPesquisa.Text = "PRODUTOS";
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
            // xtraTabPage1
            // 
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(0, 0);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(0, 0);
            // 
            // txtPreco
            // 
            this.txtPreco.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPreco.Location = new System.Drawing.Point(763, 261);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPreco.Properties.Appearance.Options.UseFont = true;
            this.txtPreco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "", null, null, true)});
            this.txtPreco.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPreco.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPreco.Properties.Mask.EditMask = "c2";
            this.txtPreco.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPreco.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txtPreco.Size = new System.Drawing.Size(121, 26);
            this.txtPreco.TabIndex = 43;
            // 
            // txt_preco_compra
            // 
            this.txt_preco_compra.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_preco_compra.Location = new System.Drawing.Point(160, 262);
            this.txt_preco_compra.Name = "txt_preco_compra";
            this.txt_preco_compra.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_preco_compra.Properties.Appearance.Options.UseFont = true;
            this.txt_preco_compra.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.txt_preco_compra.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_preco_compra.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_preco_compra.Properties.Mask.EditMask = "c2";
            this.txt_preco_compra.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txt_preco_compra.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txt_preco_compra.Size = new System.Drawing.Size(131, 26);
            this.txt_preco_compra.TabIndex = 38;
            // 
            // cmbTipoLucro
            // 
            this.cmbTipoLucro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoLucro.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbTipoLucro.FormattingEnabled = true;
            this.cmbTipoLucro.Location = new System.Drawing.Point(363, 259);
            this.cmbTipoLucro.Name = "cmbTipoLucro";
            this.cmbTipoLucro.Size = new System.Drawing.Size(142, 27);
            this.cmbTipoLucro.TabIndex = 40;
            // 
            // txt_Quantidade
            // 
            this.txt_Quantidade.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_Quantidade.Location = new System.Drawing.Point(160, 210);
            this.txt_Quantidade.Name = "txt_Quantidade";
            this.txt_Quantidade.Size = new System.Drawing.Size(227, 27);
            this.txt_Quantidade.TabIndex = 37;
            // 
            // txt_Quantidade_Minimo
            // 
            this.txt_Quantidade_Minimo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_Quantidade_Minimo.Location = new System.Drawing.Point(656, 200);
            this.txt_Quantidade_Minimo.Name = "txt_Quantidade_Minimo";
            this.txt_Quantidade_Minimo.Size = new System.Drawing.Size(227, 27);
            this.txt_Quantidade_Minimo.TabIndex = 46;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(318, 267);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 19);
            this.labelControl2.TabIndex = 59;
            this.labelControl2.Text = "Lucro";
            // 
            // lbl_Quantidade
            // 
            this.lbl_Quantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Quantidade.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantidade.Location = new System.Drawing.Point(73, 213);
            this.lbl_Quantidade.Name = "lbl_Quantidade";
            this.lbl_Quantidade.Size = new System.Drawing.Size(81, 19);
            this.lbl_Quantidade.TabIndex = 58;
            this.lbl_Quantidade.Text = "Quantidade";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(54, 267);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(100, 19);
            this.labelControl1.TabIndex = 57;
            this.labelControl1.Text = "Preço Compra";
            // 
            // cmb_Fornecedor
            // 
            this.cmb_Fornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Fornecedor.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmb_Fornecedor.FormattingEnabled = true;
            this.cmb_Fornecedor.Location = new System.Drawing.Point(160, 420);
            this.cmb_Fornecedor.Name = "cmb_Fornecedor";
            this.cmb_Fornecedor.Size = new System.Drawing.Size(722, 27);
            this.cmb_Fornecedor.Sorted = true;
            this.cmb_Fornecedor.TabIndex = 48;
            // 
            // lbl_fornecedor
            // 
            this.lbl_fornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fornecedor.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fornecedor.Location = new System.Drawing.Point(75, 429);
            this.lbl_fornecedor.Name = "lbl_fornecedor";
            this.lbl_fornecedor.Size = new System.Drawing.Size(79, 19);
            this.lbl_fornecedor.TabIndex = 56;
            this.lbl_fornecedor.Text = "Fornecedor";
            // 
            // txt_idProduto
            // 
            this.txt_idProduto.EditValue = "";
            this.txt_idProduto.Enabled = false;
            this.txt_idProduto.EnterMoveNextControl = true;
            this.txt_idProduto.Location = new System.Drawing.Point(160, 48);
            this.txt_idProduto.Name = "txt_idProduto";
            this.txt_idProduto.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txt_idProduto.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_idProduto.Properties.Appearance.BackColor2 = System.Drawing.Color.White;
            this.txt_idProduto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idProduto.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txt_idProduto.Properties.Appearance.Options.UseBackColor = true;
            this.txt_idProduto.Properties.Appearance.Options.UseBorderColor = true;
            this.txt_idProduto.Properties.Appearance.Options.UseFont = true;
            this.txt_idProduto.Properties.Appearance.Options.UseForeColor = true;
            this.txt_idProduto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txt_idProduto.Properties.MaxLength = 50;
            this.txt_idProduto.Properties.NullValuePromptShowForEmptyValue = true;
            this.txt_idProduto.Size = new System.Drawing.Size(245, 28);
            this.txt_idProduto.TabIndex = 54;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigo.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(104, 51);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(50, 19);
            this.lblCodigo.TabIndex = 55;
            this.lblCodigo.Text = "Código";
            // 
            // txtCoddeBarra
            // 
            this.txtCoddeBarra.EditValue = "";
            this.txtCoddeBarra.EnterMoveNextControl = true;
            this.txtCoddeBarra.Location = new System.Drawing.Point(655, 42);
            this.txtCoddeBarra.Name = "txtCoddeBarra";
            this.txtCoddeBarra.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtCoddeBarra.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtCoddeBarra.Properties.Appearance.BackColor2 = System.Drawing.Color.White;
            this.txtCoddeBarra.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoddeBarra.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtCoddeBarra.Properties.Appearance.Options.UseBackColor = true;
            this.txtCoddeBarra.Properties.Appearance.Options.UseBorderColor = true;
            this.txtCoddeBarra.Properties.Appearance.Options.UseFont = true;
            this.txtCoddeBarra.Properties.Appearance.Options.UseForeColor = true;
            this.txtCoddeBarra.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtCoddeBarra.Properties.MaxLength = 50;
            this.txtCoddeBarra.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtCoddeBarra.Size = new System.Drawing.Size(227, 28);
            this.txtCoddeBarra.TabIndex = 34;
            // 
            // lblCodBarras
            // 
            this.lblCodBarras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodBarras.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodBarras.Location = new System.Drawing.Point(545, 51);
            this.lblCodBarras.Name = "lblCodBarras";
            this.lblCodBarras.Size = new System.Drawing.Size(104, 19);
            this.lblCodBarras.TabIndex = 53;
            this.lblCodBarras.Text = "Cód. de Barras";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(160, 314);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(345, 27);
            this.cmbCategoria.Sorted = true;
            this.cmbCategoria.TabIndex = 44;
            // 
            // cmbLocal
            // 
            this.cmbLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocal.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbLocal.FormattingEnabled = true;
            this.cmbLocal.Location = new System.Drawing.Point(160, 367);
            this.cmbLocal.Name = "cmbLocal";
            this.cmbLocal.Size = new System.Drawing.Size(345, 27);
            this.cmbLocal.TabIndex = 47;
            // 
            // lblDtVencimento
            // 
            this.lblDtVencimento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDtVencimento.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtVencimento.Location = new System.Drawing.Point(34, 159);
            this.lblDtVencimento.Name = "lblDtVencimento";
            this.lblDtVencimento.Size = new System.Drawing.Size(120, 19);
            this.lblDtVencimento.TabIndex = 52;
            this.lblDtVencimento.Text = "Data Vencimento";
            // 
            // lblLocal
            // 
            this.lblLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLocal.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.Location = new System.Drawing.Point(118, 375);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(36, 19);
            this.lblLocal.TabIndex = 51;
            this.lblLocal.Text = "Local";
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoria.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(87, 321);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(67, 19);
            this.lblCategoria.TabIndex = 50;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblQuantidade_Minimo
            // 
            this.lblQuantidade_Minimo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuantidade_Minimo.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade_Minimo.Location = new System.Drawing.Point(511, 207);
            this.lblQuantidade_Minimo.Name = "lblQuantidade_Minimo";
            this.lblQuantidade_Minimo.Size = new System.Drawing.Size(138, 19);
            this.lblQuantidade_Minimo.TabIndex = 49;
            this.lblQuantidade_Minimo.Text = "Quantidade Minímo";
            // 
            // lblPreco
            // 
            this.lblPreco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPreco.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(669, 264);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(88, 19);
            this.lblPreco.TabIndex = 45;
            this.lblPreco.Text = "Preço Venda";
            // 
            // txtDescricao
            // 
            this.txtDescricao.EditValue = "";
            this.txtDescricao.EnterMoveNextControl = true;
            this.txtDescricao.Location = new System.Drawing.Point(160, 102);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtDescricao.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtDescricao.Properties.Appearance.BackColor2 = System.Drawing.Color.White;
            this.txtDescricao.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtDescricao.Properties.Appearance.Options.UseBackColor = true;
            this.txtDescricao.Properties.Appearance.Options.UseBorderColor = true;
            this.txtDescricao.Properties.Appearance.Options.UseFont = true;
            this.txtDescricao.Properties.Appearance.Options.UseForeColor = true;
            this.txtDescricao.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtDescricao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Properties.MaxLength = 50;
            this.txtDescricao.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtDescricao.Size = new System.Drawing.Size(722, 28);
            this.txtDescricao.TabIndex = 35;
            // 
            // lblDescricao
            // 
            this.lblDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescricao.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(98, 105);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(56, 19);
            this.lblDescricao.TabIndex = 41;
            this.lblDescricao.Text = "Produto";
            // 
            // txtDTVencimento
            // 
            this.txtDTVencimento.EditValue = new System.DateTime(2012, 8, 19, 0, 0, 0, 0);
            this.txtDTVencimento.Location = new System.Drawing.Point(160, 156);
            this.txtDTVencimento.Name = "txtDTVencimento";
            this.txtDTVencimento.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txtDTVencimento.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtDTVencimento.Properties.Appearance.BackColor2 = System.Drawing.Color.White;
            this.txtDTVencimento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDTVencimento.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtDTVencimento.Properties.Appearance.Options.UseBackColor = true;
            this.txtDTVencimento.Properties.Appearance.Options.UseBorderColor = true;
            this.txtDTVencimento.Properties.Appearance.Options.UseFont = true;
            this.txtDTVencimento.Properties.Appearance.Options.UseForeColor = true;
            this.txtDTVencimento.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtDTVencimento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDTVencimento.Properties.MaxLength = 50;
            this.txtDTVencimento.Properties.MinValue = new System.DateTime(2012, 8, 19, 0, 0, 0, 0);
            this.txtDTVencimento.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtDTVencimento.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDTVencimento.Size = new System.Drawing.Size(114, 28);
            this.txtDTVencimento.StyleController = this.styleController1;
            this.txtDTVencimento.TabIndex = 36;
            // 
            // txt_lucro_valor
            // 
            this.txt_lucro_valor.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_lucro_valor.Location = new System.Drawing.Point(511, 259);
            this.txt_lucro_valor.Name = "txt_lucro_valor";
            this.txt_lucro_valor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_lucro_valor.Properties.Appearance.Options.UseFont = true;
            this.txt_lucro_valor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.txt_lucro_valor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_lucro_valor.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_lucro_valor.Properties.Mask.EditMask = "c2";
            this.txt_lucro_valor.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txt_lucro_valor.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txt_lucro_valor.Size = new System.Drawing.Size(120, 26);
            this.txt_lucro_valor.TabIndex = 42;
            // 
            // txt_lucro_porcentagem
            // 
            this.txt_lucro_porcentagem.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_lucro_porcentagem.Location = new System.Drawing.Point(511, 260);
            this.txt_lucro_porcentagem.Name = "txt_lucro_porcentagem";
            this.txt_lucro_porcentagem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_lucro_porcentagem.Properties.Appearance.Options.UseFont = true;
            this.txt_lucro_porcentagem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, false, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.txt_lucro_porcentagem.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_lucro_porcentagem.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_lucro_porcentagem.Properties.IsFloatValue = false;
            this.txt_lucro_porcentagem.Properties.Mask.EditMask = "P0";
            this.txt_lucro_porcentagem.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txt_lucro_porcentagem.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txt_lucro_porcentagem.Size = new System.Drawing.Size(120, 26);
            this.txt_lucro_porcentagem.TabIndex = 39;
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 661);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.LookAndFeel.SkinName = "Blue";
            this.Name = "frmProdutos";
            this.Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.cmbFiltros.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPesquisa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPanel)).EndInit();
            this.tabPanel.ResumeLayout(false);
            this.tabConsulta.ResumeLayout(false);
            this.tabCadastro.ResumeLayout(false);
            this.tabCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTabela)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOpcoes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_preco_compra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Quantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Quantidade_Minimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_idProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCoddeBarra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDTVencimento.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDTVencimento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_lucro_valor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_lucro_porcentagem.Properties)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.SpinEdit txtPreco;
        private DevExpress.XtraEditors.SpinEdit txt_preco_compra;
        private System.Windows.Forms.ComboBox cmbTipoLucro;
        private System.Windows.Forms.NumericUpDown txt_Quantidade;
        private System.Windows.Forms.NumericUpDown txt_Quantidade_Minimo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lbl_Quantidade;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cmb_Fornecedor;
        private DevExpress.XtraEditors.LabelControl lbl_fornecedor;
        private DevExpress.XtraEditors.TextEdit txt_idProduto;
        private DevExpress.XtraEditors.LabelControl lblCodigo;
        private DevExpress.XtraEditors.TextEdit txtCoddeBarra;
        private DevExpress.XtraEditors.LabelControl lblCodBarras;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbLocal;
        private DevExpress.XtraEditors.LabelControl lblDtVencimento;
        private DevExpress.XtraEditors.LabelControl lblLocal;
        private DevExpress.XtraEditors.LabelControl lblCategoria;
        private DevExpress.XtraEditors.LabelControl lblQuantidade_Minimo;
        private DevExpress.XtraEditors.LabelControl lblPreco;
        private DevExpress.XtraEditors.TextEdit txtDescricao;
        private DevExpress.XtraEditors.LabelControl lblDescricao;
        private DevExpress.XtraEditors.DateEdit txtDTVencimento;
        private DevExpress.XtraEditors.SpinEdit txt_lucro_valor;
        private DevExpress.XtraEditors.SpinEdit txt_lucro_porcentagem;



    }
    
}