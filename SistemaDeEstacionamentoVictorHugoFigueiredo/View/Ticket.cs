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
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {

        }
        public void limparTela()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = String.Empty;
                }
                else if (ctl is Label && Convert.ToInt32(ctl.Tag).Equals(1))
                {
                    ctl.Text = string.Empty;
                }
            }
        }

        private void btnCadastroT_Click(object sender, EventArgs e)
        {

            try
            {
                if (tbxNomeT.Text == string.Empty)
                {
                    MessageBox.Show("Falta preencher o campo");
                    return;
                }
                if (tbxDataT.Text == string.Empty)
                {
                    MessageBox.Show("Falta preencher o campo");
                    return;
                }
                if (tbxPlacaT.Text == string.Empty)
                {
                    MessageBox.Show("Falta preencher o campo");
                    return;
                }

                if (tbxCorT.Text == string.Empty)
                {
                    MessageBox.Show("Falta preencher o campo");
                    return;
                }
                {
                    MessageBox.Show("Cadastro realizado");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de erro");
            }
        }

        private void Ticket_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                limparTela();
            }
        }
    }
}
