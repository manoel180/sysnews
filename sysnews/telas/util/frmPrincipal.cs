using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DAL;

namespace telas.util
{
    public partial class frmPrincipal : DevExpress.XtraEditors.XtraForm
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public frmPrincipal(Usuarios u)
        {
            InitializeComponent();
            lblUsuario.Caption = "Usuário: " + u.nome.ToUpper();
        }

        private Dictionary<Type, Form> dicForms = new Dictionary<Type, Form>();

        private void CarregaTela<T>()
        {
            CarregarTela(typeof(T));
        }

        private void CarregarTela(Type type)
        {
            bool carregar = true;
            Form f = null;

            try
            {

                if (dicForms.ContainsKey(type))
                {
                    if (dicForms.TryGetValue(type, out f))
                    {

                        if (!f.IsDisposed)
                        {
                            f.Focus();
                            carregar = false;
                        }
                        else
                        {
                            dicForms.Remove(type);
                        }
                    }
                }

                if (carregar)
                {
                    Cursor = Cursors.WaitCursor;
                    f = (Form)Activator.CreateInstance(type);
                    dicForms.Add(type, f);
                    f.MdiParent = this;
                    //f.FormBorderStyle = FormBorderStyle.SizableToolWindow;
                    f.StartPosition = FormStartPosition.CenterScreen;
                    f.MaximizeBox = true;
                    f.Show();
                }
            }
            catch (Exception ex)
            {
                dicForms.Remove(type);
                MessageBox.Show(String.Format("Não foi possível inicializar a tela {0}!\n\nCausa:{1}", type.Name, ex.Message), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (f != null)
                {
                    f.Close();
                    f.Dispose();
                }
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void mnuItemUsuarios_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CarregaTela<telas.seguranca.frmUsuario>();
        }

        private void btnSair_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblHora.Caption = DateTime.Now.ToLongTimeString();
            lblData.Caption = DateTime.Now.ToLongDateString();
        }

        private void mnuItemSobre_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmSobre().ShowDialog();
        }

        private void mnuItemProdutos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CarregaTela<estoque.frmProdutos>();
        }

        private void btnClientes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CarregaTela<estoque.frmClientes>();
        }

        private void mnuItemClientes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CarregaTela<estoque.frmClientes>();
        }

        private void mnuItemCategorias_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CarregaTela<estoque.frmCategorias>();
        }

        private void mnuItemSetores_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            CarregaTela<estoque.frmClientes>();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            CarregaTela<vendas.frmVendas>();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmSobre().ShowDialog();
        }

        private void mnuItemLocais_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CarregaTela<estoque.frmLocais>();
        }

       

      
    }
}