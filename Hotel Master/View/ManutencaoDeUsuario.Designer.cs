namespace Hotel_Master
{
    partial class ManutencaoDeUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManutencaoDeUsuario));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panPesquisa = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.panModifica = new System.Windows.Forms.TableLayoutPanel();
            this.btnNovoUsuario = new System.Windows.Forms.Button();
            this.btnExcluiUsuario = new System.Windows.Forms.Button();
            this.btnEditaUsuario = new System.Windows.Forms.Button();
            this.panDados = new System.Windows.Forms.Panel();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.radLinha = new System.Windows.Forms.RadioButton();
            this.radSupervisor = new System.Windows.Forms.RadioButton();
            this.radAdmin = new System.Windows.Forms.RadioButton();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblPermissao = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.dtgUsuario = new System.Windows.Forms.DataGridView();
            this.lblValidaCpf = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panPesquisa.SuspendLayout();
            this.panModifica.SuspendLayout();
            this.panDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightBlue;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblTitulo, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1148, 137);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(382, 81);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(383, 41);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Manuteção de Usuário";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.3345F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.6655F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtgUsuario, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 137);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1148, 524);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panPesquisa, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblTitulo2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panModifica, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.panDados, 0, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.598455F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.302325F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.51938F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(480, 518);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panPesquisa
            // 
            this.panPesquisa.Controls.Add(this.lblPesquisa);
            this.panPesquisa.Controls.Add(this.txtPesquisa);
            this.panPesquisa.Controls.Add(this.btnPesquisa);
            this.panPesquisa.Location = new System.Drawing.Point(5, 5);
            this.panPesquisa.Name = "panPesquisa";
            this.panPesquisa.Size = new System.Drawing.Size(470, 30);
            this.panPesquisa.TabIndex = 0;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPesquisa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisa.Location = new System.Drawing.Point(3, 0);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(111, 29);
            this.lblPesquisa.TabIndex = 0;
            this.lblPesquisa.Text = "Pesquisar:";
            this.lblPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisa.Location = new System.Drawing.Point(120, 4);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(259, 20);
            this.txtPesquisa.TabIndex = 1;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.Location = new System.Drawing.Point(385, 3);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(77, 23);
            this.btnPesquisa.TabIndex = 2;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.Location = new System.Drawing.Point(193, 43);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(93, 22);
            this.lblTitulo2.TabIndex = 1;
            this.lblTitulo2.Text = "Usuários";
            // 
            // panModifica
            // 
            this.panModifica.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.panModifica.ColumnCount = 3;
            this.panModifica.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panModifica.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panModifica.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panModifica.Controls.Add(this.btnNovoUsuario, 0, 0);
            this.panModifica.Controls.Add(this.btnExcluiUsuario, 2, 0);
            this.panModifica.Controls.Add(this.btnEditaUsuario, 1, 0);
            this.panModifica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panModifica.Location = new System.Drawing.Point(5, 73);
            this.panModifica.Name = "panModifica";
            this.panModifica.RowCount = 1;
            this.panModifica.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panModifica.Size = new System.Drawing.Size(470, 41);
            this.panModifica.TabIndex = 2;
            // 
            // btnNovoUsuario
            // 
            this.btnNovoUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNovoUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoUsuario.Location = new System.Drawing.Point(5, 9);
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.Size = new System.Drawing.Size(148, 23);
            this.btnNovoUsuario.TabIndex = 3;
            this.btnNovoUsuario.Text = "Novo Usuario";
            this.btnNovoUsuario.UseVisualStyleBackColor = true;
            this.btnNovoUsuario.Click += new System.EventHandler(this.btnNovoUsuario_Click);
            // 
            // btnExcluiUsuario
            // 
            this.btnExcluiUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluiUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluiUsuario.Location = new System.Drawing.Point(317, 9);
            this.btnExcluiUsuario.Name = "btnExcluiUsuario";
            this.btnExcluiUsuario.Size = new System.Drawing.Size(148, 23);
            this.btnExcluiUsuario.TabIndex = 5;
            this.btnExcluiUsuario.Text = "Exclui Usuário";
            this.btnExcluiUsuario.UseVisualStyleBackColor = true;
            this.btnExcluiUsuario.Click += new System.EventHandler(this.btnExcluiUsuario_Click);
            // 
            // btnEditaUsuario
            // 
            this.btnEditaUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditaUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditaUsuario.Location = new System.Drawing.Point(161, 9);
            this.btnEditaUsuario.Name = "btnEditaUsuario";
            this.btnEditaUsuario.Size = new System.Drawing.Size(148, 23);
            this.btnEditaUsuario.TabIndex = 4;
            this.btnEditaUsuario.Text = "Edita Usuário";
            this.btnEditaUsuario.UseVisualStyleBackColor = true;
            this.btnEditaUsuario.Click += new System.EventHandler(this.btnEditaUsuario_Click);
            // 
            // panDados
            // 
            this.panDados.Controls.Add(this.lblValidaCpf);
            this.panDados.Controls.Add(this.txtTelefone);
            this.panDados.Controls.Add(this.txtCpf);
            this.panDados.Controls.Add(this.btnConfirma);
            this.panDados.Controls.Add(this.radLinha);
            this.panDados.Controls.Add(this.radSupervisor);
            this.panDados.Controls.Add(this.radAdmin);
            this.panDados.Controls.Add(this.txtSenha);
            this.panDados.Controls.Add(this.txtEmail);
            this.panDados.Controls.Add(this.txtNome);
            this.panDados.Controls.Add(this.txtUsuario);
            this.panDados.Controls.Add(this.txtId);
            this.panDados.Controls.Add(this.lblPermissao);
            this.panDados.Controls.Add(this.lblCpf);
            this.panDados.Controls.Add(this.lblSenha);
            this.panDados.Controls.Add(this.lblEmail);
            this.panDados.Controls.Add(this.lblTelefone);
            this.panDados.Controls.Add(this.lblNome);
            this.panDados.Controls.Add(this.lblUsuario);
            this.panDados.Controls.Add(this.lblId);
            this.panDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panDados.Enabled = false;
            this.panDados.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panDados.Location = new System.Drawing.Point(5, 122);
            this.panDados.Name = "panDados";
            this.panDados.Size = new System.Drawing.Size(470, 391);
            this.panDados.TabIndex = 3;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(74, 154);
            this.txtTelefone.Mask = "(00) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(168, 22);
            this.txtTelefone.TabIndex = 12;
            this.txtTelefone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTelefone_MouseClick);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(74, 117);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(168, 22);
            this.txtCpf.TabIndex = 11;
            this.txtCpf.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCpf_MouseClick);
            this.txtCpf.TextChanged += new System.EventHandler(this.txtCpf_TextChanged);
            // 
            // btnConfirma
            // 
            this.btnConfirma.Location = new System.Drawing.Point(180, 359);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(167, 23);
            this.btnConfirma.TabIndex = 18;
            this.btnConfirma.Text = "Confirma";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // radLinha
            // 
            this.radLinha.AutoSize = true;
            this.radLinha.Location = new System.Drawing.Point(8, 336);
            this.radLinha.Name = "radLinha";
            this.radLinha.Size = new System.Drawing.Size(61, 20);
            this.radLinha.TabIndex = 17;
            this.radLinha.TabStop = true;
            this.radLinha.Text = "Linha";
            this.radLinha.UseVisualStyleBackColor = true;
            // 
            // radSupervisor
            // 
            this.radSupervisor.AutoSize = true;
            this.radSupervisor.Location = new System.Drawing.Point(8, 310);
            this.radSupervisor.Name = "radSupervisor";
            this.radSupervisor.Size = new System.Drawing.Size(93, 20);
            this.radSupervisor.TabIndex = 16;
            this.radSupervisor.TabStop = true;
            this.radSupervisor.Text = "Supervisor";
            this.radSupervisor.UseVisualStyleBackColor = true;
            // 
            // radAdmin
            // 
            this.radAdmin.AutoSize = true;
            this.radAdmin.Location = new System.Drawing.Point(7, 284);
            this.radAdmin.Name = "radAdmin";
            this.radAdmin.Size = new System.Drawing.Size(66, 20);
            this.radAdmin.TabIndex = 15;
            this.radAdmin.TabStop = true;
            this.radAdmin.Text = "Admin";
            this.radAdmin.UseVisualStyleBackColor = true;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(74, 218);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(168, 22);
            this.txtSenha.TabIndex = 14;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(74, 186);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(168, 22);
            this.txtEmail.TabIndex = 13;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(74, 82);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(168, 22);
            this.txtNome.TabIndex = 10;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(74, 47);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(168, 22);
            this.txtUsuario.TabIndex = 9;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(35, 13);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(32, 22);
            this.txtId.TabIndex = 8;
            // 
            // lblPermissao
            // 
            this.lblPermissao.AutoSize = true;
            this.lblPermissao.Location = new System.Drawing.Point(5, 254);
            this.lblPermissao.Name = "lblPermissao";
            this.lblPermissao.Size = new System.Drawing.Size(83, 16);
            this.lblPermissao.TabIndex = 7;
            this.lblPermissao.Text = "Permissões:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(5, 117);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(41, 16);
            this.lblCpf.TabIndex = 6;
            this.lblCpf.Text = "CPF: ";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(4, 218);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(56, 16);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha: ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(5, 186);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 16);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(5, 154);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(70, 16);
            this.lblTelefone.TabIndex = 3;
            this.lblTelefone.Text = "Telefone: ";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(5, 82);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(52, 16);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome: ";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(5, 47);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(63, 16);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario: ";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(5, 16);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 16);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // dtgUsuario
            // 
            this.dtgUsuario.AllowUserToAddRows = false;
            this.dtgUsuario.AllowUserToDeleteRows = false;
            this.dtgUsuario.AllowUserToResizeRows = false;
            this.dtgUsuario.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dtgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgUsuario.Location = new System.Drawing.Point(489, 3);
            this.dtgUsuario.MultiSelect = false;
            this.dtgUsuario.Name = "dtgUsuario";
            this.dtgUsuario.ReadOnly = true;
            this.dtgUsuario.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dtgUsuario.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgUsuario.Size = new System.Drawing.Size(656, 518);
            this.dtgUsuario.TabIndex = 1;
            this.dtgUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsuario_CellClick);
            // 
            // lblValidaCpf
            // 
            this.lblValidaCpf.AutoSize = true;
            this.lblValidaCpf.Location = new System.Drawing.Point(249, 125);
            this.lblValidaCpf.Name = "lblValidaCpf";
            this.lblValidaCpf.Size = new System.Drawing.Size(0, 16);
            this.lblValidaCpf.TabIndex = 21;
            // 
            // ManutencaoDeUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1148, 661);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1164, 700);
            this.MinimumSize = new System.Drawing.Size(1164, 700);
            this.Name = "ManutencaoDeUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ManutencaoDeUsuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManutencaoDeUsuario_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panPesquisa.ResumeLayout(false);
            this.panPesquisa.PerformLayout();
            this.panModifica.ResumeLayout(false);
            this.panDados.ResumeLayout(false);
            this.panDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel panPesquisa;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.TableLayoutPanel panModifica;
        private System.Windows.Forms.Button btnNovoUsuario;
        private System.Windows.Forms.Button btnExcluiUsuario;
        private System.Windows.Forms.Button btnEditaUsuario;
        private System.Windows.Forms.Panel panDados;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPermissao;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.RadioButton radLinha;
        private System.Windows.Forms.RadioButton radSupervisor;
        private System.Windows.Forms.RadioButton radAdmin;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.DataGridView dtgUsuario;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label lblValidaCpf;
    }
}