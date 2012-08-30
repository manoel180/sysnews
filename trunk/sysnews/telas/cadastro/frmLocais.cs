using System;
using DAL;
using System.Linq;
using telas.util.layout;

namespace telas.estoque
{
    public partial class frmLocais : frmBase
    {
        private Locais obj;
        private IDao<Locais> objDAL = new GenericDAO<Locais>();

        public frmLocais()
        {
            InitializeComponent();
            gdvTabela.DataSource = objDAL.SelectAll();
        }

        //public override void btnNovo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    cadastros.frmLocais frmLocal = new cadastros.frmLocais();
        //    frmLocal.MdiParent = this.ParentForm;
        //    frmLocal.Show();
        //}
       

        protected override void pesquisar()
        {
            //Verifica qual o campo da pesquisa
            /**
             * 0 - Todos
             * 1 - Código
             * 2 - Local
             */

            try
            {   //Console.Write( localDAL.Context.Locais.SelectOne(obj => obj.idLocal==1));
                switch (cmbFiltros.SelectedIndex)
                {

                    case 0: gdvTabela.DataSource = objDAL.SelectAll(); break;
                    case 1: gdvTabela.DataSource = objDAL.SelectAll().Where(obj => obj.idLocal==int.Parse(txtPesquisa.Text)).ToList<Locais>();break;
                    case 2:
                        {
                            // Verifica qual tipo de filtro
                            switch (cmbOpcoes.SelectedIndex)
                            {
                                case 0: gdvTabela.DataSource = objDAL.SelectWhere(obj => obj.loc_descricao.StartsWith(txtPesquisa.Text)); break;
                                case 1: gdvTabela.DataSource = objDAL.SelectWhere(obj => obj.loc_descricao.Contains(txtPesquisa.Text)); break;
                                case 2: gdvTabela.DataSource = objDAL.SelectWhere(obj => obj.loc_descricao.EndsWith(txtPesquisa.Text)); break;
                            } break;
                        }
                }
                gridTabela.RefreshData();
                gdvTabela.Refresh();
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
        }
        private void alterar()
        {
            if (!gridTabela.IsEmpty)
            {
                base.alterar();
                obj = new Locais();
                obj.idLocal = Convert.ToInt32(gridTabela.GetRowCellValue(gridTabela.GetSelectedRows()[0], "idLocal"));
                obj.loc_descricao = gridTabela.GetRowCellValue(gridTabela.GetSelectedRows()[0], "loc_descricao").ToString();
            }
        }
        //protected override void btnAlterar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    alterar();
        //}
        //protected override void btnExcluir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    if (!gridTabela.IsEmpty)
        //    {
        //        Locais l = new Locais();
        //        l.idLocal = Convert.ToInt32(gridTabela.GetRowCellValue(gridTabela.GetSelectedRows()[0], "idLocal"));
        //        l.loc_descricao = gridTabela.GetRowCellValue(gridTabela.GetSelectedRows()[0], "loc_descricao").ToString();
        //        l = localDAL.SelectOne(obj => obj.idLocal == l.idLocal);

        //        if (MessageBox.Show("Deseja excluir este registro?", "Confirmar exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
        //        {
        //            localDAL.Delete(l);
        //            cmbFiltros.SelectedIndex = 0;
        //            localDAL = new GenericDAO<Locais, sysnewsEntities>();
        //            gdvTabela.DataSource = localDAL.SelectAll();
        //        }

        //    }
        //}

        private void frmLocais_Load(object sender, EventArgs e)
        {
            objDAL = new GenericDAO<Locais>();
            gdvTabela.DataSource = objDAL.SelectAll();
        }

        private void gdvTabela_DoubleClick(object sender, EventArgs e)
        {
            alterar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                obj.loc_descricao = txtLocal.Text;
                if (Editar)
                {
                    objDAL.Update(obj);
                }
                else
                {
                    objDAL.Insert(obj);
                }
                obj = new Locais();
                objDAL = new GenericDAO<Locais>();

            }
            catch (Exception ex)
            {
                

            }
        }
        

    }
}
