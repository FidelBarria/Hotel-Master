namespace Hotel_Master
{
    partial class ProcuraTarifa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcuraTarifa));
            this.panPrincipal = new System.Windows.Forms.Panel();
            this.panTarifa = new System.Windows.Forms.FlowLayoutPanel();
            this.dtgTarifa = new System.Windows.Forms.DataGridView();
            this.panProcuraTarifa = new System.Windows.Forms.FlowLayoutPanel();
            this.txtPesquisaTarifa = new System.Windows.Forms.TextBox();
            this.btnProcuraTarifa = new System.Windows.Forms.Button();
            this.btnSeleciona = new System.Windows.Forms.Button();
            this.panPrincipal.SuspendLayout();
            this.panTarifa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTarifa)).BeginInit();
            this.panProcuraTarifa.SuspendLayout();
            this.SuspendLayout();
            // 
            // panPrincipal
            // 
            this.panPrincipal.Controls.Add(this.panTarifa);
            this.panPrincipal.Controls.Add(this.panProcuraTarifa);
            this.panPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panPrincipal.Name = "panPrincipal";
            this.panPrincipal.Size = new System.Drawing.Size(517, 249);
            this.panPrincipal.TabIndex = 0;
            // 
            // panTarifa
            // 
            this.panTarifa.Controls.Add(this.dtgTarifa);
            this.panTarifa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panTarifa.Location = new System.Drawing.Point(0, 38);
            this.panTarifa.Name = "panTarifa";
            this.panTarifa.Size = new System.Drawing.Size(517, 211);
            this.panTarifa.TabIndex = 1;
            // 
            // dtgTarifa
            // 
            this.dtgTarifa.AllowUserToAddRows = false;
            this.dtgTarifa.AllowUserToDeleteRows = false;
            this.dtgTarifa.AllowUserToResizeRows = false;
            this.dtgTarifa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTarifa.Location = new System.Drawing.Point(3, 3);
            this.dtgTarifa.MultiSelect = false;
            this.dtgTarifa.Name = "dtgTarifa";
            this.dtgTarifa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTarifa.Size = new System.Drawing.Size(511, 205);
            this.dtgTarifa.TabIndex = 0;
            // 
            // panProcuraTarifa
            // 
            this.panProcuraTarifa.Controls.Add(this.txtPesquisaTarifa);
            this.panProcuraTarifa.Controls.Add(this.btnProcuraTarifa);
            this.panProcuraTarifa.Controls.Add(this.btnSeleciona);
            this.panProcuraTarifa.Dock = System.Windows.Forms.DockStyle.Top;
            this.panProcuraTarifa.Location = new System.Drawing.Point(0, 0);
            this.panProcuraTarifa.Name = "panProcuraTarifa";
            this.panProcuraTarifa.Size = new System.Drawing.Size(517, 38);
            this.panProcuraTarifa.TabIndex = 0;
            // 
            // txtPesquisaTarifa
            // 
            this.txtPesquisaTarifa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisaTarifa.Location = new System.Drawing.Point(3, 4);
            this.txtPesquisaTarifa.Name = "txtPesquisaTarifa";
            this.txtPesquisaTarifa.Size = new System.Drawing.Size(262, 20);
            this.txtPesquisaTarifa.TabIndex = 0;
            // 
            // btnProcuraTarifa
            // 
            this.btnProcuraTarifa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProcuraTarifa.Location = new System.Drawing.Point(271, 3);
            this.btnProcuraTarifa.Name = "btnProcuraTarifa";
            this.btnProcuraTarifa.Size = new System.Drawing.Size(75, 23);
            this.btnProcuraTarifa.TabIndex = 1;
            this.btnProcuraTarifa.Text = "Procurar Tarifa";
            this.btnProcuraTarifa.UseVisualStyleBackColor = true;
            // 
            // btnSeleciona
            // 
            this.btnSeleciona.Location = new System.Drawing.Point(352, 3);
            this.btnSeleciona.Name = "btnSeleciona";
            this.btnSeleciona.Size = new System.Drawing.Size(78, 23);
            this.btnSeleciona.TabIndex = 2;
            this.btnSeleciona.Text = "Seleciona";
            this.btnSeleciona.UseVisualStyleBackColor = true;
            this.btnSeleciona.Click += new System.EventHandler(this.btnSeleciona_Click);
            // 
            // ProcuraTarifa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(517, 249);
            this.Controls.Add(this.panPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProcuraTarifa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProcuraTarifa";
            this.panPrincipal.ResumeLayout(false);
            this.panTarifa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTarifa)).EndInit();
            this.panProcuraTarifa.ResumeLayout(false);
            this.panProcuraTarifa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panPrincipal;
        private System.Windows.Forms.FlowLayoutPanel panTarifa;
        private System.Windows.Forms.FlowLayoutPanel panProcuraTarifa;
        private System.Windows.Forms.TextBox txtPesquisaTarifa;
        private System.Windows.Forms.Button btnProcuraTarifa;
        private System.Windows.Forms.Button btnSeleciona;
        public System.Windows.Forms.DataGridView dtgTarifa;
    }
}