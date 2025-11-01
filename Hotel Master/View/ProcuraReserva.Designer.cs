namespace Hotel_Master
{
    partial class ProcuraReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcuraReserva));
            this.panPrincipal = new System.Windows.Forms.Panel();
            this.tbPanelMenuLateral = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.btnCancela = new System.Windows.Forms.Button();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnNoShow = new System.Windows.Forms.Button();
            this.dtgReserva = new System.Windows.Forms.DataGridView();
            this.panPesquisa = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lblStatusReserva = new System.Windows.Forms.Label();
            this.cbStatusReserva = new System.Windows.Forms.ComboBox();
            this.lblCheckin = new System.Windows.Forms.Label();
            this.dtCheckin = new System.Windows.Forms.DateTimePicker();
            this.lblCheckout = new System.Windows.Forms.Label();
            this.dtCheckout = new System.Windows.Forms.DateTimePicker();
            this.lblReserva = new System.Windows.Forms.Label();
            this.txtReserva = new System.Windows.Forms.TextBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnReativar = new System.Windows.Forms.Button();
            this.panPrincipal.SuspendLayout();
            this.tbPanelMenuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReserva)).BeginInit();
            this.panPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // panPrincipal
            // 
            this.panPrincipal.Controls.Add(this.tbPanelMenuLateral);
            this.panPrincipal.Controls.Add(this.dtgReserva);
            this.panPrincipal.Controls.Add(this.panPesquisa);
            this.panPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panPrincipal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panPrincipal.Name = "panPrincipal";
            this.panPrincipal.Size = new System.Drawing.Size(1033, 450);
            this.panPrincipal.TabIndex = 0;
            // 
            // tbPanelMenuLateral
            // 
            this.tbPanelMenuLateral.ColumnCount = 1;
            this.tbPanelMenuLateral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbPanelMenuLateral.Controls.Add(this.btnEditar, 0, 0);
            this.tbPanelMenuLateral.Controls.Add(this.btnCheckin, 0, 1);
            this.tbPanelMenuLateral.Controls.Add(this.btnCancela, 0, 2);
            this.tbPanelMenuLateral.Controls.Add(this.btnNoShow, 0, 3);
            this.tbPanelMenuLateral.Controls.Add(this.btnReativar, 0, 4);
            this.tbPanelMenuLateral.Controls.Add(this.btnCaixa, 0, 5);
            this.tbPanelMenuLateral.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbPanelMenuLateral.Location = new System.Drawing.Point(898, 47);
            this.tbPanelMenuLateral.Name = "tbPanelMenuLateral";
            this.tbPanelMenuLateral.RowCount = 7;
            this.tbPanelMenuLateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.926018F));
            this.tbPanelMenuLateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.92046F));
            this.tbPanelMenuLateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.92309F));
            this.tbPanelMenuLateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.926406F));
            this.tbPanelMenuLateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.927344F));
            this.tbPanelMenuLateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.926479F));
            this.tbPanelMenuLateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.4502F));
            this.tbPanelMenuLateral.Size = new System.Drawing.Size(135, 403);
            this.tbPanelMenuLateral.TabIndex = 2;
            // 
            // btnEditar
            // 
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditar.Location = new System.Drawing.Point(3, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(129, 34);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCheckin
            // 
            this.btnCheckin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCheckin.Location = new System.Drawing.Point(3, 43);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(129, 33);
            this.btnCheckin.TabIndex = 0;
            this.btnCheckin.Text = "Checkin";
            this.btnCheckin.UseVisualStyleBackColor = true;
            // 
            // btnCancela
            // 
            this.btnCancela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancela.Location = new System.Drawing.Point(3, 82);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(129, 33);
            this.btnCancela.TabIndex = 1;
            this.btnCancela.Text = "Cancela";
            this.btnCancela.UseVisualStyleBackColor = true;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // btnCaixa
            // 
            this.btnCaixa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCaixa.Location = new System.Drawing.Point(3, 201);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(129, 34);
            this.btnCaixa.TabIndex = 3;
            this.btnCaixa.Text = "Caixa";
            this.btnCaixa.UseVisualStyleBackColor = true;
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            // 
            // btnNoShow
            // 
            this.btnNoShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNoShow.Location = new System.Drawing.Point(3, 121);
            this.btnNoShow.Name = "btnNoShow";
            this.btnNoShow.Size = new System.Drawing.Size(129, 34);
            this.btnNoShow.TabIndex = 2;
            this.btnNoShow.Text = "No-Show";
            this.btnNoShow.UseVisualStyleBackColor = true;
            this.btnNoShow.Click += new System.EventHandler(this.btnNoShow_Click);
            // 
            // dtgReserva
            // 
            this.dtgReserva.AllowUserToAddRows = false;
            this.dtgReserva.AllowUserToDeleteRows = false;
            this.dtgReserva.AllowUserToOrderColumns = true;
            this.dtgReserva.AllowUserToResizeRows = false;
            this.dtgReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReserva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgReserva.Location = new System.Drawing.Point(0, 47);
            this.dtgReserva.MultiSelect = false;
            this.dtgReserva.Name = "dtgReserva";
            this.dtgReserva.ReadOnly = true;
            this.dtgReserva.RowHeadersVisible = false;
            this.dtgReserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgReserva.Size = new System.Drawing.Size(1033, 403);
            this.dtgReserva.TabIndex = 1;
            // 
            // panPesquisa
            // 
            this.panPesquisa.Controls.Add(this.lblCategoria);
            this.panPesquisa.Controls.Add(this.cbCategoria);
            this.panPesquisa.Controls.Add(this.lblStatusReserva);
            this.panPesquisa.Controls.Add(this.cbStatusReserva);
            this.panPesquisa.Controls.Add(this.lblCheckin);
            this.panPesquisa.Controls.Add(this.dtCheckin);
            this.panPesquisa.Controls.Add(this.lblCheckout);
            this.panPesquisa.Controls.Add(this.dtCheckout);
            this.panPesquisa.Controls.Add(this.lblReserva);
            this.panPesquisa.Controls.Add(this.txtReserva);
            this.panPesquisa.Controls.Add(this.btnPesquisa);
            this.panPesquisa.Dock = System.Windows.Forms.DockStyle.Top;
            this.panPesquisa.Location = new System.Drawing.Point(0, 0);
            this.panPesquisa.Name = "panPesquisa";
            this.panPesquisa.Size = new System.Drawing.Size(1033, 47);
            this.panPesquisa.TabIndex = 0;
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(3, 7);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(77, 16);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Categoria: ";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "-"});
            this.cbCategoria.Location = new System.Drawing.Point(86, 3);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(61, 24);
            this.cbCategoria.TabIndex = 1;
            // 
            // lblStatusReserva
            // 
            this.lblStatusReserva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatusReserva.AutoSize = true;
            this.lblStatusReserva.Location = new System.Drawing.Point(153, 7);
            this.lblStatusReserva.Name = "lblStatusReserva";
            this.lblStatusReserva.Size = new System.Drawing.Size(109, 16);
            this.lblStatusReserva.TabIndex = 9;
            this.lblStatusReserva.Text = "Status Reserva: ";
            // 
            // cbStatusReserva
            // 
            this.cbStatusReserva.FormattingEnabled = true;
            this.cbStatusReserva.Location = new System.Drawing.Point(268, 3);
            this.cbStatusReserva.Name = "cbStatusReserva";
            this.cbStatusReserva.Size = new System.Drawing.Size(105, 24);
            this.cbStatusReserva.TabIndex = 10;
            // 
            // lblCheckin
            // 
            this.lblCheckin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCheckin.AutoSize = true;
            this.lblCheckin.Location = new System.Drawing.Point(379, 7);
            this.lblCheckin.Name = "lblCheckin";
            this.lblCheckin.Size = new System.Drawing.Size(66, 16);
            this.lblCheckin.TabIndex = 3;
            this.lblCheckin.Text = "Checkin: ";
            // 
            // dtCheckin
            // 
            this.dtCheckin.CustomFormat = "\" \"";
            this.dtCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCheckin.Location = new System.Drawing.Point(451, 3);
            this.dtCheckin.Name = "dtCheckin";
            this.dtCheckin.Size = new System.Drawing.Size(103, 22);
            this.dtCheckin.TabIndex = 4;
            this.dtCheckin.Value = new System.DateTime(2025, 10, 22, 15, 15, 35, 0);
            this.dtCheckin.ValueChanged += new System.EventHandler(this.dtCheckin_ValueChanged);
            this.dtCheckin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dtCheckin_KeyUp);
            // 
            // lblCheckout
            // 
            this.lblCheckout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCheckout.AutoSize = true;
            this.lblCheckout.Location = new System.Drawing.Point(560, 7);
            this.lblCheckout.Name = "lblCheckout";
            this.lblCheckout.Size = new System.Drawing.Size(74, 16);
            this.lblCheckout.TabIndex = 5;
            this.lblCheckout.Text = "Checkout: ";
            // 
            // dtCheckout
            // 
            this.dtCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCheckout.Location = new System.Drawing.Point(640, 3);
            this.dtCheckout.Name = "dtCheckout";
            this.dtCheckout.Size = new System.Drawing.Size(103, 22);
            this.dtCheckout.TabIndex = 6;
            this.dtCheckout.ValueChanged += new System.EventHandler(this.dtCheckout_ValueChanged);
            this.dtCheckout.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dtCheckout_KeyUp);
            // 
            // lblReserva
            // 
            this.lblReserva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReserva.AutoSize = true;
            this.lblReserva.Location = new System.Drawing.Point(749, 7);
            this.lblReserva.Name = "lblReserva";
            this.lblReserva.Size = new System.Drawing.Size(66, 16);
            this.lblReserva.TabIndex = 7;
            this.lblReserva.Text = "Reserva: ";
            // 
            // txtReserva
            // 
            this.txtReserva.Location = new System.Drawing.Point(821, 3);
            this.txtReserva.Name = "txtReserva";
            this.txtReserva.Size = new System.Drawing.Size(127, 22);
            this.txtReserva.TabIndex = 8;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(954, 3);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisa.TabIndex = 2;
            this.btnPesquisa.Text = "Pesquisa";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // btnReativar
            // 
            this.btnReativar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReativar.Location = new System.Drawing.Point(3, 161);
            this.btnReativar.Name = "btnReativar";
            this.btnReativar.Size = new System.Drawing.Size(129, 34);
            this.btnReativar.TabIndex = 5;
            this.btnReativar.Text = "Reativar";
            this.btnReativar.UseVisualStyleBackColor = true;
            this.btnReativar.Click += new System.EventHandler(this.btnReativar_Click);
            // 
            // ProcuraReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1033, 450);
            this.Controls.Add(this.panPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProcuraReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procura Reserva";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panPrincipal.ResumeLayout(false);
            this.tbPanelMenuLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgReserva)).EndInit();
            this.panPesquisa.ResumeLayout(false);
            this.panPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panPrincipal;
        private System.Windows.Forms.FlowLayoutPanel panPesquisa;
        private System.Windows.Forms.DataGridView dtgReserva;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Label lblCheckin;
        private System.Windows.Forms.DateTimePicker dtCheckin;
        private System.Windows.Forms.Label lblCheckout;
        private System.Windows.Forms.DateTimePicker dtCheckout;
        private System.Windows.Forms.Label lblReserva;
        private System.Windows.Forms.TextBox txtReserva;
        private System.Windows.Forms.Label lblStatusReserva;
        private System.Windows.Forms.ComboBox cbStatusReserva;
        private System.Windows.Forms.TableLayoutPanel tbPanelMenuLateral;
        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Button btnNoShow;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnReativar;
    }
}