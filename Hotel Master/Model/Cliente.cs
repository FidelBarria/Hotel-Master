using Hotel_Master.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Master.Model
{
    internal class Cliente
    {
        public int idCliente { get; set; }
        public string cliente { get; set; }
        public string cnpj { get; set; }
        public string endereco { get; set; }
        public string contato { get; set; }
        public string telefone { get; set; }

        public Cliente()
        {
        }

        public void procuraCliente(string cliente)
        {
            string sql = "SELECT * FROM cliente WHERE cliente LIKE @cliente OR cnpj LIKE @cliente";
            try
            {
                Conecta conexao = new Conecta();
                MySqlCommand cmd = new MySqlCommand(sql, conexao.Conectar());
                cmd.Parameters.AddWithValue("@cliente", cliente);
                cmd.Prepare();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    this.idCliente = reader.GetInt32("idcliente");
                    this.cliente = reader.GetString("cliente");
                    this.cnpj = reader.GetString("cnpj");
                    MessageBox.Show(reader.GetString("cliente"));
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
