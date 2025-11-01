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
    internal class Movimentacao
    {
        public int idMovimentacao { get; set; }
        public string tipoMovimentacao { get; set; }
        public DateTime dataMovimentacao { get; set; }
        public double valorMovimentacao { get; set; }
        public string descricaoMovimentacao { get; set; }
        public int idReserva { get; set; }
        public int idHospede { get; set; }
        public int janela { get; set; }

        public void insereMovimentacao()
        {
            string sql = "INSERT INTO movimentacao (tipomovimentacao, datamovimentacao, valormovimentacao," +
                " descricaomovimentacao, idreserva, idhospede, janela) " +
                "VALUES (@tipomovimentacao, @datamovimentacao, @valormovimentacao, @descricaomovimentacao," +
                "@idreserva, @idhospede, @janela)";
            Conecta conexao = new Conecta();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@tipomovimentacao", this.tipoMovimentacao);
                cmd.Parameters.AddWithValue("@datamovimentacao", this.dataMovimentacao);
                cmd.Parameters.AddWithValue("@valormovimentacao", this.valorMovimentacao);
                cmd.Parameters.AddWithValue("@descricaomovimentacao", this.descricaoMovimentacao);
                cmd.Parameters.AddWithValue("@idreserva", this.idReserva);
                cmd.Parameters.AddWithValue("@idHospede", this.idHospede);
                cmd.Parameters.AddWithValue("@janela", this.janela);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                conexao.Desconectar(conexao.Conectar());
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable procuraMovimentacao(int idReserva)
        {
            string sql = "SELECT idmovimentacao, datamovimentacao, descricaomovimentacao, valormovimentacao, janela FROM movimentacao WHERE idreserva = @idreserva";

            Conecta conexao = new Conecta();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("idreserva", idReserva);
                cmd.Prepare();
                da.Fill(dt);
                return dt;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public void alteraMovimentacao()
        {
            string sql = "UPDATE movimentacao SET janela = @janela WHERE idmovimentacao = @idmovimentacao";

            try
            {
                Conecta conexao = new Conecta();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@janela", this.janela);
                cmd.Parameters.AddWithValue("@idmovimentacao", this.idMovimentacao);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                conexao.Desconectar(conexao.Conectar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
