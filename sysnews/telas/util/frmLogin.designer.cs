namespace telas
{
    partial class frmLogin
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::telas.Splash), true, true, DevExpress.XtraSplashScreen.SplashFormStartPosition.Manual, new System.Drawing.Point(0, 0));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblLicenca = new System.Windows.Forms.Label();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.lblBanca = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_login = new DevExpress.XtraEditors.TextEdit();
            this.txt_senha = new DevExpress.XtraEditors.TextEdit();
            this.validacao = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.btn_Entrar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Sair = new DevExpress.XtraEditors.SimpleButton();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_login.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_senha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validacao)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F);
            this.lblUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblUsuario.Location = new System.Drawing.Point(163, 124);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(102, 26);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuário";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.Black;
            this.lblSenha.Location = new System.Drawing.Point(183, 165);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(82, 26);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha";
            // 
            // lblLicenca
            // 
            this.lblLicenca.AutoSize = true;
            this.lblLicenca.BackColor = System.Drawing.Color.Transparent;
            this.lblLicenca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenca.ForeColor = System.Drawing.Color.Black;
            this.lblLicenca.Location = new System.Drawing.Point(249, 228);
            this.lblLicenca.Name = "lblLicenca";
            this.lblLicenca.Size = new System.Drawing.Size(221, 18);
            this.lblLicenca.TabIndex = 3;
            this.lblLicenca.Text = "Este sistema está licensiado a";
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.BackColor = System.Drawing.Color.White;
            this.lblBemVindo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBemVindo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBemVindo.Location = new System.Drawing.Point(34, 26);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(258, 26);
            this.lblBemVindo.TabIndex = 8;
            this.lblBemVindo.Text = "Bem Vindo ao SYSNEWS";
            // 
            // lblBanca
            // 
            this.lblBanca.AutoSize = true;
            this.lblBanca.BackColor = System.Drawing.Color.Transparent;
            this.lblBanca.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanca.ForeColor = System.Drawing.Color.Black;
            this.lblBanca.Location = new System.Drawing.Point(248, 246);
            this.lblBanca.Name = "lblBanca";
            this.lblBanca.Size = new System.Drawing.Size(117, 23);
            this.lblBanca.TabIndex = 10;
            this.lblBanca.Text = "Banca Dirce";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Copyright BIMATECH";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::telas.Properties.Resources.LOGO_SYS_NEWS_sem_fundo1;
            this.pictureBox1.Location = new System.Drawing.Point(325, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txt_login
            // 
            this.txt_login.EnterMoveNextControl = true;
            this.txt_login.Location = new System.Drawing.Point(271, 122);
            this.txt_login.Name = "txt_login";
            this.txt_login.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txt_login.Properties.Appearance.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txt_login.Properties.Appearance.Options.UseFont = true;
            this.txt_login.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_login.Properties.MaxLength = 30;
            this.txt_login.Properties.NullValuePrompt = "Digite seu login";
            this.txt_login.Properties.NullValuePromptShowForEmptyValue = true;
            this.txt_login.Properties.ValidateOnEnterKey = true;
            this.txt_login.Size = new System.Drawing.Size(212, 28);
            this.txt_login.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Login é Obrigatório";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.validacao.SetValidationRule(this.txt_login, conditionValidationRule1);
            // 
            // txt_senha
            // 
            this.txt_senha.EnterMoveNextControl = true;
            this.txt_senha.Location = new System.Drawing.Point(271, 163);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.txt_senha.Properties.Appearance.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txt_senha.Properties.Appearance.Options.UseFont = true;
            this.txt_senha.Properties.MaxLength = 10;
            this.txt_senha.Properties.NullValuePrompt = "Digite sua senha";
            this.txt_senha.Properties.NullValuePromptShowForEmptyValue = true;
            this.txt_senha.Properties.PasswordChar = '*';
            this.txt_senha.Properties.ValidateOnEnterKey = true;
            this.txt_senha.Size = new System.Drawing.Size(212, 28);
            this.txt_senha.TabIndex = 1;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Senha é obrigatória";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.validacao.SetValidationRule(this.txt_senha, conditionValidationRule2);
            // 
            // validacao
            // 
            this.validacao.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.Appearance.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_Entrar.Appearance.Options.UseFont = true;
            this.btn_Entrar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Entrar.Location = new System.Drawing.Point(271, 295);
            this.btn_Entrar.LookAndFeel.SkinName = "Lilian";
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(89, 32);
            this.btn_Entrar.TabIndex = 2;
            this.btn_Entrar.Text = "Entrar";
            this.btn_Entrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Appearance.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_Sair.Appearance.Options.UseFont = true;
            this.btn_Sair.CausesValidation = false;
            this.btn_Sair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Sair.Location = new System.Drawing.Point(393, 295);
            this.btn_Sair.LookAndFeel.SkinName = "Lilian";
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(90, 32);
            this.btn_Sair.TabIndex = 3;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Money Twins";
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btn_Entrar;
            this.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::telas.Properties.Resources.black_and_white_abstract;
            this.CancelButton = this.btn_Sair;
            this.ClientSize = new System.Drawing.Size(499, 339);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Entrar);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBanca);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.lblLicenca);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bem Vindo ao SYSNEWS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_login.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_senha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
		private System.Windows.Forms.Label lblLicenca;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Label lblBanca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
		private DevExpress.XtraEditors.TextEdit txt_login;
		private DevExpress.XtraEditors.TextEdit txt_senha;
		protected DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validacao;
		private DevExpress.XtraEditors.SimpleButton btn_Entrar;
		private DevExpress.XtraEditors.SimpleButton btn_Sair;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
    }
}

