using Hotel_Master.Model;
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
    public partial class Lancamento : Form
    {
        Movimentacao movimentacao = new Movimentacao();

        bool btnDiariaClicado = false;
        bool btnDifDiariaClicado = false;
        bool btnRestauranteClicado = false;
        bool btnFrigobarClicado = false;
        
        public Lancamento()
        {
            InitializeComponent();
        }

        int idHospede = 0;
        int idReserva = 0;

        private void btnDiaria_Click(object sender, EventArgs e)
        {  
            btnDiariaClicado = true;
            btnDifDiariaClicado = false;
            if (btnDiariaClicado == true)
            {
                btnDiaria.BackColor = Color.LightGreen;
                btnDifDiaria.BackColor = Color.White;
            }
            else
            {
                btnDiaria.BackColor = Color.White;
            }
        }
        private void btnDifDiaria_Click(object sender, EventArgs e)
        {
            btnDifDiariaClicado = true;
            btnDiariaClicado = false;
            if (btnDifDiariaClicado == true)
            {
                btnDifDiaria.BackColor = Color.LightGreen;
                btnDiaria.BackColor = Color.White;                
            }
            else
            {
                btnDifDiaria.BackColor = Color.White;
            }
        }
        private void btnRestaurante_Click(object sender, EventArgs e)
        {
            btnRestauranteClicado = true;
            btnFrigobarClicado = false;
            if (btnRestauranteClicado == true)
            {
                btnRestaurante.BackColor = Color.LightGreen;
                btnFrigobar.BackColor = Color.White;
            }
            else
            {
                btnRestaurante.BackColor = Color.White;
            }
        }
        private void btnFrigobar_Click(object sender, EventArgs e)
        {
            btnFrigobarClicado = true;
            btnRestauranteClicado = false;
            if (btnFrigobarClicado == true)
            {
                btnFrigobar.BackColor = Color.LightGreen;
                btnRestaurante.BackColor = Color.White;
            }
            else
            {
                btnFrigobar.BackColor = Color.White;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            movimentacao.tipoMovimentacao = "S";
            movimentacao.valorMovimentacao = +Convert.ToSingle(txtValorDiaria.Text);
            if (btnDiariaClicado == true)
            {
                btnDiaria.Text.Trim();
                int tamBtnDiaria = btnDiaria.Text.Length;
                movimentacao.descricaoMovimentacao = btnDiaria.Text.Insert(tamBtnDiaria, txtDescricaoDiaria.Text);
            }
            else if (btnDifDiariaClicado == true)
            {
                btnDifDiaria.Text.Trim();
                int tamBtnDifDiaria = btnDifDiaria.Text.Length;
                movimentacao.descricaoMovimentacao = btnDifDiaria.Text.Insert(tamBtnDifDiaria, txtDescricaoDiaria.Text);
            }
            movimentacao.dataMovimentacao = DateTime.Now;
            movimentacao.idReserva = idReserva;
            movimentacao.idHospede = idHospede;
            movimentacao.janela = cbJanela.SelectedIndex + 1;
            movimentacao.insereMovimentacao();
            this.Close();
        }
        private void btnLancarAeB_Click(object sender, EventArgs e)
        {
            movimentacao.tipoMovimentacao = "S";
            movimentacao.valorMovimentacao = +Convert.ToSingle(txtValorAeB.Text);
            if (btnRestauranteClicado == true)
            {
                btnRestaurante.Text.Trim();
                int tamBtnRestaurante = btnRestaurante.Text.Length;
                movimentacao.descricaoMovimentacao = btnRestaurante.Text.Insert(tamBtnRestaurante, txtDescAeB.Text);
            }
            else if (btnFrigobarClicado == true)
            {
                btnFrigobar.Text.Trim();
                int tamBtnFrigobar = btnFrigobar.Text.Length;
                movimentacao.descricaoMovimentacao = btnFrigobar.Text.Insert(tamBtnFrigobar, txtDescAeB.Text);
            }
            movimentacao.dataMovimentacao = DateTime.Now;
            movimentacao.idReserva = idReserva;
            movimentacao.idHospede = idHospede;
            movimentacao.janela = cbJanelaAeB.SelectedIndex + 1;
            movimentacao.insereMovimentacao();
            this.Close();
        }

        public void pegaIdReservaIdHospede(int idReserva, int IdHospede)
        {
            this.idReserva = idReserva;
            this.idHospede = IdHospede;
        }

        private void Lancamento_Load(object sender, EventArgs e)
        {
            txtIdHospede.Text = this.idHospede.ToString();
            txtReserva.Text = this.idReserva.ToString();
        }


    }
}
