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
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        this.id = reader.GetInt32(0);
                        this.nome = reader.GetString(1);
                        this.email = reader.GetString(2);
                        this.telefone = reader.GetString(3);
                        this.cpf = reader.GetString(4);
                        this.senha = reader.GetString(5);
                        this.usuario = reader.GetString(6);
                        this.permissao = reader.GetString(7);
                        this.usuarioLogado = true;
                    }
                    return true;
                }
                reader.Close();
                conexao.Desconectar(cmd.Connection);
                //return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return false;
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

        public void alteraSenhaUsuario(int id, string senha)
        {
            string alteraSql = "UPDATE usuario SET senha_usuario = @senha WHERE idusuario = @id";
            try
            {
                Conecta conexao = new Conecta();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = alteraSql;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Prepare();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Senha alterada com sucesso!");
                }
                conexao.Desconectar(cmd.Connection);
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

        public bool validaCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }
    }   
}    
