using System;
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
            if (cbx_pessoa.SelectedIndex == -1)
            {
                lb_cpf.Visible = false;
                lb_cnpj.Visible = false;
                mkb_cpfoucnpj.Mask = string.Empty;
            }
            else if (cbx_pessoa.SelectedIndex == 0)
            {
                lb_cpf.Visible = true;
                lb_cnpj.Visible = false;
                mkb_cpfoucnpj.Enabled = true;
                mkb_cpfoucnpj.Mask = "000.000.000-00";
            }
            else if (cbx_pessoa.SelectedIndex == 1)
            {
                lb_cpf.Visible = false;
                lb_cnpj.Visible = true;
                mkb_cpfoucnpj.Enabled = true;
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
            mkb_cpfoucnpj.Enabled = false;
            Txb_logradouro.Enabled = true;
            Txb_numero.Enabled = true;
            Txb_complemento.Enabled = true;
            Txb_bairro.Enabled = true;
            Txb_cidade.Enabled = true;
            mkt_cep.Enabled = true;
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
            mkt_cep.Clear();
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
            mkt_cep.Enabled = false;
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
            mkt_cep.Clear();
            cbx_uf.SelectedIndex = -1;
        }

        private void Btn_Novo_Click(object sender, EventArgs e)
        {
            Func_habilitar();
            Txb_Nome.Focus();
            Btn_SalvarNoDB.Enabled = true;
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

        private void Func_SomenteLetra(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo não aceita números.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void Txb_logradouro_KeyPress(object sender, KeyPressEventArgs e)
        {
            Func_SomenteLetra(e);
        }
        private void Txb_complemento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Func_SomenteLetra(e);
        }

        private void Txb_cidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            Func_SomenteLetra(e);
        }

        private void Txb_bairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            Func_SomenteLetra(e);
        }

        private bool Func_Ferramentas_Vazias()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (String.IsNullOrWhiteSpace(textBox.Text))
                    {
                        return true;
                    }
                }
                else if (c is MaskedTextBox)
                {
                    MaskedTextBox maskedTextBox = c as MaskedTextBox;
                    if (string.IsNullOrWhiteSpace(maskedTextBox.Text))
                    {
                        return true;
                    }
                }
                else if (c is ComboBox)
                {
                    ComboBox comboBox = c as ComboBox;
                    if (string.IsNullOrWhiteSpace(comboBox.Text))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void Btn_SalvarNoDB_Click(object sender, EventArgs e)
        {
            bool emailvalido = true;

            if(Func_Ferramentas_Vazias() == true)
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "Campo(s) vazios.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if(!string.IsNullOrWhiteSpace(mkt_telefone.Text) && !mkt_telefone.MaskCompleted)
            {
                MessageBox.Show("Telefone inválido! Informe um número com o total de 11 caracteres incluindo DDD.", "Campo inválido.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if(lb_cpf.Visible == true)
            {
                if (!string.IsNullOrWhiteSpace(mkb_cpfoucnpj.Text) && !mkb_cpfoucnpj.MaskCompleted)
                {
                    MessageBox.Show("CPF inválido! Informe um CPF com o total de 11 caracteres.", "Campo inválido.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if(lb_cnpj.Visible == true)
            {
                if (!string.IsNullOrWhiteSpace(mkb_cpfoucnpj.Text) && !mkb_cpfoucnpj.MaskCompleted)
                {
                    MessageBox.Show("CNPJ inválido! Informe um CNPJ com o total de 14 caracteres.", "Campo inválido.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if(!string.IsNullOrWhiteSpace(mkt_cep.Text) && !mkt_cep.MaskCompleted)
            {
                MessageBox.Show("CEP inválido! Informe um CEP com o total de 8 caracteres.", "Campo inválido.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (lb_cpf.Visible)
            {
                if (Txb_email.Text.Contains("@gmail.com"))
                {
                    if (Txb_email.TextLength < 12)
                    {
                        MessageBox.Show("E-mail inválido! Informe um e-mail que seja válido.");
                        emailvalido = false;
                    }
                }else if(Txb_email.Text.Contains("@outlook.com"))
                {
                    if(Txb_email.TextLength < 14)
                    {
                        MessageBox.Show("E-mail inválido! Informe um e-mail que seja válido.");
                        emailvalido = false;
                    }
                }else
                {
                    if (Txb_email.TextLength > 0)
                    {
                        MessageBox.Show("E-mail inválido! Informe um e-mail que seja válido.");
                        emailvalido = false;
                    }
                }
            }
            else if(lb_cnpj.Visible)
            {
                if (!Txb_email.Text.Contains("@") || (Txb_email.Text.Contains("@") && Txb_email.TextLength < 11))
                {
                    MessageBox.Show("E-mail inválido! Informe um e-mail que seja válido.");
                    emailvalido = false;
                }
            }

            if (Func_Ferramentas_Vazias() == false && mkt_telefone.MaskCompleted && mkb_cpfoucnpj.MaskCompleted && mkt_cep.MaskCompleted && emailvalido == true)
            {
                MessageBox.Show("deu certo!!!");
            }
        }
    }
}
