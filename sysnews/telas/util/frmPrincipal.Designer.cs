namespace telas.util
{
    partial class frmPrincipal
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
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.mnuBarMenus = new DevExpress.XtraBars.Bar();
            this.mnuCadastros = new DevExpress.XtraBars.BarSubItem();
            this.mnuItemProdutos = new DevExpress.XtraBars.BarButtonItem();
            this.mnuItemCategorias = new DevExpress.XtraBars.BarButtonItem();
            this.mnuItemClientes = new DevExpress.XtraBars.BarButtonItem();
            this.mnuItemSetores = new DevExpress.XtraBars.BarButtonItem();
            this.mnuItemLocais = new DevExpress.XtraBars.BarButtonItem();
            this.mnuRelatorios = new DevExpress.XtraBars.BarSubItem();
            this.mnuConfiguracoes = new DevExpress.XtraBars.BarSubItem();
            this.mnuItemUsuarios = new DevExpress.XtraBars.BarButtonItem();
            this.mnuAjuda = new DevExpress.XtraBars.BarSubItem();
            this.mnuItemSobre = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.lblStatus = new DevExpress.XtraBars.BarStaticItem();
            this.lblUsuario = new DevExpress.XtraBars.BarStaticItem();
            this.lblHora = new DevExpress.XtraBars.BarStaticItem();
            this.lblData = new DevExpress.XtraBars.BarStaticItem();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barBtnItemClientes = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnItemProdutos = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnItemSair = new DevExpress.XtraBars.BarButtonItem();
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctxtMnuTrayIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCliente = new System.Windows.Forms.ToolStripButton();
            this.btnVendas = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.mnuBarFerramentas = new DevExpress.XtraBars.Bar();
            this.styleController1 = new DevExpress.XtraEditors.StyleController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            this.ctxtMnuTrayIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager
            // 
            this.barManager.AllowMoveBarOnToolbar = false;
            this.barManager.AllowQuickCustomization = false;
            this.barManager.AllowShowToolbarsPopup = false;
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.mnuBarMenus,
            this.bar3,
            this.bar1});
            this.barManager.Controller = this.barAndDockingController1;
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mnuCadastros,
            this.mnuRelatorios,
            this.mnuConfiguracoes,
            this.mnuAjuda,
            this.mnuItemSobre,
            this.mnuItemUsuarios,
            this.lblData,
            this.lblHora,
            this.lblUsuario,
            this.mnuItemProdutos,
            this.mnuItemCategorias,
            this.mnuItemClientes,
            this.mnuItemSetores,
            this.lblStatus,
            this.mnuItemLocais,
            this.barBtnItemClientes,
            this.barBtnItemSair,
            this.barBtnItemProdutos});
            this.barManager.MainMenu = this.mnuBarMenus;
            this.barManager.MaxItemId = 24;
            this.barManager.StatusBar = this.bar3;
            // 
            // mnuBarMenus
            // 
            this.mnuBarMenus.BarName = "Menus";
            this.mnuBarMenus.DockCol = 0;
            this.mnuBarMenus.DockRow = 0;
            this.mnuBarMenus.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.mnuBarMenus.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.mnuCadastros, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "C", ""),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuRelatorios),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuConfiguracoes),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuAjuda)});
            this.mnuBarMenus.OptionsBar.AllowQuickCustomization = false;
            this.mnuBarMenus.OptionsBar.DisableCustomization = true;
            this.mnuBarMenus.OptionsBar.DrawDragBorder = false;
            this.mnuBarMenus.OptionsBar.MultiLine = true;
            this.mnuBarMenus.OptionsBar.UseWholeRow = true;
            this.mnuBarMenus.Text = "Menu Principal";
            // 
            // mnuCadastros
            // 
            this.mnuCadastros.Caption = "&Cadastros";
            this.mnuCadastros.Id = 0;
            this.mnuCadastros.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C));
            this.mnuCadastros.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuItemProdutos),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuItemCategorias),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuItemClientes),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuItemSetores),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuItemLocais)});
            this.mnuCadastros.Name = "mnuCadastros";
            // 
            // mnuItemProdutos
            // 
            this.mnuItemProdutos.Caption = "Produtos";
            this.mnuItemProdutos.Glyph = global::telas.Properties.Resources.btn_add_produto;
            this.mnuItemProdutos.Id = 13;
            this.mnuItemProdutos.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2);
            this.mnuItemProdutos.Name = "mnuItemProdutos";
            this.mnuItemProdutos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuItemProdutos_ItemClick);
            // 
            // mnuItemCategorias
            // 
            this.mnuItemCategorias.Caption = "Categorias";
            this.mnuItemCategorias.Id = 14;
            this.mnuItemCategorias.Name = "mnuItemCategorias";
            this.mnuItemCategorias.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuItemCategorias_ItemClick);
            // 
            // mnuItemClientes
            // 
            this.mnuItemClientes.Caption = "Clientes";
            this.mnuItemClientes.Id = 15;
            this.mnuItemClientes.Name = "mnuItemClientes";
            this.mnuItemClientes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuItemClientes_ItemClick);
            // 
            // mnuItemSetores
            // 
            this.mnuItemSetores.Caption = "Setores";
            this.mnuItemSetores.Id = 16;
            this.mnuItemSetores.Name = "mnuItemSetores";
            this.mnuItemSetores.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuItemSetores_ItemClick);
            // 
            // mnuItemLocais
            // 
            this.mnuItemLocais.Caption = "Locais";
            this.mnuItemLocais.Id = 20;
            this.mnuItemLocais.Name = "mnuItemLocais";
            this.mnuItemLocais.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuItemLocais_ItemClick);
            // 
            // mnuRelatorios
            // 
            this.mnuRelatorios.Caption = "Relatórios";
            this.mnuRelatorios.Id = 1;
            this.mnuRelatorios.Name = "mnuRelatorios";
            // 
            // mnuConfiguracoes
            // 
            this.mnuConfiguracoes.Caption = "Configruações";
            this.mnuConfiguracoes.Id = 2;
            this.mnuConfiguracoes.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuItemUsuarios)});
            this.mnuConfiguracoes.Name = "mnuConfiguracoes";
            // 
            // mnuItemUsuarios
            // 
            this.mnuItemUsuarios.Caption = "Usuários";
            this.mnuItemUsuarios.Id = 5;
            this.mnuItemUsuarios.Name = "mnuItemUsuarios";
            this.mnuItemUsuarios.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuItemUsuarios_ItemClick);
            // 
            // mnuAjuda
            // 
            this.mnuAjuda.Caption = "Ajuda";
            this.mnuAjuda.Id = 3;
            this.mnuAjuda.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuItemSobre)});
            this.mnuAjuda.Name = "mnuAjuda";
            // 
            // mnuItemSobre
            // 
            this.mnuItemSobre.Caption = "Sobre";
            this.mnuItemSobre.Id = 4;
            this.mnuItemSobre.Name = "mnuItemSobre";
            this.mnuItemSobre.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuItemSobre_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.lblStatus),
            new DevExpress.XtraBars.LinkPersistInfo(this.lblUsuario),
            new DevExpress.XtraBars.LinkPersistInfo(this.lblHora),
            new DevExpress.XtraBars.LinkPersistInfo(this.lblData)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring;
            this.lblStatus.Caption = "lblStatus";
            this.lblStatus.Id = 19;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.TextAlignment = System.Drawing.StringAlignment.Near;
            this.lblStatus.Width = 32;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Caption = "lblUsuario";
            this.lblUsuario.Id = 12;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // lblHora
            // 
            this.lblHora.Caption = "lblHora";
            this.lblHora.Id = 9;
            this.lblHora.Name = "lblHora";
            this.lblHora.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // lblData
            // 
            this.lblData.Caption = "lblData";
            this.lblData.Id = 10;
            this.lblData.Name = "lblData";
            this.lblData.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 4";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(42, 188);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnItemClientes),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnItemProdutos),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnItemSair)});
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Custom 4";
            // 
            // barBtnItemClientes
            // 
            this.barBtnItemClientes.Caption = "Clientes";
            this.barBtnItemClientes.Id = 21;
            this.barBtnItemClientes.Name = "barBtnItemClientes";
            // 
            // barBtnItemProdutos
            // 
            this.barBtnItemProdutos.Caption = "Produtos";
            this.barBtnItemProdutos.Glyph = global::telas.Properties.Resources.btn_add_produto;
            this.barBtnItemProdutos.Id = 23;
            this.barBtnItemProdutos.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2);
            this.barBtnItemProdutos.Name = "barBtnItemProdutos";
            toolTipTitleItem1.Text = "Produtos";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Cadastro e Pesquisa de Produtos";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.barBtnItemProdutos.SuperTip = superToolTip1;
            // 
            // barBtnItemSair
            // 
            this.barBtnItemSair.Caption = "Sair";
            this.barBtnItemSair.Glyph = global::telas.Properties.Resources.btn_sair;
            this.barBtnItemSair.Id = 22;
            this.barBtnItemSair.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4));
            this.barBtnItemSair.Name = "barBtnItemSair";
            toolTipTitleItem2.Text = "Sair";
            toolTipItem2.LeftIndent = 6;
            toolTipItem2.Text = "Finalizar a sessão atual do SYSNEWS";
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            this.barBtnItemSair.SuperTip = superToolTip2;
            // 
            // barAndDockingController1
            // 
            this.barAndDockingController1.PaintStyleName = "Skin";
            this.barAndDockingController1.PropertiesBar.AllowLinkLighting = false;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(909, 69);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 616);
            this.barDockControlBottom.Size = new System.Drawing.Size(909, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 69);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 547);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(909, 69);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 547);
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Money Twins";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "SYSNEWS";
            this.notifyIcon.ContextMenuStrip = this.ctxtMnuTrayIcon;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "SYSNEWS";
            this.notifyIcon.Visible = true;
            // 
            // ctxtMnuTrayIcon
            // 
            this.ctxtMnuTrayIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.vendasToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.ctxtMnuTrayIcon.Name = "ctxtMnuTrayIcon";
            this.ctxtMnuTrayIcon.Size = new System.Drawing.Size(117, 70);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.toolStripMenuItem1.Text = "Clientes";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(53, 35);
            this.btnCliente.Text = "Clientes";
            this.btnCliente.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.Image = ((System.Drawing.Image)(resources.GetObject("btnVendas.Image")));
            this.btnVendas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(49, 35);
            this.btnVendas.Text = "Vendas";
            this.btnVendas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // btnSair
            // 
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(30, 35);
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // mnuBarFerramentas
            // 
            this.mnuBarFerramentas.BarAppearance.Normal.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.mnuBarFerramentas.BarName = "Ferramentas";
            this.mnuBarFerramentas.DockCol = 0;
            this.mnuBarFerramentas.DockRow = 1;
            this.mnuBarFerramentas.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.mnuBarFerramentas.OptionsBar.AllowQuickCustomization = false;
            this.mnuBarFerramentas.OptionsBar.DisableCustomization = true;
            this.mnuBarFerramentas.OptionsBar.DrawDragBorder = false;
            this.mnuBarFerramentas.OptionsBar.UseWholeRow = true;
            this.mnuBarFerramentas.Text = "Ferramentas";
            // 
            // styleController1
            // 
            this.styleController1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleController1.Appearance.Options.UseFont = true;
            this.styleController1.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.styleController1.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleController1.AppearanceDisabled.Options.UseBackColor = true;
            this.styleController1.AppearanceDisabled.Options.UseFont = true;
            // 
            // frmPrincipal
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::telas.Properties.Resources.LOGO_SYS_NEWS_sem_fundo;
            this.ClientSize = new System.Drawing.Size(909, 641);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.LookAndFeel.SkinName = "Lilian";
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:: SYSNEWS ::.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            this.ctxtMnuTrayIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar mnuBarMenus;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem mnuCadastros;
        private DevExpress.XtraBars.BarSubItem mnuRelatorios;
        private DevExpress.XtraBars.BarSubItem mnuConfiguracoes;
        private DevExpress.XtraBars.BarSubItem mnuAjuda;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.XtraBars.BarButtonItem mnuItemSobre;
        private DevExpress.XtraBars.BarButtonItem mnuItemUsuarios;
        private System.Windows.Forms.Timer timer;
        private DevExpress.XtraBars.BarStaticItem lblUsuario;
        private DevExpress.XtraBars.BarStaticItem lblData;
        private DevExpress.XtraBars.BarStaticItem lblHora;
        private DevExpress.XtraBars.BarButtonItem mnuItemProdutos;
        private DevExpress.XtraBars.BarButtonItem mnuItemCategorias;
        private DevExpress.XtraBars.BarButtonItem mnuItemClientes;
        private DevExpress.XtraBars.BarButtonItem mnuItemSetores;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private DevExpress.XtraBars.Bar mnuBarFerramentas;
        private System.Windows.Forms.ToolStripButton btnCliente;
        private System.Windows.Forms.ToolStripButton btnVendas;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.ContextMenuStrip ctxtMnuTrayIcon;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private DevExpress.XtraBars.BarButtonItem mnuItemLocais;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barBtnItemClientes;
        private DevExpress.XtraBars.BarButtonItem barBtnItemSair;
        private DevExpress.XtraBars.BarButtonItem barBtnItemProdutos;
        private DevExpress.XtraBars.BarAndDockingController barAndDockingController1;
        private DevExpress.XtraEditors.StyleController styleController1;
        public DevExpress.XtraBars.BarStaticItem lblStatus;
    }
}