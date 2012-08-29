using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace telas
{
    public partial class Splash : SplashScreen
    {
        public Splash()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            //base.ProcessCommand(cmd, arg);
            progressBarControl1.Text = arg + "%";
            progressBarControl1.Increment((int)arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
            SetProgress,
            Command2,
            Command3
        }
    }
}