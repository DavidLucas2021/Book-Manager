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
    public partial class T_Login : Form
    {
        public T_Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        //BOTÃO PARA FECHAR A APLICAÇÃO
        private void BT_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //EVENTO PARA QUANDO O BOTÃO ESTIVER ACIONADO 
        private void BT_Visibilidade_MouseDown(object sender, MouseEventArgs e)
        {
            BT_Visibilidade.BackgroundImage = Properties.Resources.olho_aberto_removebg_preview;
            TB_Senha.UseSystemPasswordChar = false;
        }
        //EVENTO PARA QUANDO O BOTÃO FOR SOLTO 
        private void BT_Visibilidade_MouseUp(object sender, MouseEventArgs e)
        {
            BT_Visibilidade.BackgroundImage = Properties.Resources.olho_fechado_removebg_preview;
            TB_Senha.UseSystemPasswordChar = true;
        }
    }
}
