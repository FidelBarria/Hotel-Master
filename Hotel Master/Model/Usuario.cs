using Hotel_Master.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Master.Model
{
    internal class Usuario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string cpf { get; set; }
        public string senha { get; set; }
        public string usuario { get; set; }
        public string permissao { get; set; }
        public bool usuarioLogado { get; set; } = false;

        public Usuario()
        {

        }

        public Boolean logaUsuario(string usuario, string senha)
        {
            // Lógica para validar o login do usuário no banco de dados
            string consultaSql = "SELECT * FROM usuario WHERE usuario = @usuario AND senha_usuario = @senha";
            try
            {
                Conecta conexao = new Conecta();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = consultaSql;
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Prepare();
                MySqlDataReader reader = cmd.ExecuteReader();
                bool usuarioValido = reader.HasRows;
                this.usuarioLogado = usuarioValido;
                reader.Close();
                conexao.Desconectar(cmd.Connection);
                return this.usuarioLogado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return this.usuarioLogado;
            }
        }

        public object verificaUsuarioLogado(string usuario)
        {
            // List<Usuario> listUsuario = new List<Usuario>();
            string consultaSql = "SELECT usuario FROM usuario WHERE usuario = @usuario";

            try
            {
                Conecta conexao = new Conecta();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = consultaSql;
                cmd.Parameters.AddWithValue("@usuario", this.usuario);
                cmd.Prepare();
                object usuarioLogado = cmd.ExecuteScalar();
                conexao.Desconectar(cmd.Connection);
                return usuarioLogado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return usuarioLogado;
            }
        }

        public void insereUsuario(string nome, string email, string telefone, string cpf, string senha, string usuario, string permissao)
        {
            // Lógica para inserir o usuário no banco de dados
            string insereSql = "INSERT INTO " +
                "usuario (nome_usuario, email_usuario, telefone_usuario, cpf_usuario, senha_usuario, usuario, permissao) " +
                "VALUES (@nome, @email, @telefone, @cpf, @senha, @usuario, @permissao)";

            try
            {
                if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(telefone)
                    && !string.IsNullOrEmpty(cpf) && !string.IsNullOrEmpty(senha) && !string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(permissao))
                {
                    Conecta conexao = new Conecta();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conexao.Conectar();
                    cmd.CommandText = insereSql;
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@telefone", telefone);
                    cmd.Parameters.AddWithValue("@cpf", cpf);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@permissao", permissao);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    conexao.Desconectar(cmd.Connection);
                    MessageBox.Show("Usuário cadastrado com sucesso!");

                }
                else
                {
                    MessageBox.Show("Todos os campos marcados com * são Obrigatorios, favor verificar e preencher todos os campos.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public DataTable procuraUsuario(string parametro)
        {
            string consultaSql = "SELECT * FROM usuario WHERE usuario LIKE @parametro OR cpf_usuario LIKE @parametro";
            DataTable dataTable = new DataTable();
            try
            {
                Conecta conexao = new Conecta();
                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand(consultaSql);
                cmd.Connection = conexao.Conectar();
                cmd.Parameters.AddWithValue("@parametro", "%" + parametro + "%");
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                conexao.Desconectar(adapter.SelectCommand.Connection);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;


        }

        public void editaUsuario(int id, string nome, string email, string telefone, string cpf, string senha, string usuario, string permissao)
        {
            string editaSql = "UPDATE usuario SET nome_usuario = @nome, email_usuario = @email, telefone_usuario = @telefone, " +
                "cpf_usuario = @cpf, senha_usuario = @senha, usuario = @usuario, permissao = @permissao WHERE idusuario = @id";
            try
            {
                Conecta conexao = new Conecta();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = editaSql;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@permissao", permissao);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                conexao.Desconectar(cmd.Connection);
                MessageBox.Show("Alterado com sucesso!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public void excluiUsuario(int id)
        {
            string excluiSql = "DELETE FROM usuario WHERE idusuario = @id";
            try
            {
                Conecta conexao = new Conecta();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = excluiSql;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                conexao.Desconectar(cmd.Connection);
                MessageBox.Show("Usuário excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }    
}
