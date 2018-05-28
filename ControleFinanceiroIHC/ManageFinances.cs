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
    public partial class ManageFinances : Form
    {

        BindingList<Financa> bList;
        BindingSource bs = new BindingSource();

        double maxCost;
        double minProfit;

        public ManageFinances(List<Financa> list, ref double maxCost, ref double minProfit)
        {
            InitializeComponent();
            bList = new BindingList<Financa>(list);
            bs.DataSource = bList;
            bindingNavigator1.BindingSource = bs;
            this.dataGridView1.DataSource = bs;
            this.SetUpDataGridView();
            this.maxCost = maxCost;
            this.minProfit = minProfit;
            
            
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            AddCost addCost = new AddCost(this);
            addCost.MdiParent = this.ParentForm;
            addCost.Show();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Item removido com sucesso.","Item removido", 0, MessageBoxIcon.Asterisk);
            this.dataGridView1.Refresh();
        }

        public void addItem(Financa item)
        {
            bList.Add(item);
            this.dataGridView1.Refresh();
        }

        private void SetUpDataGridView()
        {
            this.Controls.Add(dataGridView1);
            dataGridView1.Columns[0].HeaderText = "Tipo de Finança";
            dataGridView1.Columns[1].HeaderText = "Descrição";
            dataGridView1.Columns[2].HeaderText = "Valor";
            dataGridView1.Columns[2].DefaultCellStyle.Format = "c";
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


        }

        private void bttExitUpValue_Click(object sender, EventArgs e)
        {
            this.bs.DataSource = bList;
            this.dataGridView1.DataSource = bs;
            this.Hide();
        }

        private void bttAnaUpValue_Click(object sender, EventArgs e)
        {
            double gain = 0;
            double cost = 0;
            double profit = 0;
            string analysisResult = "";


            foreach (Financa item in bList.ToList())
            {
                if (item.type == "Renda" )
                {
                    gain = gain + item.value;
                }
            }
            foreach(Financa item in bList.ToList())
            {
                if (item.type == "Gasto")
                {
                    cost += item.value;
                }
            }
            profit = gain - cost;
            analysisResult += string.Format("Sua renda nesse demonstrativo foi de {0:C2}\n", gain);
            analysisResult += string.Format("Seu gasto nesse demonstrativo foi de {0:C2}\n\n", cost);
            if (this.maxCost == 0 && this.minProfit == 0)
            {
                MessageBox.Show(analysisResult + "\n\nCaso queira uma análise mais detalhada, favor adicionar algum limite.", "Resultado de Análise Genérica", 0, MessageBoxIcon.Asterisk);
            }
            else
            {
                if (maxCost != 0)
                {
                    if (cost > maxCost)
                    {
                        double difference = cost - maxCost;
                        analysisResult += string.Format("Analisando seus gastos, foi constatado que você gastou {0:C2} a mais do que o que planejou.\n" +
                            "Seu limite de gasto máximo: {1:C2} - Seu gasto: {2:C2}\n\n", difference, maxCost, cost);
                    }
                    else
                    {
                        double difference = cost - maxCost;
                        analysisResult += string.Format("Analisando seus gastos, foi constatado que você gastou {0:C2} a menos do que o que planejou. Parabéns!\n" +
                            "Seu limite de gasto máximo: {1:C2} - Seu gasto: {2:C2}\n\n", Math.Abs(difference), maxCost, cost);
                    }
                }
                if (minProfit != 0)
                {
                    if(minProfit < profit)
                    {
                        double difference = profit - minProfit;
                        analysisResult += string.Format("Analisando suas finanças, foi constatado que você poupou {0:C2} a mais do que o que planejou.\n" +
                            "Seu limite de poupança mínima: {1:C2} - Seu lucro: {2:C2}\n\n", difference, minProfit, profit);
                    }
                    else
                    {
                        double difference = profit - minProfit;
                        analysisResult += string.Format("Analisando suas finanças, foi constatado que você poupou {0:C2} a menos do que o que planejou.\n" +
                            "Seu limite de poupança mínima: {1:C2} - Seu lucro: {2:C2}\n\n", Math.Abs(difference), minProfit, profit);
                    }
                }
                //if (profit > cost)
                //{
                //    double difference = profit - cost;
                //    analysisResult += string.Format("Analisando suas finanças, foi constatado que você lucrou {0:C2}.\n", difference);
                //}
                //else
                //{
                //    double difference = profit - cost;
                //    analysisResult += string.Format("Analisando suas finanças, foi constatado que você teve um prejuízo de {0:C2}.\n", Math.Abs(difference));
                //}
                MessageBox.Show(analysisResult, "Resultado da Análise", 0, MessageBoxIcon.Asterisk);
            }
            
        }
        public void removeFirstLine()
        {
            this.bList.RemoveAt(0);
        }

        private void linkLblAddValue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HelpWindow help = new HelpWindow();
            help.Show();
        }
    }
}
