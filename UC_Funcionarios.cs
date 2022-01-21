using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Book_Manager
{
    public partial class UC_Funcionarios : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-O72G9B1;integrated security=SSPI;initial Catalog=DB_Livraria");
        SqlCommand command = new SqlCommand();
        SqlDataReader dataReader;
        //CLASSE QUE RECEBE DADOS DE UMA TABELA APÓS O COMANDO SELECT
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        //CLASSE QUE PODE REPRESENTAR UMA OU MAIS TABELAS DE DADOS
        //QUE PERMANECEM ALOCADAS NA MEMÓRIA E PODEM SER MANIPULADAS
        DataTable dataTable = new DataTable();

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
            Btn_visivel.Enabled = false; 
        }

        private void Func_Habilitar()
        {
            Txb_Nome.Enabled = true;
            Tbx_Login.Enabled = true;
            Txb_Senha.Enabled = true;

            Btn_SalvarNoDB.Enabled = true;
            Btn_Cancelar.Enabled = true;
            Btn_visivel.Enabled = true;
        }

        private void Limpar_Campos()
        {
            Txb_Nome.Clear();
            Tbx_Login.Clear();
            Txb_Senha.Clear();
            Txb_Nome.Focus();
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
                    try
                    {
                        String nome = Txb_Nome.Text;
                        string login = Tbx_Login.Text;
                        string senha = Txb_Senha.Text;

                        //COMANDO INSERT NA TABALEA ATENDENTE NAS VARIAVEIS DETERMINADAS
                        //(ds_Login,ds_Senha,nm_Atendente) DENTRO DO BANCO DE DADOS 
                        //ADICIONADO OS VALORES(@login,@senha,@nome)//DETERMINO COM
                        //COMMAND.PARAMETERS QUAL VARIAVEL RECEBE QUAL VALOR.
                        string sql = "insert into TBLAtendente(ds_Login,ds_Senha,nm_Atendente)values(@login,@senha,@nome)";

                        //INFORMANDO O COMANDO NA CONEXÃO DETERMINADA
                        //SqlCommand command = new SqlCommand(sql, connection);

                        command.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                        command.Parameters.Add("@senha", SqlDbType.Char).Value = senha;
                        command.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;

                        connection.Open();
                        command.CommandText = sql;
                        command.Connection = connection;

                        //EXECUTA O COMANDO SEM CONSULTA, POIS NÃO PRECISA RETORNA NADA
                        //EXENCUTENDO INSERÇÃO NO BANCO DE DADOS 
                        command.ExecuteNonQuery();
                        Limpar_Campos();
                    }
                    catch(Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                        connection.Close();
                        //Limpar_Campos();
                    }
                    finally
                    {
                        connection.Close();
                        MessageBox.Show("Novo Funcionário cadastrado com sucesso!", "Inserção de Dados", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        Limpar_Campos();
                        Txb_Nome.Focus();
                    }
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
        
        //EVENTO PARA CARREGAR OS DADOS DO BANCO DE DADOS 
        //QUANDO SOLICITADO NO CAMPO DE PESQUISA 
        private void Tbx_Pesq_funcionario_TextChanged(object sender, EventArgs e)
        {
            if(Tbx_Pesq_funcionario.Text != String.Empty)
            {
                try
                {
                    connection.Open();
                    //COMANDO USANDO O LIKE PARA BUSCAR OQUE FOR DIGITADO EM TBX_PESQ_FUNCIONARIO
                    //LIKE É O COMANDO NO BANCO DE DADOS PARA BUSCAS DE DADOS ESPECIFICOS
                    command.CommandText = "select * from TBLAtendente where nm_Atendente like ('" + Tbx_Pesq_funcionario.Text + "%')";
                    command.Connection = connection;

                    //DATAADAPTER RECEBE OS DADOS CONFORME COMANDO(SELECT)
                    dataAdapter.SelectCommand = command;
                    //PREECHE A TABELA EM DATATABLE
                    dataAdapter.Fill(dataTable);
                    //O COMPONENTE DATAGRIDVIEW RECEBE A TABELA EM DATATABLE
                    Caixa_do_DB.DataSource = dataTable;
                    connection.Close();
                }
                catch(Exception erro)
                { 
                    MessageBox.Show(erro.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                dataTable.Clear();
                Caixa_do_DB.DataSource = null;
            }
        }
    }
}
