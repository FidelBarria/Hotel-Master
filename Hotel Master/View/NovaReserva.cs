using Hotel_Master.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Master
{
    public partial class NovaReserva : Form
    {
        public string modo { get; set; }

        Cliente cliente = new Cliente();
        Hospede hospede = new Hospede();
        Reserva reserva = new Reserva();
        Categoria categoria = new Categoria();
        Tarifa tarifa = new Tarifa();


        public NovaReserva()
        {
            InitializeComponent();
            panAdicionaHospede.Visible = false;

            
            dtgDiaria.Columns.Add("data", "Data");
            dtgDiaria.Columns.Add("diaria", "Diaria");
            dtgDiaria.Columns.Add("valorDiaria", "Valor Diaria");
            dtgDiaria.Columns.Add("valorTotal", "Valor Total");

            dtgHospede.Columns.Add("idhospede", "ID");
            dtgHospede.Columns.Add("cpf", "CPF");
            dtgHospede.Columns.Add("hospede", "Hospede");
            dtgHospede.Columns.Add("email", "Email");
            dtgHospede.Columns.Add("Telefone", "Telefone");

            cbCategoria.DataSource = categoria.procuraCategoria();
            cbCategoria.DisplayMember = "categoria";
            cbCategoria.ValueMember = "idcategoria";
        }

        public void modoCriaouEdita(string modo)
        {
            if (modo == "CRIA")
            {
                this.modo = "CRIA";
                this.Text = "Nova Reserva";
            }
            else if (modo == "EDITA")
            {
                this.modo = "EDITA";
                this.Text = "Edita Reserva";
            }
        }

        private void btnAdicionaHospede_Click(object sender, EventArgs e)
        {
            panAdicionaHospede.Visible = !panAdicionaHospede.Visible;
        }

        private void btnObservacao_Click(object sender, EventArgs e)
        {
            btnObservacao.Enabled = !btnObservacao.Enabled;
            btnSalvar.Enabled = !btnSalvar.Enabled;
            txtObservacao.Enabled = !txtObservacao.Enabled;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            btnObservacao.Enabled = !btnObservacao.Enabled;
            btnSalvar.Enabled = !btnSalvar.Enabled;
            txtObservacao.Enabled = !txtObservacao.Enabled;
        }

        private void btnConfirmaReserva_Click(object sender, EventArgs e)
        {
            if (modo == "CRIA")
            {
                if (numHospede.Value != dtgHospede.RowCount - 1)
                {
                    MessageBox.Show("Você precisa adicionar todos hospedes!!");
                }
                else
                {
                    try
                    {
                        reserva.cliente = Convert.ToInt32(txtIdCliente.Text);
                        reserva.categoria = Convert.ToInt32(cbCategoria.SelectedValue);
                        reserva.checkin = Convert.ToDateTime(dtCheckin.Text);
                        reserva.checkout = Convert.ToDateTime(dtCheckout.Text);
                        reserva.qtdDiarias = Convert.ToInt32(txtQtdDiarias.Text);
                        reserva.qtdHospede = Convert.ToInt32(numHospede.Text);
                        reserva.hospede1 = Convert.ToInt32(dtgHospede.Rows[0].Cells[0].Value);
                        reserva.hospede2 = Convert.ToInt32(dtgHospede.Rows[1].Cells[0].Value);
                        reserva.valorDiaria = Convert.ToSingle(txtValorDiaria.Text);
                        int indiceLinha = dtgDiaria.Rows.Count - 1;
                        reserva.valorTotal = Convert.ToSingle(dtgDiaria.Rows[indiceLinha].Cells["valorTotal"].Value);
                        reserva.garantia = radSim.Checked ? "Sim" : radNao.Checked ? "Não" : "";
                        reserva.statusReserva = 1;
                        reserva.observacao = txtObservacao.Text;
                        reserva.insereReserva();
                        new MenuApoio(this).ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                if (numHospede.Value != dtgHospede.RowCount - 1)
                {
                    MessageBox.Show("Você precisa adicionar todos hospedes!!");
                }
                else
                {
                    try
                    {
                        reserva.idReserva = Convert.ToInt32(lblIdReserva.Text);
                        reserva.cliente = Convert.ToInt32(txtIdCliente.Text);
                        reserva.categoria = Convert.ToInt32(cbCategoria.SelectedValue);
                        reserva.checkin = Convert.ToDateTime(dtCheckin.Text);
                        reserva.checkout = Convert.ToDateTime(dtCheckout.Text);
                        reserva.qtdDiarias = Convert.ToInt32(txtQtdDiarias.Text);
                        reserva.qtdHospede = Convert.ToInt32(numHospede.Text);
                        reserva.hospede1 = Convert.ToInt32(dtgHospede.Rows[0].Cells[0].Value);
                        reserva.hospede2 = Convert.ToInt32(dtgHospede.Rows[1].Cells[0].Value);
                        reserva.valorDiaria = Convert.ToSingle(txtValorDiaria.Text);
                        int indiceLinha = dtgDiaria.Rows.Count - 1;
                        reserva.valorTotal = Convert.ToSingle(dtgDiaria.Rows[indiceLinha].Cells["valorTotal"].Value);
                        reserva.garantia = radSim.Checked ? "Sim" : radNao.Checked ? "Não" : "";
                        reserva.statusReserva = 1;
                        reserva.observacao = txtObservacao.Text;
                        reserva.atualizaReserva(true, false);
                        new MenuApoio(this).ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

        }

        private void dtCheckout_ValueChanged(object sender, EventArgs e)
        {
            criaTabelaDeValoresDiarias();
        }

        public void criaTabelaDeValoresDiarias()
        {
            dtgDiaria.Rows.Clear();
            DateTime dataCheckin = Convert.ToDateTime(dtCheckin.Text);
            DateTime dataCheckout = Convert.ToDateTime(dtCheckout.Text);
            var qtdDiaria = (dataCheckout - dataCheckin).Days;
            var valorDiaria = Convert.ToSingle(txtValorDiaria.Text);
            txtQtdDiarias.Text = qtdDiaria.ToString();
            while (qtdDiaria > 0)
            {
                dtgDiaria.Rows.Add(dataCheckin.AddDays(qtdDiaria).ToString("dd/MM/yyyy"), qtdDiaria, valorDiaria, valorDiaria * qtdDiaria);
                qtdDiaria--;
            }
            DataGridViewColumn a = dtgDiaria.Columns[0];
            dtgDiaria.Sort(a, ListSortDirection.Ascending);
        }

        private void btnProcuraCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCliente.Text))
            {
                MessageBox.Show("Especifique o nome do cliente ou o CNPJ");
            }else
            {
                cliente.procuraCliente(txtCliente.Text);
            }
            
            txtCliente.Text = cliente.cliente;
            txtIdCliente.Text = cliente.idCliente.ToString();
        }


        private void txtCpf_Click(object sender, EventArgs e)
        {
            txtCpf.Focus();
        }

        private void txtCpf_Leave_1(object sender, EventArgs e)
        {
            hospede.procuraHospede(txtCpf.Text);
            //txtCpf.Text = hospede.cpf;
            txtHospede.Text = hospede.hospede;
            txtEmail.Text = hospede.email;
            txtTelefone.Text = hospede.telefone;
            txtIdHospede.Text = hospede.idHospede.ToString();
        }

        private void btnSalvaHospede_Click(object sender, EventArgs e)
        {
            Hospede hospede1 = new Hospede();
            int qtdHospede = Convert.ToInt32(numHospede.Text);
            int controle = 0;
            if (dtgHospede.Rows.Count <= qtdHospede)
            {
                if (string.IsNullOrEmpty(txtHospede.Text) || string.IsNullOrEmpty(txtEmail.Text) ||
                    string.IsNullOrEmpty(txtTelefone.Text) || string.IsNullOrEmpty(txtCpf.Text))
                {
                    MessageBox.Show("Preencha todas as informações.");
                }
                else if (hospede.idHospede == 0)
                {

                    hospede1.hospede = txtHospede.Text;
                    hospede1.cpf = txtCpf.Text;
                    hospede1.email = txtEmail.Text;
                    hospede1.telefone = txtTelefone.Text;
                    hospede1.insereHospede();
                    hospede1.procuraHospede(txtCpf.Text);
                    dtgHospede.Rows.Add(hospede1.idHospede, hospede1.cpf, hospede1.hospede, hospede1.email, hospede1.telefone);
                }
                else
                {
                    dtgHospede.Rows.Add(txtIdHospede.Text, txtCpf.Text, txtHospede.Text, txtEmail.Text, txtTelefone.Text);
                }
                controle += controle;
            }
            else
            {
                MessageBox.Show("Você ja Colocou Quantidade de Maxima de Hospedes.");
            }


            txtHospede.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtCpf.Clear();
            txtIdHospede.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dtgHospede.Rows.RemoveAt(dtgHospede.SelectedRows[0].Index);
        }

        private void btnProcuraTarifa_Click(object sender, EventArgs e)
        {
            
            ProcuraTarifa procuraTarifa = new ProcuraTarifa();
            procuraTarifa.ShowDialog();
            if (procuraTarifa.valorDiaria == null) 
            { 
                txtValorDiaria.Text = "0";
            }else
            {
                txtValorDiaria.Text = procuraTarifa.valorDiaria.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuApoio menuApoio = new MenuApoio(this);
            menuApoio.ShowDialog();
        }

        public void fechaNovaReserva()
        {
            this.Close();
        }

        public void pegaIdSelecionado(int idSelecionado)
        {
            lblIdReserva.Text = idSelecionado.ToString();
        }

        private void NovaReserva_Load(object sender, EventArgs e)
        {
            if (this.modo == "EDITA")
            {
                MySqlDataReader dr = null;
                dr = reserva.procuraReservaId(Convert.ToInt32(lblIdReserva.Text));
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        txtIdCliente.Text = dr.GetInt32("idcliente").ToString();
                        txtCliente.Text = dr.GetString("cliente");
                        dtCheckin.Text = dr.GetDateTime("checkin").ToString();
                        dtCheckout.Text = dr.GetDateTime("checkout").ToString();
                        txtValorDiaria.Text = dr.GetDouble("valordiaria").ToString();
                        numHospede.Value = dr.GetInt32("qtdhospede");
                        if (dr.GetString("garantia") == "Sim")
                        {
                            radSim.Checked = true;
                        }
                        else if (dr.GetString("garantia") == "Não")
                        {
                            radNao.Checked = true;
                        }
                        cbCategoria.SelectedIndex = dr.GetInt32("idcategoria") - 1;
                        txtObservacao.Text = dr.GetString("observacao");
                        // Adiciona as colunas na mesma ordem do DataGridView
                        if (dr["hospede2"] == DBNull.Value)
                        {
                            dtgHospede.Rows.Add(
                             dr.GetInt32("idhospede1"),
                             dr.GetString("cpf1"),
                             dr.GetString("hospede1"),
                             dr.GetString("email1"),
                             dr.GetString("telefone1")
                             );
                        }
                        else
                        {
                            dtgHospede.Rows.Add(
                             dr.GetInt32("idhospede1"),
                             dr.GetString("cpf1"),
                             dr.GetString("hospede1"),
                             dr.GetString("email1"),
                             dr.GetString("telefone1")
 );
                            dtgHospede.Rows.Add(
                              dr.GetInt32("idhospede2"),
                              dr.GetString("cpf2"),
                              dr.GetString("hospede2"),
                              dr.GetString("email2"),
                              dr.GetString("telefone2")
                              );
                        }


                    }
                    dr.Close(); // FECHA O READER ANTES DE QUALQUER OUTRA OPERAÇÃO
                }
            }
            criaTabelaDeValoresDiarias();
        }

        private void txtValorDiaria_TextChanged(object sender, EventArgs e)
        {
            criaTabelaDeValoresDiarias();
        }
    }
}
