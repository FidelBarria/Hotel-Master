using Hotel_Master.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Master.Model
{
    internal class Hospede
    {
        public int idHospede { get; set; }
        public string hospede { get; set; }
        public string cpf { get; set; }
        public DateTime dataDeNascimento { get; set; }
        public string idade { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string cep { get; set; }
        public string endereco { get; set; }
        public string estrangeiro { get; set; }
        public string observacao { get; set; }

        public Hospede()
        {
        }

        public void procuraHospede(string cpf)
        {
            string sql = "SELECT * from hospede WHERE cpf = @cpf";
            try
            {

                Conecta conexao = new Conecta();
                MySqlCommand cmd = new MySqlCommand(sql, conexao.Conectar());
                cmd.Parameters.AddWithValue("cpf", cpf);
                cmd.Prepare();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    this.idHospede = reader.GetInt32("idhospede");
                    this.hospede = reader.GetString("hospede");
                    this.cpf = reader.GetString("cpf");
                    this.email = reader.GetString("email");
                    this.telefone = reader.GetString("telefone");
                }
                
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public void insereHospede()
        {
            string sql = "INSERT INTO hospede (hospede, cpf, datadenascimento, idade, telefone, email, cep, endereco, estrangeiro, observacao)" +
                "VALUES (@hospede, @cpf, @datadenascimento, @idade, @telefone, @email, @cep, @endereco, @estrangeiro, @observacao)";
            try
            {
                Conecta conexao = new Conecta();
                MySqlCommand cmd = new MySqlCommand(sql, conexao.Conectar());
                cmd.Parameters.AddWithValue("hospede", this.hospede);
                cmd.Parameters.AddWithValue("cpf", this.cpf);
                cmd.Parameters.AddWithValue("datadenascimento", this.dataDeNascimento);
                cmd.Parameters.AddWithValue("idade", this.idade);
                cmd.Parameters.AddWithValue("telefone", this.telefone);
                cmd.Parameters.AddWithValue("email", this.email);
                cmd.Parameters.AddWithValue("cep", this.cep);
                cmd.Parameters.AddWithValue("endereco", this.endereco);
                cmd.Parameters.AddWithValue("estrangeiro", this.estrangeiro);
                cmd.Parameters.AddWithValue("observacao", this.observacao);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                conexao.Desconectar(conexao.Conectar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
