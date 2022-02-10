
namespace Book_Manager
{
    partial class UC_Cliente
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Cliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Ativ_Inat = new System.Windows.Forms.Button();
            this.Btn_Alterar = new System.Windows.Forms.Button();
            this.Btn_SalvarNoDB = new System.Windows.Forms.Button();
            this.Btn_Novo = new System.Windows.Forms.Button();
            this.lb_ativ_inativo = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.gpb_pesquisa = new System.Windows.Forms.GroupBox();
            this.Txb_Pesq_funcionario = new System.Windows.Forms.TextBox();
            this.DataGrid_do_DB = new System.Windows.Forms.DataGridView();
            this.Lb_Código = new System.Windows.Forms.Label();
            this.Txb_Nome = new System.Windows.Forms.TextBox();
            this.Txb_email = new System.Windows.Forms.TextBox();
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_pessoa = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.Lb_Codigotxt = new System.Windows.Forms.Label();
            this.lb_cliente = new System.Windows.Forms.Label();
            this.Txb_logradouro = new System.Windows.Forms.TextBox();
            this.Txb_complemento = new System.Windows.Forms.TextBox();
            this.lb_complemento = new System.Windows.Forms.Label();
            this.lb_logradouro = new System.Windows.Forms.Label();
            this.Txb_cidade = new System.Windows.Forms.TextBox();
            this.lb_uf = new System.Windows.Forms.Label();
            this.lb_cidade = new System.Windows.Forms.Label();
            this.lb_cep = new System.Windows.Forms.Label();
            this.Txb_numero = new System.Windows.Forms.TextBox();
            this.Txb_bairro = new System.Windows.Forms.TextBox();
            this.lb_bairro = new System.Windows.Forms.Label();
            this.lb_numero = new System.Windows.Forms.Label();
            this.lb_cpf = new System.Windows.Forms.Label();
            this.lb_telefone = new System.Windows.Forms.Label();
            this.lb_cnpj = new System.Windows.Forms.Label();
            this.mkt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.cbx_pessoa = new System.Windows.Forms.ComboBox();
            this.cbx_uf = new System.Windows.Forms.ComboBox();
            this.mkb_cpfoucnpj = new System.Windows.Forms.MaskedTextBox();
            this.mkt_cep = new System.Windows.Forms.MaskedTextBox();
            this.gpb_pesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_do_DB)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Enabled = false;
            this.Btn_Cancelar.Image = global::Book_Manager.Properties.Resources.excluir__1_;
            this.Btn_Cancelar.Location = new System.Drawing.Point(645, 425);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(117, 60);
            this.Btn_Cancelar.TabIndex = 107;
            this.Btn_Cancelar.Text = " Cancelar";
            this.Btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Ativ_Inat
            // 
            this.Btn_Ativ_Inat.Enabled = false;
            this.Btn_Ativ_Inat.Image = global::Book_Manager.Properties.Resources.excluir;
            this.Btn_Ativ_Inat.Location = new System.Drawing.Point(645, 345);
            this.Btn_Ativ_Inat.Name = "Btn_Ativ_Inat";
            this.Btn_Ativ_Inat.Size = new System.Drawing.Size(117, 60);
            this.Btn_Ativ_Inat.TabIndex = 108;
            this.Btn_Ativ_Inat.Text = "Ativar/Inativar";
            this.Btn_Ativ_Inat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Ativ_Inat.UseVisualStyleBackColor = true;
            // 
            // Btn_Alterar
            // 
            this.Btn_Alterar.Enabled = false;
            this.Btn_Alterar.Image = global::Book_Manager.Properties.Resources.botao_editar;
            this.Btn_Alterar.Location = new System.Drawing.Point(645, 261);
            this.Btn_Alterar.Name = "Btn_Alterar";
            this.Btn_Alterar.Size = new System.Drawing.Size(117, 60);
            this.Btn_Alterar.TabIndex = 106;
            this.Btn_Alterar.Text = " Alterar";
            this.Btn_Alterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Alterar.UseVisualStyleBackColor = true;
            // 
            // Btn_SalvarNoDB
            // 
            this.Btn_SalvarNoDB.Enabled = false;
            this.Btn_SalvarNoDB.Image = global::Book_Manager.Properties.Resources.salve_;
            this.Btn_SalvarNoDB.Location = new System.Drawing.Point(645, 182);
            this.Btn_SalvarNoDB.Name = "Btn_SalvarNoDB";
            this.Btn_SalvarNoDB.Size = new System.Drawing.Size(117, 60);
            this.Btn_SalvarNoDB.TabIndex = 12;
            this.Btn_SalvarNoDB.Text = " Salvar";
            this.Btn_SalvarNoDB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_SalvarNoDB.UseVisualStyleBackColor = true;
            this.Btn_SalvarNoDB.Click += new System.EventHandler(this.Btn_SalvarNoDB_Click);
            // 
            // Btn_Novo
            // 
            this.Btn_Novo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Novo.Image")));
            this.Btn_Novo.Location = new System.Drawing.Point(645, 102);
            this.Btn_Novo.Name = "Btn_Novo";
            this.Btn_Novo.Size = new System.Drawing.Size(117, 60);
            this.Btn_Novo.TabIndex = 105;
            this.Btn_Novo.Text = " Novo";
            this.Btn_Novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Novo.UseVisualStyleBackColor = true;
            this.Btn_Novo.Click += new System.EventHandler(this.Btn_Novo_Click);
            // 
            // lb_ativ_inativo
            // 
            this.lb_ativ_inativo.AutoSize = true;
            this.lb_ativ_inativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ativ_inativo.ForeColor = System.Drawing.Color.White;
            this.lb_ativ_inativo.Location = new System.Drawing.Point(510, 269);
            this.lb_ativ_inativo.Name = "lb_ativ_inativo";
            this.lb_ativ_inativo.Size = new System.Drawing.Size(0, 24);
            this.lb_ativ_inativo.TabIndex = 125;
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.ForeColor = System.Drawing.Color.White;
            this.lb_status.Location = new System.Drawing.Point(440, 269);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(72, 24);
            this.lb_status.TabIndex = 124;
            this.lb_status.Text = "Status:";
            this.lb_status.Visible = false;
            // 
            // gpb_pesquisa
            // 
            this.gpb_pesquisa.Controls.Add(this.Txb_Pesq_funcionario);
            this.gpb_pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_pesquisa.ForeColor = System.Drawing.Color.White;
            this.gpb_pesquisa.Location = new System.Drawing.Point(89, 331);
            this.gpb_pesquisa.Name = "gpb_pesquisa";
            this.gpb_pesquisa.Size = new System.Drawing.Size(534, 52);
            this.gpb_pesquisa.TabIndex = 119;
            this.gpb_pesquisa.TabStop = false;
            this.gpb_pesquisa.Text = "Pesquisa por Funcionário ";
            // 
            // Txb_Pesq_funcionario
            // 
            this.Txb_Pesq_funcionario.Location = new System.Drawing.Point(11, 20);
            this.Txb_Pesq_funcionario.MaxLength = 20;
            this.Txb_Pesq_funcionario.Name = "Txb_Pesq_funcionario";
            this.Txb_Pesq_funcionario.Size = new System.Drawing.Size(515, 26);
            this.Txb_Pesq_funcionario.TabIndex = 13;
            // 
            // DataGrid_do_DB
            // 
            this.DataGrid_do_DB.AllowUserToResizeColumns = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGrid_do_DB.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGrid_do_DB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid_do_DB.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_do_DB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGrid_do_DB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid_do_DB.DefaultCellStyle = dataGridViewCellStyle8;
            this.DataGrid_do_DB.Location = new System.Drawing.Point(89, 389);
            this.DataGrid_do_DB.MultiSelect = false;
            this.DataGrid_do_DB.Name = "DataGrid_do_DB";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_do_DB.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DataGrid_do_DB.RowHeadersVisible = false;
            this.DataGrid_do_DB.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGrid_do_DB.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DataGrid_do_DB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_do_DB.Size = new System.Drawing.Size(534, 202);
            this.DataGrid_do_DB.TabIndex = 118;
            // 
            // Lb_Código
            // 
            this.Lb_Código.AutoSize = true;
            this.Lb_Código.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Código.ForeColor = System.Drawing.Color.White;
            this.Lb_Código.Location = new System.Drawing.Point(163, 62);
            this.Lb_Código.Name = "Lb_Código";
            this.Lb_Código.Size = new System.Drawing.Size(0, 24);
            this.Lb_Código.TabIndex = 117;
            this.Lb_Código.Visible = false;
            // 
            // Txb_Nome
            // 
            this.Txb_Nome.Enabled = false;
            this.Txb_Nome.Location = new System.Drawing.Point(167, 102);
            this.Txb_Nome.MaxLength = 60;
            this.Txb_Nome.Name = "Txb_Nome";
            this.Txb_Nome.Size = new System.Drawing.Size(448, 20);
            this.Txb_Nome.TabIndex = 0;
            // 
            // Txb_email
            // 
            this.Txb_email.Enabled = false;
            this.Txb_email.Location = new System.Drawing.Point(167, 142);
            this.Txb_email.MaxLength = 60;
            this.Txb_email.Name = "Txb_email";
            this.Txb_email.Size = new System.Drawing.Size(171, 20);
            this.Txb_email.TabIndex = 1;
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.ForeColor = System.Drawing.Color.White;
            this.lb_nome.Location = new System.Drawing.Point(96, 98);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(72, 24);
            this.lb_nome.TabIndex = 116;
            this.lb_nome.Text = "Nome:";
            // 
            // lb_pessoa
            // 
            this.lb_pessoa.AutoSize = true;
            this.lb_pessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pessoa.ForeColor = System.Drawing.Color.White;
            this.lb_pessoa.Location = new System.Drawing.Point(76, 165);
            this.lb_pessoa.Name = "lb_pessoa";
            this.lb_pessoa.Size = new System.Drawing.Size(84, 24);
            this.lb_pessoa.TabIndex = 115;
            this.lb_pessoa.Text = "Pessoa:";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.ForeColor = System.Drawing.Color.White;
            this.lb_email.Location = new System.Drawing.Point(85, 139);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(75, 24);
            this.lb_email.TabIndex = 113;
            this.lb_email.Text = "E-mail:";
            // 
            // Lb_Codigotxt
            // 
            this.Lb_Codigotxt.AutoSize = true;
            this.Lb_Codigotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Codigotxt.ForeColor = System.Drawing.Color.White;
            this.Lb_Codigotxt.Location = new System.Drawing.Point(85, 62);
            this.Lb_Codigotxt.Name = "Lb_Codigotxt";
            this.Lb_Codigotxt.Size = new System.Drawing.Size(83, 24);
            this.Lb_Codigotxt.TabIndex = 112;
            this.Lb_Codigotxt.Text = "Código:";
            this.Lb_Codigotxt.Visible = false;
            // 
            // lb_cliente
            // 
            this.lb_cliente.AutoSize = true;
            this.lb_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cliente.ForeColor = System.Drawing.Color.White;
            this.lb_cliente.Location = new System.Drawing.Point(274, 10);
            this.lb_cliente.Name = "lb_cliente";
            this.lb_cliente.Size = new System.Drawing.Size(132, 39);
            this.lb_cliente.TabIndex = 109;
            this.lb_cliente.Text = "Cliente";
            // 
            // Txb_logradouro
            // 
            this.Txb_logradouro.Enabled = false;
            this.Txb_logradouro.Location = new System.Drawing.Point(167, 194);
            this.Txb_logradouro.MaxLength = 60;
            this.Txb_logradouro.Name = "Txb_logradouro";
            this.Txb_logradouro.Size = new System.Drawing.Size(171, 20);
            this.Txb_logradouro.TabIndex = 3;
            // 
            // Txb_complemento
            // 
            this.Txb_complemento.Enabled = false;
            this.Txb_complemento.Location = new System.Drawing.Point(167, 220);
            this.Txb_complemento.MaxLength = 20;
            this.Txb_complemento.Name = "Txb_complemento";
            this.Txb_complemento.Size = new System.Drawing.Size(171, 20);
            this.Txb_complemento.TabIndex = 4;
            // 
            // lb_complemento
            // 
            this.lb_complemento.AutoSize = true;
            this.lb_complemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_complemento.ForeColor = System.Drawing.Color.White;
            this.lb_complemento.Location = new System.Drawing.Point(14, 217);
            this.lb_complemento.Name = "lb_complemento";
            this.lb_complemento.Size = new System.Drawing.Size(146, 24);
            this.lb_complemento.TabIndex = 129;
            this.lb_complemento.Text = "Complemento:";
            // 
            // lb_logradouro
            // 
            this.lb_logradouro.AutoSize = true;
            this.lb_logradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_logradouro.ForeColor = System.Drawing.Color.White;
            this.lb_logradouro.Location = new System.Drawing.Point(37, 191);
            this.lb_logradouro.Name = "lb_logradouro";
            this.lb_logradouro.Size = new System.Drawing.Size(124, 24);
            this.lb_logradouro.TabIndex = 127;
            this.lb_logradouro.Text = "Logradouro:";
            // 
            // Txb_cidade
            // 
            this.Txb_cidade.Enabled = false;
            this.Txb_cidade.Location = new System.Drawing.Point(167, 246);
            this.Txb_cidade.MaxLength = 20;
            this.Txb_cidade.Name = "Txb_cidade";
            this.Txb_cidade.Size = new System.Drawing.Size(171, 20);
            this.Txb_cidade.TabIndex = 5;
            // 
            // lb_uf
            // 
            this.lb_uf.AutoSize = true;
            this.lb_uf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_uf.ForeColor = System.Drawing.Color.White;
            this.lb_uf.Location = new System.Drawing.Point(117, 269);
            this.lb_uf.Name = "lb_uf";
            this.lb_uf.Size = new System.Drawing.Size(43, 24);
            this.lb_uf.TabIndex = 135;
            this.lb_uf.Text = "UF:";
            // 
            // lb_cidade
            // 
            this.lb_cidade.AutoSize = true;
            this.lb_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cidade.ForeColor = System.Drawing.Color.White;
            this.lb_cidade.Location = new System.Drawing.Point(78, 242);
            this.lb_cidade.Name = "lb_cidade";
            this.lb_cidade.Size = new System.Drawing.Size(82, 24);
            this.lb_cidade.TabIndex = 133;
            this.lb_cidade.Text = "Cidade:";
            // 
            // lb_cep
            // 
            this.lb_cep.AutoSize = true;
            this.lb_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cep.ForeColor = System.Drawing.Color.White;
            this.lb_cep.Location = new System.Drawing.Point(384, 244);
            this.lb_cep.Name = "lb_cep";
            this.lb_cep.Size = new System.Drawing.Size(54, 24);
            this.lb_cep.TabIndex = 151;
            this.lb_cep.Text = "Cep:";
            // 
            // Txb_numero
            // 
            this.Txb_numero.Enabled = false;
            this.Txb_numero.Location = new System.Drawing.Point(444, 194);
            this.Txb_numero.MaxLength = 5;
            this.Txb_numero.Name = "Txb_numero";
            this.Txb_numero.Size = new System.Drawing.Size(171, 20);
            this.Txb_numero.TabIndex = 9;
            this.Txb_numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txb_numero_KeyPress);
            // 
            // Txb_bairro
            // 
            this.Txb_bairro.Enabled = false;
            this.Txb_bairro.Location = new System.Drawing.Point(444, 220);
            this.Txb_bairro.MaxLength = 20;
            this.Txb_bairro.Name = "Txb_bairro";
            this.Txb_bairro.Size = new System.Drawing.Size(171, 20);
            this.Txb_bairro.TabIndex = 10;
            // 
            // lb_bairro
            // 
            this.lb_bairro.AutoSize = true;
            this.lb_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bairro.ForeColor = System.Drawing.Color.White;
            this.lb_bairro.Location = new System.Drawing.Point(367, 218);
            this.lb_bairro.Name = "lb_bairro";
            this.lb_bairro.Size = new System.Drawing.Size(71, 24);
            this.lb_bairro.TabIndex = 147;
            this.lb_bairro.Text = "Bairro:";
            // 
            // lb_numero
            // 
            this.lb_numero.AutoSize = true;
            this.lb_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_numero.ForeColor = System.Drawing.Color.White;
            this.lb_numero.Location = new System.Drawing.Point(347, 194);
            this.lb_numero.Name = "lb_numero";
            this.lb_numero.Size = new System.Drawing.Size(91, 24);
            this.lb_numero.TabIndex = 145;
            this.lb_numero.Text = "Número:";
            // 
            // lb_cpf
            // 
            this.lb_cpf.AutoSize = true;
            this.lb_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cpf.ForeColor = System.Drawing.Color.White;
            this.lb_cpf.Location = new System.Drawing.Point(384, 168);
            this.lb_cpf.Name = "lb_cpf";
            this.lb_cpf.Size = new System.Drawing.Size(56, 24);
            this.lb_cpf.TabIndex = 141;
            this.lb_cpf.Text = "CPF:";
            this.lb_cpf.Visible = false;
            // 
            // lb_telefone
            // 
            this.lb_telefone.AutoSize = true;
            this.lb_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_telefone.ForeColor = System.Drawing.Color.White;
            this.lb_telefone.Location = new System.Drawing.Point(339, 141);
            this.lb_telefone.Name = "lb_telefone";
            this.lb_telefone.Size = new System.Drawing.Size(99, 24);
            this.lb_telefone.TabIndex = 139;
            this.lb_telefone.Text = "Telefone:";
            // 
            // lb_cnpj
            // 
            this.lb_cnpj.AutoSize = true;
            this.lb_cnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cnpj.ForeColor = System.Drawing.Color.White;
            this.lb_cnpj.Location = new System.Drawing.Point(370, 168);
            this.lb_cnpj.Name = "lb_cnpj";
            this.lb_cnpj.Size = new System.Drawing.Size(68, 24);
            this.lb_cnpj.TabIndex = 154;
            this.lb_cnpj.Text = "CNPJ:";
            this.lb_cnpj.Visible = false;
            // 
            // mkt_telefone
            // 
            this.mkt_telefone.Location = new System.Drawing.Point(444, 141);
            this.mkt_telefone.Mask = "(00)00000-0000";
            this.mkt_telefone.Name = "mkt_telefone";
            this.mkt_telefone.Size = new System.Drawing.Size(171, 20);
            this.mkt_telefone.TabIndex = 7;
            this.mkt_telefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cbx_pessoa
            // 
            this.cbx_pessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_pessoa.FormattingEnabled = true;
            this.cbx_pessoa.Items.AddRange(new object[] {
            "Física",
            "Jurídica"});
            this.cbx_pessoa.Location = new System.Drawing.Point(166, 168);
            this.cbx_pessoa.Name = "cbx_pessoa";
            this.cbx_pessoa.Size = new System.Drawing.Size(172, 21);
            this.cbx_pessoa.TabIndex = 2;
            this.cbx_pessoa.SelectedIndexChanged += new System.EventHandler(this.cbx_pessoa_SelectedIndexChanged);
            // 
            // cbx_uf
            // 
            this.cbx_uf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_uf.FormattingEnabled = true;
            this.cbx_uf.Items.AddRange(new object[] {
            " AC",
            " AL",
            " AP",
            " AM",
            " BA",
            " CE",
            " DF",
            " ES",
            " GO",
            " MA",
            " MT",
            " MS",
            " MG",
            " PA",
            " PB",
            " PR",
            " PE",
            " PI",
            " RJ",
            " RN",
            " RS",
            " RO",
            " RR",
            " SC",
            " SP",
            " SE",
            " TO"});
            this.cbx_uf.Location = new System.Drawing.Point(166, 272);
            this.cbx_uf.Name = "cbx_uf";
            this.cbx_uf.Size = new System.Drawing.Size(84, 21);
            this.cbx_uf.TabIndex = 6;
            // 
            // mkb_cpfoucnpj
            // 
            this.mkb_cpfoucnpj.Location = new System.Drawing.Point(444, 169);
            this.mkb_cpfoucnpj.Name = "mkb_cpfoucnpj";
            this.mkb_cpfoucnpj.Size = new System.Drawing.Size(171, 20);
            this.mkb_cpfoucnpj.TabIndex = 8;
            this.mkb_cpfoucnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mkt_cep
            // 
            this.mkt_cep.Location = new System.Drawing.Point(444, 246);
            this.mkt_cep.Mask = "00000-000";
            this.mkt_cep.Name = "mkt_cep";
            this.mkt_cep.Size = new System.Drawing.Size(171, 20);
            this.mkt_cep.TabIndex = 11;
            this.mkt_cep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // UC_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.mkt_cep);
            this.Controls.Add(this.mkb_cpfoucnpj);
            this.Controls.Add(this.cbx_uf);
            this.Controls.Add(this.cbx_pessoa);
            this.Controls.Add(this.mkt_telefone);
            this.Controls.Add(this.lb_cnpj);
            this.Controls.Add(this.lb_cep);
            this.Controls.Add(this.Txb_numero);
            this.Controls.Add(this.Txb_bairro);
            this.Controls.Add(this.lb_bairro);
            this.Controls.Add(this.lb_numero);
            this.Controls.Add(this.lb_cpf);
            this.Controls.Add(this.lb_telefone);
            this.Controls.Add(this.Txb_cidade);
            this.Controls.Add(this.lb_uf);
            this.Controls.Add(this.lb_cidade);
            this.Controls.Add(this.Txb_logradouro);
            this.Controls.Add(this.Txb_complemento);
            this.Controls.Add(this.lb_complemento);
            this.Controls.Add(this.lb_logradouro);
            this.Controls.Add(this.lb_ativ_inativo);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.gpb_pesquisa);
            this.Controls.Add(this.DataGrid_do_DB);
            this.Controls.Add(this.Lb_Código);
            this.Controls.Add(this.Txb_Nome);
            this.Controls.Add(this.Txb_email);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.lb_pessoa);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.Lb_Codigotxt);
            this.Controls.Add(this.lb_cliente);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Ativ_Inat);
            this.Controls.Add(this.Btn_Alterar);
            this.Controls.Add(this.Btn_SalvarNoDB);
            this.Controls.Add(this.Btn_Novo);
            this.Name = "UC_Cliente";
            this.Size = new System.Drawing.Size(800, 650);
            this.gpb_pesquisa.ResumeLayout(false);
            this.gpb_pesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_do_DB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Ativ_Inat;
        private System.Windows.Forms.Button Btn_Alterar;
        private System.Windows.Forms.Button Btn_SalvarNoDB;
        private System.Windows.Forms.Button Btn_Novo;
        private System.Windows.Forms.Label lb_ativ_inativo;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.GroupBox gpb_pesquisa;
        private System.Windows.Forms.TextBox Txb_Pesq_funcionario;
        private System.Windows.Forms.DataGridView DataGrid_do_DB;
        private System.Windows.Forms.Label Lb_Código;
        private System.Windows.Forms.TextBox Txb_Nome;
        private System.Windows.Forms.TextBox Txb_email;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label lb_pessoa;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label Lb_Codigotxt;
        private System.Windows.Forms.Label lb_cliente;
        private System.Windows.Forms.TextBox Txb_logradouro;
        private System.Windows.Forms.TextBox Txb_complemento;
        private System.Windows.Forms.Label lb_complemento;
        private System.Windows.Forms.Label lb_logradouro;
        private System.Windows.Forms.TextBox Txb_cidade;
        private System.Windows.Forms.Label lb_uf;
        private System.Windows.Forms.Label lb_cidade;
        private System.Windows.Forms.Label lb_cep;
        private System.Windows.Forms.TextBox Txb_numero;
        private System.Windows.Forms.TextBox Txb_bairro;
        private System.Windows.Forms.Label lb_bairro;
        private System.Windows.Forms.Label lb_numero;
        private System.Windows.Forms.Label lb_cpf;
        private System.Windows.Forms.Label lb_telefone;
        private System.Windows.Forms.Label lb_cnpj;
        private System.Windows.Forms.MaskedTextBox mkt_telefone;
        private System.Windows.Forms.ComboBox cbx_pessoa;
        private System.Windows.Forms.ComboBox cbx_uf;
        private System.Windows.Forms.MaskedTextBox mkb_cpfoucnpj;
        private System.Windows.Forms.MaskedTextBox mkt_cep;
    }
}
