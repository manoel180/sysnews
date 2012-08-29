using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;


namespace telas.vendas
{
    public partial class frmVendas : Form
    {
        //Declaração Variavéis

        private List<ItemVendas> listaItensVendas = new List<ItemVendas>();
        private List<Produtos> listaProdutos = new List<Produtos>();
        private List<int> listaIndex = new List<int>();
        private Vendedores vendedor = new Vendedores();
        private Clientes cliente = new Clientes();
		private Usuarios user = new Usuarios();
//        private Produtos produto = new Produtos();
        private ItemVendas itemVenda;
        private decimal total = 0;
		Vendas venda = new Vendas();
        private IDao<ItemVendas> iv = new GenericDAO<ItemVendas>();
        private IDao<Produtos> pd = new GenericDAO<Produtos>();
        private IDao<Vendas> vendaDAL = new GenericDAO<Vendas>();
        private IDao<Vendedores> vendedorDAL = new GenericDAO<Vendedores>();
        private IDao<Clientes> clienteDAL = new GenericDAO<Clientes>();

		public frmVendas(Usuarios u)
        {
            InitializeComponent();
			cliente.idClientes = 1;
			cliente.nome = "Balcão";
			
           // vendedor = vendedorDAL.SelectOne(v => v.usuario == u.idUsuarios);
			lbl_Vendedor.Text = vendedor.nome;

			lkpedt_Cliente.EditValue = cliente.idClientes;
            lkpedt_Cliente.Properties.DataSource = clienteDAL.SelectAll();
        }

