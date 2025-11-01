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
    internal class Tarifa
    {
        public int idTarifa { get; set; }
        public string tarifa { get; set; }
        public double valorTarifa { get; set; }
        public double desconto { get; set; }
        public string observacao { get; set; }

        public Tarifa() { }

        public DataTable procuraTarifa()
        {
            string sql = "SELECT * FROM tarifa";

            try
            {
                Conecta conexao = new Conecta();
                MySqlCommand cmd = new MySqlCommand(sql, conexao.Conectar());
                cmd.Prepare();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public void procuraTarifaId(int idtarifa)
        {
            string sql = "SELECT * FROM tarifa WHERE idtarifa = @idtarifa";
            try
            {
                Conecta conexao = new Conecta();
                MySqlCommand cmd = new MySqlCommand(sql, conexao.Conectar());
                cmd.Parameters.AddWithValue("idtarifa", idtarifa);
                cmd.Prepare();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    this.idTarifa = reader.GetInt32("idtarifa");
                    this.tarifa = reader.GetString("tarifa");
                    this.valorTarifa = reader.GetDouble("valor");
                    this.desconto = reader.GetDouble("desconto");
                    this.observacao = reader.GetString("observacao");
                }

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
