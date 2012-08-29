using System;
using System.Data;
using System.Windows.Forms;
using DAL;
using telas.util;
using DevExpress.XtraSplashScreen;
using System.Threading;

namespace telas
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {

        private IDao<Usuarios> usuarioDAL = new GenericDAO<Usuarios>();
        private Usuarios usuario;

        public frmLogin()
        {
            // Open a Splash Screen
            //SplashScreenManager.ShowForm(this, typeof(Splash), true, true, false);
            InitializeComponent();
            usuario = new Usuarios();
            // The splash screen will be opened in a separate thread. To interact with it, use the SendCommand method.
            for (int i = 1; i <= 100; i++)
            {
                //To process commands, override the SplashScreen.ProcessCommand method.
              //  Thread.Sleep(20);
                //SplashScreenManager.Default.SendCommand(Splash.SplashScreenCommand.SetProgress, i);

            }
            // Close the Splash Screen.
            //SplashScreenManager.CloseForm(false);
            //usuarioDAL ;
        }
        private void validar_Login()
        {
            try
            {
                //IDao<Locais, sysnewsEntities> locaisDAL = new GenericDAO<Locais, sysnewsEntities>();
                //locaisDAL.SelectWhere(obj => obj.idLocal <= 1);

                usuario = usuarioDAL.SelectOne(u => u.login.Equals(txt_login.Text));

                if (usuario != null && (usuario.senha == txt_senha.Text))
                {
                    frmLogin.ActiveForm.Visible = false;
                    new frmPrincipal(usuario).Show();
                }
                else
                {
                    MessageBox.Show("Login ou senha inválido", "ERROR: ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (EntityException e)
            {
                e.ToString();
                MessageBox.Show("Falha ao conectar com o Banco de Dados", "ERROR: ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR: ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            frmLogin.ActiveForm.Close();
        }

        



        public void btnEntrar_Click(object sender, EventArgs e)
        {
            if (validacao.Validate())
            {
                validar_Login();
            }
        }


    }
}
