
namespace Book_Manager
{
    partial class T_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(T_Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LB_Usuariotxt = new System.Windows.Forms.Label();
            this.Btn_Sair_Login = new System.Windows.Forms.Button();
            this.BT_Caixa = new System.Windows.Forms.Button();
            this.BT_Pedido = new System.Windows.Forms.Button();
            this.LB_Usuario = new System.Windows.Forms.Label();
            this.BT_Autores = new System.Windows.Forms.Button();
            this.BT_Editoras = new System.Windows.Forms.Button();
            this.BT_Categorias = new System.Windows.Forms.Button();
            this.BT_Livros = new System.Windows.Forms.Button();
            this.BT_Telefone = new System.Windows.Forms.Button();
            this.BT_Clientes = new System.Windows.Forms.Button();
            this.BT_Funcionarios = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LB_Nome_Livraria = new System.Windows.Forms.Label();
            this.LB_DataeHora = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.uC_Funcionarios1 = new Book_Manager.UC_Funcionarios();
            this.principal1 = new Book_Manager.Principal();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.panel1.Controls.Add(this.LB_Usuariotxt);
            this.panel1.Controls.Add(this.Btn_Sair_Login);
            this.panel1.Controls.Add(this.BT_Caixa);
            this.panel1.Controls.Add(this.BT_Pedido);
            this.panel1.Controls.Add(this.LB_Usuario);
            this.panel1.Controls.Add(this.BT_Autores);
            this.panel1.Controls.Add(this.BT_Editoras);
            this.panel1.Controls.Add(this.BT_Categorias);
            this.panel1.Controls.Add(this.BT_Livros);
            this.panel1.Controls.Add(this.BT_Telefone);
            this.panel1.Controls.Add(this.BT_Clientes);
            this.panel1.Controls.Add(this.BT_Funcionarios);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 557);
            this.panel1.TabIndex = 0;
            // 
            // LB_Usuariotxt
            // 
            this.LB_Usuariotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Usuariotxt.ForeColor = System.Drawing.Color.White;
            this.LB_Usuariotxt.Location = new System.Drawing.Point(68, 481);
            this.LB_Usuariotxt.Name = "LB_Usuariotxt";
            this.LB_Usuariotxt.Size = new System.Drawing.Size(121, 28);
            this.LB_Usuariotxt.TabIndex = 13;
            this.LB_Usuariotxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Sair_Login
            // 
            this.Btn_Sair_Login.FlatAppearance.BorderSize = 0;
            this.Btn_Sair_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Sair_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Sair_Login.ForeColor = System.Drawing.Color.White;
            this.Btn_Sair_Login.Image = global::Book_Manager.Properties.Resources.logout__1_;
            this.Btn_Sair_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Sair_Login.Location = new System.Drawing.Point(0, 513);
            this.Btn_Sair_Login.Name = "Btn_Sair_Login";
            this.Btn_Sair_Login.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Btn_Sair_Login.Size = new System.Drawing.Size(90, 44);
            this.Btn_Sair_Login.TabIndex = 12;
            this.Btn_Sair_Login.Text = "Sair";
            this.Btn_Sair_Login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Sair_Login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Sair_Login.UseVisualStyleBackColor = true;
            this.Btn_Sair_Login.Click += new System.EventHandler(this.Btn_Sair_Login_Click);
            // 
            // BT_Caixa
            // 
            this.BT_Caixa.Dock = System.Windows.Forms.DockStyle.Top;
            this.BT_Caixa.FlatAppearance.BorderSize = 0;
            this.BT_Caixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Caixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Caixa.ForeColor = System.Drawing.Color.White;
            this.BT_Caixa.Image = global::Book_Manager.Properties.Resources.fluxo_de_caixa;
            this.BT_Caixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Caixa.Location = new System.Drawing.Point(0, 428);
            this.BT_Caixa.Name = "BT_Caixa";
            this.BT_Caixa.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BT_Caixa.Size = new System.Drawing.Size(200, 45);
            this.BT_Caixa.TabIndex = 9;
            this.BT_Caixa.Text = " Caixa";
            this.BT_Caixa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Caixa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_Caixa.UseVisualStyleBackColor = true;
            // 
            // BT_Pedido
            // 
            this.BT_Pedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.BT_Pedido.FlatAppearance.BorderSize = 0;
            this.BT_Pedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Pedido.ForeColor = System.Drawing.Color.White;
            this.BT_Pedido.Image = ((System.Drawing.Image)(resources.GetObject("BT_Pedido.Image")));
            this.BT_Pedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Pedido.Location = new System.Drawing.Point(0, 383);
            this.BT_Pedido.Name = "BT_Pedido";
            this.BT_Pedido.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BT_Pedido.Size = new System.Drawing.Size(200, 45);
            this.BT_Pedido.TabIndex = 8;
            this.BT_Pedido.Text = " Pedidos";
            this.BT_Pedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Pedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_Pedido.UseVisualStyleBackColor = true;
            // 
            // LB_Usuario
            // 
            this.LB_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Usuario.ForeColor = System.Drawing.Color.White;
            this.LB_Usuario.Location = new System.Drawing.Point(3, 481);
            this.LB_Usuario.Name = "LB_Usuario";
            this.LB_Usuario.Size = new System.Drawing.Size(69, 28);
            this.LB_Usuario.TabIndex = 11;
            this.LB_Usuario.Text = "Login:";
            this.LB_Usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BT_Autores
            // 
            this.BT_Autores.Dock = System.Windows.Forms.DockStyle.Top;
            this.BT_Autores.FlatAppearance.BorderSize = 0;
            this.BT_Autores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Autores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Autores.ForeColor = System.Drawing.Color.White;
            this.BT_Autores.Image = ((System.Drawing.Image)(resources.GetObject("BT_Autores.Image")));
            this.BT_Autores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Autores.Location = new System.Drawing.Point(0, 338);
            this.BT_Autores.Name = "BT_Autores";
            this.BT_Autores.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BT_Autores.Size = new System.Drawing.Size(200, 45);
            this.BT_Autores.TabIndex = 7;
            this.BT_Autores.Text = " Autores";
            this.BT_Autores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Autores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_Autores.UseVisualStyleBackColor = true;
            // 
            // BT_Editoras
            // 
            this.BT_Editoras.Dock = System.Windows.Forms.DockStyle.Top;
            this.BT_Editoras.FlatAppearance.BorderSize = 0;
            this.BT_Editoras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Editoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Editoras.ForeColor = System.Drawing.Color.White;
            this.BT_Editoras.Image = global::Book_Manager.Properties.Resources.design_editorial;
            this.BT_Editoras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Editoras.Location = new System.Drawing.Point(0, 293);
            this.BT_Editoras.Name = "BT_Editoras";
            this.BT_Editoras.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BT_Editoras.Size = new System.Drawing.Size(200, 45);
            this.BT_Editoras.TabIndex = 6;
            this.BT_Editoras.Text = " Editoras";
            this.BT_Editoras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Editoras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_Editoras.UseVisualStyleBackColor = true;
            // 
            // BT_Categorias
            // 
            this.BT_Categorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.BT_Categorias.FlatAppearance.BorderSize = 0;
            this.BT_Categorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Categorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Categorias.ForeColor = System.Drawing.Color.White;
            this.BT_Categorias.Image = ((System.Drawing.Image)(resources.GetObject("BT_Categorias.Image")));
            this.BT_Categorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Categorias.Location = new System.Drawing.Point(0, 248);
            this.BT_Categorias.Name = "BT_Categorias";
            this.BT_Categorias.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BT_Categorias.Size = new System.Drawing.Size(200, 45);
            this.BT_Categorias.TabIndex = 5;
            this.BT_Categorias.Text = " Categorias";
            this.BT_Categorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Categorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_Categorias.UseVisualStyleBackColor = true;
            // 
            // BT_Livros
            // 
            this.BT_Livros.Dock = System.Windows.Forms.DockStyle.Top;
            this.BT_Livros.FlatAppearance.BorderSize = 0;
            this.BT_Livros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Livros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Livros.ForeColor = System.Drawing.Color.White;
            this.BT_Livros.Image = global::Book_Manager.Properties.Resources.pilha_de_livros;
            this.BT_Livros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Livros.Location = new System.Drawing.Point(0, 203);
            this.BT_Livros.Name = "BT_Livros";
            this.BT_Livros.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BT_Livros.Size = new System.Drawing.Size(200, 45);
            this.BT_Livros.TabIndex = 4;
            this.BT_Livros.Text = " Livros";
            this.BT_Livros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Livros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_Livros.UseVisualStyleBackColor = true;
            // 
            // BT_Telefone
            // 
            this.BT_Telefone.Dock = System.Windows.Forms.DockStyle.Top;
            this.BT_Telefone.FlatAppearance.BorderSize = 0;
            this.BT_Telefone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Telefone.ForeColor = System.Drawing.Color.White;
            this.BT_Telefone.Image = ((System.Drawing.Image)(resources.GetObject("BT_Telefone.Image")));
            this.BT_Telefone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Telefone.Location = new System.Drawing.Point(0, 158);
            this.BT_Telefone.Name = "BT_Telefone";
            this.BT_Telefone.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BT_Telefone.Size = new System.Drawing.Size(200, 45);
            this.BT_Telefone.TabIndex = 3;
            this.BT_Telefone.Text = " Telefones";
            this.BT_Telefone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Telefone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_Telefone.UseVisualStyleBackColor = true;
            // 
            // BT_Clientes
            // 
            this.BT_Clientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BT_Clientes.FlatAppearance.BorderSize = 0;
            this.BT_Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Clientes.ForeColor = System.Drawing.Color.White;
            this.BT_Clientes.Image = ((System.Drawing.Image)(resources.GetObject("BT_Clientes.Image")));
            this.BT_Clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Clientes.Location = new System.Drawing.Point(0, 113);
            this.BT_Clientes.Name = "BT_Clientes";
            this.BT_Clientes.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BT_Clientes.Size = new System.Drawing.Size(200, 45);
            this.BT_Clientes.TabIndex = 2;
            this.BT_Clientes.Text = " Clientes";
            this.BT_Clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_Clientes.UseVisualStyleBackColor = true;
            // 
            // BT_Funcionarios
            // 
            this.BT_Funcionarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BT_Funcionarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.BT_Funcionarios.FlatAppearance.BorderSize = 0;
            this.BT_Funcionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Funcionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Funcionarios.ForeColor = System.Drawing.Color.White;
            this.BT_Funcionarios.Image = global::Book_Manager.Properties.Resources.carteira_de_identidade;
            this.BT_Funcionarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Funcionarios.Location = new System.Drawing.Point(0, 68);
            this.BT_Funcionarios.Name = "BT_Funcionarios";
            this.BT_Funcionarios.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.BT_Funcionarios.Size = new System.Drawing.Size(200, 45);
            this.BT_Funcionarios.TabIndex = 1;
            this.BT_Funcionarios.Text = " Funcionários";
            this.BT_Funcionarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_Funcionarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_Funcionarios.UseVisualStyleBackColor = true;
            this.BT_Funcionarios.Click += new System.EventHandler(this.BT_Funcionarios_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.Controls.Add(this.LB_Nome_Livraria);
            this.flowLayoutPanel1.Controls.Add(this.LB_DataeHora);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 68);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // LB_Nome_Livraria
            // 
            this.LB_Nome_Livraria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Nome_Livraria.ForeColor = System.Drawing.Color.White;
            this.LB_Nome_Livraria.Location = new System.Drawing.Point(3, 0);
            this.LB_Nome_Livraria.Name = "LB_Nome_Livraria";
            this.LB_Nome_Livraria.Size = new System.Drawing.Size(197, 36);
            this.LB_Nome_Livraria.TabIndex = 1;
            this.LB_Nome_Livraria.Text = "Livraria Johnson";
            this.LB_Nome_Livraria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_DataeHora
            // 
            this.LB_DataeHora.BackColor = System.Drawing.Color.Black;
            this.LB_DataeHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_DataeHora.ForeColor = System.Drawing.Color.White;
            this.LB_DataeHora.Location = new System.Drawing.Point(3, 36);
            this.LB_DataeHora.Name = "LB_DataeHora";
            this.LB_DataeHora.Size = new System.Drawing.Size(186, 24);
            this.LB_DataeHora.TabIndex = 10;
            this.LB_DataeHora.Text = "00/00/0000 - 00:00:00";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // uC_Funcionarios1
            // 
            this.uC_Funcionarios1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_Funcionarios1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uC_Funcionarios1.Location = new System.Drawing.Point(195, 0);
            this.uC_Funcionarios1.Name = "uC_Funcionarios1";
            this.uC_Funcionarios1.Size = new System.Drawing.Size(600, 600);
            this.uC_Funcionarios1.TabIndex = 2;
            // 
            // principal1
            // 
            this.principal1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.principal1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.principal1.ForeColor = System.Drawing.Color.Black;
            this.principal1.Location = new System.Drawing.Point(195, 0);
            this.principal1.Name = "principal1";
            this.principal1.Size = new System.Drawing.Size(600, 600);
            this.principal1.TabIndex = 1;
            // 
            // T_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.uC_Funcionarios1);
            this.Controls.Add(this.principal1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "T_Menu";
            this.Text = "Book Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.T_Menu_FormClosed);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BT_Caixa;
        private System.Windows.Forms.Button BT_Pedido;
        private System.Windows.Forms.Button BT_Autores;
        private System.Windows.Forms.Button BT_Editoras;
        private System.Windows.Forms.Button BT_Categorias;
        private System.Windows.Forms.Button BT_Livros;
        private System.Windows.Forms.Button BT_Telefone;
        private System.Windows.Forms.Button BT_Clientes;
        private System.Windows.Forms.Button BT_Funcionarios;
        private System.Windows.Forms.Label LB_Nome_Livraria;
        private Principal principal1;
        private UC_Funcionarios uC_Funcionarios1;
        private System.Windows.Forms.Label LB_DataeHora;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button Btn_Sair_Login;
        private System.Windows.Forms.Label LB_Usuario;
        private System.Windows.Forms.Label LB_Usuariotxt;
    }
}