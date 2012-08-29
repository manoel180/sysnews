using DAL;
namespace telas.vendas
{
    partial class frmVendas
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
            

            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txt_quantidade = new System.Windows.Forms.NumericUpDown();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblHeader = new DevExpress.XtraEditors.LabelControl();
            this.txt_produto = new DevExpress.XtraEditors.TextEdit();
            this.pnlAtalhos = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFinalizarVenda = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.gdv_Itens_Vendas = new DevExpress.XtraEditors.SpinEdit();
            this.lbl_Vendedor = new DevExpress.XtraEditors.TextEdit();
            this.txt_total = new DevExpress.XtraEditors.SpinEdit();
            this.gridView_itens_vendas = new System.Windows.Forms.DataGridView();
            this.idProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lkpedt_Cliente = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_quantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_produto.Properties)).BeginInit();
            this.pnlAtalhos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_Itens_Vendas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_Vendedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_total.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_itens_vendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpedt_Cliente.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblQuantidade.Location = new System.Drawing.Point(451, 171);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(138, 29);
            this.lblQuantidade.TabIndex = 12;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txt_quantidade.Location = new System.Drawing.Point(456, 203);
            this.txt_quantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(163, 35);
            this.txt_quantidade.TabIndex = 1;
            this.txt_quantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_quantidade.Validated += new System.EventHandler(this.txt_quantidade_Validated);
            // 
            // lblProduto
            // 
            this.lblProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblProduto.Location = new System.Drawing.Point(12, 171);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(98, 29);
            this.lblProduto.TabIndex = 11;
            this.lblProduto.Text = "Produto";
            // 
            // lblValor
            // 
            this.lblValor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblValor.Location = new System.Drawing.Point(620, 171);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(69, 29);
            this.lblValor.TabIndex = 13;
            this.lblValor.Text = "Valor";
            // 
            // lblHeader
            // 
            this.lblHeader.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.lblHeader.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHeader.Appearance.BackColor2 = System.Drawing.Color.White;
            this.lblHeader.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.lblHeader.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHeader.Appearance.Options.UseBackColor = true;
            this.lblHeader.Appearance.Options.UseFont = true;
            this.lblHeader.Appearance.Options.UseForeColor = true;
            this.lblHeader.Appearance.Options.UseTextOptions = true;
            this.lblHeader.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblHeader.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.lblHeader.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.lblHeader.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.lblHeader.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None;
            this.lblHeader.LineLocation = DevExpress.XtraEditors.LineLocation.Default;
            this.lblHeader.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Default;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.LookAndFeel.SkinName = "Blue";
            this.lblHeader.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(893, 35);
            this.lblHeader.TabIndex = 8;
            this.lblHeader.Text = "CAIXA";
            this.lblHeader.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            // 
            // txt_produto
            // 
            this.txt_produto.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.txt_produto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_produto.EnterMoveNextControl = true;
            this.txt_produto.Location = new System.Drawing.Point(12, 203);
            this.txt_produto.Name = "txt_produto";
            this.txt_produto.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Default;
            this.txt_produto.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.Default;
            this.txt_produto.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txt_produto.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txt_produto.Properties.Appearance.Options.UseFont = true;
            this.txt_produto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txt_produto.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txt_produto.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txt_produto.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txt_produto.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txt_produto.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txt_produto.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txt_produto.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txt_produto.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txt_produto.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txt_produto.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txt_produto.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txt_produto.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txt_produto.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txt_produto.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txt_produto.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txt_produto.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txt_produto.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txt_produto.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txt_produto.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txt_produto.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txt_produto.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txt_produto.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txt_produto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.txt_produto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_produto.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txt_produto.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Default;
            this.txt_produto.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.txt_produto.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Default;
            this.txt_produto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txt_produto.Size = new System.Drawing.Size(438, 35);
            this.txt_produto.TabIndex = 0;
            this.txt_produto.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            this.txt_produto.Validated += new System.EventHandler(this.txt_produto_Validated);
            // 
            // pnlAtalhos
            // 
            this.pnlAtalhos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlAtalhos.Controls.Add(this.label4);
            this.pnlAtalhos.Controls.Add(this.label3);
            this.pnlAtalhos.Controls.Add(this.label2);
            this.pnlAtalhos.Controls.Add(this.label1);
            this.pnlAtalhos.Location = new System.Drawing.Point(12, 431);
            this.pnlAtalhos.Name = "pnlAtalhos";
            this.pnlAtalhos.Size = new System.Drawing.Size(466, 129);
            this.pnlAtalhos.TabIndex = 14;
            this.pnlAtalhos.TabStop = false;
            this.pnlAtalhos.Text = "Atalhos";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label5.Location = new System.Drawing.Point(464, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Vendedor";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label6.Location = new System.Drawing.Point(12, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cliente";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label7.Location = new System.Drawing.Point(571, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 32);
            this.label7.TabIndex = 15;
            this.label7.Text = "TOTAL";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.btnFinalizarVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizarVenda.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnFinalizarVenda.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.btnFinalizarVenda.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.btnFinalizarVenda.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.btnFinalizarVenda.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.btnFinalizarVenda.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.btnFinalizarVenda.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btnFinalizarVenda.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFinalizarVenda.ImageLocation = DevExpress.XtraEditors.ImageLocation.Default;
            this.btnFinalizarVenda.Location = new System.Drawing.Point(681, 537);
            this.btnFinalizarVenda.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(110, 23);
            this.btnFinalizarVenda.TabIndex = 6;
            this.btnFinalizarVenda.TabStop = false;
            this.btnFinalizarVenda.Text = "Finalizar Venda";
            this.btnFinalizarVenda.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            this.btnFinalizarVenda.Click += new System.EventHandler(this.btnFinalizarVenda_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.simpleButton2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.simpleButton2.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.simpleButton2.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.simpleButton2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.simpleButton2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.simpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.Default;
            this.simpleButton2.Location = new System.Drawing.Point(807, 537);
            this.simpleButton2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.TabStop = false;
            this.simpleButton2.Text = "Cancelar";
            this.simpleButton2.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            this.simpleButton2.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gdv_Itens_Vendas
            // 
            this.gdv_Itens_Vendas.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.gdv_Itens_Vendas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdv_Itens_Vendas.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.gdv_Itens_Vendas.Enabled = false;
            this.gdv_Itens_Vendas.Location = new System.Drawing.Point(625, 203);
            this.gdv_Itens_Vendas.Name = "gdv_Itens_Vendas";
            this.gdv_Itens_Vendas.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Default;
            this.gdv_Itens_Vendas.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.Default;
            this.gdv_Itens_Vendas.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.gdv_Itens_Vendas.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gdv_Itens_Vendas.Properties.Appearance.Options.UseFont = true;
            this.gdv_Itens_Vendas.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gdv_Itens_Vendas.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gdv_Itens_Vendas.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gdv_Itens_Vendas.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gdv_Itens_Vendas.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gdv_Itens_Vendas.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gdv_Itens_Vendas.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gdv_Itens_Vendas.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gdv_Itens_Vendas.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gdv_Itens_Vendas.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gdv_Itens_Vendas.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gdv_Itens_Vendas.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gdv_Itens_Vendas.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gdv_Itens_Vendas.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gdv_Itens_Vendas.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gdv_Itens_Vendas.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gdv_Itens_Vendas.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gdv_Itens_Vendas.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gdv_Itens_Vendas.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.gdv_Itens_Vendas.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.gdv_Itens_Vendas.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.gdv_Itens_Vendas.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.gdv_Itens_Vendas.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gdv_Itens_Vendas.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            serializableAppearanceObject1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            serializableAppearanceObject1.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            serializableAppearanceObject1.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            serializableAppearanceObject1.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            serializableAppearanceObject1.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            serializableAppearanceObject1.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.gdv_Itens_Vendas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.gdv_Itens_Vendas.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.gdv_Itens_Vendas.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gdv_Itens_Vendas.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gdv_Itens_Vendas.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.gdv_Itens_Vendas.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Default;
            this.gdv_Itens_Vendas.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.gdv_Itens_Vendas.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Default;
            this.gdv_Itens_Vendas.Properties.Mask.EditMask = "c2";
            this.gdv_Itens_Vendas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.gdv_Itens_Vendas.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.gdv_Itens_Vendas.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.gdv_Itens_Vendas.Properties.SpinStyle = DevExpress.XtraEditors.Controls.SpinStyles.Vertical;
            this.gdv_Itens_Vendas.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.gdv_Itens_Vendas.Size = new System.Drawing.Size(256, 35);
            this.gdv_Itens_Vendas.TabIndex = 2;
            this.gdv_Itens_Vendas.TabStop = false;
            this.gdv_Itens_Vendas.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            // 
            // lbl_Vendedor
            // 
            this.lbl_Vendedor.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.lbl_Vendedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Vendedor.Location = new System.Drawing.Point(469, 121);
            this.lbl_Vendedor.Name = "lbl_Vendedor";
            this.lbl_Vendedor.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Default;
            this.lbl_Vendedor.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.Default;
            this.lbl_Vendedor.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_Vendedor.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.lbl_Vendedor.Properties.Appearance.Options.UseFont = true;
            this.lbl_Vendedor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.lbl_Vendedor.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.lbl_Vendedor.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.lbl_Vendedor.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.lbl_Vendedor.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.lbl_Vendedor.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.lbl_Vendedor.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.lbl_Vendedor.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.lbl_Vendedor.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.lbl_Vendedor.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.lbl_Vendedor.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.lbl_Vendedor.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.lbl_Vendedor.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.lbl_Vendedor.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.lbl_Vendedor.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.lbl_Vendedor.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.lbl_Vendedor.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.lbl_Vendedor.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.lbl_Vendedor.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.lbl_Vendedor.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.lbl_Vendedor.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.lbl_Vendedor.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.lbl_Vendedor.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.lbl_Vendedor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.lbl_Vendedor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.lbl_Vendedor.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.lbl_Vendedor.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Default;
            this.lbl_Vendedor.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.lbl_Vendedor.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Default;
            this.lbl_Vendedor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.lbl_Vendedor.Properties.ReadOnly = true;
            this.lbl_Vendedor.Size = new System.Drawing.Size(413, 35);
            this.lbl_Vendedor.TabIndex = 99;
            this.lbl_Vendedor.TabStop = false;
            this.lbl_Vendedor.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            // 
            // txt_total
            // 
            this.txt_total.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.txt_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_total.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_total.Location = new System.Drawing.Point(709, 443);
            this.txt_total.Name = "txt_total";
            this.txt_total.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Default;
            this.txt_total.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.Default;
            this.txt_total.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txt_total.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txt_total.Properties.Appearance.Options.UseFont = true;
            this.txt_total.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txt_total.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txt_total.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txt_total.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txt_total.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txt_total.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txt_total.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txt_total.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txt_total.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txt_total.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txt_total.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txt_total.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txt_total.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txt_total.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txt_total.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txt_total.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txt_total.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txt_total.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.txt_total.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White;
            this.txt_total.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.txt_total.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txt_total.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txt_total.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.txt_total.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.txt_total.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.txt_total.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txt_total.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            serializableAppearanceObject2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            serializableAppearanceObject2.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            serializableAppearanceObject2.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            serializableAppearanceObject2.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            serializableAppearanceObject2.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            serializableAppearanceObject2.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.txt_total.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.txt_total.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_total.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_total.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt_total.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.txt_total.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Default;
            this.txt_total.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.txt_total.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Default;
            this.txt_total.Properties.Mask.EditMask = "c2";
            this.txt_total.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_total.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txt_total.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.txt_total.Properties.ReadOnly = true;
            this.txt_total.Properties.SpinStyle = DevExpress.XtraEditors.Controls.SpinStyles.Vertical;
            this.txt_total.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txt_total.Size = new System.Drawing.Size(172, 35);
            this.txt_total.TabIndex = 100;
            this.txt_total.TabStop = false;
            this.txt_total.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
            // 
            // gridView_itens_vendas
            // 
            this.gridView_itens_vendas.AllowUserToAddRows = false;
            this.gridView_itens_vendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridView_itens_vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView_itens_vendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProduto,
            this.produto,
            this.quantidade,
            this.valor});
            this.gridView_itens_vendas.Location = new System.Drawing.Point(12, 244);
            this.gridView_itens_vendas.MultiSelect = false;
            this.gridView_itens_vendas.Name = "gridView_itens_vendas";
            this.gridView_itens_vendas.ReadOnly = true;
            this.gridView_itens_vendas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridView_itens_vendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView_itens_vendas.Size = new System.Drawing.Size(870, 181);
            this.gridView_itens_vendas.TabIndex = 101;
            this.gridView_itens_vendas.TabStop = false;
            this.gridView_itens_vendas.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.gridView_itens_vendas_UserDeletingRow);
            // 
            // idProduto
            // 
            this.idProduto.HeaderText = "idProduto";
            this.idProduto.Name = "idProduto";
            this.idProduto.ReadOnly = true;
            this.idProduto.Visible = false;
            // 
            // produto
            // 
            this.produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.produto.HeaderText = "Produto";
            this.produto.Name = "produto";
            this.produto.ReadOnly = true;
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            // 
            // valor
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.valor.DefaultCellStyle = dataGridViewCellStyle1;
            this.valor.HeaderText = "Total";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // lkpedt_Cliente
            // 
            this.lkpedt_Cliente.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
            this.lkpedt_Cliente.Location = new System.Drawing.Point(12, 122);
            this.lkpedt_Cliente.Name = "lkpedt_Cliente";
            this.lkpedt_Cliente.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Default;
            this.lkpedt_Cliente.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.lkpedt_Cliente.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lkpedt_Cliente.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.lkpedt_Cliente.Properties.Appearance.Options.UseFont = true;
            this.lkpedt_Cliente.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.lkpedt_Cliente.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.lkpedt_Cliente.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.lkpedt_Cliente.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.lkpedt_Cliente.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.lkpedt_Cliente.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.lkpedt_Cliente.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.lkpedt_Cliente.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.lkpedt_Cliente.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.lkpedt_Cliente.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.lkpedt_Cliente.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.lkpedt_Cliente.Properties.AppearanceDropDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.lkpedt_Cliente.Properties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.lkpedt_Cliente.Properties.AppearanceDropDown.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.lkpedt_Cliente.Properties.AppearanceDropDown.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.lkpedt_Cliente.Properties.AppearanceDropDown.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.lkpedt_Cliente.Properties.AppearanceDropDown.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.lkpedt_Cliente.Properties.AppearanceDropDownHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.lkpedt_Cliente.Properties.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.lkpedt_Cliente.Properties.AppearanceDropDownHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.lkpedt_Cliente.Properties.AppearanceDropDownHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.lkpedt_Cliente.Properties.AppearanceDropDownHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.lkpedt_Cliente.Properties.AppearanceDropDownHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.lkpedt_Cliente.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.lkpedt_Cliente.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.lkpedt_Cliente.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.lkpedt_Cliente.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.lkpedt_Cliente.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.lkpedt_Cliente.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.lkpedt_Cliente.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.lkpedt_Cliente.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.lkpedt_Cliente.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            this.lkpedt_Cliente.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            this.lkpedt_Cliente.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            this.lkpedt_Cliente.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.lkpedt_Cliente.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.None;
            this.lkpedt_Cliente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            serializableAppearanceObject3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            serializableAppearanceObject3.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            serializableAppearanceObject3.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
            serializableAppearanceObject3.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
            serializableAppearanceObject3.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
            serializableAppearanceObject3.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
            this.lkpedt_Cliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "...", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.lkpedt_Cliente.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lkpedt_Cliente.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("matricula", "matricula", 107, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nome", "nome", 71, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("descricao", "setor", 64, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lkpedt_Cliente.Properties.DisplayMember = "nome";
            this.lkpedt_Cliente.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.lkpedt_Cliente.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Default;
            this.lkpedt_Cliente.Properties.HeaderClickMode = DevExpress.XtraEditors.Controls.HeaderClickMode.Sorting;
            this.lkpedt_Cliente.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Default;
            this.lkpedt_Cliente.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.lkpedt_Cliente.Properties.NullText = "";
            this.lkpedt_Cliente.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.Default;
            this.lkpedt_Cliente.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lkpedt_Cliente.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.SingleClick;
            this.lkpedt_Cliente.Properties.SortColumnIndex = 1;
            this.lkpedt_Cliente.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lkpedt_Cliente.Properties.ValueMember = "idClientes";
            this.lkpedt_Cliente.Size = new System.Drawing.Size(438, 35);
            this.lkpedt_Cliente.TabIndex = 102;
            this.lkpedt_Cliente.TabStop = false;
            this.lkpedt_Cliente.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
           
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(893, 572);
            this.Controls.Add(this.lkpedt_Cliente);
            this.Controls.Add(this.gridView_itens_vendas);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.lbl_Vendedor);
            this.Controls.Add(this.gdv_Itens_Vendas);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnFinalizarVenda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnlAtalhos);
            this.Controls.Add(this.txt_produto);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.txt_quantidade);
            this.Controls.Add(this.lblQuantidade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmVendas";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = ".:: SYSNEWS ::. ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_quantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_produto.Properties)).EndInit();
            this.pnlAtalhos.ResumeLayout(false);
            this.pnlAtalhos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_Itens_Vendas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_Vendedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_total.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_itens_vendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpedt_Cliente.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.NumericUpDown txt_quantidade;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblValor;
        private DevExpress.XtraEditors.LabelControl lblHeader;
        private DevExpress.XtraEditors.TextEdit txt_produto;
        private System.Windows.Forms.GroupBox pnlAtalhos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton btnFinalizarVenda;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SpinEdit gdv_Itens_Vendas;
        private DevExpress.XtraEditors.TextEdit lbl_Vendedor;
        private DevExpress.XtraEditors.SpinEdit txt_total;
        private System.Windows.Forms.DataGridView gridView_itens_vendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private DevExpress.XtraEditors.LookUpEdit lkpedt_Cliente;
      
    }
}