using DAL;
using System.Collections.Generic;
using System;
using telas.util.layout;
namespace telas.estoque
{
    public partial class frmProdutos : frmBase
    {
        private List<Produtos> resultado = new List<Produtos>();
        private IDao<Produtos> objDAL = new GenericDAO<Produtos>();

        public frmProdutos()
        {
            InitializeComponent();
            //gdvTabela.DataSource = objDAL.SelectAll();
            txtDTVencimento.DateTime = DateTime.Now.Date;
            txtDTVencimento.Properties.MinValue = DateTime.Now.Date;
        }

       
       
    }
}
