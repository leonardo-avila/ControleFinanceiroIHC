using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFinanceiroIHC
{
    public partial class AddCost : Form
    {
        ManageFinances up;
        public AddCost(ManageFinances form)
        {
            InitializeComponent();
            this.up = form;
        }
        public AddCost()
        {
            InitializeComponent();
        }

        private void bttAddAddCost_Click(object sender, EventArgs e)
        {
            if (radioButtonGasto.Checked || radioButtonRenda.Checked)
            {
                try
                {
                    if (radioButtonGasto.Checked)
                    {
                        Financa item = new Gasto(txtBoxAddDescription.Text, double.Parse(txtBoxAddValue.Text));
                        this.up.addItem(item);
                        MessageBox.Show("Item adicionado com sucesso.", "Item adicionado", 0, MessageBoxIcon.Asterisk);
                        this.Close();
                    }

                    else if (radioButtonRenda.Checked)
                    {

                        Financa item = new Renda(txtBoxAddDescription.Text, double.Parse(txtBoxAddValue.Text));
                        this.up.addItem(item);
                        MessageBox.Show("Item adicionado com sucesso.", "Item adicionado", 0, MessageBoxIcon.Asterisk);
                        this.Close();
                    }
                }
                catch (System.FormatException)
                {
                    
                    MessageBox.Show("Provavelmente algum dado informado não segue a orientação. Infelizmente não conseguimos concluir a ação. Favor verificar as informações.", "Inconsistência de Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (InvalidOperationException)
                {
                    this.up.removeFirstLine();
                    MessageBox.Show("Pedimos desculpas pelo inconveniente. A tabela não foi atualizada devidamente, porém o valor foi adicionado com sucesso. Para atualizar a tabela, exclua a primeira linha, que se encontra em branco, que então seu valor adicionado irá aparecer.", "Informação sobre a tabela", 0, MessageBoxIcon.Asterisk);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Você deve selecionar um tipo de valor (Renda ou Gasto)", "Nenhuma opção foi selecionada! ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bttCancelAddCost_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLblAddCost_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HelpWindow helpWindow = new HelpWindow();
            helpWindow.Show();
        }
    }
}
