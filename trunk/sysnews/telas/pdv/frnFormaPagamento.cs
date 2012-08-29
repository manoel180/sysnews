using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAL;

namespace telas.cadastros
{
    public partial class frmFormaPagamento : DevExpress.XtraEditors.XtraForm
    {
        public frmFormaPagamento()
        {
            InitializeComponent();
        }

 
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            FormasPagamentos formaPagamento = new FormasPagamentos();
            formaPagamento.Descricao = txtDescricao.Text;
            new FormaPagamentoDAL().SaveRegistro(formaPagamento);
        
        }
         
    }
}