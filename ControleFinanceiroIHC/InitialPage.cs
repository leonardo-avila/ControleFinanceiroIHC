using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ControleFinanceiroIHC
{
    public partial class InitialPage : Form
    {
        List<Financa> list = new List<Financa>();
        SetControls manageWindow;

        public InitialPage()
        {
            InitializeComponent();
            list.Add(new Renda("Exemplo", 0));
            manageWindow = new SetControls();
        }

        private void alterarLimitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageWindow.Show();
        }

        private void adicionarCustoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCost addCostWindow = new AddCost();
            addCostWindow.Show();
        }

        private void exibirAjudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpWindow helwindow = new HelpWindow();
            helwindow.Show();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpWindow helpWindow = new HelpWindow();
            helpWindow.Show();
        }

        private void exportarCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            string format = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";
            saveFileDialog1.Filter = format;
            StreamWriter streamWriter = null;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string name = saveFileDialog1.FileName;
                streamWriter = new StreamWriter(name, false, Encoding.UTF8);

                streamWriter.WriteLine("Tipo de Finança;Descrição;Valor");
                foreach (Financa i in this.list)
                {
                    streamWriter.WriteLine(i);
                }
                streamWriter.Close();
                MessageBox.Show("Arquivo salvo com sucesso.", "Arquivo Salvo", 0, MessageBoxIcon.Asterisk);
            }
            
        }

        private void importarCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            openFileDialog1.Title = "Importar CSV";
            openFileDialog1.Filter = "Arquivos CSV (*.csv)|*.csv";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                List<string> financas = File.ReadAllLines(openFileDialog1.FileName).ToList();
                financas.RemoveAt(0);
                this.list.Clear();
                foreach(string line in financas)
                {
                    string[] split = line.Split(';');
                    if(split[0] == "Renda")
                    {
                        this.list.Add(new Renda(split[1], double.Parse(split[2])));
                    }
                    else if(split[0] == "Gasto")
                    {
                        this.list.Add(new Gasto(split[1], double.Parse(split[2])));
                    }
                }
                MessageBox.Show("Arquivo importado com sucesso. Sua tabela de finanças foi atualizada.","Arquivo importado", 0, MessageBoxIcon.Asterisk);
                              
            }

        }

        private void gerenciarFinançasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double maxCost = manageWindow.MaxCost;
            double minProfit = manageWindow.MinProfit;
            ManageFinances upValues = new ManageFinances(this.list, ref maxCost, ref minProfit);
            upValues.Show();
        }
    }
}