        private void frmVendas_Load(object sender, EventArgs e)
        {
            
          
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

      
        // soma o valor de todos os itens
        private void somaritens()
        {
            total = 0;
            foreach (ItemVendas itemVenda in listaItensVendas)
            {
                total = itemVenda.valor + total;
            }
            txt_total.Value = total;
        }


        private void adicionarItens()
        {
            itemVenda = new ItemVendas();
            
            if (txt_produto.Text != "")
            {
                Produtos produto = pd.SelectOne(p => p.codigo_barra == txt_produto.Text);
                //System.Data.DataSet ds = new System.Data.DataSet();

                if (produto != null && produto.quantidade>0)
                {
                    //itemVenda.Produtos = produto;
					itemVenda.idProduto = produto.idProduto;
                    itemVenda.nome_Produto = produto.nome;
                    itemVenda.quantidade = Convert.ToInt32(txt_quantidade.Value);
                    itemVenda.valor = produto.preco * itemVenda.quantidade;
				
                    ItemVendas existe = listaItensVendas.Where(iv => iv.idProduto == itemVenda.idProduto).FirstOrDefault();

                    if (existe == null )
                    {
                        
                        listaIndex.Add(itemVenda.idProduto);
                        gridView_itens_vendas.Rows.Add(itemVenda.idProduto, itemVenda.nome_Produto, itemVenda.quantidade, itemVenda.valor);
                        listaItensVendas.Add(itemVenda);
                        produto.quantidade  = produto.quantidade - itemVenda.quantidade;
                        listaProdutos.Add(produto);
                        somaritens();
                        itemVenda = new ItemVendas();
                    }
                    else
                    {
                        decimal precoanterior = Convert.ToDecimal(gridView_itens_vendas.Rows[listaIndex.IndexOf(itemVenda.idProduto)].Cells[3].Value);
                        int quantidadeanterior = Convert.ToInt32(gridView_itens_vendas.Rows[listaIndex.IndexOf(itemVenda.idProduto)].Cells[2].Value);
                        gridView_itens_vendas.Rows[listaIndex.IndexOf(itemVenda.idProduto)].Cells[3].Value = precoanterior + (itemVenda.valor);
                        gridView_itens_vendas.Rows[listaIndex.IndexOf(itemVenda.idProduto)].Cells[2].Value = quantidadeanterior + itemVenda.quantidade;

                        itemVenda.valor = Convert.ToDecimal(gridView_itens_vendas.Rows[listaIndex.IndexOf(itemVenda.idProduto)].Cells[3].Value);
                        itemVenda.quantidade = Convert.ToInt32(gridView_itens_vendas.Rows[listaIndex.IndexOf(itemVenda.idProduto)].Cells[2].Value);
                        listaItensVendas[listaIndex.IndexOf(itemVenda.idProduto)].valor = itemVenda.valor;
                        listaItensVendas[listaIndex.IndexOf(itemVenda.idProduto)].quantidade = itemVenda.quantidade;
                        
                        listaProdutos[listaIndex.IndexOf(itemVenda.idProduto)].quantidade = produto.quantidade-itemVenda.quantidade;
                        
                        somaritens();

                    }
					//txt_quantidade.Refresh();
                }
                else
                {
                    MessageBox.Show("Produto não encontrado no estoque!!!");
                }
            }
            else
            {
                MessageBox.Show("Produto não informado!!!");
            }
        }





        private void txt_produto_Validated(object sender, EventArgs e)
        {
            itemVenda = new ItemVendas();
            
            if (txt_produto.Text != "")
            {

                Produtos produto = pd.SelectOne(p => p.codigo_barra == txt_produto.Text);
                if (produto != null)
				{

					ItemVendas existe = listaItensVendas.Where(iv => iv.idProduto == produto.idProduto).FirstOrDefault();
					
                    if (existe == null)
					{
                        //Verifica se estoque é maior que ZERO
                        if (produto.quantidade <= 0)
                        {
                            MessageBox.Show("Sem produto no estoque!!!");
                            txt_quantidade.Maximum = 0;
                        }
                        else {
                            txt_quantidade.Maximum = produto.quantidade;
                        }
						
					}
					else
					{
						txt_quantidade.Maximum = produto.quantidade - existe.quantidade;
					}
					
                }
                else
                {
                    MessageBox.Show("Produto não encontrado no estoque!!!");
                }
            }
            else
            {
				MessageBox.Show("Produto não informado!!!");
            }

        }

        private void txt_quantidade_Validated(object sender, EventArgs e)
        {
            adicionarItens();
		}

		private void gridView_itens_vendas_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
		{
			int i = e.Row.Index;
			listaItensVendas.Remove(listaItensVendas.Where(iv => iv.idProduto.Equals(e.Row.Cells["idProduto"].Value)).FirstOrDefault());
            listaProdutos.Remove(listaProdutos.Where(iv => iv.idProduto.Equals(e.Row.Cells["idProduto"].Value)).FirstOrDefault());
			somaritens();
		}
		
		private void salvarItensVenda()
		{
            
			foreach (ItemVendas itemVenda in listaItensVendas)
			{
				itemVenda.idVenda = venda.idVenda;
				iv.Insert(itemVenda);
			}
		}

        private void atualizarEstoque()
        {
            foreach (Produtos produto in listaProdutos)
            {
                
                pd.Update(produto);
            }
        }

		private void btnFinalizarVenda_Click(object sender, EventArgs e)
		{
			
			
			venda.cliente = Convert.ToInt32( lkpedt_Cliente.EditValue);
			venda.vendedor = vendedor.idVendedores;
			venda.valorvenda = txt_total.Value;
			venda.usuario = user.idUsuarios;
			venda.data = DateTime.Now.Date;
			venda.hora = DateTime.Now.TimeOfDay;
			frmPagamento frmpagto = new frmPagamento();
			frmpagto.Venda = venda;
			frmpagto.ShowDialog();
			venda.formaPagamento = frmpagto.Venda.formaPagamento;
			//venda.Item_Vendas;
			vendaDAL.Insert(venda);
			salvarItensVenda();
            atualizarEstoque();
			this.Close();
			frmVendas frmvenda = new frmVendas(user);
			frmvenda.MdiParent = this.ParentForm;
            frmvenda.Show();
		//	frmvenda.Refresh();
		}

    }
}