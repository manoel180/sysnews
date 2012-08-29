namespace telas
{
    partial class Splash
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.styleController1 = new DevExpress.XtraEditors.StyleController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl1.Location = new System.Drawing.Point(23, 286);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(87, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Copyright © 2012";
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = global::telas.Properties.Resources.LOGO_SYS_NEWS_sem_fundo;
            this.pictureEdit2.Location = new System.Drawing.Point(12, 12);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.AllowFocused = false;
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowMenu = false;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit2.Size = new System.Drawing.Size(426, 180);
            this.pictureEdit2.TabIndex = 9;
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(23, 238);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.Appearance.BackColor = System.Drawing.Color.Black;
            this.progressBarControl1.Properties.NullText = "1";
            this.progressBarControl1.Properties.ShowTitle = true;
            this.progressBarControl1.Properties.StartColor = System.Drawing.Color.Red;
            this.progressBarControl1.Properties.Step = 1;
            this.progressBarControl1.Size = new System.Drawing.Size(404, 18);
            this.progressBarControl1.StyleController = this.styleController1;
            this.progressBarControl1.TabIndex = 10;
            // 
            // styleController1
            // 
            this.styleController1.LookAndFeel.SkinName = "Seven Classic";
            this.styleController1.LookAndFeel.UseDefaultLookAndFeel = false;
            // 
            // SplashScreen1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 320);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.labelControl1);
            this.Name = "SplashScreen1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.StyleController styleController1;
    }
}
