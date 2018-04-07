namespace ControleFinanceiroIHC
{
    partial class ManageLimits
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageLimits));
            this.checkBoxCost = new System.Windows.Forms.CheckBox();
            this.checkBoxProfit = new System.Windows.Forms.CheckBox();
            this.txtBoxCost = new System.Windows.Forms.TextBox();
            this.txtBoxProfit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bttApply = new System.Windows.Forms.Button();
            this.bttCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxCost
            // 
            this.checkBoxCost.AutoSize = true;
            this.checkBoxCost.Location = new System.Drawing.Point(66, 39);
            this.checkBoxCost.Name = "checkBoxCost";
            this.checkBoxCost.Size = new System.Drawing.Size(136, 17);
            this.checkBoxCost.TabIndex = 7;
            this.checkBoxCost.Text = "Limite de Gasto Mensal";
            this.checkBoxCost.UseVisualStyleBackColor = true;
            this.checkBoxCost.CheckedChanged += new System.EventHandler(this.checkBoxCost_CheckedChanged);
            // 
            // checkBoxProfit
            // 
            this.checkBoxProfit.AutoSize = true;
            this.checkBoxProfit.Location = new System.Drawing.Point(66, 99);
            this.checkBoxProfit.Name = "checkBoxProfit";
            this.checkBoxProfit.Size = new System.Drawing.Size(158, 17);
            this.checkBoxProfit.TabIndex = 8;
            this.checkBoxProfit.Text = "Limite de Poupança Mínima";
            this.checkBoxProfit.UseVisualStyleBackColor = true;
            this.checkBoxProfit.CheckedChanged += new System.EventHandler(this.checkBoxProfit_CheckedChanged);
            // 
            // txtBoxCost
            // 
            this.txtBoxCost.Enabled = false;
            this.txtBoxCost.Location = new System.Drawing.Point(91, 62);
            this.txtBoxCost.Name = "txtBoxCost";
            this.txtBoxCost.Size = new System.Drawing.Size(111, 20);
            this.txtBoxCost.TabIndex = 9;
            // 
            // txtBoxProfit
            // 
            this.txtBoxProfit.Enabled = false;
            this.txtBoxProfit.Location = new System.Drawing.Point(91, 122);
            this.txtBoxProfit.Name = "txtBoxProfit";
            this.txtBoxProfit.Size = new System.Drawing.Size(111, 20);
            this.txtBoxProfit.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "R$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "R$";
            // 
            // bttApply
            // 
            this.bttApply.Location = new System.Drawing.Point(78, 181);
            this.bttApply.Name = "bttApply";
            this.bttApply.Size = new System.Drawing.Size(103, 23);
            this.bttApply.TabIndex = 13;
            this.bttApply.Text = "Aplicar";
            this.bttApply.UseVisualStyleBackColor = true;
            this.bttApply.Click += new System.EventHandler(this.bttApply_Click);
            // 
            // bttCancel
            // 
            this.bttCancel.Location = new System.Drawing.Point(187, 181);
            this.bttCancel.Name = "bttCancel";
            this.bttCancel.Size = new System.Drawing.Size(75, 23);
            this.bttCancel.TabIndex = 14;
            this.bttCancel.Text = "Cancelar";
            this.bttCancel.UseVisualStyleBackColor = true;
            this.bttCancel.Click += new System.EventHandler(this.bttCancel_Click);
            // 
            // ManageLimits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(274, 216);
            this.Controls.Add(this.bttCancel);
            this.Controls.Add(this.bttApply);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxProfit);
            this.Controls.Add(this.txtBoxCost);
            this.Controls.Add(this.checkBoxProfit);
            this.Controls.Add(this.checkBoxCost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ManageLimits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Limites";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxCost;
        private System.Windows.Forms.CheckBox checkBoxProfit;
        private System.Windows.Forms.TextBox txtBoxCost;
        private System.Windows.Forms.TextBox txtBoxProfit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttApply;
        private System.Windows.Forms.Button bttCancel;
    }
}