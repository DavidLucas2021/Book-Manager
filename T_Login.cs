using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//BIBLIOTE EXCLUSIVA PARA O SQL SERVER
using System.Data.SqlClient;

namespace Book_Manager
{
    public partial class T_Login : Form
    {
        public T_Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            TB_Login.Focus();
        }

        //CONEXÃO COM O BANCO DE DADOS SQL SERVER.
        //
        //CONNECTION = CLASSE PARA CONECTAR COM O BANCO
        //DE DADOS QUE FOR DETERMINADO (SQLCONNECTION)
        //
        //É CRIADO UMA CONEXÃO COM O BANCO DE DADOS 
        //INFORMANDO O SERVIDOR DO BANCO DE DADOS, A
        //AUTENTICAÇÃO (SSPI = AUTENTICAÇÃO DO WINDOWS)
        //E NOME DO BANCO DE DADOS  
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-O72G9B1;integrated security=SSPI;initial Catalog=DB_Livraria");
        //COMMAND = CLASSE PARA ENVIAR ISNTRUÇÕES 
        //(SELECT, INSERT, UPDATE, DELETE E ETC...)
        //AO BANCO DE DADOS 
        SqlCommand command = new SqlCommand();
        //DATAREADER = CLASSE PARA OBTER DADOS DE UMA TABELA 
        //APÓS A EXECUÇÃO DE UM SELECT
        SqlDataReader dataReader;



        //BOTÃO PARA FECHAR A APLICAÇÃO
        private void BT_Fechar_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            //T_Login.ActiveForm.Close();
            this.Close();
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

        private void BT_Logar_Click(object sender, EventArgs e)
        {
            if((TB_Login.Text != string.Empty) && (TB_Senha.Text != string.Empty))
            {
                try
                {
                    //ABRI UMA CONEXÃO COM O BANCO DE DADOS
                    connection.Open();
                    //DEFINE UM COMANDO PARA LER E COMPARAR OS DADOS INFORMADOS COM O BANDCO DE DADOS
                    command.CommandText = "select * from TBLAtendente where ds_Login = ('" + TB_Login.Text + "') and ds_Senha = ('" + TB_Senha.Text + "')";
                    //VINCULA ESSE COMANDO AO BANCO DE DADOS EM CONNECTION
                    command.Connection = connection;
                    //EXECUTA A LEITURA DO BANCO DE DADOS É RETORNA A TABELA CONFORME COMANDO 
                    dataReader = command.ExecuteReader();
                    
                    //IDENTIFICA SE O SQL CONTEM LINHAS COM O COMANDO ESPECIFICADO 
                    if(dataReader.HasRows)
                    {
                        //OCULTA A TELA DE LOGIN QUANDO O MENU ABRIR
                         this.Hide();
                        T_Menu _Menu = new T_Menu();
                        _Menu.StartPosition = FormStartPosition.CenterScreen;
                        _Menu.ShowDialog();

                        
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválidos!", "Erro ao logar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TB_Login.Clear();
                        TB_Senha.Clear();
                        TB_Login.Focus();
                    }
                }
                catch(Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    connection.Close();
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Os campos login e senha devem ser preenchidos.", "Campo(s) vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TB_Login.Clear();
                TB_Senha.Clear();
                TB_Login.Focus();
            }
        }
    }
}
