namespace ControleFinanceiroIHC
{
    partial class AddGain
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
            this.bttCancelAddCost = new System.Windows.Forms.Button();
            this.bttAddAddCost = new System.Windows.Forms.Button();
            this.txtBoxAddCost = new System.Windows.Forms.TextBox();
            this.labelAddCost5 = new System.Windows.Forms.Label();
            this.labelAddCost4 = new System.Windows.Forms.Label();
            this.labelAddCost3 = new System.Windows.Forms.Label();
            this.labelAddCost2 = new System.Windows.Forms.Label();
            this.labelAddCost1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttCancelAddCost
            // 
            this.bttCancelAddCost.Location = new System.Drawing.Point(353, 160);
            this.bttCancelAddCost.Name = "bttCancelAddCost";
            this.bttCancelAddCost.Size = new System.Drawing.Size(75, 23);
            this.bttCancelAddCost.TabIndex = 15;
            this.bttCancelAddCost.Text = "Cancelar";
            this.bttCancelAddCost.UseVisualStyleBackColor = true;
            // 
            // bttAddAddCost
            // 
            this.bttAddAddCost.Location = new System.Drawing.Point(207, 160);
            this.bttAddAddCost.Name = "bttAddAddCost";
            this.bttAddAddCost.Size = new System.Drawing.Size(140, 23);
            this.bttAddAddCost.TabIndex = 14;
            this.bttAddAddCost.Text = "Adicionar";
            this.bttAddAddCost.UseVisualStyleBackColor = true;
            // 
            // txtBoxAddCost
            // 
            this.txtBoxAddCost.Location = new System.Drawing.Point(12, 104);
            this.txtBoxAddCost.Name = "txtBoxAddCost";
            this.txtBoxAddCost.Size = new System.Drawing.Size(161, 20);
            this.txtBoxAddCost.TabIndex = 13;
            // 
            // labelAddCost5
            // 
            this.labelAddCost5.AutoSize = true;
            this.labelAddCost5.Location = new System.Drawing.Point(12, 77);
            this.labelAddCost5.Name = "labelAddCost5";
            this.labelAddCost5.Size = new System.Drawing.Size(223, 13);
            this.labelAddCost5.TabIndex = 12;
            this.labelAddCost5.Text = "Exemplos: (1000.00) (200.50) (0.50) (2500.00)";
            // 
            // labelAddCost4
            // 
            this.labelAddCost4.AutoSize = true;
            this.labelAddCost4.Location = new System.Drawing.Point(12, 60);
            this.labelAddCost4.Name = "labelAddCost4";
            this.labelAddCost4.Size = new System.Drawing.Size(94, 13);
            this.labelAddCost4.TabIndex = 11;
            this.labelAddCost4.Text = "- Não utilize cifrão;";
            // 
            // labelAddCost3
            // 
            this.labelAddCost3.AutoSize = true;
            this.labelAddCost3.Location = new System.Drawing.Point(12, 43);
            this.labelAddCost3.Name = "labelAddCost3";
            this.labelAddCost3.Size = new System.Drawing.Size(398, 13);
            this.labelAddCost3.TabIndex = 10;
            this.labelAddCost3.Text = "- A separação da casa dos centavos deve ser feita por ponto ao invés de vírgulas;" +
    "";
            // 
            // labelAddCost2
            // 
            this.labelAddCost2.AutoSize = true;
            this.labelAddCost2.Location = new System.Drawing.Point(12, 26);
            this.labelAddCost2.Name = "labelAddCost2";
            this.labelAddCost2.Size = new System.Drawing.Size(223, 13);
            this.labelAddCost2.TabIndex = 9;
            this.labelAddCost2.Text = "- Não há separação com pontos nos milhares;";
            // 
            // labelAddCost1
            // 
            this.labelAddCost1.AutoSize = true;
            this.labelAddCost1.Location = new System.Drawing.Point(12, 9);
            this.labelAddCost1.Name = "labelAddCost1";
            this.labelAddCost1.Size = new System.Drawing.Size(428, 13);
            this.labelAddCost1.TabIndex = 8;
            this.labelAddCost1.Text = "Escreva abaixo o valor que deseja adicionar como RENDA, seguindo o seguinte forma" +
    "to:";
            // 
            // AddGain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(439, 196);
            this.Controls.Add(this.bttCancelAddCost);
            this.Controls.Add(this.bttAddAddCost);
            this.Controls.Add(this.txtBoxAddCost);
            this.Controls.Add(this.labelAddCost5);
            this.Controls.Add(this.labelAddCost4);
            this.Controls.Add(this.labelAddCost3);
            this.Controls.Add(this.labelAddCost2);
            this.Controls.Add(this.labelAddCost1);
            this.Name = "AddGain";
            this.Text = "Adicionar Renda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttCancelAddCost;
        private System.Windows.Forms.Button bttAddAddCost;
        private System.Windows.Forms.TextBox txtBoxAddCost;
        private System.Windows.Forms.Label labelAddCost5;
        private System.Windows.Forms.Label labelAddCost4;
        private System.Windows.Forms.Label labelAddCost3;
        private System.Windows.Forms.Label labelAddCost2;
        private System.Windows.Forms.Label labelAddCost1;
    }
}