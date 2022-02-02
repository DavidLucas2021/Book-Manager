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
    public partial class T_Menu : Form
    {
        public T_Menu(string usuário_logado)
        {
            InitializeComponent();
            uC_Funcionarios1.Hide();
            LB_Usuariotxt.Text = usuário_logado;
        }

        private void T_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BT_Funcionarios_Click(object sender, EventArgs e)
        {
            principal1.Hide();
            uC_Funcionarios1.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            LB_DataeHora.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
        }

        private void Btn_Sair_Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            T_Login t_Login = new T_Login();
            t_Login.Show();
            
        }
    }
}
