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
    public partial class MenuCadastrar : Form
    {
        public MenuCadastrar()
        {
            InitializeComponent();
        }

        private void tbxNomeCli_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
      
            try
            {
                if (tbxNomeCli.Text != string.Empty)
                {

                }
                 if (tbxCelCli.Text != string.Empty)
                {

                }
                 if (tbxEmailCli.Text != string.Empty)
                { 

                }

                 if (tbxCelCli.Text != string.Empty)
                {

                }
                if (tbxCpfCli.Text != string.Empty)
                {
                    MessageBox.Show("Cadastro realizado");
                }
                }
            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de erro");
            }
            
        }
    }
}
