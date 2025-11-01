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
    
    public partial class TelaDeLogin : Form
    {
        public TelaDeLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panCadastraUsuario_Paint(object sender, PaintEventArgs e)
        {

   
        }

        private void btnCadastraUsuario_Click(object sender, EventArgs e)
        {
           
            panCadastraUsuario.Visible = !panCadastraUsuario.Visible;

            if (panCadastraUsuario.Visible)
            {
                this.MinimumSize = new Size(400, 650);
            }
            else
            {
                this.MaximumSize = new Size(400, 400);
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            if (txtUsuario.Text != "" && txtSenha.Text != "")
            {
                usuario.usuario = txtUsuario.Text;
                usuario.senha = txtSenha.Text;
                bool logado = usuario.logaUsuario(usuario.usuario, usuario.senha);
                if (logado == true)
                {
                    MessageBox.Show("Login realizado com sucesso!");
                    HotelMaster hotelMaster = new HotelMaster();
                    hotelMaster.pegaUsuarioLogado(usuario.usuario, usuario.permissao, usuario.id);
                    hotelMaster.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos!" + logado);
                }
            } else MessageBox.Show("Preencha todos os campos!");


        }

        private void btnCadastra_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.usuario = txtNovoUsuario.Text;
            usuario.nome = txtNomeUsuario.Text;
            usuario.email = txtEmail.Text;
            usuario.telefone = txtTelefone.Text;
            usuario.cpf = txtCpf.Text;
            usuario.senha = txtSenhaUsuario.Text;

            if (lblValidaCpf.Text == "CPF Válido" && txtTelefone.Text.Length == 15 )
            {
                usuario.insereUsuario(usuario.nome, usuario.email, usuario.telefone, usuario.cpf, usuario.senha, usuario.usuario, "Linha");
            }else MessageBox.Show("Algo esta errado favor verificar!");


            panCadastraUsuario.Visible = !panCadastraUsuario.Visible;
            this.MaximumSize = new Size(400, 400);
            txtNovoUsuario.Clear();
            txtNomeUsuario.Clear();
            txtSenhaUsuario.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtCpf.Clear();
            
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }

        private void TelaDeLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            if (usuario.validaCpf(txtCpf.Text))
            {
                lblValidaCpf.ForeColor = Color.Green;
                lblValidaCpf.Text = "CPF Válido";
            }
            else
            {
                lblValidaCpf.ForeColor = Color.Red;
                lblValidaCpf.Text = "CPF Invalido";
            }
        }
    }
}
