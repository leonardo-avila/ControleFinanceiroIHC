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
        ManageLimits manageWindow;

        public InitialPage()
        {
            InitializeComponent();
            list.Add(new Renda("Exemplo", 0));
            manageWindow = new ManageLimits();
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

        private void alterarValoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double maxCost = manageWindow.MaxCost;
            double minProfit = manageWindow.MinProfit;
            UpdateValues upValues = new UpdateValues(this.list, ref maxCost, ref minProfit);
            upValues.Show();
        }

        private void exibirAjudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpWindow2 helwindow = new HelpWindow2();
            helwindow.Show();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpWindow2 helpWindow = new HelpWindow2();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
