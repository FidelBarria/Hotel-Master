using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel_Master.Model;

namespace Hotel_Master
{
    public partial class HotelMaster : Form
    {
        public HotelMaster()
        {
            
            InitializeComponent();
            menuSuperior.Visible = true;
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        public void pegaTxtUsuario(string usuario)
        {
            lblUsuario.Text += usuario;
        }

        private void HotelMaster_Load(object sender, EventArgs e)
        {
            
        }

        private void menuDesloga_Click(object sender, EventArgs e)
        {
            new TelaDeLogin().ShowDialog();
            this.Dispose();
        }

        private void HotelMaster_FormClosing(object sender, FormClosingEventArgs e)
        {
           Application.Exit();
        }

        private void novoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManutencaoDeUsuario manutecaoDeUsuario = new ManutencaoDeUsuario();
            //manutecaoDeUsuario.Show();
            manutecaoDeUsuario.TopLevel = false;
            //manutecaoDeUsuario.Dock = DockStyle.Fill;
            panForms.Controls.Add(manutecaoDeUsuario);
            manutecaoDeUsuario.Show();
        }
    }
}
