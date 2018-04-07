namespace ControleFinanceiroIHC
{
    partial class AddCost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCost));
            this.labelAddCost1 = new System.Windows.Forms.Label();
            this.txtBoxAddValue = new System.Windows.Forms.TextBox();
            this.bttAddAddCost = new System.Windows.Forms.Button();
            this.bttCancelAddCost = new System.Windows.Forms.Button();
            this.radioButtonRenda = new System.Windows.Forms.RadioButton();
            this.radioButtonGasto = new System.Windows.Forms.RadioButton();
            this.txtBoxAddDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLblAddCost = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelAddCost1
            // 
            this.labelAddCost1.AutoSize = true;
            this.labelAddCost1.Location = new System.Drawing.Point(12, 21);
            this.labelAddCost1.Name = "labelAddCost1";
            this.labelAddCost1.Size = new System.Drawing.Size(219, 13);
            this.labelAddCost1.TabIndex = 0;
            this.labelAddCost1.Text = "Escreva abaixo o valor que deseja adicionar.";
            // 
            // txtBoxAddValue
            // 
            this.txtBoxAddValue.Location = new System.Drawing.Point(74, 133);
            this.txtBoxAddValue.Name = "txtBoxAddValue";
            this.txtBoxAddValue.Size = new System.Drawing.Size(161, 20);
            this.txtBoxAddValue.TabIndex = 5;
            // 
            // bttAddAddCost
            // 
            this.bttAddAddCost.Location = new System.Drawing.Point(218, 189);
            this.bttAddAddCost.Name = "bttAddAddCost";
            this.bttAddAddCost.Size = new System.Drawing.Size(140, 23);
            this.bttAddAddCost.TabIndex = 6;
            this.bttAddAddCost.Text = "Adicionar";
            this.bttAddAddCost.UseVisualStyleBackColor = true;
            this.bttAddAddCost.Click += new System.EventHandler(this.bttAddAddCost_Click);
            // 
            // bttCancelAddCost
            // 
            this.bttCancelAddCost.Location = new System.Drawing.Point(364, 189);
            this.bttCancelAddCost.Name = "bttCancelAddCost";
            this.bttCancelAddCost.Size = new System.Drawing.Size(75, 23);
            this.bttCancelAddCost.TabIndex = 7;
            this.bttCancelAddCost.Text = "Cancelar";
            this.bttCancelAddCost.UseVisualStyleBackColor = true;
            this.bttCancelAddCost.Click += new System.EventHandler(this.bttCancelAddCost_Click);
            // 
            // radioButtonRenda
            // 
            this.radioButtonRenda.AutoSize = true;
            this.radioButtonRenda.Location = new System.Drawing.Point(74, 79);
            this.radioButtonRenda.Name = "radioButtonRenda";
            this.radioButtonRenda.Size = new System.Drawing.Size(57, 17);
            this.radioButtonRenda.TabIndex = 8;
            this.radioButtonRenda.TabStop = true;
            this.radioButtonRenda.Text = "Renda";
            this.radioButtonRenda.UseVisualStyleBackColor = true;
            // 
            // radioButtonGasto
            // 
            this.radioButtonGasto.AutoSize = true;
            this.radioButtonGasto.Location = new System.Drawing.Point(166, 79);
            this.radioButtonGasto.Name = "radioButtonGasto";
            this.radioButtonGasto.Size = new System.Drawing.Size(53, 17);
            this.radioButtonGasto.TabIndex = 9;
            this.radioButtonGasto.TabStop = true;
            this.radioButtonGasto.Text = "Gasto";
            this.radioButtonGasto.UseVisualStyleBackColor = true;
            // 
            // txtBoxAddDescription
            // 
            this.txtBoxAddDescription.Location = new System.Drawing.Point(74, 107);
            this.txtBoxAddDescription.Name = "txtBoxAddDescription";
            this.txtBoxAddDescription.Size = new System.Drawing.Size(284, 20);
            this.txtBoxAddDescription.TabIndex = 10;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 110);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(55, 13);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "Descrição";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(12, 136);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(54, 13);
            this.lblValue.TabIndex = 12;
            this.lblValue.Text = "Valor (R$)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Quaisquer dúvidas sobre como preencher, este campo, verifique a ";
            // 
            // linkLblAddCost
            // 
            this.linkLblAddCost.AutoSize = true;
            this.linkLblAddCost.Location = new System.Drawing.Point(332, 38);
            this.linkLblAddCost.Name = "linkLblAddCost";
            this.linkLblAddCost.Size = new System.Drawing.Size(45, 13);
            this.linkLblAddCost.TabIndex = 14;
            this.linkLblAddCost.TabStop = true;
            this.linkLblAddCost.Text = "AJUDA.";
            this.linkLblAddCost.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblAddCost_LinkClicked);
            // 
            // AddCost
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(454, 224);
            this.Controls.Add(this.linkLblAddCost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtBoxAddDescription);
            this.Controls.Add(this.radioButtonGasto);
            this.Controls.Add(this.radioButtonRenda);
            this.Controls.Add(this.bttCancelAddCost);
            this.Controls.Add(this.bttAddAddCost);
            this.Controls.Add(this.txtBoxAddValue);
            this.Controls.Add(this.labelAddCost1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddCost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Valor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddCost1;
        private System.Windows.Forms.TextBox txtBoxAddValue;
        private System.Windows.Forms.Button bttAddAddCost;
        private System.Windows.Forms.Button bttCancelAddCost;
        private System.Windows.Forms.RadioButton radioButtonRenda;
        private System.Windows.Forms.RadioButton radioButtonGasto;
        private System.Windows.Forms.TextBox txtBoxAddDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLblAddCost;
    }
}