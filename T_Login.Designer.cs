
namespace Book_Manager
{
    partial class T_Login
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BT_Logar = new System.Windows.Forms.Button();
            this.BT_Fechar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Senha = new System.Windows.Forms.TextBox();
            this.TB_Login = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BT_Visibilidade = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 550);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(147, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 41);
            this.label3.TabIndex = 5;
            this.label3.Text = "Desenvolvido por: David Lucas";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 89);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bem vindo ao Sistema  Gerenciador de Livros ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Manager";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BT_Visibilidade);
            this.panel2.Controls.Add(this.BT_Logar);
            this.panel2.Controls.Add(this.BT_Fechar);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.TB_Senha);
            this.panel2.Controls.Add(this.TB_Login);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(320, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 550);
            this.panel2.TabIndex = 1;
            // 
            // BT_Logar
            // 
            this.BT_Logar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.BT_Logar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Logar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Logar.ForeColor = System.Drawing.Color.White;
            this.BT_Logar.Location = new System.Drawing.Point(130, 405);
            this.BT_Logar.Name = "BT_Logar";
            this.BT_Logar.Size = new System.Drawing.Size(75, 23);
            this.BT_Logar.TabIndex = 12;
            this.BT_Logar.Text = "Logar";
            this.BT_Logar.UseVisualStyleBackColor = false;
            this.BT_Logar.Click += new System.EventHandler(this.BT_Logar_Click);
            // 
            // BT_Fechar
            // 
            this.BT_Fechar.FlatAppearance.BorderSize = 0;
            this.BT_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Fechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.BT_Fechar.Location = new System.Drawing.Point(352, 3);
            this.BT_Fechar.Name = "BT_Fechar";
            this.BT_Fechar.Size = new System.Drawing.Size(75, 39);
            this.BT_Fechar.TabIndex = 11;
            this.BT_Fechar.Text = "X";
            this.BT_Fechar.UseVisualStyleBackColor = true;
            this.BT_Fechar.Click += new System.EventHandler(this.BT_Fechar_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.label6.Location = new System.Drawing.Point(57, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Senha:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.label5.Location = new System.Drawing.Point(125, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 35);
            this.label5.TabIndex = 9;
            this.label5.Text = "Faça seu login:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TB_Senha
            // 
            this.TB_Senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Senha.Location = new System.Drawing.Point(130, 376);
            this.TB_Senha.MaxLength = 8;
            this.TB_Senha.Name = "TB_Senha";
            this.TB_Senha.Size = new System.Drawing.Size(170, 20);
            this.TB_Senha.TabIndex = 8;
            this.TB_Senha.UseSystemPasswordChar = true;
            // 
            // TB_Login
            // 
            this.TB_Login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Login.Location = new System.Drawing.Point(130, 337);
            this.TB_Login.MaxLength = 20;
            this.TB_Login.Name = "TB_Login";
            this.TB_Login.Size = new System.Drawing.Size(195, 20);
            this.TB_Login.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.label4.Location = new System.Drawing.Point(64, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Login:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BT_Visibilidade
            // 
            this.BT_Visibilidade.BackColor = System.Drawing.Color.White;
            this.BT_Visibilidade.BackgroundImage = global::Book_Manager.Properties.Resources.olho_fechado_removebg_preview;
            this.BT_Visibilidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BT_Visibilidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Visibilidade.Location = new System.Drawing.Point(298, 376);
            this.BT_Visibilidade.Name = "BT_Visibilidade";
            this.BT_Visibilidade.Size = new System.Drawing.Size(27, 20);
            this.BT_Visibilidade.TabIndex = 13;
            this.BT_Visibilidade.UseVisualStyleBackColor = false;
            this.BT_Visibilidade.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BT_Visibilidade_MouseDown);
            this.BT_Visibilidade.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BT_Visibilidade_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Book_Manager.Properties.Resources.padrao_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(130, 124);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(195, 166);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Book_Manager.Properties.Resources.book_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(40, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // T_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "T_Login";
            this.Text = "Book Manager";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_Senha;
        private System.Windows.Forms.TextBox TB_Login;
        private System.Windows.Forms.Button BT_Logar;
        private System.Windows.Forms.Button BT_Fechar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BT_Visibilidade;
    }
}

