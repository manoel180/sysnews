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
    public partial class frmPagamento : Form
    {
        //Declaração Variavéis

		private Vendas venda;

		public Vendas Venda
		{
			get { return venda; }
			set { venda = value; }
		}
		
       // private decimal total = 0;

				
		public frmPagamento()
        {
            InitializeComponent();
			
			
        }

        private void frmVendas_Load(object sender, EventArgs e)
        {
			txt_valor.Text = venda.valorvenda.ToString();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

	
		private void rdgrp_tipo_pagamento_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (rdgrp_tipo_pagamento.SelectedIndex == 0)
			{
				//Pagamento Dinheiro
				txt_valor_pago.Properties.ReadOnly = false;
			}
			else
			{
				if (rdgrp_tipo_pagamento.SelectedIndex == 3)
				{

					//Pagamento a Prazo
					txt_valor_pago.Properties.ReadOnly = true;
					txt_valor_pago.Value = 0;
				}
				else
				{
					// Pagamento Cartão
					txt_valor_pago.Properties.ReadOnly = true;
					txt_valor_pago.Value = txt_valor.Value;
					
				}
				
			}
		}

		private void txt_valor_pago_EditValueChanged(object sender, EventArgs e)
		{
			decimal troco = Convert.ToDecimal(txt_valor_pago.Value)-Convert.ToDecimal(txt_valor.Value);
			txt_troco.Text = troco.ToString();
			if (troco < 0)
			{
				txt_troco.Properties.AppearanceDisabled.ForeColor = Color.Red;
			}
			else {
				txt_troco.Properties.AppearanceDisabled.ForeColor = Color.Blue;
			}

		}

		private void btn_cancelar_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void btn_efetuar_pagamento_Click(object sender, EventArgs e)
		{
			venda.formaPagamento = Convert.ToInt16(rdgrp_tipo_pagamento.EditValue);
			this.Dispose();
		}

    }
}