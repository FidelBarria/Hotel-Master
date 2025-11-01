namespace Hotel_Master
{
    partial class HotelMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelMaster));
            this.menuSuperior = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuManutencaoUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTrocarSenha = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDesloga = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTituloUsuario = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblTituloNivelPermissao = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNivelPermissao = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.panMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnNovaReserva = new System.Windows.Forms.Button();
            this.btnGovernanca = new System.Windows.Forms.Button();
            this.btnBuscaReserva = new System.Windows.Forms.Button();
            this.menuSuperior.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuSuperior
            // 
            this.menuSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuSuperior.Location = new System.Drawing.Point(0, 0);
            this.menuSuperior.Name = "menuSuperior";
            this.menuSuperior.Size = new System.Drawing.Size(800, 24);
            this.menuSuperior.TabIndex = 0;
            this.menuSuperior.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuManutencaoUsuario,
            this.menuTrocarSenha,
            this.menuDesloga});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // menuManutencaoUsuario
            // 
            this.menuManutencaoUsuario.Name = "menuManutencaoUsuario";
            this.menuManutencaoUsuario.Size = new System.Drawing.Size(193, 22);
            this.menuManutencaoUsuario.Text = "Manuteção de Usuario";
            this.menuManutencaoUsuario.Click += new System.EventHandler(this.novoUsuarioToolStripMenuItem_Click);
            // 
            // menuTrocarSenha
            // 
            this.menuTrocarSenha.Name = "menuTrocarSenha";
            this.menuTrocarSenha.Size = new System.Drawing.Size(193, 22);
            this.menuTrocarSenha.Text = "Trocar Senha";
            this.menuTrocarSenha.Click += new System.EventHandler(this.menuTrocarSenha_Click);
            // 
            // menuDesloga
            // 
            this.menuDesloga.Name = "menuDesloga";
            this.menuDesloga.Size = new System.Drawing.Size(193, 22);
            this.menuDesloga.Text = "Desloga";
            this.menuDesloga.Click += new System.EventHandler(this.menuDesloga_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.12145F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.270677F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.80201F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.2782F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.18296F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.04417F));
            this.tableLayoutPanel2.Controls.Add(this.lblTituloUsuario, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblData, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblTituloNivelPermissao, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblUsuario, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblNivelPermissao, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblId, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 429);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 21);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // lblTituloUsuario
            // 
            this.lblTituloUsuario.AutoSize = true;
            this.lblTituloUsuario.Location = new System.Drawing.Point(94, 2);
            this.lblTituloUsuario.Name = "lblTituloUsuario";
            this.lblTituloUsuario.Size = new System.Drawing.Size(55, 14);
            this.lblTituloUsuario.TabIndex = 0;
            this.lblTituloUsuario.Text = "Usuario: ";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(600, 2);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(39, 14);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "label2";
            // 
            // lblTituloNivelPermissao
            // 
            this.lblTituloNivelPermissao.AutoSize = true;
            this.lblTituloNivelPermissao.Location = new System.Drawing.Point(326, 2);
            this.lblTituloNivelPermissao.Name = "lblTituloNivelPermissao";
            this.lblTituloNivelPermissao.Size = new System.Drawing.Size(73, 14);
            this.lblTituloNivelPermissao.TabIndex = 2;
            this.lblTituloNivelPermissao.Text = "Permissão: ";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(161, 2);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(39, 14);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "label1";
            // 
            // lblNivelPermissao
            // 
            this.lblNivelPermissao.AutoSize = true;
            this.lblNivelPermissao.Location = new System.Drawing.Point(416, 2);
            this.lblNivelPermissao.Name = "lblNivelPermissao";
            this.lblNivelPermissao.Size = new System.Drawing.Size(39, 14);
            this.lblNivelPermissao.TabIndex = 4;
            this.lblNivelPermissao.Text = "label1";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(5, 2);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(39, 14);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "label1";
            // 
            // panMenu
            // 
            this.panMenu.ColumnCount = 10;
            this.panMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.83397F));
            this.panMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.19434F));
            this.panMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.19434F));
            this.panMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.19434F));
            this.panMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.19434F));
            this.panMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.19434F));
            this.panMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.19434F));
            this.panMenu.Controls.Add(this.btnNovaReserva, 1, 0);
            this.panMenu.Controls.Add(this.btnGovernanca, 0, 0);
            this.panMenu.Controls.Add(this.btnBuscaReserva, 2, 0);
            this.panMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panMenu.Location = new System.Drawing.Point(0, 24);
            this.panMenu.Name = "panMenu";
            this.panMenu.RowCount = 1;
            this.panMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panMenu.Size = new System.Drawing.Size(800, 73);
            this.panMenu.TabIndex = 6;
            // 
            // btnNovaReserva
            // 
            this.btnNovaReserva.BackgroundImage = global::Hotel_Master.Properties.Resources.formulario_de_contato__1_;
            this.btnNovaReserva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovaReserva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNovaReserva.Location = new System.Drawing.Point(86, 3);
            this.btnNovaReserva.Name = "btnNovaReserva";
            this.btnNovaReserva.Size = new System.Drawing.Size(76, 67);
            this.btnNovaReserva.TabIndex = 1;
            this.btnNovaReserva.UseVisualStyleBackColor = true;
            this.btnNovaReserva.Click += new System.EventHandler(this.btnNovaReserva_Click);
            // 
            // btnGovernanca
            // 
            this.btnGovernanca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGovernanca.BackgroundImage")));
            this.btnGovernanca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGovernanca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGovernanca.Location = new System.Drawing.Point(5, 5);
            this.btnGovernanca.Margin = new System.Windows.Forms.Padding(5);
            this.btnGovernanca.Name = "btnGovernanca";
            this.btnGovernanca.Size = new System.Drawing.Size(73, 63);
            this.btnGovernanca.TabIndex = 0;
            this.btnGovernanca.UseVisualStyleBackColor = true;
            this.btnGovernanca.Click += new System.EventHandler(this.btnGovernanca_Click);
            // 
            // btnBuscaReserva
            // 
            this.btnBuscaReserva.BackgroundImage = global::Hotel_Master.Properties.Resources.procurar__1_;
            this.btnBuscaReserva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaReserva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBuscaReserva.Location = new System.Drawing.Point(168, 3);
            this.btnBuscaReserva.Name = "btnBuscaReserva";
            this.btnBuscaReserva.Size = new System.Drawing.Size(69, 67);
            this.btnBuscaReserva.TabIndex = 2;
            this.btnBuscaReserva.UseVisualStyleBackColor = true;
            this.btnBuscaReserva.Click += new System.EventHandler(this.btnBuscaReserva_Click);
            // 
            // HotelMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panMenu);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.menuSuperior);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "HotelMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HotelMaster";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HotelMaster_FormClosing);
            this.Load += new System.EventHandler(this.HotelMaster_Load);
            this.menuSuperior.ResumeLayout(false);
            this.menuSuperior.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuSuperior;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuManutencaoUsuario;
        private System.Windows.Forms.ToolStripMenuItem menuDesloga;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblTituloUsuario;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblTituloNivelPermissao;
        private System.Windows.Forms.Label lblNivelPermissao;
        private System.Windows.Forms.ToolStripMenuItem menuTrocarSenha;
        public System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TableLayoutPanel panMenu;
        private System.Windows.Forms.Button btnGovernanca;
        private System.Windows.Forms.Button btnNovaReserva;
        private System.Windows.Forms.Button btnBuscaReserva;
    }
}