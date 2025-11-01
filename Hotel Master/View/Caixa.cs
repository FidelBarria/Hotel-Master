using Hotel_Master.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Master
{
    public partial class Caixa : Form
    {
        Reserva reserva = new Reserva();
        int idReserva = 0;
        int idHospede = 0;
        public Caixa()
        {
            InitializeComponent();
        }

        private void Caixa_Load(object sender, EventArgs e)
        {
            carregaJanelaCaixa();
            dtgCaixa1.Columns["idmovimentacao"].Visible = false;
            dtgCaixa1.Columns["janela"].Visible = false;
            dtgCaixa1.Columns["datamovimentacao"].HeaderText = "Dia";
            dtgCaixa1.Columns["valormovimentacao"].HeaderText = "Valor";
            dtgCaixa1.Columns["descricaomovimentacao"].HeaderText = "Descrição";
            dtgCaixa2.Columns["idmovimentacao"].Visible = false;
            dtgCaixa2.Columns["janela"].Visible = false;
            dtgCaixa2.Columns["datamovimentacao"].HeaderText = "Dia";
            dtgCaixa2.Columns["valormovimentacao"].HeaderText = "Valor";
            dtgCaixa2.Columns["descricaomovimentacao"].HeaderText = "Descrição";
            dtgCaixa3.Columns["idmovimentacao"].Visible = false;
            dtgCaixa3.Columns["janela"].Visible = false;
            dtgCaixa3.Columns["datamovimentacao"].HeaderText = "Dia";
            dtgCaixa3.Columns["valormovimentacao"].HeaderText = "Valor";
            dtgCaixa3.Columns["descricaomovimentacao"].HeaderText = "Descrição";
            dtgCaixa4.Columns["idmovimentacao"].Visible = false;
            dtgCaixa4.Columns["janela"].Visible = false;
            dtgCaixa4.Columns["datamovimentacao"].HeaderText = "Dia";
            dtgCaixa4.Columns["valormovimentacao"].HeaderText = "Valor";
            dtgCaixa4.Columns["descricaomovimentacao"].HeaderText = "Descrição";


        }

        public void carregaJanelaCaixa()
        {
            MySqlDataReader dr = reserva.procuraReservaId(idReserva);

            

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtHospede.Text = dr.GetString("hospede1");
                    txtReserva.Text = dr.GetInt32("idreserva").ToString();
                    idHospede = dr.GetInt32("idHospede1");
                    txtCliente.Text = dr.GetString("cliente");
                    txtStatus.Text = dr.GetString("statusreserva");
                    gpJanela1.Text = dr.GetString("hospede1") + ":";
                    rtObservacao.Text = dr.GetString("observacao");

                }
            }

            Movimentacao movimentacao = new Movimentacao();  
            DataTable dt = new DataTable();
            dt = movimentacao.procuraMovimentacao(Convert.ToInt32(txtReserva.Text));
            DataView janela1 = new DataView(dt);
            DataView janela2 = new DataView(dt);
            DataView janela3 = new DataView(dt);
            DataView janela4 = new DataView(dt);

            janela1.RowFilter = "janela = 1";
            dtgCaixa1.DataSource = janela1;
            janela2.RowFilter = "janela = 2";
            dtgCaixa2.DataSource = janela2;
            janela3.RowFilter = "janela = 3";
            dtgCaixa3.DataSource = janela3;
            janela4.RowFilter = "janela = 4";
            dtgCaixa4.DataSource = janela4;

            decimal valorTotalJanela1 = 0;
            foreach (DataGridViewRow row in dtgCaixa1.Rows)
            {
                if (row.Cells["valormovimentacao"] != null)
                {
                    valorTotalJanela1 += Convert.ToDecimal(row.Cells["valormovimentacao"].Value);
                }
                lblValorTotalJanela1.Text = valorTotalJanela1.ToString();
            }
            decimal valorTotalJanela2 = 0;
            foreach (DataGridViewRow row in dtgCaixa2.Rows)
            {
                if (row.Cells["valormovimentacao"] != null)
                {
                    valorTotalJanela2 += Convert.ToDecimal(row.Cells["valormovimentacao"].Value);
                }
                lblValorTotalJanela2.Text = valorTotalJanela2.ToString();
            }
            decimal valorTotalJanela3 = 0;
            foreach (DataGridViewRow row in dtgCaixa3.Rows)
            {
                if (row.Cells["valormovimentacao"] != null)
                {
                    valorTotalJanela3 += Convert.ToDecimal(row.Cells["valormovimentacao"].Value);
                }
                lblValorTotalJanela3.Text = valorTotalJanela3.ToString();
            }
            decimal valorTotalJanela4 = 0;
            foreach (DataGridViewRow row in dtgCaixa4.Rows)
            {
                if (row.Cells["valormovimentacao"] != null)
                {
                    valorTotalJanela4 += Convert.ToDecimal(row.Cells["valormovimentacao"].Value);
                }
                lblValorTotalJanela4.Text = valorTotalJanela4.ToString();
            }

            decimal valorTotalGeral = valorTotalJanela1 + valorTotalJanela2 + valorTotalJanela3 + valorTotalJanela4;
            txtSaldo.Text = valorTotalGeral.ToString();
        }

        public void pegaIdReserva(int idReserva)
        {
            this.idReserva = idReserva;
        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            Lancamento lancamento = new Lancamento();
            lancamento.pegaIdReservaIdHospede(idReserva, idHospede);
            lancamento.Show();
        }

        private void dtgCaixa1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            double valorTotal = 0;
            foreach (DataGridViewRow row in dtgCaixa1.SelectedRows)
            {
                if (row.Cells["valormovimentacao"] != null)
                {
                    valorTotal += Convert.ToSingle(row.Cells["valormovimentacao"].Value);
                }
                lblValorSelecionadoJanela1.Text = valorTotal.ToString();
            }
        }

        private void dtgCaixa2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            double valorTotal = 0;
            foreach (DataGridViewRow row in dtgCaixa1.SelectedRows)
            {
                if (row.Cells["valormovimentacao"] != null)
                {
                    valorTotal += Convert.ToSingle(row.Cells["valormovimentacao"].Value);
                }
                lblValorSelecionadoJanela2.Text = valorTotal.ToString();
            }
        }

        private void dtgCaixa3_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            double valorTotal = 0;
            foreach (DataGridViewRow row in dtgCaixa1.SelectedRows)
            {
                if (row.Cells["valormovimentacao"] != null)
                {
                    valorTotal += Convert.ToSingle(row.Cells["valormovimentacao"].Value);
                }
                lblValorSelecionadoJanela3.Text = valorTotal.ToString();
            }
        }

        private void dtgCaixa4_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            double valorTotal = 0;
            foreach (DataGridViewRow row in dtgCaixa1.SelectedRows)
            {
                if (row.Cells["valormovimentacao"] != null)
                {
                    valorTotal += Convert.ToSingle(row.Cells["valormovimentacao"].Value);
                }
                lblValorSelecionadoJanela4.Text = valorTotal.ToString();
            }
        }

        private void dtgCaixa1_Enter(object sender, EventArgs e)
        {
            dtgCaixa1.GridColor = Color.Red;
        }

        private void dtgCaixa1_Leave(object sender, EventArgs e)
        {
            dtgCaixa1.GridColor = Color.Black;
        }

        private void dtgCaixa2_Enter(object sender, EventArgs e)
        {
            dtgCaixa2.GridColor = Color.Red;
        }

        private void dtgCaixa2_Leave(object sender, EventArgs e)
        {
            dtgCaixa2.GridColor = Color.Black;
        }

        private void dtgCaixa3_Enter(object sender, EventArgs e)
        {
            dtgCaixa3.GridColor = Color.Red;
        }

        private void dtgCaixa3_Leave(object sender, EventArgs e)
        {
            dtgCaixa3.GridColor = Color.Black;
        }

        private void dtgCaixa4_Enter(object sender, EventArgs e)
        {
            dtgCaixa4.GridColor = Color.Red;
        }

        private void dtgCaixa4_Leave(object sender, EventArgs e)
        {
            dtgCaixa1.GridColor = Color.Black;
        }


        private void dtgCaixa2_DragDrop(object sender, DragEventArgs e)
        {
            Movimentacao movimentacao = new Movimentacao();
            DataGridViewRow linhaArrastada = (DataGridViewRow)e.Data.GetData(typeof(DataGridViewRow));
            movimentacao.idMovimentacao = Convert.ToInt32(linhaArrastada.Cells["idmovimentacao"].Value);
            movimentacao.janela = 2;
            movimentacao.alteraMovimentacao();
            carregaJanelaCaixa();
        }

        private void dtgCaixa2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataGridViewRow)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }



        private void dtgCaixa1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && dtgCaixa1.SelectedRows.Count > 0)
            {
                dtgCaixa1.DoDragDrop(dtgCaixa1.SelectedRows[0], DragDropEffects.Move);
            }
                
        }

        private void dtgCaixa2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && dtgCaixa2.SelectedRows.Count > 0)
            {
                dtgCaixa2.DoDragDrop(dtgCaixa2.SelectedRows[0], DragDropEffects.Move);
            }
        }

        private void dtgCaixa3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && dtgCaixa3.SelectedRows.Count > 0)
            {
                dtgCaixa3.DoDragDrop(dtgCaixa3.SelectedRows[0], DragDropEffects.Move);
            }
        }

        private void dtgCaixa4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && dtgCaixa4.SelectedRows.Count > 0)
            {
                dtgCaixa4.DoDragDrop(dtgCaixa4.SelectedRows[0], DragDropEffects.Move);
            }
        }

        private void dtgCaixa1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataGridViewRow)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void dtgCaixa3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataGridViewRow)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void dtgCaixa4_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataGridViewRow)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void dtgCaixa1_DragDrop(object sender, DragEventArgs e)
        {
            Movimentacao movimentacao = new Movimentacao();
            DataGridViewRow linhaArrastada = (DataGridViewRow)e.Data.GetData(typeof(DataGridViewRow));
            movimentacao.idMovimentacao = Convert.ToInt32(linhaArrastada.Cells["idmovimentacao"].Value);
            movimentacao.janela = 1;
            movimentacao.alteraMovimentacao();
            carregaJanelaCaixa();
        }

        private void dtgCaixa3_DragDrop(object sender, DragEventArgs e)
        {
            Movimentacao movimentacao = new Movimentacao();
            DataGridViewRow linhaArrastada = (DataGridViewRow)e.Data.GetData(typeof(DataGridViewRow));
            movimentacao.idMovimentacao = Convert.ToInt32(linhaArrastada.Cells["idmovimentacao"].Value);
            movimentacao.janela = 3;
            movimentacao.alteraMovimentacao();
            carregaJanelaCaixa();
        }

        private void dtgCaixa4_DragDrop(object sender, DragEventArgs e)
        {
            Movimentacao movimentacao = new Movimentacao();
            DataGridViewRow linhaArrastada = (DataGridViewRow)e.Data.GetData(typeof(DataGridViewRow));
            movimentacao.idMovimentacao = Convert.ToInt32(linhaArrastada.Cells["idmovimentacao"].Value);
            movimentacao.janela = 4;
            movimentacao.alteraMovimentacao();
            carregaJanelaCaixa();
        }

        private void btnAtualiza_Click(object sender, EventArgs e)
        {
            carregaJanelaCaixa();
        }

        private void btnEncerrarConta_Click(object sender, EventArgs e)
        {

        }
    }
}
