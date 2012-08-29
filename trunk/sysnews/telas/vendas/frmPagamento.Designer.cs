namespace telas.vendas
{
    partial class frmPagamento
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
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
			this.lbl_Header = new DevExpress.XtraEditors.LabelControl();
			this.rdgrp_tipo_pagamento = new DevExpress.XtraEditors.RadioGroup();
			this.lbl_valor = new DevExpress.XtraEditors.LabelControl();
			this.lbl_valor_pago = new DevExpress.XtraEditors.LabelControl();
			this.lbl_troco = new DevExpress.XtraEditors.LabelControl();
			this.btn_efetuar_pagamento = new DevExpress.XtraEditors.SimpleButton();
			this.btn_cancelar = new DevExpress.XtraEditors.SimpleButton();
			this.txt_valor = new DevExpress.XtraEditors.SpinEdit();
			this.txt_valor_pago = new DevExpress.XtraEditors.SpinEdit();
			this.txt_troco = new DevExpress.XtraEditors.SpinEdit();
			this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
			((System.ComponentModel.ISupportInitialize)(this.rdgrp_tipo_pagamento.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_valor.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_valor_pago.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_troco.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_Header
			// 
			this.lbl_Header.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
			this.lbl_Header.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lbl_Header.Appearance.BackColor2 = System.Drawing.Color.White;
			this.lbl_Header.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Header.Appearance.ForeColor = System.Drawing.Color.White;
			this.lbl_Header.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.lbl_Header.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_Header.Appearance.Options.UseBackColor = true;
			this.lbl_Header.Appearance.Options.UseFont = true;
			this.lbl_Header.Appearance.Options.UseForeColor = true;
			this.lbl_Header.Appearance.Options.UseTextOptions = true;
			this.lbl_Header.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.lbl_Header.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
			this.lbl_Header.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
			this.lbl_Header.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
			this.lbl_Header.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
			this.lbl_Header.AutoEllipsis = true;
			this.lbl_Header.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
			this.lbl_Header.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbl_Header.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None;
			this.lbl_Header.LineLocation = DevExpress.XtraEditors.LineLocation.Default;
			this.lbl_Header.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Default;
			this.lbl_Header.Location = new System.Drawing.Point(0, 0);
			this.lbl_Header.LookAndFeel.SkinName = "Blue";
			this.lbl_Header.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
			this.lbl_Header.Name = "lbl_Header";
			this.lbl_Header.Size = new System.Drawing.Size(893, 35);
			this.lbl_Header.TabIndex = 9;
			this.lbl_Header.Text = "FORMA DE PAGAMENTO";
			this.lbl_Header.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
			// 
			// rdgrp_tipo_pagamento
			// 
			this.rdgrp_tipo_pagamento.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
			this.rdgrp_tipo_pagamento.EditValue = ((short)(1));
			this.rdgrp_tipo_pagamento.Location = new System.Drawing.Point(12, 146);
			this.rdgrp_tipo_pagamento.Name = "rdgrp_tipo_pagamento";
			this.rdgrp_tipo_pagamento.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Default;
			this.rdgrp_tipo_pagamento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdgrp_tipo_pagamento.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.rdgrp_tipo_pagamento.Properties.Appearance.Options.UseFont = true;
			this.rdgrp_tipo_pagamento.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
			this.rdgrp_tipo_pagamento.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
			this.rdgrp_tipo_pagamento.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
			this.rdgrp_tipo_pagamento.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
			this.rdgrp_tipo_pagamento.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
			this.rdgrp_tipo_pagamento.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.rdgrp_tipo_pagamento.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
			this.rdgrp_tipo_pagamento.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
			this.rdgrp_tipo_pagamento.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
			this.rdgrp_tipo_pagamento.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
			this.rdgrp_tipo_pagamento.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
			this.rdgrp_tipo_pagamento.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.rdgrp_tipo_pagamento.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
			this.rdgrp_tipo_pagamento.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
			this.rdgrp_tipo_pagamento.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
			this.rdgrp_tipo_pagamento.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
			this.rdgrp_tipo_pagamento.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
			this.rdgrp_tipo_pagamento.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.rdgrp_tipo_pagamento.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
			this.rdgrp_tipo_pagamento.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
			this.rdgrp_tipo_pagamento.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
			this.rdgrp_tipo_pagamento.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
			this.rdgrp_tipo_pagamento.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
			this.rdgrp_tipo_pagamento.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
			this.rdgrp_tipo_pagamento.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
			this.rdgrp_tipo_pagamento.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Default;
			this.rdgrp_tipo_pagamento.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Near;
			this.rdgrp_tipo_pagamento.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "Dinheiro"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(2)), "Cartão de Crédito"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(3)), "Cartão de Débito"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(4)), "à Prazo")});
			this.rdgrp_tipo_pagamento.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
			this.rdgrp_tipo_pagamento.Size = new System.Drawing.Size(268, 192);
			this.rdgrp_tipo_pagamento.TabIndex = 10;
			this.rdgrp_tipo_pagamento.TabStop = false;
			this.rdgrp_tipo_pagamento.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
			this.rdgrp_tipo_pagamento.SelectedIndexChanged += new System.EventHandler(this.rdgrp_tipo_pagamento_SelectedIndexChanged);
			// 
			// lbl_valor
			// 
			this.lbl_valor.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
			this.lbl_valor.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
			this.lbl_valor.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.lbl_valor.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_valor.Appearance.Options.UseFont = true;
			this.lbl_valor.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
			this.lbl_valor.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
			this.lbl_valor.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
			this.lbl_valor.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
			this.lbl_valor.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
			this.lbl_valor.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Default;
			this.lbl_valor.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None;
			this.lbl_valor.LineLocation = DevExpress.XtraEditors.LineLocation.Default;
			this.lbl_valor.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Default;
			this.lbl_valor.Location = new System.Drawing.Point(429, 153);
			this.lbl_valor.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
			this.lbl_valor.Name = "lbl_valor";
			this.lbl_valor.Size = new System.Drawing.Size(56, 23);
			this.lbl_valor.TabIndex = 11;
			this.lbl_valor.Text = "VALOR";
			this.lbl_valor.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
			// 
			// lbl_valor_pago
			// 
			this.lbl_valor_pago.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
			this.lbl_valor_pago.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
			this.lbl_valor_pago.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.lbl_valor_pago.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_valor_pago.Appearance.Options.UseFont = true;
			this.lbl_valor_pago.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
			this.lbl_valor_pago.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
			this.lbl_valor_pago.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
			this.lbl_valor_pago.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
			this.lbl_valor_pago.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
			this.lbl_valor_pago.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Default;
			this.lbl_valor_pago.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None;
			this.lbl_valor_pago.LineLocation = DevExpress.XtraEditors.LineLocation.Default;
			this.lbl_valor_pago.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Default;
			this.lbl_valor_pago.Location = new System.Drawing.Point(376, 205);
			this.lbl_valor_pago.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
			this.lbl_valor_pago.Name = "lbl_valor_pago";
			this.lbl_valor_pago.Size = new System.Drawing.Size(109, 23);
			this.lbl_valor_pago.TabIndex = 13;
			this.lbl_valor_pago.Text = "VALOR PAGO";
			this.lbl_valor_pago.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
			// 
			// lbl_troco
			// 
			this.lbl_troco.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
			this.lbl_troco.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
			this.lbl_troco.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.lbl_troco.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_troco.Appearance.Options.UseFont = true;
			this.lbl_troco.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
			this.lbl_troco.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
			this.lbl_troco.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
			this.lbl_troco.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
			this.lbl_troco.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
			this.lbl_troco.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Default;
			this.lbl_troco.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None;
			this.lbl_troco.LineLocation = DevExpress.XtraEditors.LineLocation.Default;
			this.lbl_troco.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Default;
			this.lbl_troco.Location = new System.Drawing.Point(425, 257);
			this.lbl_troco.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
			this.lbl_troco.Name = "lbl_troco";
			this.lbl_troco.Size = new System.Drawing.Size(60, 23);
			this.lbl_troco.TabIndex = 15;
			this.lbl_troco.Text = "TROCO";
			this.lbl_troco.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
			// 
			// btn_efetuar_pagamento
			// 
			this.btn_efetuar_pagamento.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
			this.btn_efetuar_pagamento.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.btn_efetuar_pagamento.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
			this.btn_efetuar_pagamento.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
			this.btn_efetuar_pagamento.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
			this.btn_efetuar_pagamento.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
			this.btn_efetuar_pagamento.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
			this.btn_efetuar_pagamento.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
			this.btn_efetuar_pagamento.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btn_efetuar_pagamento.ImageLocation = DevExpress.XtraEditors.ImageLocation.Default;
			this.btn_efetuar_pagamento.Location = new System.Drawing.Point(537, 393);
			this.btn_efetuar_pagamento.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
			this.btn_efetuar_pagamento.Name = "btn_efetuar_pagamento";
			this.btn_efetuar_pagamento.Size = new System.Drawing.Size(139, 41);
			this.btn_efetuar_pagamento.TabIndex = 2;
			this.btn_efetuar_pagamento.Text = "EFETUAR PAGAMENTO";
			this.btn_efetuar_pagamento.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
			this.btn_efetuar_pagamento.Click += new System.EventHandler(this.btn_efetuar_pagamento_Click);
			// 
			// btn_cancelar
			// 
			this.btn_cancelar.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
			this.btn_cancelar.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.btn_cancelar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
			this.btn_cancelar.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
			this.btn_cancelar.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
			this.btn_cancelar.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
			this.btn_cancelar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
			this.btn_cancelar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
			this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btn_cancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.Default;
			this.btn_cancelar.Location = new System.Drawing.Point(697, 393);
			this.btn_cancelar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
			this.btn_cancelar.Name = "btn_cancelar";
			this.btn_cancelar.Size = new System.Drawing.Size(139, 41);
			this.btn_cancelar.TabIndex = 3;
			this.btn_cancelar.Text = "CANCELAR";
			this.btn_cancelar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
			this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
			// 
			// txt_valor
			// 
			this.txt_valor.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
			this.txt_valor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txt_valor.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.txt_valor.Enabled = false;
			this.txt_valor.Location = new System.Drawing.Point(491, 146);
			this.txt_valor.Name = "txt_valor";
			this.txt_valor.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Default;
			this.txt_valor.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.Default;
			this.txt_valor.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.txt_valor.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.txt_valor.Properties.Appearance.Options.UseFont = true;
			this.txt_valor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
			this.txt_valor.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
			this.txt_valor.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
			this.txt_valor.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
			this.txt_valor.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
			this.txt_valor.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Blue;
			this.txt_valor.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.txt_valor.Properties.AppearanceDisabled.Options.UseForeColor = true;
			this.txt_valor.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
			this.txt_valor.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
			this.txt_valor.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
			this.txt_valor.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
			this.txt_valor.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
			this.txt_valor.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.txt_valor.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
			this.txt_valor.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
			this.txt_valor.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
			this.txt_valor.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
			this.txt_valor.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
			this.txt_valor.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.txt_valor.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
			this.txt_valor.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
			this.txt_valor.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
			this.txt_valor.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
			this.txt_valor.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
			this.txt_valor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
			serializableAppearanceObject1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			serializableAppearanceObject1.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
			serializableAppearanceObject1.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
			serializableAppearanceObject1.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
			serializableAppearanceObject1.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
			serializableAppearanceObject1.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
			this.txt_valor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
			this.txt_valor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txt_valor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.txt_valor.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.txt_valor.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
			this.txt_valor.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Default;
			this.txt_valor.Properties.LookAndFeel.SkinName = "Lilian";
			this.txt_valor.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
			this.txt_valor.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
			this.txt_valor.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Default;
			this.txt_valor.Properties.Mask.EditMask = "c2";
			this.txt_valor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txt_valor.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.txt_valor.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.txt_valor.Properties.SpinStyle = DevExpress.XtraEditors.Controls.SpinStyles.Vertical;
			this.txt_valor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.txt_valor.Size = new System.Drawing.Size(256, 35);
			this.txt_valor.TabIndex = 21;
			this.txt_valor.TabStop = false;
			this.txt_valor.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
			// 
			// txt_valor_pago
			// 
			this.txt_valor_pago.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
			this.txt_valor_pago.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txt_valor_pago.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.txt_valor_pago.Location = new System.Drawing.Point(491, 198);
			this.txt_valor_pago.Name = "txt_valor_pago";
			this.txt_valor_pago.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Default;
			this.txt_valor_pago.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.Default;
			this.txt_valor_pago.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.txt_valor_pago.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.txt_valor_pago.Properties.Appearance.Options.UseFont = true;
			this.txt_valor_pago.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
			this.txt_valor_pago.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
			this.txt_valor_pago.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
			this.txt_valor_pago.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
			this.txt_valor_pago.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
			this.txt_valor_pago.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.txt_valor_pago.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
			this.txt_valor_pago.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
			this.txt_valor_pago.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
			this.txt_valor_pago.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
			this.txt_valor_pago.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
			this.txt_valor_pago.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.txt_valor_pago.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
			this.txt_valor_pago.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
			this.txt_valor_pago.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
			this.txt_valor_pago.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
			this.txt_valor_pago.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
			this.txt_valor_pago.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.txt_valor_pago.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
			this.txt_valor_pago.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
			this.txt_valor_pago.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
			this.txt_valor_pago.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
			this.txt_valor_pago.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
			this.txt_valor_pago.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
			serializableAppearanceObject2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			serializableAppearanceObject2.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
			serializableAppearanceObject2.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
			serializableAppearanceObject2.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
			serializableAppearanceObject2.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
			serializableAppearanceObject2.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
			this.txt_valor_pago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
			this.txt_valor_pago.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txt_valor_pago.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.txt_valor_pago.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.txt_valor_pago.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
			this.txt_valor_pago.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Default;
			this.txt_valor_pago.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
			this.txt_valor_pago.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Default;
			this.txt_valor_pago.Properties.Mask.EditMask = "c2";
			this.txt_valor_pago.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txt_valor_pago.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.txt_valor_pago.Properties.MaxValue = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
			this.txt_valor_pago.Properties.SpinStyle = DevExpress.XtraEditors.Controls.SpinStyles.Vertical;
			this.txt_valor_pago.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.txt_valor_pago.Size = new System.Drawing.Size(256, 35);
			this.txt_valor_pago.TabIndex = 1;
			this.txt_valor_pago.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
			this.txt_valor_pago.EditValueChanged += new System.EventHandler(this.txt_valor_pago_EditValueChanged);
			// 
			// txt_troco
			// 
			this.txt_troco.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.Default;
			this.txt_troco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txt_troco.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.txt_troco.Enabled = false;
			this.txt_troco.Location = new System.Drawing.Point(491, 250);
			this.txt_troco.Name = "txt_troco";
			this.txt_troco.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Default;
			this.txt_troco.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.Default;
			this.txt_troco.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.txt_troco.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.txt_troco.Properties.Appearance.Options.UseFont = true;
			this.txt_troco.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
			this.txt_troco.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
			this.txt_troco.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
			this.txt_troco.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
			this.txt_troco.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
			this.txt_troco.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Red;
			this.txt_troco.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.txt_troco.Properties.AppearanceDisabled.Options.UseForeColor = true;
			this.txt_troco.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
			this.txt_troco.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
			this.txt_troco.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
			this.txt_troco.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
			this.txt_troco.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
			this.txt_troco.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.txt_troco.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
			this.txt_troco.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
			this.txt_troco.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
			this.txt_troco.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
			this.txt_troco.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
			this.txt_troco.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.txt_troco.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
			this.txt_troco.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
			this.txt_troco.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
			this.txt_troco.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
			this.txt_troco.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
			this.txt_troco.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
			serializableAppearanceObject3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			serializableAppearanceObject3.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
			serializableAppearanceObject3.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
			serializableAppearanceObject3.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
			serializableAppearanceObject3.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
			serializableAppearanceObject3.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
			this.txt_troco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
			this.txt_troco.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txt_troco.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.txt_troco.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.txt_troco.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
			this.txt_troco.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Default;
			this.txt_troco.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
			this.txt_troco.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Default;
			this.txt_troco.Properties.Mask.EditMask = "c2";
			this.txt_troco.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txt_troco.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.txt_troco.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.txt_troco.Properties.SpinStyle = DevExpress.XtraEditors.Controls.SpinStyles.Vertical;
			this.txt_troco.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.txt_troco.Size = new System.Drawing.Size(256, 35);
			this.txt_troco.TabIndex = 23;
			this.txt_troco.TabStop = false;
			this.txt_troco.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None;
			// 
			// alertControl1
			// 
			this.alertControl1.AppearanceCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.alertControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
			this.alertControl1.AppearanceCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
			this.alertControl1.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
			this.alertControl1.AppearanceCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
			this.alertControl1.AppearanceCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
			this.alertControl1.AppearanceHotTrackedText.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.alertControl1.AppearanceHotTrackedText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
			this.alertControl1.AppearanceHotTrackedText.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
			this.alertControl1.AppearanceHotTrackedText.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
			this.alertControl1.AppearanceHotTrackedText.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
			this.alertControl1.AppearanceHotTrackedText.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
			this.alertControl1.AppearanceText.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.alertControl1.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
			this.alertControl1.AppearanceText.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Default;
			this.alertControl1.AppearanceText.TextOptions.Trimming = DevExpress.Utils.Trimming.Default;
			this.alertControl1.AppearanceText.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Default;
			this.alertControl1.AppearanceText.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Default;
			this.alertControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
			// 
			// frmPagamento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(893, 462);
			this.Controls.Add(this.txt_troco);
			this.Controls.Add(this.txt_valor_pago);
			this.Controls.Add(this.txt_valor);
			this.Controls.Add(this.btn_cancelar);
			this.Controls.Add(this.btn_efetuar_pagamento);
			this.Controls.Add(this.lbl_troco);
			this.Controls.Add(this.lbl_valor_pago);
			this.Controls.Add(this.lbl_valor);
			this.Controls.Add(this.rdgrp_tipo_pagamento);
			this.Controls.Add(this.lbl_Header);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmPagamento";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = ".:: SYSNEWS ::. ";
			this.Load += new System.EventHandler(this.frmVendas_Load);
			((System.ComponentModel.ISupportInitialize)(this.rdgrp_tipo_pagamento.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_valor.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_valor_pago.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_troco.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private DevExpress.XtraEditors.LabelControl lbl_Header;
		private DevExpress.XtraEditors.RadioGroup rdgrp_tipo_pagamento;
		private DevExpress.XtraEditors.LabelControl lbl_valor;
		private DevExpress.XtraEditors.LabelControl lbl_valor_pago;
		private DevExpress.XtraEditors.LabelControl lbl_troco;
		private DevExpress.XtraEditors.SimpleButton btn_efetuar_pagamento;
		private DevExpress.XtraEditors.SimpleButton btn_cancelar;
		private DevExpress.XtraEditors.SpinEdit txt_valor;
		private DevExpress.XtraEditors.SpinEdit txt_valor_pago;
		private DevExpress.XtraEditors.SpinEdit txt_troco;
		private DevExpress.XtraBars.Alerter.AlertControl alertControl1;


	}
}