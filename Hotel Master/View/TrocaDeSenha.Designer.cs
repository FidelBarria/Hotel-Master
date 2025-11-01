namespace Hotel_Master
{
    partial class TrocaDeSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrocaDeSenha));
            this.panTitulo = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panTrocaSenha = new System.Windows.Forms.TableLayoutPanel();
            this.lblSenhaAnterior = new System.Windows.Forms.Label();
            this.lblNovaSenha = new System.Windows.Forms.Label();
            this.txtSenhaAnterior = new System.Windows.Forms.TextBox();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.lblRepetirSenha = new System.Windows.Forms.Label();
            this.txtRepetirSenha = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.panTitulo.SuspendLayout();
            this.panInfo.SuspendLayout();
            this.panTrocaSenha.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTitulo
            // 
            this.panTitulo.ColumnCount = 1;
            this.panTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panTitulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panTitulo.Controls.Add(this.lblTitulo, 0, 0);
            this.panTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTitulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panTitulo.Location = new System.Drawing.Point(0, 0);
            this.panTitulo.Name = "panTitulo";
            this.panTitulo.RowCount = 1;
            this.panTitulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panTitulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.panTitulo.Size = new System.Drawing.Size(442, 75);
            this.panTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(153, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(136, 22);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Trocar Senha";
            // 
            // panInfo
            // 
            this.panInfo.ColumnCount = 1;
            this.panInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panInfo.Controls.Add(this.lblInfo, 0, 0);
            this.panInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panInfo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panInfo.Location = new System.Drawing.Point(0, 75);
            this.panInfo.Name = "panInfo";
            this.panInfo.RowCount = 1;
            this.panInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.panInfo.Size = new System.Drawing.Size(442, 48);
            this.panInfo.TabIndex = 1;
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(4, 8);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(434, 32);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Para trocar a senha, forneça sua senha antiga e logo em seguinda a nova senha que" +
    " quer cadastrar.\r\n";
            // 
            // panTrocaSenha
            // 
            this.panTrocaSenha.ColumnCount = 4;
            this.panTrocaSenha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.81982F));
            this.panTrocaSenha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.72973F));
            this.panTrocaSenha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.30631F));
            this.panTrocaSenha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.14415F));
            this.panTrocaSenha.Controls.Add(this.lblSenhaAnterior, 1, 0);
            this.panTrocaSenha.Controls.Add(this.lblNovaSenha, 1, 1);
            this.panTrocaSenha.Controls.Add(this.txtSenhaAnterior, 2, 0);
            this.panTrocaSenha.Controls.Add(this.txtNovaSenha, 2, 1);
            this.panTrocaSenha.Controls.Add(this.lblRepetirSenha, 1, 2);
            this.panTrocaSenha.Controls.Add(this.txtRepetirSenha, 2, 2);
            this.panTrocaSenha.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTrocaSenha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panTrocaSenha.Location = new System.Drawing.Point(0, 123);
            this.panTrocaSenha.Name = "panTrocaSenha";
            this.panTrocaSenha.RowCount = 3;
            this.panTrocaSenha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panTrocaSenha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panTrocaSenha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panTrocaSenha.Size = new System.Drawing.Size(442, 81);
            this.panTrocaSenha.TabIndex = 2;
            // 
            // lblSenhaAnterior
            // 
            this.lblSenhaAnterior.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSenhaAnterior.AutoSize = true;
            this.lblSenhaAnterior.Location = new System.Drawing.Point(99, 5);
            this.lblSenhaAnterior.Name = "lblSenhaAnterior";
            this.lblSenhaAnterior.Size = new System.Drawing.Size(107, 16);
            this.lblSenhaAnterior.TabIndex = 0;
            this.lblSenhaAnterior.Text = "Senha Anterior:";
            // 
            // lblNovaSenha
            // 
            this.lblNovaSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNovaSenha.AutoSize = true;
            this.lblNovaSenha.Location = new System.Drawing.Point(106, 32);
            this.lblNovaSenha.Name = "lblNovaSenha";
            this.lblNovaSenha.Size = new System.Drawing.Size(92, 16);
            this.lblNovaSenha.TabIndex = 1;
            this.lblNovaSenha.Text = "Nova Senha: ";
            // 
            // txtSenhaAnterior
            // 
            this.txtSenhaAnterior.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenhaAnterior.Location = new System.Drawing.Point(221, 3);
            this.txtSenhaAnterior.Name = "txtSenhaAnterior";
            this.txtSenhaAnterior.Size = new System.Drawing.Size(131, 22);
            this.txtSenhaAnterior.TabIndex = 2;
            this.txtSenhaAnterior.UseSystemPasswordChar = true;
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNovaSenha.Location = new System.Drawing.Point(221, 30);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Size = new System.Drawing.Size(131, 22);
            this.txtNovaSenha.TabIndex = 3;
            this.txtNovaSenha.UseSystemPasswordChar = true;
            // 
            // lblRepetirSenha
            // 
            this.lblRepetirSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRepetirSenha.AutoSize = true;
            this.lblRepetirSenha.Location = new System.Drawing.Point(103, 59);
            this.lblRepetirSenha.Name = "lblRepetirSenha";
            this.lblRepetirSenha.Size = new System.Drawing.Size(98, 16);
            this.lblRepetirSenha.TabIndex = 4;
            this.lblRepetirSenha.Text = "Repetir Senha";
            // 
            // txtRepetirSenha
            // 
            this.txtRepetirSenha.Location = new System.Drawing.Point(221, 57);
            this.txtRepetirSenha.Name = "txtRepetirSenha";
            this.txtRepetirSenha.Size = new System.Drawing.Size(131, 22);
            this.txtRepetirSenha.TabIndex = 5;
            this.txtRepetirSenha.UseSystemPasswordChar = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnConfirma, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 204);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(442, 65);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnConfirma
            // 
            this.btnConfirma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirma.Location = new System.Drawing.Point(168, 16);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(106, 32);
            this.btnConfirma.TabIndex = 0;
            this.btnConfirma.Text = "Confirma";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // TrocaDeSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(442, 269);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panTrocaSenha);
            this.Controls.Add(this.panInfo);
            this.Controls.Add(this.panTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(458, 308);
            this.MinimumSize = new System.Drawing.Size(458, 308);
            this.Name = "TrocaDeSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Troca De Senha";
            this.panTitulo.ResumeLayout(false);
            this.panTitulo.PerformLayout();
            this.panInfo.ResumeLayout(false);
            this.panInfo.PerformLayout();
            this.panTrocaSenha.ResumeLayout(false);
            this.panTrocaSenha.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TableLayoutPanel panInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TableLayoutPanel panTrocaSenha;
        private System.Windows.Forms.Label lblSenhaAnterior;
        private System.Windows.Forms.Label lblNovaSenha;
        private System.Windows.Forms.TextBox txtSenhaAnterior;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.Label lblRepetirSenha;
        private System.Windows.Forms.TextBox txtRepetirSenha;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnConfirma;
    }
}