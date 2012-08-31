using System;
using System.Collections.Generic;
using System.Data;
using DAL;
using System.Linq;
using telas.util.layout;
using DevExpress.XtraEditors.Controls;
using System.Drawing;
using System.Data.Objects;

namespace telas.seguranca
{
    public partial class frmUsuario : telas.util.layout.frmBase
    {
        private Usuarios usuario;
        private IDao<Usuarios> usuarioDAL = new GenericDAO<Usuarios>();
        private IDao<Perfis> perfilDAL = new GenericDAO<Perfis>();
        public frmUsuario()
        {
            InitializeComponent();
        }
        
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            gdvTabela.DataSource = usuarioDAL.SelectAll();                       
        }

        protected override void pesquisar()
        {
            //Verifica qual o campo da pesquisa
            /**
             * 0 - Todos
             * 1 - Código
             * 2 - Nome
             * 3 - Login
             */

            try
            {
                //usuarioDAL = new GenericDAO<Usuarios>();
                switch (cmbFiltros.SelectedIndex)
                {

                    case 0: gdvTabela.DataSource = usuarioDAL.SelectAll(); break;
                    case 1: gdvTabela.DataSource = usuarioDAL.SelectAll().Where(obj => obj.idUsuarios == int.Parse(txtPesquisa.Text)).ToList<Usuarios>(); break;
                    case 2:
                        {
                            // Verifica qual tipo de filtro do Nome
                            switch (cmbOpcoes.SelectedIndex)
                            {
                                case 0: gdvTabela.DataSource = usuarioDAL.SelectWhere(obj => obj.nome.StartsWith(txtPesquisa.Text)); break;
                                case 1: gdvTabela.DataSource = usuarioDAL.SelectWhere(obj => obj.nome.Contains(txtPesquisa.Text)); break;
                                case 2: gdvTabela.DataSource = usuarioDAL.SelectWhere(obj => obj.nome.EndsWith(txtPesquisa.Text)); break;
                            } break;
                        }
                    case 3:
                        {
                            // Verifica qual tipo de filtro Login
                            switch (cmbOpcoes.SelectedIndex)
                            {
                                case 0: gdvTabela.DataSource = usuarioDAL.SelectWhere(obj => obj.login.StartsWith(txtPesquisa.Text)); break;
                                case 1: gdvTabela.DataSource = usuarioDAL.SelectWhere(obj => obj.login.Contains(txtPesquisa.Text)); break;
                                case 2: gdvTabela.DataSource = usuarioDAL.SelectWhere(obj => obj.login.EndsWith(txtPesquisa.Text)); break;
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
        protected override void preecherObj()
        {
            base.preecherObj();
            usuario = new Usuarios();
            if (Editar)
            {
                int tmp = Convert.ToInt32(gridTabela.GetRowCellValue(gridTabela.GetSelectedRows()[0], "idUsuarios"));
                usuario = usuarioDAL.SelectOne(u => u.idUsuarios.Equals(tmp));
                txtLogin.Text = usuario.login;
                txtNome.Text = usuario.nome;
                txtSenha.Text = usuario.senha;
                txtRepetirSenha.Text = usuario.senha;
                cmbPerfis.SelectedValue= usuario.perfil;
            }
            else
            {
                txtLogin.Text = String.Empty;
                txtNome.Text = String.Empty;
                txtSenha.Text = String.Empty;
                txtRepetirSenha.Text = String.Empty;
                cmbPerfis.SelectedItem = null;
            }
        }

        protected override void alterar()
        {
           
            if (!gridTabela.IsEmpty)
            {
                base.alterar();
                popularComboPerfil();
                preecherObj();            
            }
        }

        private void popularObjs()
        {
            usuario.nome = txtNome.Text;
            usuario.login = txtLogin.Text;
            usuario.senha = txtSenha.Text;
            usuario.perfil = (Int32)cmbPerfis.SelectedValue;
        }
        private void popularComboPerfil()
        {
            cmbPerfis.DataSource = perfilDAL.SelectAll();
            cmbPerfis.DisplayMember = "descricao";
            cmbPerfis.ValueMember = "idPerfil";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                if (validacao.Validate())
                {
                    usuarioDAL =  new GenericDAO<Usuarios>();
                    popularObjs();
                    if (Editar)
                    {                  
                        usuarioDAL.Update(usuario);
                    }
                    else
                    {
                        usuarioDAL.Insert(usuario);
                    }
                    base.refazerPesquisa();
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            alterar();
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            Editar = false;
            tabCadastro.PageVisible = true;
            tabConsulta.PageVisible = false;
            tabPanel.SelectedTabPage = tabCadastro;
            popularComboPerfil();
            preecherObj();
          
        }

       
    }
}