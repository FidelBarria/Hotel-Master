using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel_Master.Model;

namespace Hotel_Master
{
    public partial class HotelMaster : Form
    {
        public HotelMaster()
        {
            
            InitializeComponent();
            menuSuperior.Visible = true;
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        public void pegaUsuarioLogado(string usuario, string permissao, int id)
        {
           lblUsuario.Text = usuario;
           lblNivelPermissao.Text = permissao;
           lblId.Text = Convert.ToString(id);

            if (lblNivelPermissao.Text == "Administrador")
            {
                menuManutencaoUsuario.Enabled = true;
            }else if (lblNivelPermissao.Text == "Supervisor")
            {
                menuManutencaoUsuario.Enabled = false;
            }else if (lblNivelPermissao.Text == "Linha")
            {
                menuManutencaoUsuario.Enabled = false;
            }
        }

        private void HotelMaster_Load(object sender, EventArgs e)
        {
            
        }

        private void menuDesloga_Click(object sender, EventArgs e)
        {
            new TelaDeLogin().ShowDialog();
            this.Dispose();
        }

        private void HotelMaster_FormClosing(object sender, FormClosingEventArgs e)
        {
           Application.Exit();
        }

        private void novoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManutencaoDeUsuario manutecaoDeUsuario = new ManutencaoDeUsuario();
            manutecaoDeUsuario.MdiParent = this;
            manutecaoDeUsuario.Show();
        }

        private void menuTrocarSenha_Click(object sender, EventArgs e)
        {
            TrocaDeSenha trocaDeSenha = new TrocaDeSenha();
            trocaDeSenha.pegaUsuario(lblUsuario.Text, lblId.Text);
            trocaDeSenha.MdiParent = this;
            trocaDeSenha.Show();
        }

        private void btnGovernanca_Click(object sender, EventArgs e)
        {
            TelaDeGovernanca telaDeGovernanca = new TelaDeGovernanca();
            telaDeGovernanca.MdiParent = this;
            var telaDeGovernancaAberto = Application.OpenForms.OfType<TelaDeGovernanca>().FirstOrDefault();
            if (telaDeGovernancaAberto == null)
            {
                telaDeGovernanca.Show();
            }else telaDeGovernanca.Hide();
            
        }

        private void btnNovaReserva_Click(object sender, EventArgs e)
        {
            NovaReserva novaReserva = new NovaReserva();
            novaReserva.modoCriaouEdita("CRIA");
            novaReserva.MdiParent = this;
            novaReserva.Show();
        }

        private void btnBuscaReserva_Click(object sender, EventArgs e)
        {
            ProcuraReserva procuraReserva = new ProcuraReserva();
            procuraReserva.MdiParent = this;
            procuraReserva.Show();
        }

    }
}
