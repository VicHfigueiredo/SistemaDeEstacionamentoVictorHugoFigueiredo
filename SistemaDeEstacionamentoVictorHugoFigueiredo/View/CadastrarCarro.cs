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
    public partial class CadastrarCarro : Form
    {
        public CadastrarCarro()
        {
            InitializeComponent();
        }

        private void tbxNomeCar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        public void limparTela()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox || ctl is ComboBox)
                {
                    ctl.Text = String.Empty;
                }
                else if (ctl is Label && Convert.ToInt32(ctl.Tag).Equals(1))
                {
                    ctl.Text = string.Empty;
                }
            }
        }
        private void btnCadastrarCarro_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxNomeCar
                    .Text == string.Empty)
                {
                    MessageBox.Show("Falta preencher o campo");
                    return;
                }
                if (tbxCorCar.Text == string.Empty)
                {
                    MessageBox.Show("Falta preencher o campo");
                    return;
                }
                if (tbxMarcaCar.Text == string.Empty)
                {
                    MessageBox.Show("Falta preencher o campo");
                    return;
                }

                if (tbxPlacaCar.Text == string.Empty)
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

        private void tbxMarcaCar_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastrarCarro_Load(object sender, EventArgs e)
        {

        }

        private void CadastrarCarro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                limparTela();
            }
        }
    }
    
    }

