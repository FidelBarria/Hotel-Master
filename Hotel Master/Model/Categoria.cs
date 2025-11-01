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
    internal class Categoria
    {

        public int idCategoria { get; set; }
        public string categoria { get; set; }
        public string tipoDeCama { get; set; }
        public string qtdCama { get; set; }

        public DataTable procuraCategoria()
        {
            string sql = "SELECT * FROM categoria";

            try
            {
                Conecta conexa = new Conecta();
                MySqlCommand cmd = new MySqlCommand(sql, conexa.Conectar());
                cmd.Prepare();
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
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
