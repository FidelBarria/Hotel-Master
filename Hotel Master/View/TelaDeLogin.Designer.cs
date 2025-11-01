namespace Hotel_Master
{
    partial class TelaDeLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDeLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFecha = new System.Windows.Forms.Button();
            this.btnCadastraUsuario = new System.Windows.Forms.Button();
            this.panCadastraUsuario = new System.Windows.Forms.TableLayoutPanel();
            this.lblCadastra = new System.Windows.Forms.Label();
            this.lblNovoUsuario = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblSenhaUsuario = new System.Windows.Forms.Label();
            this.btnCadastra = new System.Windows.Forms.Button();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.txtNovoUsuario = new System.Windows.Forms.TextBox();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenhaUsuario = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblValidaCpf = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panCadastraUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.btnFecha);
            this.panel1.Controls.Add(this.btnCadastraUsuario);
            this.panel1.Controls.Add(this.panCadastraUsuario);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.txtSenha);
            this.panel1.Controls.Add(this.lblSenha);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 637);
            this.panel1.TabIndex = 0;
            // 
            // btnFecha
            // 
            this.btnFecha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecha.Location = new System.Drawing.Point(220, 183);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(60, 24);
            this.btnFecha.TabIndex = 6;
            this.btnFecha.Text = "Fecha";
            this.btnFecha.UseVisualStyleBackColor = true;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // btnCadastraUsuario
            // 
            this.btnCadastraUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastraUsuario.Location = new System.Drawing.Point(117, 213);
            this.btnCadastraUsuario.Name = "btnCadastraUsuario";
            this.btnCadastraUsuario.Size = new System.Drawing.Size(132, 23);
            this.btnCadastraUsuario.TabIndex = 7;
            this.btnCadastraUsuario.Text = "Cadastra Usuario";
            this.btnCadastraUsuario.UseVisualStyleBackColor = true;
            this.btnCadastraUsuario.Click += new System.EventHandler(this.btnCadastraUsuario_Click);
            // 
            // panCadastraUsuario
            // 
            this.panCadastraUsuario.ColumnCount = 3;
            this.panCadastraUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.79108F));
            this.panCadastraUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.41783F));
            this.panCadastraUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.79109F));
            this.panCadastraUsuario.Controls.Add(this.txtCpf, 1, 10);
            this.panCadastraUsuario.Controls.Add(this.lblCadastra, 1, 0);
            this.panCadastraUsuario.Controls.Add(this.lblNovoUsuario, 1, 1);
            this.panCadastraUsuario.Controls.Add(this.lblCpf, 1, 9);
            this.panCadastraUsuario.Controls.Add(this.lblSenhaUsuario, 1, 11);
            this.panCadastraUsuario.Controls.Add(this.btnCadastra, 1, 13);
            this.panCadastraUsuario.Controls.Add(this.lblTelefone, 1, 7);
            this.panCadastraUsuario.Controls.Add(this.lblEmail, 1, 5);
            this.panCadastraUsuario.Controls.Add(this.lblNomeUsuario, 1, 3);
            this.panCadastraUsuario.Controls.Add(this.txtNovoUsuario, 1, 2);
            this.panCadastraUsuario.Controls.Add(this.txtNomeUsuario, 1, 4);
            this.panCadastraUsuario.Controls.Add(this.txtEmail, 1, 6);
            this.panCadastraUsuario.Controls.Add(this.txtSenhaUsuario, 1, 12);
            this.panCadastraUsuario.Controls.Add(this.txtTelefone, 1, 8);
            this.panCadastraUsuario.Controls.Add(this.lblValidaCpf, 2, 10);
            this.panCadastraUsuario.Location = new System.Drawing.Point(0, 242);
            this.panCadastraUsuario.Name = "panCadastraUsuario";
            this.panCadastraUsuario.RowCount = 14;
            this.panCadastraUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.389316F));
            this.panCadastraUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.189739F));
            this.panCadastraUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.835443F));
            this.panCadastraUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.822785F));
            this.panCadastraUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.075949F));
            this.panCadastraUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.316456F));
            this.panCadastraUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.835443F));
            this.panCadastraUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.063291F));
            this.panCadastraUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.835443F));
            this.panCadastraUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.316456F));
            this.panCadastraUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.341772F));
            this.panCadastraUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.810127F));
            this.panCadastraUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.848101F));
            this.panCadastraUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.74684F));
            this.panCadastraUsuario.Size = new System.Drawing.Size(360, 395);
            this.panCadastraUsuario.TabIndex = 7;
            this.panCadastraUsuario.Visible = false;
            this.panCadastraUsuario.Paint += new System.Windows.Forms.PaintEventHandler(this.panCadastraUsuario_Paint);
            // 
            // lblCadastra
            // 
            this.lblCadastra.AutoSize = true;
            this.lblCadastra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCadastra.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastra.Location = new System.Drawing.Point(92, 0);
            this.lblCadastra.Name = "lblCadastra";
            this.lblCadastra.Size = new System.Drawing.Size(175, 35);
            this.lblCadastra.TabIndex = 0;
            this.lblCadastra.Text = "Cadastrar Novo Usuario";
            this.lblCadastra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNovoUsuario
            // 
            this.lblNovoUsuario.AutoSize = true;
            this.lblNovoUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNovoUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovoUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblNovoUsuario.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblNovoUsuario.Location = new System.Drawing.Point(92, 42);
            this.lblNovoUsuario.Name = "lblNovoUsuario";
            this.lblNovoUsuario.Size = new System.Drawing.Size(175, 16);
            this.lblNovoUsuario.TabIndex = 1;
            this.lblNovoUsuario.Text = "Novo Usuario: * ";
            this.lblNovoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCpf.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(92, 224);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(175, 16);
            this.lblCpf.TabIndex = 6;
            this.lblCpf.Text = "CPF:";
            this.lblCpf.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblSenhaUsuario
            // 
            this.lblSenhaUsuario.AutoSize = true;
            this.lblSenhaUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSenhaUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaUsuario.Location = new System.Drawing.Point(92, 270);
            this.lblSenhaUsuario.Name = "lblSenhaUsuario";
            this.lblSenhaUsuario.Size = new System.Drawing.Size(175, 16);
            this.lblSenhaUsuario.TabIndex = 9;
            this.lblSenhaUsuario.Text = "Senha:";
            this.lblSenhaUsuario.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnCadastra
            // 
            this.btnCadastra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastra.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastra.Location = new System.Drawing.Point(92, 318);
            this.btnCadastra.Name = "btnCadastra";
            this.btnCadastra.Size = new System.Drawing.Size(175, 23);
            this.btnCadastra.TabIndex = 19;
            this.btnCadastra.Text = "Cadastra";
            this.btnCadastra.UseVisualStyleBackColor = true;
            this.btnCadastra.Click += new System.EventHandler(this.btnCadastra_Click);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTelefone.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(92, 178);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(175, 16);
            this.lblTelefone.TabIndex = 5;
            this.lblTelefone.Text = "Telefone:";
            this.lblTelefone.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(92, 133);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(175, 16);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNomeUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuario.Location = new System.Drawing.Point(92, 90);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(175, 16);
            this.lblNomeUsuario.TabIndex = 12;
            this.lblNomeUsuario.Text = "Nome Usuario";
            // 
            // txtNovoUsuario
            // 
            this.txtNovoUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtNovoUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovoUsuario.Location = new System.Drawing.Point(92, 61);
            this.txtNovoUsuario.Name = "txtNovoUsuario";
            this.txtNovoUsuario.Size = new System.Drawing.Size(175, 22);
            this.txtNovoUsuario.TabIndex = 13;
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtNomeUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUsuario.Location = new System.Drawing.Point(92, 109);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(175, 22);
            this.txtNomeUsuario.TabIndex = 14;
            // 
            // txtEmail
            // 
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(92, 152);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(175, 22);
            this.txtEmail.TabIndex = 15;
            // 
            // txtSenhaUsuario
            // 
            this.txtSenhaUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtSenhaUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaUsuario.Location = new System.Drawing.Point(92, 290);
            this.txtSenhaUsuario.Name = "txtSenhaUsuario";
            this.txtSenhaUsuario.Size = new System.Drawing.Size(175, 22);
            this.txtSenhaUsuario.TabIndex = 18;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(102, 183);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(60, 24);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(102, 157);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(178, 20);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(99, 138);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(52, 16);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(99, 80);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(59, 16);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(157, 49);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(57, 23);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.Location = new System.Drawing.Point(102, 99);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(178, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtCpf
            // 
            this.txtCpf.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.txtCpf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCpf.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCpf.Location = new System.Drawing.Point(92, 243);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(175, 20);
            this.txtCpf.TabIndex = 17;
            this.txtCpf.TextChanged += new System.EventHandler(this.txtCpf_TextChanged);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(92, 197);
            this.txtTelefone.Mask = "(00) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(175, 20);
            this.txtTelefone.TabIndex = 16;
            // 
            // lblValidaCpf
            // 
            this.lblValidaCpf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValidaCpf.AutoSize = true;
            this.lblValidaCpf.Location = new System.Drawing.Point(315, 247);
            this.lblValidaCpf.Name = "lblValidaCpf";
            this.lblValidaCpf.Size = new System.Drawing.Size(0, 13);
            this.lblValidaCpf.TabIndex = 20;
            // 
            // TelaDeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(640, 310);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "TelaDeLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Master";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaDeLogin_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panCadastraUsuario.ResumeLayout(false);
            this.panCadastraUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TableLayoutPanel panCadastraUsuario;
        private System.Windows.Forms.Label lblCadastra;
        private System.Windows.Forms.Label lblNovoUsuario;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblSenhaUsuario;
        private System.Windows.Forms.Button btnCadastra;
        private System.Windows.Forms.Button btnCadastraUsuario;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.TextBox txtNovoUsuario;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenhaUsuario;
        private System.Windows.Forms.Button btnFecha;
        public System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label lblValidaCpf;
    }
}

