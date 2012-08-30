using System;
using System.Collections.Generic;

using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAL;
using telas.util.layout;

namespace telas.cadastro
{
    public partial class frmLocal : frmBase
    {
        private IDao<Setores> setorDAL = new GenericDAO<Setores>();
        public frmLocal()
        {
            InitializeComponent();
        }


       //protected override void btnSalvar_Click(object sender, EventArgs e)
       // {
       //     Setores setor = new Setores();
       //     setor.descricao = txtLocal.Text;
       //     setor.ramal = txtRamal.Text;
       //     setor.chefe = txt_chefe.Text;
       //     setor.telefone = txtTelefone.Text;
       //     setor.turno = 1;
       //     setorDAL.Insert(setor);
       // }

      
         
    }
}