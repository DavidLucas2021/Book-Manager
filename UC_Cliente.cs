using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Manager
{
    public partial class UC_Cliente : UserControl
    {
        public UC_Cliente()
        {
            InitializeComponent();
            Func_desbilitar();
        }
        //FUNÇÃO QUE CARREGA O CPF OU CNPJ CONFORME PESSOA ESCOLHIDA
        private void Func_SelecaoFisicaouJuridica()
        {
            //-1 == QUANDO NÃO HÁ NADA SELECIONADO
            if(cbx_pessoa.SelectedIndex == -1)
            {
                lb_cpf.Visible = false;
                lb_cnpj.Visible = false;
            }
            else if (cbx_pessoa.SelectedIndex == 0)
            {
                lb_cpf.Visible = true;
                lb_cnpj.Visible = false;
                mkb_cpfoucnpj.Mask = "000.000.000-00";
            }
            else if (cbx_pessoa.SelectedIndex == 1)
            {
                lb_cpf.Visible = false;
                lb_cnpj.Visible = true;
                mkb_cpfoucnpj.Mask = "00.000.000/0000-00";
            }
        }

        private void cbx_pessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func_SelecaoFisicaouJuridica();
        }

        private void Func_habilitar()
        {
            Lb_Codigotxt.Visible = false;
            Lb_Código.Visible = false;
            lb_status.Visible = false;
            lb_ativ_inativo.Visible = false;

            Btn_Cancelar.Enabled = true;

            Btn_Novo.Enabled = false;
            Btn_SalvarNoDB.Enabled = false;
            Btn_Alterar.Enabled = false;
            Btn_Ativ_Inat.Enabled = false;

            Txb_Nome.Enabled = true;
            Txb_email.Enabled = true;
            mkt_telefone.Enabled = true;
            cbx_pessoa.Enabled = true;
            mkb_cpfoucnpj.Enabled = true;
            Txb_logradouro.Enabled = true;
            Txb_numero.Enabled = true;
            Txb_complemento.Enabled = true;
            Txb_bairro.Enabled = true;
            Txb_cidade.Enabled = true;
            mkb_cep.Enabled = true;
            cbx_uf.Enabled = true;

            Txb_Nome.Clear();
            Txb_email.Clear();
            mkt_telefone.Clear();
            //O COMANDO COM O VALOR -1 DIZ QUE O CAMPO ESTA SEM NENHUMA SELEÇÃO
            cbx_pessoa.SelectedIndex = -1;
            mkb_cpfoucnpj.Clear();
            Txb_logradouro.Clear();
            Txb_numero.Clear();
            Txb_complemento.Clear();
            Txb_bairro.Clear();
            Txb_cidade.Clear();
            mkb_cep.Clear();
            cbx_pessoa.SelectedIndex = -1;

        }
        private void Func_desbilitar()
        {
            Lb_Codigotxt.Visible = false;
            Lb_Código.Visible = false;
            lb_status.Visible = false;
            lb_ativ_inativo.Visible = false;

            Btn_Novo.Enabled = true;

            Btn_SalvarNoDB.Enabled = false;
            Btn_Alterar.Enabled = false;
            Btn_Ativ_Inat.Enabled = false;
            Btn_Cancelar.Enabled = false;

            Txb_Nome.Enabled = false;
            Txb_email.Enabled = false;
            mkt_telefone.Enabled = false;
            cbx_pessoa.Enabled = false;
            mkb_cpfoucnpj.Enabled = false;
            Txb_logradouro.Enabled = false;
            Txb_numero.Enabled = false;
            Txb_complemento.Enabled = false;
            Txb_bairro.Enabled = false;
            Txb_cidade.Enabled = false;
            mkb_cep.Enabled = false;
            cbx_uf.Enabled = false;

            Txb_Nome.Clear();
            Txb_email.Clear(); 
            mkt_telefone.Clear();
            cbx_pessoa.SelectedIndex = -1;
            mkb_cpfoucnpj.Clear();
            Txb_logradouro.Clear();
            Txb_numero.Clear();
            Txb_complemento.Clear();
            Txb_bairro.Clear();
            Txb_cidade.Clear();
            mkb_cep.Clear();
            cbx_uf.SelectedIndex = -1;
        }

        private void Btn_Novo_Click(object sender, EventArgs e)
        {
            Func_habilitar();
            Txb_Nome.Focus();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Func_desbilitar();
        }
        //FUNCIONALIDADE PARA IMPEDIR QUE O CAMPO NUMERO RECEBA LETRAS
        private void Txb_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
