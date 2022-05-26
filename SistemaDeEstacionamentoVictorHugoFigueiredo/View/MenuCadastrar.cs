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
       



        public void limparTela()
        {
            foreach (Control ctl in this.Controls)
            {
                if(ctl is TextBox)
                {
                    ctl.Text = String.Empty;
                }
                else if(ctl is Label && Convert.ToInt32(ctl.Tag).Equals(1)) 
                {
                    ctl.Text = string.Empty;
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
      
            try
            {
                if (tbxNomeCli.Text == string.Empty)
                {
                    MessageBox.Show("Falta preencher o campo");
                    return;
                }
                 if (tbxCelCli.Text == string.Empty)
                {
                    MessageBox.Show("Falta preencher o campo");
                    return;
                }
                 if (tbxEmailCli.Text == string.Empty)
                {
                    MessageBox.Show("Falta preencher o campo");
                    return;
                }

                 if (tbxCelCli.Text == string.Empty)
                {
                    MessageBox.Show("Falta preencher o campo");
                    return;
                }
                if (tbxCpfCli.Text == string.Empty)
                {

                    MessageBox.Show("Falta preencher o campo");
                    
                }
                {
                    MessageBox.Show("Cadastro realizado");
                }
                }
            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de erro");
            }
            
        }

        private void MenuCadastrar_Load(object sender, EventArgs e)
        {

        }

        private void MenuCadastrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 27)
            {
                limparTela();
            }
        }
    }
}
