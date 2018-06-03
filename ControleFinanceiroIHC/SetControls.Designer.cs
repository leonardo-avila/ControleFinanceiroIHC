namespace ControleFinanceiroIHC
{
    partial class SetControls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetControls));
            this.bttApply = new System.Windows.Forms.Button();
            this.bttCancel = new System.Windows.Forms.Button();
            this.percentageTrackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBarLabel = new System.Windows.Forms.Label();
            this.trackBarValueLb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.percentageTrackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttApply
            // 
            this.bttApply.Location = new System.Drawing.Point(22, 149);
            this.bttApply.Name = "bttApply";
            this.bttApply.Size = new System.Drawing.Size(114, 23);
            this.bttApply.TabIndex = 4;
            this.bttApply.Text = "Aplicar";
            this.bttApply.UseVisualStyleBackColor = true;
            this.bttApply.Click += new System.EventHandler(this.bttApply_Click);
            // 
            // bttCancel
            // 
            this.bttCancel.Location = new System.Drawing.Point(142, 149);
            this.bttCancel.Name = "bttCancel";
            this.bttCancel.Size = new System.Drawing.Size(75, 23);
            this.bttCancel.TabIndex = 5;
            this.bttCancel.Text = "Cancelar";
            this.bttCancel.UseVisualStyleBackColor = true;
            this.bttCancel.Click += new System.EventHandler(this.bttCancel_Click);
            // 
            // percentageTrackBar1
            // 
            this.percentageTrackBar1.Location = new System.Drawing.Point(22, 68);
            this.percentageTrackBar1.Maximum = 100;
            this.percentageTrackBar1.Name = "percentageTrackBar1";
            this.percentageTrackBar1.Size = new System.Drawing.Size(195, 45);
            this.percentageTrackBar1.SmallChange = 5;
            this.percentageTrackBar1.TabIndex = 13;
            this.percentageTrackBar1.Scroll += new System.EventHandler(this.percentageTrackBar1_Scroll);
            // 
            // trackBarLabel
            // 
            this.trackBarLabel.AutoSize = true;
            this.trackBarLabel.Location = new System.Drawing.Point(19, 116);
            this.trackBarLabel.Name = "trackBarLabel";
            this.trackBarLabel.Size = new System.Drawing.Size(102, 13);
            this.trackBarLabel.TabIndex = 15;
            this.trackBarLabel.Text = "Porcentagem atual: ";
            // 
            // trackBarValueLb
            // 
            this.trackBarValueLb.AutoSize = true;
            this.trackBarValueLb.Location = new System.Drawing.Point(127, 116);
            this.trackBarValueLb.Name = "trackBarValueLb";
            this.trackBarValueLb.Size = new System.Drawing.Size(21, 13);
            this.trackBarValueLb.TabIndex = 16;
            this.trackBarValueLb.Text = "0%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Defina a porcentagem da sua renda que";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "você deseja economizar.";
            // 
            // SetControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(233, 191);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarValueLb);
            this.Controls.Add(this.trackBarLabel);
            this.Controls.Add(this.percentageTrackBar1);
            this.Controls.Add(this.bttCancel);
            this.Controls.Add(this.bttApply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SetControls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Definir Controle";
            this.Load += new System.EventHandler(this.SetControls_Load);
            ((System.ComponentModel.ISupportInitialize)(this.percentageTrackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttApply;
        private System.Windows.Forms.Button bttCancel;
        private System.Windows.Forms.TrackBar percentageTrackBar1;
        private System.Windows.Forms.Label trackBarLabel;
        private System.Windows.Forms.Label trackBarValueLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}