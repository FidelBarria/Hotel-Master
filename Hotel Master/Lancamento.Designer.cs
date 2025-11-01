namespace Hotel_Master
{
    partial class Lancamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lancamento));
            this.panPrincipal = new System.Windows.Forms.Panel();
            this.tabLancamento = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblJanela = new System.Windows.Forms.Label();
            this.cbJanela = new System.Windows.Forms.ComboBox();
            this.txtIdHospede = new System.Windows.Forms.TextBox();
            this.txtReserva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReserva = new System.Windows.Forms.Label();
            this.btnSalvarDiaria = new System.Windows.Forms.Button();
            this.txtValorDiaria = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDifDiaria = new System.Windows.Forms.Button();
            this.btnDiaria = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnLancarAeB = new System.Windows.Forms.Button();
            this.gpbAEB = new System.Windows.Forms.GroupBox();
            this.btnFrigobar = new System.Windows.Forms.Button();
            this.btnRestaurante = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblDescricaoDiaria = new System.Windows.Forms.Label();
            this.txtDescricaoDiaria = new System.Windows.Forms.TextBox();
            this.lblJanelaAeB = new System.Windows.Forms.Label();
            this.cbJanelaAeB = new System.Windows.Forms.ComboBox();
            this.txtDescAeB = new System.Windows.Forms.TextBox();
            this.lblDescAeB = new System.Windows.Forms.Label();
            this.lblValorAeB = new System.Windows.Forms.Label();
            this.txtValorAeB = new System.Windows.Forms.TextBox();
            this.panPrincipal.SuspendLayout();
            this.tabLancamento.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.gpbAEB.SuspendLayout();
            this.SuspendLayout();
            // 
            // panPrincipal
            // 
            this.panPrincipal.Controls.Add(this.tabLancamento);
            this.panPrincipal.Controls.Add(this.lblReserva);
            this.panPrincipal.Controls.Add(this.txtIdHospede);
            this.panPrincipal.Controls.Add(this.txtReserva);
            this.panPrincipal.Controls.Add(this.label1);
            this.panPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panPrincipal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panPrincipal.Name = "panPrincipal";
            this.panPrincipal.Size = new System.Drawing.Size(545, 224);
            this.panPrincipal.TabIndex = 0;
            // 
            // tabLancamento
            // 
            this.tabLancamento.Controls.Add(this.tabPage1);
            this.tabLancamento.Controls.Add(this.tabPage3);
            this.tabLancamento.Controls.Add(this.tabPage2);
            this.tabLancamento.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabLancamento.Location = new System.Drawing.Point(0, 31);
            this.tabLancamento.Name = "tabLancamento";
            this.tabLancamento.SelectedIndex = 0;
            this.tabLancamento.Size = new System.Drawing.Size(545, 193);
            this.tabLancamento.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage1.Controls.Add(this.txtDescricaoDiaria);
            this.tabPage1.Controls.Add(this.lblDescricaoDiaria);
            this.tabPage1.Controls.Add(this.lblValor);
            this.tabPage1.Controls.Add(this.lblJanela);
            this.tabPage1.Controls.Add(this.cbJanela);
            this.tabPage1.Controls.Add(this.btnSalvarDiaria);
            this.tabPage1.Controls.Add(this.txtValorDiaria);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(537, 164);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Diaria";
            // 
            // lblJanela
            // 
            this.lblJanela.AutoSize = true;
            this.lblJanela.Location = new System.Drawing.Point(387, 6);
            this.lblJanela.Name = "lblJanela";
            this.lblJanela.Size = new System.Drawing.Size(58, 16);
            this.lblJanela.TabIndex = 11;
            this.lblJanela.Text = "Janela: ";
            // 
            // cbJanela
            // 
            this.cbJanela.FormattingEnabled = true;
            this.cbJanela.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbJanela.Location = new System.Drawing.Point(451, 3);
            this.cbJanela.Name = "cbJanela";
            this.cbJanela.Size = new System.Drawing.Size(53, 24);
            this.cbJanela.TabIndex = 10;
            // 
            // txtIdHospede
            // 
            this.txtIdHospede.Location = new System.Drawing.Point(220, 6);
            this.txtIdHospede.Name = "txtIdHospede";
            this.txtIdHospede.ReadOnly = true;
            this.txtIdHospede.Size = new System.Drawing.Size(53, 22);
            this.txtIdHospede.TabIndex = 9;
            // 
            // txtReserva
            // 
            this.txtReserva.Location = new System.Drawing.Point(79, 6);
            this.txtReserva.Name = "txtReserva";
            this.txtReserva.ReadOnly = true;
            this.txtReserva.Size = new System.Drawing.Size(53, 22);
            this.txtReserva.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hospede: ";
            // 
            // lblReserva
            // 
            this.lblReserva.AutoSize = true;
            this.lblReserva.Location = new System.Drawing.Point(7, 9);
            this.lblReserva.Name = "lblReserva";
            this.lblReserva.Size = new System.Drawing.Size(66, 16);
            this.lblReserva.TabIndex = 5;
            this.lblReserva.Text = "Reserva: ";
            // 
            // btnSalvarDiaria
            // 
            this.btnSalvarDiaria.Location = new System.Drawing.Point(415, 114);
            this.btnSalvarDiaria.Name = "btnSalvarDiaria";
            this.btnSalvarDiaria.Size = new System.Drawing.Size(75, 30);
            this.btnSalvarDiaria.TabIndex = 3;
            this.btnSalvarDiaria.Text = "Lançar";
            this.btnSalvarDiaria.UseVisualStyleBackColor = true;
            this.btnSalvarDiaria.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtValorDiaria
            // 
            this.txtValorDiaria.Location = new System.Drawing.Point(415, 77);
            this.txtValorDiaria.Name = "txtValorDiaria";
            this.txtValorDiaria.Size = new System.Drawing.Size(98, 22);
            this.txtValorDiaria.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDifDiaria);
            this.groupBox1.Controls.Add(this.btnDiaria);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diárias";
            // 
            // btnDifDiaria
            // 
            this.btnDifDiaria.Location = new System.Drawing.Point(108, 21);
            this.btnDifDiaria.Name = "btnDifDiaria";
            this.btnDifDiaria.Size = new System.Drawing.Size(96, 33);
            this.btnDifDiaria.TabIndex = 1;
            this.btnDifDiaria.Text = "Dif. Diária";
            this.btnDifDiaria.UseVisualStyleBackColor = true;
            this.btnDifDiaria.Click += new System.EventHandler(this.btnDifDiaria_Click);
            // 
            // btnDiaria
            // 
            this.btnDiaria.Location = new System.Drawing.Point(6, 21);
            this.btnDiaria.Name = "btnDiaria";
            this.btnDiaria.Size = new System.Drawing.Size(96, 33);
            this.btnDiaria.TabIndex = 0;
            this.btnDiaria.Text = "Diária";
            this.btnDiaria.UseVisualStyleBackColor = true;
            this.btnDiaria.Click += new System.EventHandler(this.btnDiaria_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(537, 192);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pagamento";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage3.Controls.Add(this.txtDescAeB);
            this.tabPage3.Controls.Add(this.lblDescAeB);
            this.tabPage3.Controls.Add(this.lblValorAeB);
            this.tabPage3.Controls.Add(this.txtValorAeB);
            this.tabPage3.Controls.Add(this.lblJanelaAeB);
            this.tabPage3.Controls.Add(this.cbJanelaAeB);
            this.tabPage3.Controls.Add(this.btnLancarAeB);
            this.tabPage3.Controls.Add(this.gpbAEB);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(537, 164);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "A&B";
            // 
            // btnLancarAeB
            // 
            this.btnLancarAeB.Location = new System.Drawing.Point(420, 109);
            this.btnLancarAeB.Name = "btnLancarAeB";
            this.btnLancarAeB.Size = new System.Drawing.Size(75, 30);
            this.btnLancarAeB.TabIndex = 14;
            this.btnLancarAeB.Text = "Lançar";
            this.btnLancarAeB.UseVisualStyleBackColor = true;
            this.btnLancarAeB.Click += new System.EventHandler(this.btnLancarAeB_Click);
            // 
            // gpbAEB
            // 
            this.gpbAEB.Controls.Add(this.btnFrigobar);
            this.gpbAEB.Controls.Add(this.btnRestaurante);
            this.gpbAEB.Location = new System.Drawing.Point(15, 14);
            this.gpbAEB.Name = "gpbAEB";
            this.gpbAEB.Size = new System.Drawing.Size(358, 142);
            this.gpbAEB.TabIndex = 12;
            this.gpbAEB.TabStop = false;
            this.gpbAEB.Text = "AeB";
            // 
            // btnFrigobar
            // 
            this.btnFrigobar.Location = new System.Drawing.Point(108, 21);
            this.btnFrigobar.Name = "btnFrigobar";
            this.btnFrigobar.Size = new System.Drawing.Size(96, 33);
            this.btnFrigobar.TabIndex = 1;
            this.btnFrigobar.Text = "Frigobar";
            this.btnFrigobar.UseVisualStyleBackColor = true;
            this.btnFrigobar.Click += new System.EventHandler(this.btnFrigobar_Click);
            // 
            // btnRestaurante
            // 
            this.btnRestaurante.Location = new System.Drawing.Point(6, 21);
            this.btnRestaurante.Name = "btnRestaurante";
            this.btnRestaurante.Size = new System.Drawing.Size(96, 33);
            this.btnRestaurante.TabIndex = 0;
            this.btnRestaurante.Text = "Restaurante";
            this.btnRestaurante.UseVisualStyleBackColor = true;
            this.btnRestaurante.Click += new System.EventHandler(this.btnRestaurante_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(370, 80);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(44, 16);
            this.lblValor.TabIndex = 12;
            this.lblValor.Text = "Valor:";
            // 
            // lblDescricaoDiaria
            // 
            this.lblDescricaoDiaria.AutoSize = true;
            this.lblDescricaoDiaria.Location = new System.Drawing.Point(373, 46);
            this.lblDescricaoDiaria.Name = "lblDescricaoDiaria";
            this.lblDescricaoDiaria.Size = new System.Drawing.Size(41, 16);
            this.lblDescricaoDiaria.TabIndex = 13;
            this.lblDescricaoDiaria.Text = "Desc:";
            // 
            // txtDescricaoDiaria
            // 
            this.txtDescricaoDiaria.Location = new System.Drawing.Point(415, 43);
            this.txtDescricaoDiaria.Name = "txtDescricaoDiaria";
            this.txtDescricaoDiaria.Size = new System.Drawing.Size(98, 22);
            this.txtDescricaoDiaria.TabIndex = 14;
            // 
            // lblJanelaAeB
            // 
            this.lblJanelaAeB.AutoSize = true;
            this.lblJanelaAeB.Location = new System.Drawing.Point(397, 14);
            this.lblJanelaAeB.Name = "lblJanelaAeB";
            this.lblJanelaAeB.Size = new System.Drawing.Size(58, 16);
            this.lblJanelaAeB.TabIndex = 16;
            this.lblJanelaAeB.Text = "Janela: ";
            // 
            // cbJanelaAeB
            // 
            this.cbJanelaAeB.FormattingEnabled = true;
            this.cbJanelaAeB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbJanelaAeB.Location = new System.Drawing.Point(461, 11);
            this.cbJanelaAeB.Name = "cbJanelaAeB";
            this.cbJanelaAeB.Size = new System.Drawing.Size(53, 24);
            this.cbJanelaAeB.TabIndex = 15;
            // 
            // txtDescAeB
            // 
            this.txtDescAeB.Location = new System.Drawing.Point(420, 46);
            this.txtDescAeB.Name = "txtDescAeB";
            this.txtDescAeB.Size = new System.Drawing.Size(98, 22);
            this.txtDescAeB.TabIndex = 20;
            // 
            // lblDescAeB
            // 
            this.lblDescAeB.AutoSize = true;
            this.lblDescAeB.Location = new System.Drawing.Point(378, 49);
            this.lblDescAeB.Name = "lblDescAeB";
            this.lblDescAeB.Size = new System.Drawing.Size(41, 16);
            this.lblDescAeB.TabIndex = 19;
            this.lblDescAeB.Text = "Desc:";
            // 
            // lblValorAeB
            // 
            this.lblValorAeB.AutoSize = true;
            this.lblValorAeB.Location = new System.Drawing.Point(375, 83);
            this.lblValorAeB.Name = "lblValorAeB";
            this.lblValorAeB.Size = new System.Drawing.Size(44, 16);
            this.lblValorAeB.TabIndex = 18;
            this.lblValorAeB.Text = "Valor:";
            // 
            // txtValorAeB
            // 
            this.txtValorAeB.Location = new System.Drawing.Point(420, 80);
            this.txtValorAeB.Name = "txtValorAeB";
            this.txtValorAeB.Size = new System.Drawing.Size(98, 22);
            this.txtValorAeB.TabIndex = 17;
            // 
            // Lancamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(545, 224);
            this.Controls.Add(this.panPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lancamento";
            this.Text = "Lançamento";
            this.Load += new System.EventHandler(this.Lancamento_Load);
            this.panPrincipal.ResumeLayout(false);
            this.panPrincipal.PerformLayout();
            this.tabLancamento.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.gpbAEB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panPrincipal;
        private System.Windows.Forms.TabControl tabLancamento;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDiaria;
        private System.Windows.Forms.Button btnDifDiaria;
        private System.Windows.Forms.Button btnSalvarDiaria;
        private System.Windows.Forms.TextBox txtValorDiaria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReserva;
        private System.Windows.Forms.TextBox txtIdHospede;
        private System.Windows.Forms.TextBox txtReserva;
        private System.Windows.Forms.ComboBox cbJanela;
        private System.Windows.Forms.Label lblJanela;
        private System.Windows.Forms.Button btnLancarAeB;
        private System.Windows.Forms.GroupBox gpbAEB;
        private System.Windows.Forms.Button btnFrigobar;
        private System.Windows.Forms.Button btnRestaurante;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtDescricaoDiaria;
        private System.Windows.Forms.Label lblDescricaoDiaria;
        private System.Windows.Forms.TextBox txtDescAeB;
        private System.Windows.Forms.Label lblDescAeB;
        private System.Windows.Forms.Label lblValorAeB;
        private System.Windows.Forms.TextBox txtValorAeB;
        private System.Windows.Forms.Label lblJanelaAeB;
        private System.Windows.Forms.ComboBox cbJanelaAeB;
    }
}