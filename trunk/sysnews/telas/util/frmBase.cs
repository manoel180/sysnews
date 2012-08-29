using System;


namespace telas.util.layout
{
    public partial class frmBase : DevExpress.XtraEditors.XtraForm
    {
        private Boolean editar;

        public Boolean Editar
        {
            get { return this.editar; }
            set { this.editar = value; }
        }

        public frmBase()
        {
            InitializeComponent();

        }
        protected virtual void preecherObj()
        {
        }
        protected virtual void pesquisar()
        {
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void txtPesquisa_EditValueChanged(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (tabConsulta.PageVisible)
            {
                this.Dispose();
            }
            else
            {
                tabConsulta.PageVisible = true; // Habilita a aba de Pesquisa
                tabCadastro.PageVisible = false; // Desabilita a aba de Cadastro e Edição
                tabPanel.SelectedTabPage = tabConsulta; // Seleciona a aba de Pesquisa
            }
        }

        private void cmbFiltros_Modified(object sender, EventArgs e)
        {
            cmbOpcoes.Enabled = true;
            if (cmbFiltros.SelectedIndex == 0)
            {
                cmbOpcoes.Enabled = false;
            }
            if (cmbFiltros.SelectedIndex == 1)
            {
                cmbOpcoes.Enabled = false;
            }
        }
        protected virtual void alterar()
        {
            editar = true;
            tabCadastro.PageVisible = true;
            tabConsulta.PageVisible = false;
            tabPanel.SelectedTabPage = tabCadastro;
        }
        protected virtual void refazerPesquisa()
        {
            pesquisar();
            tabCadastro.PageVisible = false;
            tabConsulta.PageVisible = true;
            tabPanel.SelectedTabPage = tabConsulta;
        }
    }
}