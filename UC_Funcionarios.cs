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
    public partial class UC_Funcionarios : UserControl
    {
        public UC_Funcionarios()
        {
            InitializeComponent();
            Func_Desabilitar();
        }
        private void Func_Desabilitar()
        {
            Txb_Nome.Enabled = false;
            Tbx_Login.Enabled = false;
            Txb_Senha.Enabled = false;

            Txb_Nome.Clear();
            Tbx_Login.Clear();
            Txb_Senha.Clear();
            Tbx_Pesq_funcionario.Clear();
            
            Btn_Alterar.Enabled = false;
            Btn_SalvarNoDB.Enabled = false;
            Btn_Excluir.Enabled = false;
            Btn_Cancelar.Enabled = false;
        }

        private void Func_Habilitar()
        {
            Txb_Nome.Enabled = true;
            Tbx_Login.Enabled = true;
            Txb_Senha.Enabled = true;

            Btn_SalvarNoDB.Enabled = true;
            Btn_Cancelar.Enabled = true;
        }

        private void Btn_Novo_Click(object sender, EventArgs e)
        {
            Func_Habilitar();
            Txb_Nome.Focus();
            Btn_Novo.Enabled = false;
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Func_Desabilitar();
            Btn_Novo.Enabled = true;
        }

        private void Btn_SalvarNoDB_Click(object sender, EventArgs e)
        {
            if(Txb_Nome.Text != String.Empty)
            {
                if(Tbx_Login.Text != String.Empty)
                {
                    if(Txb_Senha.Text != String.Empty)
                    {
                        if (Txb_Senha.TextLength == Txb_Senha.MaxLength)
                        {
                            MessageBox.Show("DEU CERTO!!!");
                        }
                        else
                        {
                            MessageBox.Show("O campo Senha não foi preenchido totalmente! Este campo deve conter o total de 8 caractes.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Txb_Senha.Clear();
                            Txb_Senha.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("O campo Senha é um campo obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Txb_Senha.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("O campo Login é um campo obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Tbx_Login.Focus();
                }
            }
            else
            {
                MessageBox.Show("O campo Nome é um campo obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txb_Nome.Focus();
            }
        }
    }
}
