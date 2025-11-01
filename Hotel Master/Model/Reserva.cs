using Google.Protobuf.WellKnownTypes;
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
    internal class Reserva
    {

        public int idReserva { get; set; }
        public int categoria { get; set; }
        public DateTime? checkin { get; set; }
        public DateTime? checkout { get; set; }
        public int qtdDiarias { get; set; }
        public int qtdHospede { get; set; }
        public int hospede1 { get; set; }
        public int hospede2 { get; set; }
        public int cliente { get; set; }
        public double valorDiaria { get; set; }
        public double valorTotal { get; set; }
        public string garantia { get; set; }
        public string docGarantia { get; set; }
        public int statusReserva { get; set; }
        public string observacao { get; set; }

        public void insereReserva()
        {
            string sqlHospede1 = "INSERT INTO reserva (categoria, checkin, checkout, qtddiarias, qtdhospede, hospede1, hospede2, cliente, valordiaria, valortotal," +
                "garantia, docgarantia, statusreserva, observacao) " +
                "values (@categoria, @checkin, @checkout, @qtddiarias, @qtdhospede, @hospede1, @hospede2, @cliente, @valordiaria, @valortotal, " +
                "@garantia, @docgarantia, @statusreserva, @observacao)";

            string sqlHospede2 = "INSERT INTO reserva (categoria, checkin, checkout, qtddiarias, qtdhospede, hospede1, cliente, valordiaria, valortotal," +
                "garantia, docgarantia, statusreserva, observacao) " +
                "values (@categoria, @checkin, @checkout, @qtddiarias, @qtdhospede, @hospede1, @cliente, @valordiaria, @valortotal, " +
                "@garantia, @docgarantia, @statusreserva, @observacao)";
            if (this.hospede1 > 0 && this.hospede2 > 0)
            {
                try
                {
                    Conecta conexao = new Conecta();
                    MySqlCommand cmd = new MySqlCommand(sqlHospede1, conexao.Conectar());
                    cmd.Parameters.AddWithValue("categoria", this.categoria);
                    cmd.Parameters.AddWithValue("checkin", this.checkin);
                    cmd.Parameters.AddWithValue("checkout", this.checkout);
                    cmd.Parameters.AddWithValue("qtddiarias", this.qtdDiarias);
                    cmd.Parameters.AddWithValue("qtdhospede", this.qtdHospede);
                    cmd.Parameters.AddWithValue("hospede1", this.hospede1);
                    cmd.Parameters.AddWithValue("hospede2", this.hospede2);
                    cmd.Parameters.AddWithValue("cliente", this.cliente);
                    cmd.Parameters.AddWithValue("valordiaria", this.valorDiaria);
                    cmd.Parameters.AddWithValue("valortotal", this.valorTotal);
                    cmd.Parameters.AddWithValue("garantia", this.garantia);
                    cmd.Parameters.AddWithValue("docgarantia", this.docGarantia);
                    cmd.Parameters.AddWithValue("statusreserva", this.statusReserva);
                    cmd.Parameters.AddWithValue("observacao", this.observacao);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    conexao.Desconectar(conexao.Conectar());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }else
            {
                try
                {
                    Conecta conexao = new Conecta();
                    MySqlCommand cmd = new MySqlCommand(sqlHospede2, conexao.Conectar());
                    cmd.Parameters.AddWithValue("categoria", this.categoria);
                    cmd.Parameters.AddWithValue("checkin", this.checkin);
                    cmd.Parameters.AddWithValue("checkout", this.checkout);
                    cmd.Parameters.AddWithValue("qtddiarias", this.qtdDiarias);
                    cmd.Parameters.AddWithValue("qtdhospede", this.qtdHospede);
                    cmd.Parameters.AddWithValue("hospede1", this.hospede1);
                    cmd.Parameters.AddWithValue("cliente", this.cliente);
                    cmd.Parameters.AddWithValue("valordiaria", this.valorDiaria);
                    cmd.Parameters.AddWithValue("valortotal", this.valorTotal);
                    cmd.Parameters.AddWithValue("garantia", this.garantia);
                    cmd.Parameters.AddWithValue("docgarantia", this.docGarantia);
                    cmd.Parameters.AddWithValue("statusreserva", this.statusReserva);
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

        public DataTable procuraReserva()
        {
            var sqlFinal = new StringBuilder();
            string filtro = string.Empty;
            string sql = "Select reserva.idreserva, reserva.checkin, reserva.checkout, reserva.qtdhospede, reserva.valordiaria, " +
                "reserva.valortotal, reserva.docgarantia, reserva.observacao, categoria.categoria, A.*, B.*, statusreserva.statusreserva, cliente.* " +
                "from reserva " +
                "inner JOIN categoria on reserva.categoria = categoria.idcategoria " +
                "left JOIN hospede A on reserva.hospede1 = A.idhospede or reserva.hospede1 = null " +
                "left JOIN hospede B on reserva.hospede2 = B.idhospede or reserva.hospede2 = null " +
                "INNER JOIN statusreserva on reserva.statusreserva = statusreserva.idstatusreserva " +
                "INNER JOIN cliente on reserva.cliente = cliente.idcliente";
            Conecta conexao = new Conecta();
            try
            {
                
                MySqlCommand cmd = new MySqlCommand();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                if (this.checkin != null && this.categoria != 0 && this.checkout == null && this.idReserva == 0 && this.statusReserva == 0)
                {
                    filtro = " WHERE reserva.checkin = @checkin AND reserva.categoria = @categoria";
                    cmd.Connection = conexao.Conectar();
                    sqlFinal.Append(sql + filtro);
                    cmd.CommandText = sqlFinal.ToString();
                    cmd.Parameters.AddWithValue("checkin", this.checkin);
                    cmd.Parameters.AddWithValue("categoria", this.categoria);
                    cmd.Prepare();
                    da.Fill(dt);
                }
                else if (this.checkin == null && this.categoria != 0 && this.checkout != null && this.idReserva == 0 && this.statusReserva == 0)
                {
                    filtro = " WHERE reserva.categoria = @categoria AND reserva.checkout = @checkout";
                    cmd.Connection = conexao.Conectar();
                    sqlFinal.Append(sql + filtro);
                    cmd.CommandText = sqlFinal.ToString();
                    cmd.Parameters.AddWithValue("checkout", this.checkout);
                    cmd.Parameters.AddWithValue("categoria", this.categoria);
                    cmd.Prepare();
                    da.Fill(dt);
                }
                else if (this.checkin == null && this.categoria != 0 && this.checkout == null && this.idReserva != 0 && this.statusReserva == 0)
                {
                    filtro = " WHERE reserva.categoria = @categoria AND reserva.idreserva = @idreserva";
                    cmd.Connection = conexao.Conectar();
                    sqlFinal.Append(sql + filtro);
                    cmd.CommandText = sqlFinal.ToString();
                    cmd.Parameters.AddWithValue("idreserva", this.idReserva);
                    cmd.Parameters.AddWithValue("categoria", this.categoria);
                    cmd.Prepare();
                    da.Fill(dt);
                }
                else if (this.checkin != null && this.categoria != 0 && this.checkout != null && this.idReserva == 0 && this.statusReserva == 0)
                {
                    filtro = " WHERE reserva.checkin = @checkin AND reserva.categoria = @categoria AND reserva.checkout = @checkout";
                    cmd.Connection = conexao.Conectar();
                    sqlFinal.Append(sql + filtro);
                    cmd.CommandText = sqlFinal.ToString();
                    cmd.Parameters.AddWithValue("checkin", this.checkin);
                    cmd.Parameters.AddWithValue("checkout", this.checkout);
                    cmd.Parameters.AddWithValue("categoria", this.categoria);
                    cmd.Prepare();
                    da.Fill(dt);
                }
                else if (this.checkin != null && this.categoria != 0 && this.checkout == null && this.idReserva == 0 && this.statusReserva != 0)
                {
                    filtro = " WHERE reserva.checkin = @checkin AND reserva.categoria = @categoria " +
                        "AND reserva.statusreserva = @statusreserva";
                    cmd.Connection = conexao.Conectar();
                    sqlFinal.Append(sql + filtro);
                    cmd.CommandText = sqlFinal.ToString();
                    cmd.Parameters.AddWithValue("checkin", this.checkin);
                    cmd.Parameters.AddWithValue("statusreserva", this.statusReserva);
                    cmd.Parameters.AddWithValue("categoria", this.categoria);
                    cmd.Prepare();
                    da.Fill(dt);
                }
                else if (this.checkin != null && this.categoria != 0 && this.checkout != null && this.idReserva == 0 && this.statusReserva != 0)
                {
                    filtro = " WHERE reserva.checkin = @checkin AND reserva.categoria = @categoria ANd reserva.checkout = @checkout " +
                        "AND reserva.statusreserva = @statusreserva";
                    cmd.Connection = conexao.Conectar();
                    sqlFinal.Append(sql + filtro);
                    cmd.CommandText = sqlFinal.ToString();
                    cmd.Parameters.AddWithValue("checkin", this.checkin);
                    cmd.Parameters.AddWithValue("checkout", this.checkout);
                    cmd.Parameters.AddWithValue("statusreserva", this.statusReserva);
                    cmd.Parameters.AddWithValue("categoria", this.categoria);
                    cmd.Prepare();
                    da.Fill(dt);
                }
                else if (this.checkin != null && this.categoria != 0 && this.checkout != null && this.idReserva != 0 && this.statusReserva == 0)
                {
                    filtro = " WHERE reserva.checkin = @checkin AND reserva.categoria = @categoria AND reserva.checkout = @checkout " +
                        "AND reserva.idreserva = @idreserva";
                    cmd.Connection = conexao.Conectar();
                    sqlFinal.Append(sql + filtro);
                    cmd.CommandText = sqlFinal.ToString();
                    cmd.Parameters.AddWithValue("checkin", this.checkin);
                    cmd.Parameters.AddWithValue("checkout", this.checkout);
                    cmd.Parameters.AddWithValue("categoria", this.categoria);
                    cmd.Parameters.AddWithValue("idreserva", this.idReserva);
                    cmd.Prepare();
                    da.Fill(dt);
                }
                else if (this.checkin != null && this.categoria != 0 && this.checkout != null && this.idReserva != 0 && this.statusReserva != 0)
                {
                    filtro = " WHERE reserva.checkin = @checkin AND reserva.categoria = @categoria AND reserva.checkout = @checkout " +
                        "AND reserva.idreserva = @idreserva AND reserva.statusreserva = @statusreserva";
                    cmd.Connection = conexao.Conectar();
                    sqlFinal.Append(sql + filtro);
                    cmd.CommandText = sqlFinal.ToString();
                    cmd.Parameters.AddWithValue("checkin", this.checkin);
                    cmd.Parameters.AddWithValue("checkout", this.checkout);
                    cmd.Parameters.AddWithValue("categoria", this.categoria);
                    cmd.Parameters.AddWithValue("idreserva", this.idReserva);
                    cmd.Parameters.AddWithValue("statusreserva", this.statusReserva);
                    cmd.Prepare();
                    da.Fill(dt);
                }
                else if (this.checkin == null && this.categoria != 0 && this.checkout != null && this.idReserva != 0 && this.statusReserva == 0)
                {
                    filtro = " WHERE reserva.categoria = @categoria AND reserva.checkout = @checkout ";
                    cmd.Connection = conexao.Conectar();
                    sqlFinal.Append(sql + filtro);
                    cmd.CommandText = sqlFinal.ToString();
                    cmd.Parameters.AddWithValue("checkout", this.checkout);
                    cmd.Parameters.AddWithValue("categoria", this.categoria);
                    cmd.Prepare();
                    da.Fill(dt);
                }
                else if (this.checkin == null && this.categoria != 0 && this.checkout == null && this.idReserva != 0 && this.statusReserva == 0)
                {
                    filtro = " WHERE reserva.categoria = @categoria AND reserva.idreserva = @idreserva";
                    cmd.Connection = conexao.Conectar();
                    sqlFinal.Append(sql + filtro);
                    cmd.CommandText = sqlFinal.ToString();
                    cmd.Parameters.AddWithValue("categoria", this.categoria);
                    cmd.Parameters.AddWithValue("idreserva", this.idReserva);
                    cmd.Prepare();
                    da.Fill(dt);
                }
                else if (this.checkin != null && this.categoria == 0 && this.checkout == null && this.idReserva != 0 && this.statusReserva == 0)
                {
                    filtro = " WHERE reserva.checkin = @checkin AND reserva.idreserva = @idreserva";
                    cmd.Connection = conexao.Conectar();
                    sqlFinal.Append(sql + filtro);
                    cmd.CommandText = sqlFinal.ToString();
                    cmd.Parameters.AddWithValue("checkin", this.checkin);
                    cmd.Parameters.AddWithValue("idreserva", this.idReserva);
                    cmd.Prepare();
                    da.Fill(dt);
                }
                else if (this.checkin == null && this.categoria == 0 && this.checkout != null && this.idReserva != 0 && this.statusReserva == 0)
                {
                    filtro = " WHERE reserva.checkout = @checkout AND reserva.idreserva = @idreserva";
                    cmd.Connection = conexao.Conectar();
                    sqlFinal.Append(sql + filtro);
                    cmd.CommandText = sqlFinal.ToString();
                    cmd.Parameters.AddWithValue("checkout", this.checkout);
                    cmd.Parameters.AddWithValue("idreserva", this.idReserva);
                    cmd.Prepare();
                    da.Fill(dt);
                }else if (this.checkin != null && this.categoria == 0 && this.checkout != null && this.idReserva == 0 && this.statusReserva == 0)
                {
                    filtro = " WHERE reserva.checkin = @checkin AND reserva.checkout = @checkout ";
                    cmd.Connection = conexao.Conectar();
                    sqlFinal.Append(sql + filtro);
                    cmd.CommandText = sqlFinal.ToString();
                    cmd.Parameters.AddWithValue("checkin", this.checkin);
                    cmd.Parameters.AddWithValue("checkout", this.checkout);
                    cmd.Prepare();
                    da.Fill(dt);
                }
                else if (this.checkin != null && this.categoria == 0 && this.checkout == null && this.idReserva == 0 && this.statusReserva != 0)
                {
                    filtro = " WHERE reserva.checkin = @checkin AND reserva.statusreserva = @statusreserva";
                    cmd.Connection = conexao.Conectar();
                    sqlFinal.Append(sql + filtro);
                    cmd.CommandText = sqlFinal.ToString();
                    cmd.Parameters.AddWithValue("checkin", this.checkin);
                    cmd.Parameters.AddWithValue("statusreserva", this.statusReserva);
                    cmd.Prepare();
                    da.Fill(dt);
                }
                else if (this.checkin == null && this.categoria != 0 && this.checkout == null && this.idReserva == 0 && this.statusReserva != 0)
                {
                    filtro = " WHERE reserva.categoria = @categoria AND reserva.statusreserva = @statusreserva";
                    cmd.Connection = conexao.Conectar();
                    sqlFinal.Append(sql + filtro);
                    cmd.CommandText = sqlFinal.ToString();
                    cmd.Parameters.AddWithValue("categoria", this.categoria);
                    cmd.Parameters.AddWithValue("statusreserva", this.statusReserva);
                    cmd.Prepare();
                    da.Fill(dt);
                }
                else if (this.checkin == null && this.categoria == 0 && this.checkout != null && this.idReserva == 0 && this.statusReserva != 0)
                {
                    filtro = " WHERE reserva.checkout = @checkout AND reserva.statusreserva = @statusreserva";
                    cmd.Connection = conexao.Conectar();
                    sqlFinal.Append(sql + filtro);
                    cmd.CommandText = sqlFinal.ToString();
                    cmd.Parameters.AddWithValue("checkout", this.checkout);
                    cmd.Parameters.AddWithValue("statusreserva", this.statusReserva);
                    cmd.Prepare();
                    da.Fill(dt);
                }
                else if (this.checkin == null && this.categoria == 0 && this.checkout == null && this.idReserva != 0 && this.statusReserva != 0)
                {
                    filtro = " WHERE reserva.idreserva = @idreserva AND reserva.statusreserva = @statusreserva";
                    cmd.Connection = conexao.Conectar();
                    sqlFinal.Append(sql + filtro);
                    cmd.CommandText = sqlFinal.ToString();
                    cmd.Parameters.AddWithValue("idreserva", this.idReserva);
                    cmd.Parameters.AddWithValue("statusreserva", this.statusReserva);
                    cmd.Prepare();
                    da.Fill(dt);
                }
                else
                {
                    MessageBox.Show("Você precisa colocar pelo menos 2 filtros!!");
                }
                return dt;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Desconectar(conexao.Conectar());
            }
            return null;
        }

        public MySqlDataReader procuraReservaId(int idReserva)
        {
            string sql = "Select reserva.idreserva, reserva.checkin, reserva.checkout, reserva.qtdhospede, reserva.valordiaria, " +
              "reserva.valortotal, reserva.docgarantia, reserva.observacao, reserva.garantia, reserva.categoria as idcategoria, categoria.categoria, " +
              "A.idhospede as idhospede1, A.hospede as hospede1, A.cpf as cpf1, A.email as email1, A.telefone as telefone1, " +
              "B.idhospede as idhospede2, B.hospede as hospede2, B.cpf as cpf2, B.email as email2, B.telefone as telefone2, statusreserva.statusreserva, cliente.* " +
              "from reserva " +
              "inner JOIN categoria on reserva.categoria = categoria.idcategoria " +
              "left JOIN hospede A on reserva.hospede1 = A.idhospede or reserva.hospede1 = null " +
              "left JOIN hospede B on reserva.hospede2 = B.idhospede or reserva.hospede2 = null " +
              "INNER JOIN statusreserva on reserva.statusreserva = statusreserva.idstatusreserva " +
              "INNER JOIN cliente on reserva.cliente = cliente.idcliente WHERE reserva.idreserva = @idreserva";

            Conecta conexao = new Conecta();
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("idreserva", idReserva);
                cmd.Prepare();
                MySqlDataReader dr = cmd.ExecuteReader();
                conexao.Desconectar(conexao.Conectar());
                return dr;

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Desconectar(conexao.Conectar());
            }
            return null;

        }

        public void atualizaReserva(bool alteraReserva, bool alteraStatusReserva)
        {
            string sqlAlteraReserva = "UPDATE reserva SET categoria = @categoria, checkin = @checkin, checkout = @checkout, qtddiarias = @qtddiarias, " +
                "qtdhospede = @qtdhospede, hospede1 = @hospede1, hospede2 = @hospede2, cliente = @cliente, valordiaria = @valordiaria, valortotal = @valortotal," +
                "garantia = @garantia, docgarantia = @docgarantia, statusreserva = @statusreserva, observacao = @observacao WHERE idreserva = @idreserva";
            string sqlCancelaNoshowAtiva = "UPDATE reserva SET statusreserva = @statusreserva WHERE idreserva = @idreserva";



            Conecta conexao = new Conecta();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                if (alteraReserva == true)
                {
                    cmd.Connection = conexao.Conectar();
                    cmd.CommandText = sqlAlteraReserva;
                    cmd.Parameters.AddWithValue("categoria", this.categoria);
                    cmd.Parameters.AddWithValue("checkin", this.checkin);
                    cmd.Parameters.AddWithValue("checkout", this.checkout);
                    cmd.Parameters.AddWithValue("qtddiarias", this.qtdDiarias);
                    cmd.Parameters.AddWithValue("qtdhospede", this.qtdHospede);
                    cmd.Parameters.AddWithValue("hospede1", this.hospede1);
                    cmd.Parameters.AddWithValue("hospede2", this.hospede2);
                    cmd.Parameters.AddWithValue("cliente", this.cliente);
                    cmd.Parameters.AddWithValue("valordiaria", this.valorDiaria);
                    cmd.Parameters.AddWithValue("valortotal", this.valorTotal);
                    cmd.Parameters.AddWithValue("garantia", this.garantia);
                    cmd.Parameters.AddWithValue("docgarantia", this.docGarantia);
                    cmd.Parameters.AddWithValue("statusreserva", this.statusReserva);
                    cmd.Parameters.AddWithValue("observacao", this.observacao);
                    cmd.Parameters.AddWithValue("idreserva", this.idReserva);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                    conexao.Desconectar(conexao.Conectar());
                }else if (alteraStatusReserva == true)
                {
                    int rows = 0;
                    cmd.Connection = conexao.Conectar();
                    cmd.CommandText = sqlCancelaNoshowAtiva;
                    cmd.Parameters.AddWithValue("statusreserva", this.statusReserva);
                    cmd.Parameters.AddWithValue("idreserva", this.idReserva);
                    cmd.Prepare();
                    rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Reserva Alterada!!");
                    }
                    else
                    {
                        MessageBox.Show("Reserva não Alterada!!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
