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
    
    internal class StatusReserva
    {
        public int idStatusReserva { get; set; }
        public string statusReserva { get; set; }

        public DataTable procuraStatusReserva()
        {
            string sql = "SELECT * FROM statusreserva";

            try
            {
                Conecta conexao = new Conecta();
                MySqlCommand cmd = new MySqlCommand();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = sql;
                cmd.Prepare();
                da.Fill(dt);
                conexao.Desconectar(conexao.Conectar());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
    }
}
