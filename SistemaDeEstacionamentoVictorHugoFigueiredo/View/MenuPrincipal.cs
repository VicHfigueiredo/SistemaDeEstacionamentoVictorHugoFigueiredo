using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeEstacionamentoVictorHugoFigueiredo.View
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void carroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuCadastrar cliente = new MenuCadastrar();
            cliente.Show();
        }

        private void ticketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarCarro carro = new CadastrarCarro();
            carro.Show();
        }

        private void ticketToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ticket t = new Ticket();
            t.Show();
        }
    }
}
