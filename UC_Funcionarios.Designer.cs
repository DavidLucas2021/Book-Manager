
namespace Book_Manager
{
    partial class UC_Funcionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Funcionarios));
            this.label2 = new System.Windows.Forms.Label();
            this.Lb_Codigotxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txb_Senha = new System.Windows.Forms.TextBox();
            this.Tbx_Login = new System.Windows.Forms.TextBox();
            this.Txb_Nome = new System.Windows.Forms.TextBox();
            this.Lb_Código = new System.Windows.Forms.Label();
            this.Caixa_do_DB = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Tbx_Pesq_funcionario = new System.Windows.Forms.TextBox();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Excluir = new System.Windows.Forms.Button();
            this.Btn_Alterar = new System.Windows.Forms.Button();
            this.Btn_SalvarNoDB = new System.Windows.Forms.Button();
            this.Btn_Novo = new System.Windows.Forms.Button();
            this.Btn_visivel = new System.Windows.Forms.Button();
            this.lb_texto_nome = new System.Windows.Forms.Label();
            this.lb_texto_login = new System.Windows.Forms.Label();
            this.lb_texto_senha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Caixa_do_DB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(179, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Funcionário";
            // 
            // Lb_Codigotxt
            // 
            this.Lb_Codigotxt.AutoSize = true;
            this.Lb_Codigotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Codigotxt.ForeColor = System.Drawing.Color.White;
            this.Lb_Codigotxt.Location = new System.Drawing.Point(15, 77);
            this.Lb_Codigotxt.Name = "Lb_Codigotxt";
            this.Lb_Codigotxt.Size = new System.Drawing.Size(83, 24);
            this.Lb_Codigotxt.TabIndex = 2;
            this.Lb_Codigotxt.Text = "Código:";
            this.Lb_Codigotxt.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Senha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nome:";
            // 
            // Txb_Senha
            // 
            this.Txb_Senha.Enabled = false;
            this.Txb_Senha.Location = new System.Drawing.Point(97, 201);
            this.Txb_Senha.MaxLength = 8;
            this.Txb_Senha.Name = "Txb_Senha";
            this.Txb_Senha.Size = new System.Drawing.Size(332, 20);
            this.Txb_Senha.TabIndex = 7;
            this.Txb_Senha.UseSystemPasswordChar = true;
            // 
            // Tbx_Login
            // 
            this.Tbx_Login.Enabled = false;
            this.Tbx_Login.Location = new System.Drawing.Point(97, 157);
            this.Tbx_Login.MaxLength = 20;
            this.Tbx_Login.Name = "Tbx_Login";
            this.Tbx_Login.Size = new System.Drawing.Size(332, 20);
            this.Tbx_Login.TabIndex = 8;
            // 
            // Txb_Nome
            // 
            this.Txb_Nome.Enabled = false;
            this.Txb_Nome.Location = new System.Drawing.Point(97, 117);
            this.Txb_Nome.MaxLength = 60;
            this.Txb_Nome.Name = "Txb_Nome";
            this.Txb_Nome.Size = new System.Drawing.Size(333, 20);
            this.Txb_Nome.TabIndex = 9;
            // 
            // Lb_Código
            // 
            this.Lb_Código.AutoSize = true;
            this.Lb_Código.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Código.ForeColor = System.Drawing.Color.White;
            this.Lb_Código.Location = new System.Drawing.Point(93, 77);
            this.Lb_Código.Name = "Lb_Código";
            this.Lb_Código.Size = new System.Drawing.Size(0, 24);
            this.Lb_Código.TabIndex = 10;
            this.Lb_Código.Visible = false;
            // 
            // Caixa_do_DB
            // 
            this.Caixa_do_DB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Caixa_do_DB.Location = new System.Drawing.Point(19, 360);
            this.Caixa_do_DB.MultiSelect = false;
            this.Caixa_do_DB.Name = "Caixa_do_DB";
            this.Caixa_do_DB.Size = new System.Drawing.Size(427, 186);
            this.Caixa_do_DB.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Tbx_Pesq_funcionario);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(19, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 52);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa por Funcionário ";
            // 
            // Tbx_Pesq_funcionario
            // 
            this.Tbx_Pesq_funcionario.Location = new System.Drawing.Point(7, 19);
            this.Tbx_Pesq_funcionario.MaxLength = 20;
            this.Tbx_Pesq_funcionario.Name = "Tbx_Pesq_funcionario";
            this.Tbx_Pesq_funcionario.Size = new System.Drawing.Size(403, 26);
            this.Tbx_Pesq_funcionario.TabIndex = 14;
            this.Tbx_Pesq_funcionario.TextChanged += new System.EventHandler(this.Tbx_Pesq_funcionario_TextChanged);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Enabled = false;
            this.Btn_Cancelar.Image = global::Book_Manager.Properties.Resources.excluir__1_;
            this.Btn_Cancelar.Location = new System.Drawing.Point(462, 440);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(106, 60);
            this.Btn_Cancelar.TabIndex = 18;
            this.Btn_Cancelar.Text = " Cancelar";
            this.Btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Excluir
            // 
            this.Btn_Excluir.Enabled = false;
            this.Btn_Excluir.Image = global::Book_Manager.Properties.Resources.excluir;
            this.Btn_Excluir.Location = new System.Drawing.Point(462, 360);
            this.Btn_Excluir.Name = "Btn_Excluir";
            this.Btn_Excluir.Size = new System.Drawing.Size(106, 60);
            this.Btn_Excluir.TabIndex = 17;
            this.Btn_Excluir.Text = " Remover";
            this.Btn_Excluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Excluir.UseVisualStyleBackColor = true;
            // 
            // Btn_Alterar
            // 
            this.Btn_Alterar.Enabled = false;
            this.Btn_Alterar.Image = global::Book_Manager.Properties.Resources.botao_editar;
            this.Btn_Alterar.Location = new System.Drawing.Point(462, 276);
            this.Btn_Alterar.Name = "Btn_Alterar";
            this.Btn_Alterar.Size = new System.Drawing.Size(106, 60);
            this.Btn_Alterar.TabIndex = 16;
            this.Btn_Alterar.Text = " Alterar";
            this.Btn_Alterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Alterar.UseVisualStyleBackColor = true;
            // 
            // Btn_SalvarNoDB
            // 
            this.Btn_SalvarNoDB.Enabled = false;
            this.Btn_SalvarNoDB.Image = global::Book_Manager.Properties.Resources.salve_;
            this.Btn_SalvarNoDB.Location = new System.Drawing.Point(462, 197);
            this.Btn_SalvarNoDB.Name = "Btn_SalvarNoDB";
            this.Btn_SalvarNoDB.Size = new System.Drawing.Size(106, 60);
            this.Btn_SalvarNoDB.TabIndex = 15;
            this.Btn_SalvarNoDB.Text = " Salvar";
            this.Btn_SalvarNoDB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_SalvarNoDB.UseVisualStyleBackColor = true;
            this.Btn_SalvarNoDB.Click += new System.EventHandler(this.Btn_SalvarNoDB_Click);
            // 
            // Btn_Novo
            // 
            this.Btn_Novo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Novo.Image")));
            this.Btn_Novo.Location = new System.Drawing.Point(462, 117);
            this.Btn_Novo.Name = "Btn_Novo";
            this.Btn_Novo.Size = new System.Drawing.Size(106, 60);
            this.Btn_Novo.TabIndex = 14;
            this.Btn_Novo.Text = " Novo";
            this.Btn_Novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Novo.UseVisualStyleBackColor = true;
            this.Btn_Novo.Click += new System.EventHandler(this.Btn_Novo_Click);
            // 
            // Btn_visivel
            // 
            this.Btn_visivel.BackColor = System.Drawing.SystemColors.Window;
            this.Btn_visivel.BackgroundImage = global::Book_Manager.Properties.Resources.olho_fechado_removebg_preview;
            this.Btn_visivel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_visivel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_visivel.FlatAppearance.BorderSize = 0;
            this.Btn_visivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_visivel.Location = new System.Drawing.Point(404, 202);
            this.Btn_visivel.Name = "Btn_visivel";
            this.Btn_visivel.Size = new System.Drawing.Size(25, 18);
            this.Btn_visivel.TabIndex = 19;
            this.Btn_visivel.UseVisualStyleBackColor = false;
            this.Btn_visivel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_visivel_MouseDown);
            this.Btn_visivel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_visivel_MouseUp);
            // 
            // lb_texto_nome
            // 
            this.lb_texto_nome.AutoSize = true;
            this.lb_texto_nome.BackColor = System.Drawing.SystemColors.Window;
            this.lb_texto_nome.Location = new System.Drawing.Point(97, 120);
            this.lb_texto_nome.Name = "lb_texto_nome";
            this.lb_texto_nome.Size = new System.Drawing.Size(0, 13);
            this.lb_texto_nome.TabIndex = 20;
            // 
            // lb_texto_login
            // 
            this.lb_texto_login.AutoSize = true;
            this.lb_texto_login.BackColor = System.Drawing.SystemColors.Window;
            this.lb_texto_login.Location = new System.Drawing.Point(97, 160);
            this.lb_texto_login.Name = "lb_texto_login";
            this.lb_texto_login.Size = new System.Drawing.Size(0, 13);
            this.lb_texto_login.TabIndex = 21;
            // 
            // lb_texto_senha
            // 
            this.lb_texto_senha.AutoSize = true;
            this.lb_texto_senha.BackColor = System.Drawing.SystemColors.Window;
            this.lb_texto_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lb_texto_senha.Location = new System.Drawing.Point(97, 204);
            this.lb_texto_senha.Name = "lb_texto_senha";
            this.lb_texto_senha.Size = new System.Drawing.Size(0, 13);
            this.lb_texto_senha.TabIndex = 22;
            // 
            // UC_Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.lb_texto_senha);
            this.Controls.Add(this.lb_texto_login);
            this.Controls.Add(this.lb_texto_nome);
            this.Controls.Add(this.Btn_visivel);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Excluir);
            this.Controls.Add(this.Btn_Alterar);
            this.Controls.Add(this.Btn_SalvarNoDB);
            this.Controls.Add(this.Btn_Novo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Caixa_do_DB);
            this.Controls.Add(this.Lb_Código);
            this.Controls.Add(this.Txb_Nome);
            this.Controls.Add(this.Tbx_Login);
            this.Controls.Add(this.Txb_Senha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lb_Codigotxt);
            this.Controls.Add(this.label2);
            this.Name = "UC_Funcionarios";
            this.Size = new System.Drawing.Size(600, 600);
            ((System.ComponentModel.ISupportInitialize)(this.Caixa_do_DB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lb_Codigotxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txb_Senha;
        private System.Windows.Forms.TextBox Tbx_Login;
        private System.Windows.Forms.TextBox Txb_Nome;
        private System.Windows.Forms.Label Lb_Código;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Tbx_Pesq_funcionario;
        private System.Windows.Forms.Button Btn_Novo;
        private System.Windows.Forms.Button Btn_SalvarNoDB;
        private System.Windows.Forms.Button Btn_Alterar;
        private System.Windows.Forms.Button Btn_Excluir;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_visivel;
        private System.Windows.Forms.Label lb_texto_nome;
        private System.Windows.Forms.Label lb_texto_login;
        private System.Windows.Forms.Label lb_texto_senha;
        private System.Windows.Forms.DataGridView Caixa_do_DB;
    }
}
