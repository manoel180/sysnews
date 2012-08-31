using System;
using System.Collections.Generic;
using System.Data;
using DAL;
using System.Linq;
using telas.util.layout;
using System.Windows.Forms;

namespace telas.cadastro
{
    public partial class frmCategorias : frmBase
    {
        private Categorias obj;
        private IDao<Categorias> objDAL;
        
        public frmCategorias()
        {
            InitializeComponent();
        }
        
        private void popularObjs()
        {
            obj.descricao = txtCategoria.Text;
        }
        protected override void preecherObj()
        {
            base.preecherObj();
            obj = new Categorias();
            if (Editar)
            {
                int tmp = Convert.ToInt32(gridTabela.GetRowCellValue(gridTabela.GetSelectedRows()[0], "idCategorias"));
                obj = objDAL.SelectOne(c => c.idCategorias.Equals(tmp));
                txtCodigo.Text = obj.idCategorias.ToString();
                txtCategoria.Text = obj.descricao;
            }
            else
            {
                txtCodigo.Text = String.Empty;
                txtCategoria.Text = String.Empty;
            }
        }

       
        protected override void pesquisar()
        {
            //Verifica qual o campo da pesquisa
            /**
             * 0 - Todos
             * 1 - Código
             * 2 - Local
             */

            try
            {
                objDAL = new GenericDAO<Categorias>();
                switch (cmbFiltros.SelectedIndex)
                {

                    case 0: gdvTabela.DataSource = objDAL.SelectAll(); break;
                    case 1: gdvTabela.DataSource = objDAL.SelectAll().Where(obj => obj.idCategorias==int.Parse(txtPesquisa.Text)).ToList<Categorias>();break;
                    case 2:
                        {
                            // Verifica qual tipo de filtro
                            switch (cmbOpcoes.SelectedIndex)
                            {
                                case 0: gdvTabela.DataSource = objDAL.SelectWhere(obj => obj.descricao.StartsWith(txtPesquisa.Text)); break;
                                case 1: gdvTabela.DataSource = objDAL.SelectWhere(obj => obj.descricao.Contains(txtPesquisa.Text)); break;
                                case 2: gdvTabela.DataSource = objDAL.SelectWhere(obj => obj.descricao.EndsWith(txtPesquisa.Text)); break;
                            } break;
                        }
                }
                gridTabela.RefreshData();
                gdvTabela.Refresh();
            }
            catch (EntitySqlException e)
            {
                Console.Write(e);
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
        }
        protected override void alterar()
        {
            if (!gridTabela.IsEmpty)
            {
                base.alterar();
                preecherObj();
            }
        }
        
        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!gridTabela.IsEmpty)
            {
                obj = new Categorias();
                obj.idCategorias = Convert.ToInt32(gridTabela.GetRowCellValue(gridTabela.GetSelectedRows()[0], "idCategorias"));
                obj = objDAL.SelectOne(c => c.idCategorias == obj.idCategorias);

                if (MessageBox.Show("Deseja excluir este registro?", "Confirmar exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        objDAL.Delete(obj);
                        cmbFiltros.SelectedIndex = 0;
                        objDAL = new GenericDAO<Categorias>();
                        refazerPesquisa();
                    }
                    catch (EntitySqlException ex)
                    {
                        ex.Message.ToString();
                    }

                }

            }
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            objDAL = new GenericDAO<Categorias>();
            gdvTabela.DataSource = objDAL.SelectAll();
        }

        private void gdvTabela_DoubleClick(object sender, EventArgs e)
        {
            alterar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            alterar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validacao.Validate())
            {
                try
                {
                    if (validacao.Validate())
                    {
                        objDAL = new GenericDAO<Categorias>();
                        popularObjs();
                        if (Editar)
                        {
                            objDAL.Update(obj);
                        }
                        else
                        {
                            objDAL.Insert(obj);
                        }
                        base.refazerPesquisa();
                    }

                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }
       
        private void btnNovo_Click(object sender, EventArgs e)
        {
            Editar = false;
            tabCadastro.PageVisible = true;
            tabConsulta.PageVisible = false;
            tabPanel.SelectedTabPage = tabCadastro;
            preecherObj();

        }

    }
}
