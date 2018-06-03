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
    public partial class SetControls : Form
    {
        //public double MinProfit{ get; set; }
        //public double MaxCost { get; set; }
        
        public int percentage { get; set; }

        public SetControls()
        {
            InitializeComponent();
            
        }
        

        //private void checkBoxCost_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (txtBoxCost.Enabled)
        //    {
        //        txtBoxCost.Enabled = false;
        //    }
        //    else
        //    {
        //        txtBoxCost.Enabled = true;
        //    }
        //}

        //private void checkBoxProfit_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (txtBoxProfit.Enabled)
        //    {
        //        txtBoxProfit.Enabled = false;
        //    }
        //    else
        //    {
        //        txtBoxProfit.Enabled = true;
        //    }
        //}

        private void bttCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bttApply_Click(object sender, EventArgs e)
        {
            string checkA = "";
            //if (txtBoxCost.Text != null || txtBoxProfit.Text != null)
            //{
            //    //try
            //    //{
            //    //    //if (txtBoxCost.Text != null && txtBoxCost.Enabled)
            //    //    //{
            //    //    //    this.MaxCost = double.Parse(txtBoxCost.Text);
            //    //    //    checkA += "Limite de gasto mensal definido com sucesso.\n";
            //    //    //}
            //    //    //if (txtBoxProfit.Text != null && txtBoxProfit.Enabled)
            //    //    //{
            //    //    //    this.MinProfit = double.Parse(txtBoxProfit.Text);
            //    //    //    checkA += "Limite de poupança mínima definida com sucesso.\n";
            //    //    //}
            //    //    //if ((txtBoxCost.Text != null && txtBoxCost.Enabled) || (txtBoxProfit.Text != null && txtBoxProfit.Enabled)) {
            //    //    //    MessageBox.Show(checkA, "Limite definido", 0, MessageBoxIcon.Asterisk);
            //    //    //}
            //    //    if (txtBoxCost.Enabled == false)
            //    //    {
            //    //        this.MaxCost = 0;
            //    //        checkA += "Você desativou o limite de gasto mensal.\n";
            //    //    }
            //    //    if (txtBoxProfit.Enabled == false)
            //    //    {
            //    //        this.MinProfit = 0;
            //    //        checkA += "Você desativou o limite de poupança mínima.\n";
            //    //    }
            //    //    if (!txtBoxCost.Enabled || !txtBoxProfit.Enabled)
            //    //        MessageBox.Show(checkA, "Limite", 0, MessageBoxIcon.Asterisk);
            //    //    this.Hide();
            //    //}
            //    catch (FormatException)
            //    {
            //        MessageBox.Show("Não conseguimos efetuar sua ação. Verifique se os campos de valor estão preenchidos. Se estiverem preenchidos, verifique se as informações digitadas estão no formato numérico.", "Dado fornecido inexistente ou incorreto", 0, MessageBoxIcon.Exclamation);
            //    }
            //}
            this.percentage = percentageTrackBar1.Value;
            checkA += string.Format("Controle de economia definido em {0}% do valor de sua renda.", percentage);
            MessageBox.Show(checkA, "Controle Definido", 0, MessageBoxIcon.Asterisk);
            this.Hide();
        }

       
        private void percentageTrackBar1_Scroll(object sender, EventArgs e)
        {
            trackBarValueLb.Text = percentageTrackBar1.Value.ToString() + "%";
        }

        private void SetControls_Load(object sender, EventArgs e)
        {

        }
    }
}
