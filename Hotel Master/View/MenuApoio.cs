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
    public partial class MenuApoio : Form
    {
        NovaReserva _novaReserva;
        public MenuApoio( NovaReserva novaReserva)
        {
            InitializeComponent();
            _novaReserva = novaReserva;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //NovaReserva novaReserva = new NovaReserva();
            _novaReserva.Close();
            this.Dispose();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
