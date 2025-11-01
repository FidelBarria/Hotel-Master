using Hotel_Master.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_Master.Model
{
    
    internal class Quarto
    {
        public int idquarto { get; set; }
        public string categoria { get; set; }
        public string statusUh { get; set; }
        public string statusGovernanca { get; set; }
        public string observacao { get; set; }
        public string quarto { get; set; }

        public Quarto()
        {
            idquarto = 0;
            categoria = "";
            statusUh = "";
            statusGovernanca = "";
            observacao = "";
            quarto = "";
        }       

        public Quarto(int idquarto, string categoria, string statusUh, string statusGovernanca, string observacao, string quarto)
        {
            this.idquarto = idquarto;
            this.categoria = categoria;
            this.statusUh = statusUh;
            this.statusGovernanca = statusGovernanca;
            this.observacao = observacao;
            this.quarto = quarto;
        }

        public DataTable procuraQuarto()
        {
            string sql = "SELECT * FROM quarto";
            try
            {
                Conecta conexao = new Conecta();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conexao.Conectar());
                DataTable dt = new DataTable();
                da.Fill(dt);
                conexao.Desconectar(conexao.Conectar());
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar quarto: " + ex.Message);
            }

        }

        public void mudaStatusGovernanca(int idquarto, string statusGovernanca)
        {
            string sql = "UPDATE quarto SET statusGovernanca = @statusGovernanca WHERE idquarto = @idquarto";
            try
            {
                Conecta conexao = new Conecta();
                MySqlCommand cmd = new MySqlCommand(sql, conexao.Conectar());
                cmd.Parameters.AddWithValue("@statusGovernanca", statusGovernanca);
                cmd.Parameters.AddWithValue("@idquarto", idquarto);
                cmd.ExecuteNonQuery();
                conexao.Desconectar(conexao.Conectar());
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar status da governança: " + ex.Message);
            }
        }

        public void mudaObservacao(int idquarto, string observacao)
        {
            string sql = "UPDATE quarto SET observacao = @observacao WHERE idquarto = @idquarto";
            try
            {
                Conecta conexao = new Conecta();
                MySqlCommand cmd = new MySqlCommand(sql, conexao.Conectar());
                cmd.Parameters.AddWithValue("@observacao", observacao);
                cmd.Parameters.AddWithValue("@idquarto", idquarto);
                cmd.ExecuteNonQuery();
                conexao.Desconectar(conexao.Conectar());
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar observação: " + ex.Message);
            }
        }
    }
}
