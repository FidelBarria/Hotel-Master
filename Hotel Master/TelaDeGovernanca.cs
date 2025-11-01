using Hotel_Master.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_Master
{
    public partial class TelaDeGovernanca : Form
    {
        public TelaDeGovernanca()
        {
            InitializeComponent();
        }



        private void carregarDados()
        {
            Quarto quarto = new Quarto();
            DataView dv = new DataView(quarto.procuraQuarto());
            dtgQuarto.DataSource = quarto.procuraQuarto();
            dtgQuarto.Columns["quarto"].DisplayIndex = 2;
            dtgQuarto.Columns["idquarto"].HeaderText = "Id";
            dtgQuarto.Columns["quarto"].HeaderText = "Numero Quarto";
            dtgQuarto.Columns["categoria"].HeaderText = "Categoria";
            dtgQuarto.Columns["statusUh"].HeaderText = "Status UH";
            dtgQuarto.Columns["statusGovernanca"].HeaderText = "Status Governança";
            dtgQuarto.Columns["observacao"].HeaderText = "Observação";

            txtQtdUh.Text = "";
            txtQtdVago.Text = "";
            txtQtdOcupados.Text = "";
            txtQtdBloqueado.Text = "";
            txtQtdVagoLimpo.Text = "";
            txtQtdVagoSujo.Text = "";
            txtQtdVagoArrumacao.Text = "";
            txtQtdOcupadoLimpo.Text = "";
            txtQtdOcupadoSujo.Text = "";
            txtQtdOcupadoArrumacao.Text = "";
            
            // infos do resumo
            txtQtdUh.Text += dv.Count.ToString();
            dv.RowFilter = "statusUh = 'VAGO'";
            txtQtdVago.Text += dv.Count.ToString();
            dv.RowFilter = "statusUh = 'OCUPADO'";
            txtQtdOcupados.Text += dv.Count.ToString();
            dv.RowFilter = "statusUh = 'BLOQUEADO'";
            txtQtdBloqueado.Text += dv.Count.ToString();
            dv.RowFilter = "statusUh = 'VAGO' AND statusGovernanca = 'LIMPO'";
            txtQtdVagoLimpo.Text += dv.Count.ToString();
            dv.RowFilter = "statusUh = 'VAGO' AND statusGovernanca = 'SUJO'";
            txtQtdVagoSujo.Text += dv.Count.ToString();
            dv.RowFilter = "statusUh = 'VAGO' AND statusGovernanca = 'ARRUMAÇÃO'";
            txtQtdVagoArrumacao.Text += dv.Count.ToString();
            dv.RowFilter = "statusUh = 'OCUPADO' AND statusGovernanca = 'LIMPO'";
            txtQtdOcupadoLimpo.Text += dv.Count.ToString();
            dv.RowFilter = "statusUh = 'OCUPADO' AND statusGovernanca = 'SUJO'";
            txtQtdOcupadoSujo.Text += dv.Count.ToString();
            dv.RowFilter = "statusUh = 'OCUPADO' AND statusGovernanca = 'ARRUMAÇÃO'";
            txtQtdOcupadoArrumacao.Text += dv.Count.ToString();
        }

        private void btnGovernanca_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void dtgQuarto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dtgQuarto.Columns["statusUh"].Index)
            {
                if (e.Value != null && e.Value is string)
                {
                    string statusUh = e.Value.ToString();
                    if (statusUh == "VAGO")
                    {
                        e.CellStyle.ForeColor = Color.Green;
                    }
                    else if (statusUh == "OCUPADO")
                    {
                        e.CellStyle.ForeColor = Color.Red;
                    }
                    else if (statusUh == "BLOQUEADO")
                    {
                        e.CellStyle.ForeColor = Color.Purple;
                    }
                }
            }

            if (e.ColumnIndex == dtgQuarto.Columns["statusGovernanca"].Index)
            {
                if (e.Value != null && e.Value is string)
                {
                    string statusGovernanca = e.Value.ToString();
                    if (statusGovernanca == "LIMPO")
                    {
                        e.CellStyle.BackColor = Color.Green;
                    }
                    else if (statusGovernanca == "SUJO")
                    {
                        e.CellStyle.BackColor = Color.Red;
                    }
                    else if (statusGovernanca == "ARRUMAÇÃO")
                    {
                        e.CellStyle.BackColor = Color.Yellow;
                    }
                    else if (statusGovernanca == "SITE SPECTIO")
                    {
                        e.CellStyle.BackColor = Color.Orange;
                    }
                }

            }
        }

        private void btnLimpo_Click(object sender, EventArgs e)
        {
            Quarto quarto = new Quarto();
            foreach (DataGridViewRow linha in dtgQuarto.SelectedRows)
            {
                quarto.mudaStatusGovernanca(Convert.ToInt32(linha.Cells[0].Value), btnLimpo.Text);
            }
            dtgQuarto.DataSource = quarto.procuraQuarto();

        }

        private void btnSujo_Click(object sender, EventArgs e)
        {
            Quarto quarto = new Quarto();
            foreach (DataGridViewRow linha in dtgQuarto.SelectedRows)
            {
                quarto.mudaStatusGovernanca(Convert.ToInt32(linha.Cells[0].Value), btnSujo.Text);
            }
            dtgQuarto.DataSource = quarto.procuraQuarto();
        }

        private void btnArrumacao_Click(object sender, EventArgs e)
        {
            Quarto quarto = new Quarto();
            foreach (DataGridViewRow linha in dtgQuarto.SelectedRows)
            {
                quarto.mudaStatusGovernanca(Convert.ToInt32(linha.Cells[0].Value), btnArrumacao.Text);
            }
            dtgQuarto.DataSource = quarto.procuraQuarto();
        }

        private void btnSiteSpectio_Click(object sender, EventArgs e)
        {
            Quarto quarto = new Quarto();
            foreach (DataGridViewRow linha in dtgQuarto.SelectedRows)
            {
                quarto.mudaStatusGovernanca(Convert.ToInt32(linha.Cells[0].Value), btnSiteSpectio.Text);
            }
            dtgQuarto.DataSource = quarto.procuraQuarto();
        }

        private void dtgQuarto_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnObservacao_Click_1(object sender, EventArgs e)
        {
            txtObservacao.Enabled = !txtObservacao.Enabled;
            if (txtObservacao.Enabled == false)
            {
                btnObservacao.Text = "Observação";
                Quarto quarto = new Quarto();
                if (!string.IsNullOrEmpty(txtObservacao.Text))
                {
                    foreach (DataGridViewRow linha in dtgQuarto.SelectedRows)
                    {
                        quarto.mudaObservacao(Convert.ToInt32(linha.Cells[0].Value), txtObservacao.Text);
                        txtObservacao.Clear();
                    }
                    dtgQuarto.DataSource = quarto.procuraQuarto();
                }
            }
            else btnObservacao.Text = "Salvar";


        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string statusUh = cbStatusUh.Text;
            string categoria = cbCategoria.Text;
            string statusGovernanca = cbStatusGovernanca.Text;

            Quarto quarto = new Quarto();
            DataView dv = new DataView(quarto.procuraQuarto());
            if (statusUh != "" && categoria != "" && statusGovernanca != "")
            {
                dv.RowFilter = "statusUh = '" + statusUh + "' AND categoria = '" + categoria + "' AND statusGovernanca = '" + statusGovernanca + "'";
                dtgQuarto.DataSource = dv;

            }else if (String.IsNullOrEmpty(statusUh) && String.IsNullOrEmpty(categoria) && !String.IsNullOrEmpty(statusGovernanca))
            {
                dv.RowFilter = "statusGovernanca = '" + statusGovernanca + "'";
                dtgQuarto.DataSource = dv;
            }else if (String.IsNullOrEmpty(statusUh) && !String.IsNullOrEmpty(categoria) && String.IsNullOrEmpty(statusGovernanca))
            {
                dv.RowFilter = "categoria = '" + categoria + "'";
                dtgQuarto.DataSource = dv;
            }else if (!String.IsNullOrEmpty(statusUh) && String.IsNullOrEmpty(categoria) && String.IsNullOrEmpty(statusGovernanca))
            {
                dv.RowFilter = "statusUh = '" + statusUh + "'";
                dtgQuarto.DataSource = dv;
            }else if (String.IsNullOrEmpty(statusUh) && !String.IsNullOrEmpty(categoria) && !String.IsNullOrEmpty(statusGovernanca))
            {
                dv.RowFilter = "categoria = '" + categoria + "' AND statusGovernanca = '" + statusGovernanca + "'";
                dtgQuarto.DataSource = dv;
            }else if (!String.IsNullOrEmpty(statusUh) && !String.IsNullOrEmpty(categoria) && String.IsNullOrEmpty(statusGovernanca))
            {
                dv.RowFilter = "statusUh = '" + statusUh + "' AND categoria = '" + categoria + "'";
                dtgQuarto.DataSource = dv;
            }else if (!String.IsNullOrEmpty(statusUh) && String.IsNullOrEmpty(categoria) && !String.IsNullOrEmpty(statusGovernanca))
            {
                dv.RowFilter = "statusUh = '" + statusUh + "' AND statusGovernanca = '" + statusGovernanca + "'";
                dtgQuarto.DataSource = dv;
            }
            else
            {
                dtgQuarto.DataSource = dv;
            }


        }

        private void txtUh_TextChanged(object sender, EventArgs e)
        {
            string uh = txtUh.Text;
            Quarto quarto = new Quarto();
            DataView dv = new DataView(quarto.procuraQuarto());
            dv.RowFilter = "quarto like '" + uh + "%'";
            dtgQuarto.DataSource = dv;
        }

        private void gpResumo_Enter(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            carregarDados();
        }

        private void TelaDeGovernanca_Load(object sender, EventArgs e)
        {
            carregarDados();
        }
    }
}
