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

        //VARIÁVEIS UTILIZADAS PARA FAZER COMPARAÇÃO 
        //DO QUE FOI CARREGADO NA FUNÇÃO DOUBLECLICK_DB
        //COM OQUE FOI ENCONTRADO AO CLICAR EM ATIVAR/INATIVAR
        string txtnome_carregado = String.Empty;
        string txtlogin_carregado = String.Empty;
        string txtsenha_carregado = String.Empty;

        public UC_Funcionarios()
        {
            InitializeComponent();
            Func_Desabilitar();
            Func_Cancela_escrita_Datagrid();
        }

        //FUNÇÃO PARA DETERMINAR NO TXB_SENHA QUE SOMENTE 
        //NUMEROS SEJAM COLOCADOS NO CAMPO DE TEXTO.
        //A FUNÇÃO PODE SER UTILIZADA CASO HAJA NECESSIDADE DE OPTAR 
        //POR CAMPO DE SENHA ACEITANDO SOMENTE NUMEROS.
        //private void Func_Somentenumeros(KeyPressEventArgs e)
        //{
        //    //KEYCHAR UTILIZA A TABELA ASCII PARA DETERMINAR O CARACTER
        //    if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44 && e.KeyChar != 46)
        //    {
        //        e.Handled = true;
        //    }
        //}
        //private void Txb_Senha_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    Func_Somentenumeros(e);
        //}

        //FUNÇÃO PARA EMPEDIR DE QUE O USUÁRIO  
        //ALTERE DADOS AO CLICAR NO DATAGRIDVIEW 
        //E DIGITAR PELO TECLADO 
        private void Func_Cancela_escrita_Datagrid()
        {
            Caixa_do_DB.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        
        private void Func_Desabilitar()
        {
            Txb_Nome.Enabled = false;
            Tbx_Login.Enabled = false;
            Txb_Senha.Enabled = false;

            Txb_Nome.Clear();
            Tbx_Login.Clear();
            Txb_Senha.Clear();
            //Tbx_Pesq_funcionario.Clear();

            Btn_Alterar.Enabled = false;
            Btn_SalvarNoDB.Enabled = false;
            Btn_Ativ_Inat.Enabled = false;
            Btn_Cancelar.Enabled = false;
            Btn_visivel.Enabled = false;

            Lb_Codigotxt.Visible = false;
            Lb_Código.Visible = false;
            Lb_Código.Text = String.Empty;

            LBL_status.Visible = false;
            LBL_status.Text = String.Empty;
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
            Tbx_Pesq_funcionario.Clear();
        }


        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Func_Desabilitar();
            Btn_Novo.Enabled = true;
        }

        private void Btn_SalvarNoDB_Click(object sender, EventArgs e)
        {
            if (Txb_Nome.Text == String.Empty)
            {
                MessageBox.Show("O campo Nome é de preenchimento obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txb_Nome.Focus();
            }
            if (Tbx_Login.Text == String.Empty)
            {
                MessageBox.Show("O campo Login é preenchimento obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Tbx_Login.Focus();
            }
            if (Txb_Senha.Text == String.Empty)
            {
                MessageBox.Show("O campo Senha é preenchimento obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txb_Nome.Focus();
            }
            
            if (Txb_Nome.Text != String.Empty && Tbx_Login.Text != String.Empty && Txb_Senha.Text != String.Empty)
            {
                if (Txb_Senha.TextLength == Txb_Senha.MaxLength)
                {
                    Btn_SalvarNoDB.TabIndex = 4;
                    connection.Open();
                    //DEFINE UM COMANDO PARA LER E COMPARAR OS DADOS INFORMADOS COM O BANDCO DE DADOS
                    command.CommandText = "select * from TBLAtendente where ds_Login = ('" + Tbx_Login.Text + "')";
                    command.Connection = connection;
                    //EXECUTA A LEITURA DO BANCO DE DADOS É RETORNA A TABELA CONFORME COMANDO 
                    dataReader = command.ExecuteReader();

                    if (dataReader.HasRows == false)
                    {
                        dataReader.Close();
                        try
                        {
                            String nome = Txb_Nome.Text;
                            string login = Tbx_Login.Text;
                            string senha = Txb_Senha.Text;
                            bool ativo = true;
                            
                            //COMANDO INSERT NA TABALEA ATENDENTE NAS VARIAVEIS DETERMINADAS
                            //(ds_Login,ds_Senha,nm_Atendente) DENTRO DO BANCO DE DADOS 
                            //ADICIONADO OS VALORES(@login,@senha,@nome)//DETERMINO COM
                            //COMMAND.PARAMETERS QUAL VARIAVEL RECEBE QUAL VALOR.
                            string sql = "insert into TBLAtendente(ds_Login,ds_Senha,nm_Atendente,ds_status)values(@login,@senha,@nome,@ativo)";

                            //INFORMANDO O COMANDO NA CONEXÃO DETERMINADA
                            //SqlCommand command = new SqlCommand(sql, connection);

                            command.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                            command.Parameters.Add("@senha", SqlDbType.Char).Value = senha;
                            command.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                            command.Parameters.Add("@ativo", SqlDbType.Bit).Value = ativo;

                            command.CommandText = sql;
                            command.Connection = connection;
                            //EXECUTA O COMANDO SEM CONSULTA, POIS NÃO PRECISA RETORNA NADA
                            //EXENCUTENDO INSERÇÃO NO BANCO DE DADOS 
                            command.ExecuteNonQuery();

                            Tbx_Pesq_funcionario.Clear();
                            MessageBox.Show("Novo Funcionário cadastrado com sucesso!", "Inserção de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpar_Campos();
                            Txb_Nome.Focus();

                            //O TRECHO ABAIXO EVITA UMA EXCESSÃO 
                            //QUE INFORMA QUE O "@LOGIN" JÁ CONTÉM 
                            //VALOR SEMPRE QUE É REALIZADO UMA SEGUNDA
                            //INSERÇÃO DE FUNCIONÁRIO | OS DEMAIS TRECHOS 
                            //FECHAM O VINCULO COM O BANCO POR SEGURANÇA
                            command.Parameters.Clear();
                            //dataReader.Close();
                            connection.Close();
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show(erro.Message);
                            //dataReader.Close();
                            connection.Close();
                            Limpar_Campos();
                        }
                    }
                    else
                    {
                        dataReader.Close();
                        connection.Close();
                        MessageBox.Show("O login que você deseja cadastrar já existe. Tente um novo login diferente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Tbx_Login.Clear();
                        Tbx_Login.Focus();
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
            if (Tbx_Pesq_funcionario.Text != String.Empty)
            {
                //LIMPEZA DOS DADOS DA TABELA PARA NÃO SER
                //APRESENTADO DADOS DUPLICADOS TODA VEZ QUE 
                //COMPA RECEBER UM NOVO CARACTER
                dataTable.Clear();
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
                catch (Exception erro_pesquisa)
                {
                    MessageBox.Show(erro_pesquisa.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                Caixa_do_DB.DataSource = null;
            }
        }
        //FUNÇÃO PARA CARREGAR VALORES PARA ALTERAÇÃO
        private void Caixa_do_DB_DoubleClick(object sender, EventArgs e)
        {
            Btn_Novo.Enabled = false;
            Btn_SalvarNoDB.Enabled = false;
            Btn_Alterar.Enabled = true;
            Btn_Ativ_Inat.Enabled = true;
            Btn_Cancelar.Enabled = true;


            Txb_Nome.Enabled = true;
            Tbx_Login.Enabled = true;
            Txb_Senha.Enabled = true;
            Btn_visivel.Enabled = true;

            Lb_Codigotxt.Visible = true;
            Lb_Código.Visible = true;
            LBL_status.Visible = true;

            Lb_Código.Text = Caixa_do_DB.SelectedRows[0].Cells[0].Value.ToString();
            Tbx_Login.Text = Caixa_do_DB.SelectedRows[0].Cells[1].Value.ToString();
            Txb_Senha.Text = Caixa_do_DB.SelectedRows[0].Cells[2].Value.ToString();
            Txb_Nome.Text = Caixa_do_DB.SelectedRows[0].Cells[3].Value.ToString();
            string valor = Caixa_do_DB.SelectedRows[0].Cells[4].Value.ToString();

            //vARIÁVEIS RECEBEM O PRIMEIRO VALOR 
            //QUANDO A INFORMAÇÃO É CARREGADA DO DB
            txtnome_carregado = Txb_Nome.Text;
            txtlogin_carregado = Tbx_Login.Text;
            txtsenha_carregado = Txb_Senha.Text;

            if (valor == "True")
            {
                LBL_status.Text = "Ativo";
            }
            else
            {
                LBL_status.Text = "Inativo";
            }

            if(LBL_status.Text =="Ativo")
            {
                Btn_Ativ_Inat.Text = "Inativar";
            }
            else
            {
                Btn_Ativ_Inat.Text = "Ativar";
            }
        }
        //FUNÇÃO DE ALTERAÇÃO DE CADASTROS 
        private void Btn_Alterar_Click(object sender, EventArgs e)
        {
            if (Txb_Nome.Text == String.Empty && Tbx_Login.Text == String.Empty && Txb_Senha.Text == String.Empty)
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
            else if (Txb_Nome.Text != String.Empty && Tbx_Login.Text != String.Empty && Txb_Senha.Text == String.Empty)
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
                if (Txb_Senha.TextLength == Txb_Senha.MaxLength)
                {
                    try
                    {
                        string nome = Txb_Nome.Text;
                        string login = Tbx_Login.Text;
                        string senha = Txb_Senha.Text;
                        int cd = int.Parse(Lb_Código.Text);

                        connection.Open();
                        //COMANDO UPDATE(ALTERAÇÃO) NA TABALEA ATENDENTE NAS VARIAVEIS DETERMINADAS
                        //(ds_Login,ds_Senha,nm_Atendente) DENTRO DO BANCO DE DADOS 
                        //ADICIONADO OS VALORES DAS VARIAVEIS(@login,@senha,@nome).
                        //DETERMINO COM COMMAND.PARAMETERS QUAL SERÁ O VALOR DAS VARIAVEIS.
                        //PARA ALTERAÇÃO DE DADOS O "cd" CARREGADO DEVE SER IGUAL AO "cd_Atendente"
                        //DO DADO NO BANCO DE DADOS.
                        string sql = "update TBLAtendente set ds_Login=@login,ds_Senha=@senha,nm_Atendente=@nome where cd_Atedente=@cd";

                        //INFORMANDO O COMANDO NA CONEXÃO DETERMINADA
                        //SqlCommand command = new SqlCommand(sql, connection);

                        command.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                        command.Parameters.Add("@senha", SqlDbType.Char).Value = senha;
                        command.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                        command.Parameters.Add("@cd", SqlDbType.Int).Value = cd;

                        command.CommandText = sql;
                        command.Connection = connection;
                        //EXECUTA O COMANDO SEM CONSULTA, POIS NÃO PRECISA RETORNA NADA
                        //EXENCUTENDO INSERÇÃO NO BANCO DE DADOS 
                        command.ExecuteNonQuery();

                        Lb_Codigotxt.Visible = false;
                        Lb_Código.Visible = false;
                        Tbx_Pesq_funcionario.Clear();
                        MessageBox.Show("Dados cadastrais do funcionário alterado com sucesso!", "Alteração de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpar_Campos();
                        Txb_Nome.Focus();

                        //O TRECHO ABAIXO EVITA UMA EXCESSÃO 
                        //QUE INFORMA QUE O "@LOGIN" JÁ CONTÉM 
                        //VALOR SEMPRE QUE É REALIZADO UMA SEGUNDA
                        //INSERÇÃO DE FUNCIONÁRIO | OS DEMAIS TRECHOS 
                        //FECHAM O VINCULO COM O BANCO POR SEGURANÇA
                        command.Parameters.Clear();
                        connection.Close();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                        connection.Close();
                        Limpar_Campos();
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
        //FUNÇÃO DE DELETAR FUNCIO0NÁRIOS DO DB
        private void Btn_Ativ_Inat_Click(object sender, EventArgs e)
        {
            DialogResult ativ_inat = MessageBox.Show("Tem certaza que deseja alterar o status do funcionário(a)?", "Ativar/Inativar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(ativ_inat == DialogResult.Yes)
            {
                try
                {
                    connection.Open();
                    command.CommandText = "select * from TBLAtendente where cd_atedente = ('" + Lb_Código.Text + "') and ds_status = 1";
                    //VINCULA ESSE COMANDO AO BANCO DE DADOS EM CONNECTION
                    command.Connection = connection;
                    //EXECUTA A LEITURA DO BANCO DE DADOS É RETORNA A TABELA CONFORME COMANDO 
                    dataReader = command.ExecuteReader();

                    if (txtnome_carregado != Txb_Nome.Text || txtlogin_carregado != Tbx_Login.Text || txtsenha_carregado != Txb_Senha.Text)
                    {
                        MessageBox.Show("As alterações realizadas nos dados cadastrais do(a) funcionário(a) não serão contabilizadas. Para alterações de dados utilize o botão alterar. O botão que foi utilizado serve somente para ativar e inativar funcionários(as).", "Aviso importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtnome_carregado = String.Empty;
                        txtlogin_carregado = String.Empty;
                        txtsenha_carregado = String.Empty;
                    }
                    else
                    {
                        txtnome_carregado = String.Empty;
                        txtlogin_carregado = String.Empty;
                        txtsenha_carregado = String.Empty;
                    }

                    if (dataReader.HasRows)
                    {
                        dataReader.Close();
                        //string nome = Txb_Nome.Text;
                        //string login = Tbx_Login.Text;
                        //string senha = Txb_Senha.Text;
                        int cd = int.Parse(Lb_Código.Text);
                        bool status = false;

                        string sql = "update TBLAtendente set ds_status=@status where cd_Atedente=@cd";
                        //ds_Login = @login,ds_Senha = @senha,nm_Atendente = @nome,
                        //command.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                        //command.Parameters.Add("@senha", SqlDbType.Char).Value = senha;
                        //command.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                        command.Parameters.Add("@cd", SqlDbType.Int).Value = cd;
                        command.Parameters.Add("@status", SqlDbType.Int).Value = status;

                        command.CommandText = sql;
                        command.Connection = connection;
                        command.ExecuteNonQuery();

                        MessageBox.Show("Funcionário inativado com sucesso!", "Alteração de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Limpar_Campos();
                        Tbx_Pesq_funcionario.Clear();
                        Btn_Ativ_Inat.Text = "Ativar/Inativar";

                        command.Parameters.Clear();
                        connection.Close();
                    }
                    else
                    {
                        dataReader.Close();
                        //string nome = Txb_Nome.Text;
                        //string login = Tbx_Login.Text;
                        //string senha = Txb_Senha.Text;
                        int cd = int.Parse(Lb_Código.Text);
                        bool status = true;

                        string sql = "update TBLAtendente set ds_status=@status where cd_Atedente=@cd";
                        //ds_Login = @login,ds_Senha = @senha,nm_Atendente = @nome,
                        //command.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                        //command.Parameters.Add("@senha", SqlDbType.Char).Value = senha;
                        //command.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                        command.Parameters.Add("@cd", SqlDbType.Int).Value = cd;
                        command.Parameters.Add("@status", SqlDbType.Int).Value = status;

                        command.CommandText = sql;
                        command.Connection = connection;
                        command.ExecuteNonQuery();

                        MessageBox.Show("Funcionário ativado com sucesso!", "Alteração de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Limpar_Campos();
                        Tbx_Pesq_funcionario.Clear();
                        Btn_Ativ_Inat.Text = "Ativar/Inativar";

                        command.Parameters.Clear();
                        connection.Close();
                    }
                    Func_Desabilitar();
                    Btn_Novo.Enabled = true;
                }
                catch(Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    command.Parameters.Clear();
                    connection.Close();

                    Func_Desabilitar();
                    Btn_Novo.Enabled = true;
                }
            }
            else
            {
                Func_Desabilitar();
                Btn_Novo.Enabled = true;
            }
        }
    }
}


