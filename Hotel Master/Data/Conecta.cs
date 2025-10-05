using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotel_Master.Data
{
    internal class Conecta
    {
        string conSql = "server=localhost; uid=root; pwd=Fidelito,10; database=dbhotelmaster";

        public MySqlConnection Conectar()
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(conSql);
                conexao.Open();
                return conexao;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message);
                return null;
            }

        }
        public void Desconectar(MySqlConnection conexao)
        {
            if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}
