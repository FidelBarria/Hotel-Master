namespace Hotel_Master
{
    partial class NovaReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovaReserva));
            this.tpAdicionaHospede = new System.Windows.Forms.ToolTip(this.components);
            this.btnAdicionaHospede = new System.Windows.Forms.Button();
            this.toRemoveHospede = new System.Windows.Forms.ToolTip(this.components);
            this.btnRemoveHospede = new System.Windows.Forms.Button();
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.btnProcuraCliente = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCheckin = new System.Windows.Forms.Label();
            this.dtCheckin = new System.Windows.Forms.DateTimePicker();
            this.lblCheckout = new System.Windows.Forms.Label();
            this.dtCheckout = new System.Windows.Forms.DateTimePicker();
            this.lblQtdDiarias = new System.Windows.Forms.Label();
            this.txtQtdDiarias = new System.Windows.Forms.TextBox();
            this.lblValorDiaria = new System.Windows.Forms.Label();
            this.txtValorDiaria = new System.Windows.Forms.TextBox();
            this.btnProcuraTarifa = new System.Windows.Forms.Button();
            this.lblQtdPessoas = new System.Windows.Forms.Label();
            this.numHospede = new System.Windows.Forms.NumericUpDown();
            this.lblGarantia = new System.Windows.Forms.Label();
            this.radSim = new System.Windows.Forms.RadioButton();
            this.radNao = new System.Windows.Forms.RadioButton();
            this.lblCategoriaUh = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lblUh = new System.Windows.Forms.Label();
            this.txtUh = new System.Windows.Forms.TextBox();
            this.btnPesquisaUh = new System.Windows.Forms.Button();
            this.panAdicionaHospede = new System.Windows.Forms.Panel();
            this.grpAdicionaHospede = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtIdHospede = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.lnlHospede = new System.Windows.Forms.Label();
            this.txtHospede = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.btnSalvaHospede = new System.Windows.Forms.Button();
            this.dtgHospede = new System.Windows.Forms.DataGridView();
            this.grpObservacao = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnObservacao = new System.Windows.Forms.Button();
            this.txtObservacao = new System.Windows.Forms.RichTextBox();
            this.lblReserva = new System.Windows.Forms.Label();
            this.btnConfirmaReserva = new System.Windows.Forms.Button();
            this.panPrincipal = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIdReserva = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpResumoValorDiaria = new System.Windows.Forms.GroupBox();
            this.dtgDiaria = new System.Windows.Forms.DataGridView();
            this.grpCliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHospede)).BeginInit();
            this.panAdicionaHospede.SuspendLayout();
            this.grpAdicionaHospede.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHospede)).BeginInit();
            this.grpObservacao.SuspendLayout();
            this.panPrincipal.SuspendLayout();
            this.grpResumoValorDiaria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDiaria)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionaHospede
            // 
            this.btnAdicionaHospede.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdicionaHospede.BackColor = System.Drawing.Color.Blue;
            this.btnAdicionaHospede.BackgroundImage = global::Hotel_Master.Properties.Resources.mais__1_;
            this.btnAdicionaHospede.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdicionaHospede.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionaHospede.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAdicionaHospede.Location = new System.Drawing.Point(1297, 4);
            this.btnAdicionaHospede.Name = "btnAdicionaHospede";
            this.btnAdicionaHospede.Size = new System.Drawing.Size(30, 24);
            this.btnAdicionaHospede.TabIndex = 12;
            this.btnAdicionaHospede.Text = "1";
            this.btnAdicionaHospede.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tpAdicionaHospede.SetToolTip(this.btnAdicionaHospede, "Adicionar Hospede");
            this.btnAdicionaHospede.UseVisualStyleBackColor = false;
            this.btnAdicionaHospede.Click += new System.EventHandler(this.btnAdicionaHospede_Click);
            // 
            // btnRemoveHospede
            // 
            this.btnRemoveHospede.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveHospede.BackColor = System.Drawing.Color.Red;
            this.btnRemoveHospede.BackgroundImage = global::Hotel_Master.Properties.Resources.menos;
            this.btnRemoveHospede.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemoveHospede.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveHospede.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRemoveHospede.Location = new System.Drawing.Point(1333, 4);
            this.btnRemoveHospede.Name = "btnRemoveHospede";
            this.btnRemoveHospede.Size = new System.Drawing.Size(30, 24);
            this.btnRemoveHospede.TabIndex = 13;
            this.btnRemoveHospede.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toRemoveHospede.SetToolTip(this.btnRemoveHospede, "Remove Hospede");
            this.btnRemoveHospede.UseVisualStyleBackColor = false;
            this.btnRemoveHospede.Click += new System.EventHandler(this.button2_Click);
            // 
            // grpCliente
            // 
            this.grpCliente.Controls.Add(this.txtIdCliente);
            this.grpCliente.Controls.Add(this.btnProcuraCliente);
            this.grpCliente.Controls.Add(this.txtCliente);
            this.grpCliente.Controls.Add(this.lblCliente);
            this.grpCliente.Location = new System.Drawing.Point(12, 3);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Size = new System.Drawing.Size(284, 50);
            this.grpCliente.TabIndex = 0;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "Clientes";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(18, 17);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(32, 22);
            this.txtIdCliente.TabIndex = 3;
            // 
            // btnProcuraCliente
            // 
            this.btnProcuraCliente.BackgroundImage = global::Hotel_Master.Properties.Resources.lupa__1_;
            this.btnProcuraCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProcuraCliente.Location = new System.Drawing.Point(247, 15);
            this.btnProcuraCliente.Name = "btnProcuraCliente";
            this.btnProcuraCliente.Size = new System.Drawing.Size(31, 26);
            this.btnProcuraCliente.TabIndex = 2;
            this.btnProcuraCliente.UseVisualStyleBackColor = true;
            this.btnProcuraCliente.Click += new System.EventHandler(this.btnProcuraCliente_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(122, 17);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(119, 22);
            this.txtCliente.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(56, 20);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(60, 16);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1405, 376);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info. Hospedagem";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblCheckin);
            this.flowLayoutPanel1.Controls.Add(this.dtCheckin);
            this.flowLayoutPanel1.Controls.Add(this.lblCheckout);
            this.flowLayoutPanel1.Controls.Add(this.dtCheckout);
            this.flowLayoutPanel1.Controls.Add(this.lblQtdDiarias);
            this.flowLayoutPanel1.Controls.Add(this.txtQtdDiarias);
            this.flowLayoutPanel1.Controls.Add(this.lblValorDiaria);
            this.flowLayoutPanel1.Controls.Add(this.txtValorDiaria);
            this.flowLayoutPanel1.Controls.Add(this.btnProcuraTarifa);
            this.flowLayoutPanel1.Controls.Add(this.lblQtdPessoas);
            this.flowLayoutPanel1.Controls.Add(this.numHospede);
            this.flowLayoutPanel1.Controls.Add(this.lblGarantia);
            this.flowLayoutPanel1.Controls.Add(this.radSim);
            this.flowLayoutPanel1.Controls.Add(this.radNao);
            this.flowLayoutPanel1.Controls.Add(this.lblCategoriaUh);
            this.flowLayoutPanel1.Controls.Add(this.cbCategoria);
            this.flowLayoutPanel1.Controls.Add(this.lblUh);
            this.flowLayoutPanel1.Controls.Add(this.txtUh);
            this.flowLayoutPanel1.Controls.Add(this.btnPesquisaUh);
            this.flowLayoutPanel1.Controls.Add(this.btnAdicionaHospede);
            this.flowLayoutPanel1.Controls.Add(this.btnRemoveHospede);
            this.flowLayoutPanel1.Controls.Add(this.panAdicionaHospede);
            this.flowLayoutPanel1.Controls.Add(this.dtgHospede);
            this.flowLayoutPanel1.Controls.Add(this.grpObservacao);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1399, 355);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblCheckin
            // 
            this.lblCheckin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCheckin.AutoSize = true;
            this.lblCheckin.Location = new System.Drawing.Point(3, 8);
            this.lblCheckin.Name = "lblCheckin";
            this.lblCheckin.Size = new System.Drawing.Size(62, 16);
            this.lblCheckin.TabIndex = 1;
            this.lblCheckin.Text = "Checkin:";
            // 
            // dtCheckin
            // 
            this.dtCheckin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtCheckin.CustomFormat = "dd/MM/yyyy";
            this.dtCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCheckin.Location = new System.Drawing.Point(71, 5);
            this.dtCheckin.Name = "dtCheckin";
            this.dtCheckin.Size = new System.Drawing.Size(105, 22);
            this.dtCheckin.TabIndex = 2;
            // 
            // lblCheckout
            // 
            this.lblCheckout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCheckout.AutoSize = true;
            this.lblCheckout.Location = new System.Drawing.Point(182, 8);
            this.lblCheckout.Name = "lblCheckout";
            this.lblCheckout.Size = new System.Drawing.Size(66, 16);
            this.lblCheckout.TabIndex = 3;
            this.lblCheckout.Text = "Checkout";
            // 
            // dtCheckout
            // 
            this.dtCheckout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtCheckout.CustomFormat = "dd/MM/yyyy";
            this.dtCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCheckout.Location = new System.Drawing.Point(254, 5);
            this.dtCheckout.Name = "dtCheckout";
            this.dtCheckout.Size = new System.Drawing.Size(104, 22);
            this.dtCheckout.TabIndex = 4;
            this.dtCheckout.ValueChanged += new System.EventHandler(this.dtCheckout_ValueChanged);
            // 
            // lblQtdDiarias
            // 
            this.lblQtdDiarias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQtdDiarias.AutoSize = true;
            this.lblQtdDiarias.Location = new System.Drawing.Point(364, 8);
            this.lblQtdDiarias.Name = "lblQtdDiarias";
            this.lblQtdDiarias.Size = new System.Drawing.Size(85, 16);
            this.lblQtdDiarias.TabIndex = 19;
            this.lblQtdDiarias.Text = "Qtd. Diarias:";
            // 
            // txtQtdDiarias
            // 
            this.txtQtdDiarias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQtdDiarias.Enabled = false;
            this.txtQtdDiarias.Location = new System.Drawing.Point(455, 5);
            this.txtQtdDiarias.Name = "txtQtdDiarias";
            this.txtQtdDiarias.Size = new System.Drawing.Size(22, 22);
            this.txtQtdDiarias.TabIndex = 20;
            this.txtQtdDiarias.Text = "0";
            // 
            // lblValorDiaria
            // 
            this.lblValorDiaria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValorDiaria.AutoSize = true;
            this.lblValorDiaria.Location = new System.Drawing.Point(483, 8);
            this.lblValorDiaria.Name = "lblValorDiaria";
            this.lblValorDiaria.Size = new System.Drawing.Size(86, 16);
            this.lblValorDiaria.TabIndex = 21;
            this.lblValorDiaria.Text = "Valor Diaria:";
            // 
            // txtValorDiaria
            // 
            this.txtValorDiaria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValorDiaria.Location = new System.Drawing.Point(575, 5);
            this.txtValorDiaria.Name = "txtValorDiaria";
            this.txtValorDiaria.Size = new System.Drawing.Size(47, 22);
            this.txtValorDiaria.TabIndex = 22;
            this.txtValorDiaria.Text = "0";
            this.txtValorDiaria.TextChanged += new System.EventHandler(this.txtValorDiaria_TextChanged);
            // 
            // btnProcuraTarifa
            // 
            this.btnProcuraTarifa.BackgroundImage = global::Hotel_Master.Properties.Resources.lupa__1_;
            this.btnProcuraTarifa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProcuraTarifa.Location = new System.Drawing.Point(628, 3);
            this.btnProcuraTarifa.Name = "btnProcuraTarifa";
            this.btnProcuraTarifa.Size = new System.Drawing.Size(31, 26);
            this.btnProcuraTarifa.TabIndex = 26;
            this.btnProcuraTarifa.UseVisualStyleBackColor = true;
            this.btnProcuraTarifa.Click += new System.EventHandler(this.btnProcuraTarifa_Click);
            // 
            // lblQtdPessoas
            // 
            this.lblQtdPessoas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQtdPessoas.AutoSize = true;
            this.lblQtdPessoas.Location = new System.Drawing.Point(665, 8);
            this.lblQtdPessoas.Name = "lblQtdPessoas";
            this.lblQtdPessoas.Size = new System.Drawing.Size(98, 16);
            this.lblQtdPessoas.TabIndex = 10;
            this.lblQtdPessoas.Text = "Qtd. Hospedes";
            // 
            // numHospede
            // 
            this.numHospede.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numHospede.Location = new System.Drawing.Point(769, 5);
            this.numHospede.Name = "numHospede";
            this.numHospede.Size = new System.Drawing.Size(52, 22);
            this.numHospede.TabIndex = 11;
            // 
            // lblGarantia
            // 
            this.lblGarantia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGarantia.AutoSize = true;
            this.lblGarantia.Location = new System.Drawing.Point(827, 8);
            this.lblGarantia.Name = "lblGarantia";
            this.lblGarantia.Size = new System.Drawing.Size(66, 16);
            this.lblGarantia.TabIndex = 23;
            this.lblGarantia.Text = "Garantia:";
            // 
            // radSim
            // 
            this.radSim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radSim.AutoSize = true;
            this.radSim.Location = new System.Drawing.Point(899, 6);
            this.radSim.Name = "radSim";
            this.radSim.Size = new System.Drawing.Size(50, 20);
            this.radSim.TabIndex = 24;
            this.radSim.TabStop = true;
            this.radSim.Text = "Sim";
            this.radSim.UseVisualStyleBackColor = true;
            // 
            // radNao
            // 
            this.radNao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radNao.AutoSize = true;
            this.radNao.Location = new System.Drawing.Point(955, 6);
            this.radNao.Name = "radNao";
            this.radNao.Size = new System.Drawing.Size(50, 20);
            this.radNao.TabIndex = 25;
            this.radNao.TabStop = true;
            this.radNao.Text = "Não";
            this.radNao.UseVisualStyleBackColor = true;
            // 
            // lblCategoriaUh
            // 
            this.lblCategoriaUh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCategoriaUh.AutoSize = true;
            this.lblCategoriaUh.Location = new System.Drawing.Point(1011, 8);
            this.lblCategoriaUh.Name = "lblCategoriaUh";
            this.lblCategoriaUh.Size = new System.Drawing.Size(77, 16);
            this.lblCategoriaUh.TabIndex = 5;
            this.lblCategoriaUh.Text = "Categoria: ";
            // 
            // cbCategoria
            // 
            this.cbCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "",
            "SUKN",
            "SUTN",
            "DXKN",
            "DXTN"});
            this.cbCategoria.Location = new System.Drawing.Point(1094, 5);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(66, 24);
            this.cbCategoria.TabIndex = 6;
            // 
            // lblUh
            // 
            this.lblUh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUh.AutoSize = true;
            this.lblUh.Location = new System.Drawing.Point(1166, 8);
            this.lblUh.Name = "lblUh";
            this.lblUh.Size = new System.Drawing.Size(29, 16);
            this.lblUh.TabIndex = 7;
            this.lblUh.Text = "UH:";
            // 
            // txtUh
            // 
            this.txtUh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUh.Location = new System.Drawing.Point(1201, 5);
            this.txtUh.Name = "txtUh";
            this.txtUh.Size = new System.Drawing.Size(46, 22);
            this.txtUh.TabIndex = 8;
            // 
            // btnPesquisaUh
            // 
            this.btnPesquisaUh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisaUh.BackgroundImage = global::Hotel_Master.Properties.Resources.lupa__1_;
            this.btnPesquisaUh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisaUh.Location = new System.Drawing.Point(1253, 4);
            this.btnPesquisaUh.Name = "btnPesquisaUh";
            this.btnPesquisaUh.Size = new System.Drawing.Size(38, 24);
            this.btnPesquisaUh.TabIndex = 9;
            this.btnPesquisaUh.UseVisualStyleBackColor = true;
            // 
            // panAdicionaHospede
            // 
            this.panAdicionaHospede.Controls.Add(this.grpAdicionaHospede);
            this.panAdicionaHospede.Location = new System.Drawing.Point(3, 35);
            this.panAdicionaHospede.Name = "panAdicionaHospede";
            this.panAdicionaHospede.Size = new System.Drawing.Size(1080, 70);
            this.panAdicionaHospede.TabIndex = 15;
            // 
            // grpAdicionaHospede
            // 
            this.grpAdicionaHospede.Controls.Add(this.flowLayoutPanel2);
            this.grpAdicionaHospede.Location = new System.Drawing.Point(0, 0);
            this.grpAdicionaHospede.Name = "grpAdicionaHospede";
            this.grpAdicionaHospede.Size = new System.Drawing.Size(1077, 62);
            this.grpAdicionaHospede.TabIndex = 0;
            this.grpAdicionaHospede.TabStop = false;
            this.grpAdicionaHospede.Text = "Info Hospede";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.txtIdHospede);
            this.flowLayoutPanel2.Controls.Add(this.lblCpf);
            this.flowLayoutPanel2.Controls.Add(this.txtCpf);
            this.flowLayoutPanel2.Controls.Add(this.lnlHospede);
            this.flowLayoutPanel2.Controls.Add(this.txtHospede);
            this.flowLayoutPanel2.Controls.Add(this.lblEmail);
            this.flowLayoutPanel2.Controls.Add(this.txtEmail);
            this.flowLayoutPanel2.Controls.Add(this.lblTelefone);
            this.flowLayoutPanel2.Controls.Add(this.txtTelefone);
            this.flowLayoutPanel2.Controls.Add(this.btnSalvaHospede);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 21);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1065, 35);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // txtIdHospede
            // 
            this.txtIdHospede.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdHospede.Enabled = false;
            this.txtIdHospede.Location = new System.Drawing.Point(3, 3);
            this.txtIdHospede.Name = "txtIdHospede";
            this.txtIdHospede.Size = new System.Drawing.Size(27, 22);
            this.txtIdHospede.TabIndex = 11;
            // 
            // lblCpf
            // 
            this.lblCpf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(36, 6);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(37, 16);
            this.lblCpf.TabIndex = 0;
            this.lblCpf.Text = "CPF:";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(79, 3);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(100, 22);
            this.txtCpf.TabIndex = 12;
            this.txtCpf.Click += new System.EventHandler(this.txtCpf_Click);
            this.txtCpf.Leave += new System.EventHandler(this.txtCpf_Leave_1);
            // 
            // lnlHospede
            // 
            this.lnlHospede.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnlHospede.AutoSize = true;
            this.lnlHospede.Location = new System.Drawing.Point(185, 6);
            this.lnlHospede.Name = "lnlHospede";
            this.lnlHospede.Size = new System.Drawing.Size(66, 16);
            this.lnlHospede.TabIndex = 2;
            this.lnlHospede.Text = "Hospede:";
            // 
            // txtHospede
            // 
            this.txtHospede.Location = new System.Drawing.Point(257, 3);
            this.txtHospede.Name = "txtHospede";
            this.txtHospede.Size = new System.Drawing.Size(210, 22);
            this.txtHospede.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(473, 6);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 16);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(526, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(267, 22);
            this.txtEmail.TabIndex = 7;
            // 
            // lblTelefone
            // 
            this.lblTelefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(799, 6);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(66, 16);
            this.lblTelefone.TabIndex = 8;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(871, 3);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 22);
            this.txtTelefone.TabIndex = 9;
            // 
            // btnSalvaHospede
            // 
            this.btnSalvaHospede.Location = new System.Drawing.Point(977, 3);
            this.btnSalvaHospede.Name = "btnSalvaHospede";
            this.btnSalvaHospede.Size = new System.Drawing.Size(56, 22);
            this.btnSalvaHospede.TabIndex = 10;
            this.btnSalvaHospede.Text = "Salvar";
            this.btnSalvaHospede.UseVisualStyleBackColor = true;
            this.btnSalvaHospede.Click += new System.EventHandler(this.btnSalvaHospede_Click);
            // 
            // dtgHospede
            // 
            this.dtgHospede.AllowUserToDeleteRows = false;
            this.dtgHospede.AllowUserToResizeRows = false;
            this.dtgHospede.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHospede.Location = new System.Drawing.Point(3, 111);
            this.dtgHospede.MultiSelect = false;
            this.dtgHospede.Name = "dtgHospede";
            this.dtgHospede.RowHeadersVisible = false;
            this.dtgHospede.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgHospede.Size = new System.Drawing.Size(1080, 100);
            this.dtgHospede.TabIndex = 14;
            // 
            // grpObservacao
            // 
            this.grpObservacao.Controls.Add(this.btnSalvar);
            this.grpObservacao.Controls.Add(this.btnObservacao);
            this.grpObservacao.Controls.Add(this.txtObservacao);
            this.grpObservacao.Location = new System.Drawing.Point(3, 217);
            this.grpObservacao.Name = "grpObservacao";
            this.grpObservacao.Size = new System.Drawing.Size(1008, 137);
            this.grpObservacao.TabIndex = 18;
            this.grpObservacao.TabStop = false;
            this.grpObservacao.Text = "Observação";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(548, 50);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(97, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnObservacao
            // 
            this.btnObservacao.Location = new System.Drawing.Point(548, 21);
            this.btnObservacao.Name = "btnObservacao";
            this.btnObservacao.Size = new System.Drawing.Size(97, 23);
            this.btnObservacao.TabIndex = 1;
            this.btnObservacao.Text = "Observação";
            this.btnObservacao.UseVisualStyleBackColor = true;
            this.btnObservacao.Click += new System.EventHandler(this.btnObservacao_Click);
            // 
            // txtObservacao
            // 
            this.txtObservacao.Enabled = false;
            this.txtObservacao.Location = new System.Drawing.Point(12, 21);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(530, 110);
            this.txtObservacao.TabIndex = 0;
            this.txtObservacao.Text = "";
            // 
            // lblReserva
            // 
            this.lblReserva.AutoSize = true;
            this.lblReserva.Location = new System.Drawing.Point(21, 445);
            this.lblReserva.Name = "lblReserva";
            this.lblReserva.Size = new System.Drawing.Size(66, 16);
            this.lblReserva.TabIndex = 2;
            this.lblReserva.Text = "Reserva: ";
            // 
            // btnConfirmaReserva
            // 
            this.btnConfirmaReserva.Location = new System.Drawing.Point(1179, 461);
            this.btnConfirmaReserva.Name = "btnConfirmaReserva";
            this.btnConfirmaReserva.Size = new System.Drawing.Size(139, 27);
            this.btnConfirmaReserva.TabIndex = 3;
            this.btnConfirmaReserva.Text = "Confirma Reserva";
            this.btnConfirmaReserva.UseVisualStyleBackColor = true;
            this.btnConfirmaReserva.Click += new System.EventHandler(this.btnConfirmaReserva_Click);
            // 
            // panPrincipal
            // 
            this.panPrincipal.Controls.Add(this.label2);
            this.panPrincipal.Controls.Add(this.lblIdReserva);
            this.panPrincipal.Controls.Add(this.label1);
            this.panPrincipal.Controls.Add(this.grpResumoValorDiaria);
            this.panPrincipal.Controls.Add(this.btnConfirmaReserva);
            this.panPrincipal.Controls.Add(this.lblReserva);
            this.panPrincipal.Controls.Add(this.groupBox1);
            this.panPrincipal.Controls.Add(this.grpCliente);
            this.panPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panPrincipal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panPrincipal.Name = "panPrincipal";
            this.panPrincipal.Size = new System.Drawing.Size(1904, 1041);
            this.panPrincipal.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // lblIdReserva
            // 
            this.lblIdReserva.AutoSize = true;
            this.lblIdReserva.Location = new System.Drawing.Point(82, 445);
            this.lblIdReserva.Name = "lblIdReserva";
            this.lblIdReserva.Size = new System.Drawing.Size(11, 16);
            this.lblIdReserva.TabIndex = 5;
            this.lblIdReserva.Text = "-";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // grpResumoValorDiaria
            // 
            this.grpResumoValorDiaria.Controls.Add(this.dtgDiaria);
            this.grpResumoValorDiaria.Location = new System.Drawing.Point(1420, 3);
            this.grpResumoValorDiaria.Name = "grpResumoValorDiaria";
            this.grpResumoValorDiaria.Size = new System.Drawing.Size(481, 435);
            this.grpResumoValorDiaria.TabIndex = 4;
            this.grpResumoValorDiaria.TabStop = false;
            this.grpResumoValorDiaria.Text = "Resumo Valor Diária";
            // 
            // dtgDiaria
            // 
            this.dtgDiaria.AllowUserToAddRows = false;
            this.dtgDiaria.AllowUserToDeleteRows = false;
            this.dtgDiaria.AllowUserToOrderColumns = true;
            this.dtgDiaria.AllowUserToResizeRows = false;
            this.dtgDiaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDiaria.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgDiaria.Location = new System.Drawing.Point(3, 18);
            this.dtgDiaria.MultiSelect = false;
            this.dtgDiaria.Name = "dtgDiaria";
            this.dtgDiaria.RowHeadersVisible = false;
            this.dtgDiaria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDiaria.Size = new System.Drawing.Size(475, 411);
            this.dtgDiaria.TabIndex = 0;
            // 
            // NovaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NovaReserva";
            this.Text = "Nova Reserva";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NovaReserva_Load);
            this.grpCliente.ResumeLayout(false);
            this.grpCliente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHospede)).EndInit();
            this.panAdicionaHospede.ResumeLayout(false);
            this.grpAdicionaHospede.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHospede)).EndInit();
            this.grpObservacao.ResumeLayout(false);
            this.panPrincipal.ResumeLayout(false);
            this.panPrincipal.PerformLayout();
            this.grpResumoValorDiaria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDiaria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip tpAdicionaHospede;
        private System.Windows.Forms.ToolTip toRemoveHospede;
        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.Button btnProcuraCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblCheckin;
        private System.Windows.Forms.DateTimePicker dtCheckin;
        private System.Windows.Forms.Label lblCheckout;
        private System.Windows.Forms.DateTimePicker dtCheckout;
        private System.Windows.Forms.Label lblQtdPessoas;
        private System.Windows.Forms.NumericUpDown numHospede;
        private System.Windows.Forms.Label lblCategoriaUh;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label lblUh;
        private System.Windows.Forms.TextBox txtUh;
        private System.Windows.Forms.Button btnPesquisaUh;
        private System.Windows.Forms.Button btnRemoveHospede;
        private System.Windows.Forms.Panel panAdicionaHospede;
        private System.Windows.Forms.GroupBox grpAdicionaHospede;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lnlHospede;
        private System.Windows.Forms.TextBox txtHospede;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Button btnSalvaHospede;
        private System.Windows.Forms.DataGridView dtgHospede;
        private System.Windows.Forms.GroupBox grpObservacao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnObservacao;
        private System.Windows.Forms.RichTextBox txtObservacao;
        private System.Windows.Forms.Label lblReserva;
        private System.Windows.Forms.Button btnConfirmaReserva;
        private System.Windows.Forms.Panel panPrincipal;
        private System.Windows.Forms.GroupBox grpResumoValorDiaria;
        private System.Windows.Forms.DataGridView dtgDiaria;
        private System.Windows.Forms.Label lblQtdDiarias;
        private System.Windows.Forms.TextBox txtQtdDiarias;
        private System.Windows.Forms.Label lblValorDiaria;
        private System.Windows.Forms.TextBox txtIdHospede;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label lblGarantia;
        private System.Windows.Forms.RadioButton radSim;
        private System.Windows.Forms.RadioButton radNao;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Button btnProcuraTarifa;
        private System.Windows.Forms.Button btnAdicionaHospede;
        private System.Windows.Forms.TextBox txtValorDiaria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIdReserva;
        private System.Windows.Forms.Label label2;
    }
}