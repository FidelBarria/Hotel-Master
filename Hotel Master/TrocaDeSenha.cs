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
    public partial class TrocaDeSenha : Form
    {
        public TrocaDeSenha()
        {
            InitializeComponent();
        }
        string txtUsuario;
        int lblId;
        public void pegaUsuario(string usuario, string id)
        {
            txtUsuario = usuario;
            lblId = Convert.ToInt32(id);
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            HotelMaster hotelMaster = new HotelMaster();
            if (usuario.logaUsuario(txtUsuario, txtSenhaAnterior.Text))
            {

                if (txtNovaSenha.Text == txtRepetirSenha.Text)
                {
                    
                    usuario.senha = txtNovaSenha.Text;
                    usuario.alteraSenhaUsuario(lblId, txtNovaSenha.Text);
                    MessageBox.Show("Senha alterada com sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("As senhas não conferem!");
                }
            }
            else
            {
                MessageBox.Show("Senha anterior incorreta!");

            }
        }
    }
}
