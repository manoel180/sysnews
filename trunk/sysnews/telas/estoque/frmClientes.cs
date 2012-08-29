using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DAL;
using telas.util.layout;
using System.Linq;

namespace telas.estoque
{
    public partial class frmClientes : frmBase
    {
        private List<Clientes> resultado = new List<Clientes>();
        private Clientes obj;
        private IDao<Clientes> objDAL = new GenericDAO<Clientes>();

        public frmClientes()
        {
            InitializeComponent();
            gdvTabela.DataSource = objDAL.SelectAll();
        }

        //public override void btnNovo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    //cadastros.frmCategoria frmLocal = new cadastros.frmLocais();
        //    //frmLocal.MdiParent = this.ParentForm;
        //    //frmLocal.Show();
        //}
       

        protected override void pesquisar()
        {
            //Verifica qual o campo da pesquisa
            /**
             * 0 - Todos
             * 1 - Código
             * 2 - Matricula
             * 3 - Nome
             */

            try
            {   //Console.Write( localDAL.Context.Locais.SelectOne(obj => obj.idLocal==1));
                switch (cmbFiltros.SelectedIndex)
                {

                    case 0: gdvTabela.DataSource = objDAL.SelectAll(); break;
                    case 1: gdvTabela.DataSource = objDAL.SelectAll().Where(obj => obj.idClientes==int.Parse(txtPesquisa.Text)).ToList<Clientes>();break;
                    case 2:
                        {
                            gdvTabela.DataSource = objDAL.SelectAll().Where(obj => obj.matricula == int.Parse(txtPesquisa.Text)).ToList<Clientes>(); 
                        }break; 
                    case 3:
                        {
                            // Verifica qual tipo de filtro
                            switch (cmbOpcoes.SelectedIndex)
                            {
                                case 0: gdvTabela.DataSource = objDAL.SelectWhere(obj => obj.nome.StartsWith(txtPesquisa.Text)); break;
                                case 1: gdvTabela.DataSource = objDAL.SelectWhere(obj => obj.nome.Contains(txtPesquisa.Text)); break;
                                case 2: gdvTabela.DataSource = objDAL.SelectWhere(obj => obj.nome.EndsWith(txtPesquisa.Text)); break;
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
                obj = new Clientes();
                obj.idClientes = Convert.ToInt32(gridTabela.GetRowCellValue(gridTabela.GetSelectedRows()[0], "idClientes"));
                obj = objDAL.SelectOne(o => o.idClientes.Equals(obj.idClientes));
                //obj.nome = gridTabela.GetRowCellValue(gridTabela.GetSelectedRows()[0], "nome").ToString();
                // Falta fazer o cadastro de cliente
                //cadastros.frmLocais frmLocal = new cadastros.frmClie(obj);
                //frmLocal.MdiParent = this.ParentForm;
                //frmLocal.Show();
                this.Dispose();
            }
        }
        //protected override void btnAlterar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    alterar();
        //}
        //protected void btnExcluir_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    if (!gridTabela.IsEmpty)
        //    {
        //        Clientes c = new Clientes();
        //        c.idClientes = Convert.ToInt32(gridTabela.GetRowCellValue(gridTabela.GetSelectedRows()[0], "idLocal"));
        //        c.nome = gridTabela.GetRowCellValue(gridTabela.GetSelectedRows()[0], "loc_descricao").ToString();
        //        c = objDAL.SelectOne(obj => obj.idClientes == c.idClientes);

        //        if (MessageBox.Show("Deseja excluir este registro?", "Confirmar exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
        //        {
        //            objDAL.Delete(c);
        //            cmbFiltros.SelectedIndex = 0;
        //            objDAL = new GenericDAO<Clientes, sysnewsEntities>();
        //            gdvTabela.DataSource = objDAL.SelectAll();
        //        }

        //    }
        //}

        private void frmLocais_Load(object sender, EventArgs e)
        {
            objDAL = new GenericDAO<Clientes>();
            gdvTabela.DataSource = objDAL.SelectAll();
        }

        private void gdvTabela_DoubleClick(object sender, EventArgs e)
        {
            alterar();
        }

    }
}
