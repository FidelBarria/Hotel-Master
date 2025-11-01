using Hotel_Master.Model;
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
    public partial class ProcuraReserva : Form
    {
        Reserva reserva = new Reserva();
        Categoria categoria = new Categoria();
        StatusReserva statusReserva = new StatusReserva();
        HotelMaster hotelMaster = new HotelMaster();
        NovaReserva novaReserva = new NovaReserva();

        public ProcuraReserva()
        {
            InitializeComponent();

            DataTable dtCategoria = new DataTable();
            //Combobox categoria
            dtCategoria = categoria.procuraCategoria();
            DataRow drCategoria = dtCategoria.NewRow();
            drCategoria["idcategoria"] = DBNull.Value;
            drCategoria["categoria"] = " ";
            dtCategoria.Rows.InsertAt(drCategoria, 0);
            cbCategoria.DataSource = dtCategoria;
            cbCategoria.ValueMember = "idcategoria";
            cbCategoria.DisplayMember = "categoria";

            //ComboBox statusreserva

            DataTable dtStatusReserva = new DataTable();
            dtStatusReserva = statusReserva.procuraStatusReserva();
            DataRow drStatusReserva = dtStatusReserva.NewRow();
            drStatusReserva["idstatusreserva"] = DBNull.Value;
            drStatusReserva["statusreserva"] = " ";
            dtStatusReserva.Rows.InsertAt(drStatusReserva, 0);
            cbStatusReserva.DataSource = dtStatusReserva;
            cbStatusReserva.ValueMember = "idstatusreserva";
            cbStatusReserva.DisplayMember = "statusreserva";

            dtCheckin.CustomFormat = " ";
            dtCheckin.Format = DateTimePickerFormat.Custom;
            dtCheckout.CustomFormat = " ";
            dtCheckout.Format = DateTimePickerFormat.Custom;
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            reserva.categoria = Convert.ToInt32(cbCategoria.SelectedIndex);
            reserva.statusReserva = Convert.ToInt32(cbStatusReserva.SelectedIndex);
            if (dtCheckin.Text == " ")
            {
                reserva.checkin = null;
            }else
            {
                reserva.checkin = Convert.ToDateTime(dtCheckin.Text);
            }
            if (dtCheckout.Text == " ")
            {
                reserva.checkout = null;
            }
            else
            {
                reserva.checkout = Convert.ToDateTime(dtCheckout.Text);
            }
            if (txtReserva.Text == "")
            {
                reserva.idReserva = 0;
            }
            else
            {
                reserva.idReserva = Convert.ToInt32(txtReserva.Text);
            }

            dtgReserva.DataSource = reserva.procuraReserva();
        }

        private void dtCheckin_ValueChanged(object sender, EventArgs e)
        {
            dtCheckin.CustomFormat = "dd/MM/yyyy";
        }

        private void dtCheckout_ValueChanged(object sender, EventArgs e)
        {
            dtCheckout.CustomFormat = "dd/MM/yyyy";
        }

        private void dtCheckin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                dtCheckin.CustomFormat = " ";
            }
        }

        private void dtCheckout_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                dtCheckout.CustomFormat = " ";
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HotelMaster mdiPai = this.MdiParent as HotelMaster;
            if(mdiPai != null && dtgReserva.RowCount != 0 
                && dtgReserva.SelectedRows[0].Cells["statusreserva"].Value.ToString() != "CANCELADA"
                && dtgReserva.SelectedRows[0].Cells["statusreserva"].Value.ToString() != "NOSHOW")
            {
                
                novaReserva.modoCriaouEdita("EDITA");
                novaReserva.MdiParent = mdiPai;
                novaReserva.pegaIdSelecionado(Convert.ToInt32(dtgReserva.SelectedRows[0].Cells["idreserva"].Value));
                novaReserva.Show();
                this.Close();
            }

        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            if (dtgReserva.SelectedRows[0].Cells["statusreserva"].Value.ToString() == "CONFIRMADA")
            {
                reserva.idReserva = Convert.ToInt32(dtgReserva.SelectedRows[0].Cells["idReserva"].Value);
                reserva.statusReserva = 2;
                reserva.atualizaReserva(false, true);
            }

        }

        private void btnNoShow_Click(object sender, EventArgs e)
        {
            if (dtgReserva.SelectedRows[0].Cells["statusreserva"].Value.ToString() == "CONFIRMADA")
            {
                reserva.idReserva = Convert.ToInt32(dtgReserva.SelectedRows[0].Cells["idReserva"].Value);
                reserva.statusReserva = 3;
                reserva.atualizaReserva(false, true);
            }
        }

        private void btnReativar_Click(object sender, EventArgs e)
        {
            if (dtgReserva.SelectedRows[0].Cells["statusreserva"].Value.ToString() == "NOSHOW" || 
                dtgReserva.SelectedRows[0].Cells["statusreserva"].Value.ToString() == "CANCELADA")
            {
                reserva.idReserva = Convert.ToInt32(dtgReserva.SelectedRows[0].Cells["idReserva"].Value);
                reserva.statusReserva = 1;
                reserva.atualizaReserva(false, true);
            }
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            if (dtgReserva.RowCount != 0)
            {
                Caixa caixa = new Caixa();
                caixa.pegaIdReserva(Convert.ToInt32(dtgReserva.SelectedRows[0].Cells["idReserva"].Value));
                caixa.Show();
            }
          
        }
    }
}
