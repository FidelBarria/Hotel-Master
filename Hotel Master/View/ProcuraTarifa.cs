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
    public partial class ProcuraTarifa : Form
    {
        public string valorDiaria { get; private set; }

        Tarifa tarifa = new Tarifa();

        public ProcuraTarifa()
        {
            InitializeComponent();
            dtgTarifa.DataSource = tarifa.procuraTarifa();
        }

        private void btnSeleciona_Click(object sender, EventArgs e)
        {
            this.valorDiaria = dtgTarifa.CurrentRow.Cells["valor"].Value.ToString();
            this.Dispose();

        }
    }
}
