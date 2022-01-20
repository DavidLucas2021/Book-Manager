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
            lb_texto_nome.Text = "Informe o nome do novo funcionário";
            Tbx_Login.Enabled = true;
            lb_texto_login.Text = "Informe o login do novo funcionário";
            Txb_Senha.Enabled = true;
            lb_texto_senha.Text = "Informe a senha do novo funsionário";

            Btn_SalvarNoDB.Enabled = true;
            Btn_Cancelar.Enabled = true;
        }
        private void Txb_Nome_Click(object sender, EventArgs e)
        {
            lb_texto_nome.Visible = false;
        }
        private void Tbx_Login_Click(object sender, EventArgs e)
        {
            lb_texto_login.Visible = false;
        }
        private void Txb_Senha_Click(object sender, EventArgs e)
        {
            lb_texto_senha.Visible = false;
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
            if(Txb_Nome.Text == String.Empty && Tbx_Login.Text == String.Empty && Txb_Senha.Text == String.Empty)
            {
                MessageBox.Show("Os campos Nome, Login e Senha são de preenchimento obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txb_Nome.Focus();
            }
            else if (Txb_Nome.Text != String.Empty && Tbx_Login.Text == String.Empty && Txb_Senha.Text == String.Empty)
            {
                MessageBox.Show("Os campos Login e Senha são de preenchimento obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Tbx_Login.Focus();
            }
            else if (Txb_Nome.Text == String.Empty && Tbx_Login.Text != String.Empty && Txb_Senha.Text == String.Empty)
            {
                MessageBox.Show("Os campos Nome e Senha são de preenchimento obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txb_Nome.Focus();
            }
            else if (Txb_Nome.Text == String.Empty && Tbx_Login.Text == String.Empty && Txb_Senha.Text != String.Empty)
            {
                MessageBox.Show("Os campos Nome e Login são de preenchimento obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (Txb_Senha.TextLength != Txb_Senha.MaxLength)
                {
                    MessageBox.Show("O campo Senha deve conter o total de 8 caracteres!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Txb_Senha.Clear();
                    Txb_Senha.Focus();
                }
            }
            else if(Txb_Nome.Text != String.Empty && Tbx_Login.Text != String.Empty && Txb_Senha.Text == String.Empty)
            {
                MessageBox.Show("O campo Senha é de preenchimento obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txb_Senha.Focus();
            }
            else if (Txb_Nome.Text == String.Empty && Tbx_Login.Text != String.Empty && Txb_Senha.Text != String.Empty)
            {
                MessageBox.Show("O campo Nome é de preenchimento obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (Txb_Senha.TextLength != Txb_Senha.MaxLength)
                {
                    MessageBox.Show("O campo Senha deve conter o total de 8 caracteres!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Txb_Senha.Clear();
                    Txb_Senha.Focus();
                }
            }
            else if (Txb_Nome.Text != String.Empty && Tbx_Login.Text == String.Empty && Txb_Senha.Text != String.Empty)
            {
                MessageBox.Show("O campo Login é de preenchimento obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (Txb_Senha.TextLength != Txb_Senha.MaxLength)
                {
                    MessageBox.Show("O campo Senha deve conter o total de 8 caracteres!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Txb_Senha.Clear();
                    Txb_Senha.Focus();
                }
            }
            else if (Txb_Nome.Text != String.Empty && Tbx_Login.Text != String.Empty && Txb_Senha.Text != String.Empty)
            {
                if(Txb_Senha.TextLength == Txb_Senha.MaxLength)
                {
                    MessageBox.Show("DEU CERTO!!!!!!!!!!!");
                }
                else
                {
                    MessageBox.Show("O campo Senha deve conter o total de 8 caracteres!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Txb_Senha.Clear();
                    Txb_Senha.Focus();
                }
            }
        }
        //FUNÇÃO DO BOTÃO DE VISIBILIDADE       
        private void Btn_visivel_MouseDown(object sender, MouseEventArgs e)
        {
            Btn_visivel.BackgroundImage = Properties.Resources.olho_aberto_removebg_preview;
            Txb_Senha.UseSystemPasswordChar = false;
        }
        //FUNÇÃO DO BOTÃO DE VISIBILIDADE
        private void Btn_visivel_MouseUp(object sender, MouseEventArgs e)
        {
            Btn_visivel.BackgroundImage = Properties.Resources.olho_fechado_removebg_preview;
            Txb_Senha.UseSystemPasswordChar = true;
        }
    }
}
