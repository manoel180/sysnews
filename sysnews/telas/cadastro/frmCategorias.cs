using System;
using System.Collections.Generic;
using System.Data;
using DAL;
using System.Linq;
using telas.util.layout;

namespace telas.estoque
{
    public partial class frmCategorias : frmBase
    {
        private List<Categorias> resultado = new List<Categorias>();
        private Categorias obj;
        private IDao<Categorias> objDAL;
        
        public frmCategorias()
        {
            InitializeComponent();
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
                obj = new Categorias();
                int id = Convert.ToInt32(gridTabela.GetRowCellValue(gridTabela.GetSelectedRows()[0], "idCategorias"));
                obj = objDAL.SelectOne(o => o.idCategorias.Equals(id));
                //obj.descricao = gridTabela.GetRowCellValue(gridTabela.GetSelectedRows()[0], "descricao").ToString();
                txtCodigo.Text = obj.idCategorias.ToString();
                txtCategoria.Text = obj.descricao;
                
                tabPanel.SelectedTabPage = tabCadastro;

            }
        }
        
        //protected override void btnExcluir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    if (!gridTabela.IsEmpty)
        //    {
        //        c = new Categorias();
        //        c.idCategorias = Convert.ToInt32(gridTabela.GetRowCellValue(gridTabela.GetSelectedRows()[0], "idCategorias"));
        //        c.descricao = gridTabela.GetRowCellValue(gridTabela.GetSelectedRows()[0], "descricao").ToString();
        //        c = objDAL.SelectOne(obj => obj.idCategorias == c.idCategorias);

        //        if (MessageBox.Show("Deseja excluir este registro?", "Confirmar exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
        //        {
        //            objDAL.Delete(c);
        //            cmbFiltros.SelectedIndex = 0;
        //            objDAL = new GenericDAO<Categorias, sysnewsEntities>();
        //            gdvTabela.DataSource = objDAL.SelectAll();
        //        }

        //    }
        //}

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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Editar = false;
            obj = new Categorias();
            txtCodigo.Text =  String.Empty;
            txtCategoria.Text = String.Empty;
            tabPanel.SelectedTabPage = tabCadastro;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validacao.Validate())
            {
                try
                {
                    objDAL = new GenericDAO<Categorias>();
                    obj.descricao = txtCategoria.Text;
                    if (Editar)
                    {
                        objDAL.Update(obj);
                    }
                    else
                    {
                        objDAL.Insert(obj);
                    }
                    txtCodigo.Text = obj.idCategorias.ToString();
                    gdvTabela.DataSource = new GenericDAO<Categorias>().SelectAll();
                    pesquisar();
                    tabCadastro.PageVisible = false;
                    tabConsulta.PageVisible = true;
                    tabPanel.SelectedTabPage = tabConsulta;
                    //obj = new Categorias();
                    //objDAL = new GenericDAO<Categorias, sysnewsEntities>();

                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }

    }
}
