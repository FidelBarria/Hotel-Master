using Hotel_Master.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Master
{
    public partial class ManutencaoDeUsuario : Form
    {
        public ManutencaoDeUsuario()
        {
            InitializeComponent();
            Usuario usuario = new Usuario();
            dtgUsuario.DataSource = usuario.procuraUsuario(txtPesquisa.Text);
            dtgUsuario.Columns["idusuario"].HeaderText = "Id";
            dtgUsuario.Columns["nome_usuario"].HeaderText = "Nome";
            dtgUsuario.Columns["email_usuario"].HeaderText = "email";
            dtgUsuario.Columns["email_usuario"].Width = 150;
            dtgUsuario.Columns["telefone_usuario"].HeaderText = "Telefone";
            dtgUsuario.Columns["cpf_usuario"].HeaderText = "CPF";
            dtgUsuario.Columns["senha_usuario"].HeaderText = "Senha";
            dtgUsuario.Columns["usuario"].HeaderText = "Usuario";
            dtgUsuario.Columns["permissao"].HeaderText = "Permissão";
            dtgUsuario.Columns["idusuario"].Visible = false ;
            dtgUsuario.Columns["senha_usuario"].Visible = false;
        }

        private void ManutencaoDeUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            panDados.Enabled = !panDados.Enabled;
            btnEditaUsuario.Enabled = !btnEditaUsuario.Enabled;
            btnExcluiUsuario.Enabled = !btnExcluiUsuario.Enabled;

            txtId.Clear();
            txtCpf.Clear();
            txtEmail.Clear();
            txtNome.Clear();
            txtSenha.Clear();
            txtTelefone.Clear();
            txtUsuario.Clear();
            radAdmin.Checked = false;
            radSupervisor.Checked = false;
            radLinha.Checked = false;

            if (panDados.Enabled == false)
            {
                btnNovoUsuario.Text = "Novo Usuário";
            }
            else
            {
                btnNovoUsuario.Text = "Cancela";
            }
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {


            if (btnNovoUsuario.Enabled == true && btnEditaUsuario.Enabled == false && btnExcluiUsuario.Enabled == false)
            {
                panDados.Enabled = true;
                Usuario usuario = new Usuario();
                usuario.usuario = txtUsuario.Text;
                usuario.nome = txtNome.Text;
                usuario.email = txtEmail.Text;
                usuario.telefone = txtTelefone.Text;
                usuario.cpf = txtCpf.Text;
                usuario.senha = txtSenha.Text;
                usuario.permissao = radAdmin.Checked ? "Administrador" : radSupervisor.Checked ? "Supervisor" : radLinha.Checked ? "Linha" : "";
                usuario.insereUsuario(usuario.nome, usuario.email, usuario.telefone, usuario.cpf, usuario.senha, usuario.usuario, usuario.permissao);
            } else if (btnEditaUsuario.Enabled == true && btnNovoUsuario.Enabled == false && btnExcluiUsuario.Enabled == false)
            {
                panDados.Enabled = true;
                Usuario usuario = new Usuario();
                usuario.id = Convert.ToInt32(txtId.Text);
                usuario.usuario = txtUsuario.Text;
                usuario.nome = txtNome.Text;
                usuario.email = txtEmail.Text;
                usuario.telefone = txtTelefone.Text;
                usuario.cpf = txtCpf.Text;
                usuario.senha = txtSenha.Text;
                usuario.permissao = radAdmin.Checked ? "Administrador" : radSupervisor.Checked ? "Supervisor" : radLinha.Checked ? "Linha" : "";
                usuario.editaUsuario(usuario.id, usuario.nome, usuario.email, usuario.telefone, usuario.cpf, usuario.senha, usuario.usuario, usuario.permissao);
            } else if (btnEditaUsuario.Enabled == false && btnNovoUsuario.Enabled == false && btnExcluiUsuario.Enabled == true)
            {
                Usuario usuario = new Usuario();
                usuario.id = Convert.ToInt32(txtId.Text);
                usuario.excluiUsuario(usuario.id);
            } else panDados.Enabled = false;

            txtNome.Clear();
            txtUsuario.Clear();
            txtSenha.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtCpf.Clear();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            dtgUsuario.DataSource = usuario.procuraUsuario(txtPesquisa.Text);
        }

        private void btnEditaUsuario_Click(object sender, EventArgs e)
        {
            panDados.Enabled = !panDados.Enabled;
            btnNovoUsuario.Enabled = !btnNovoUsuario.Enabled;
            btnExcluiUsuario.Enabled = !btnExcluiUsuario.Enabled;

            if (panDados.Enabled == false)
            {
                btnEditaUsuario.Text = "Edita Usuário";
            }
            else
            {
                btnEditaUsuario.Text = "Cancela";
            }

        }

        private void dtgUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtgUsuario.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dtgUsuario.CurrentRow.Cells[1].Value.ToString();
            txtEmail.Text = dtgUsuario.CurrentRow.Cells[2].Value.ToString();
            txtTelefone.Text = dtgUsuario.CurrentRow.Cells[3].Value.ToString();
            txtCpf.Text = dtgUsuario.CurrentRow.Cells[4].Value.ToString();
            txtSenha.Text = dtgUsuario.CurrentRow.Cells[5].Value.ToString();
            txtUsuario.Text = dtgUsuario.CurrentRow.Cells[6].Value.ToString();
            if (dtgUsuario.CurrentRow.Cells[7].Value.ToString() == "Administrador")
            {
                radAdmin.Checked = true;
            }
            else if (dtgUsuario.CurrentRow.Cells[7].Value.ToString() == "Supervisor")
            {
                radSupervisor.Checked = true;
            }
            else if (dtgUsuario.CurrentRow.Cells[7].Value.ToString() == "Linha")
            {
                radLinha.Checked = true;
            }
        }

        private void btnExcluiUsuario_Click(object sender, EventArgs e)
        {
            panDados.Enabled = !panDados.Enabled;
            btnNovoUsuario.Enabled = !btnNovoUsuario.Enabled;
            btnEditaUsuario.Enabled = !btnEditaUsuario.Enabled;
            if (panDados.Enabled == false)
            {
                btnExcluiUsuario.Text = "Exclui Usuário";
            }
            else
            {
                btnExcluiUsuario.Text = "Cancela";
            }
        }
    }
}
