namespace Lecture_8
{
    partial class frmTaxCalculator
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblTaxRate = new System.Windows.Forms.Label();
            this.txtTaxRate = new System.Windows.Forms.TextBox();
            this.lblFinalTax = new System.Windows.Forms.Label();
            this.txtFinalTax = new System.Windows.Forms.TextBox();
            this.btnCalculateTax = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblAmount.Location = new System.Drawing.Point(111, 74);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(66, 19);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtAmount.Location = new System.Drawing.Point(213, 74);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(272, 27);
            this.txtAmount.TabIndex = 1;
            // 
            // lblTaxRate
            // 
            this.lblTaxRate.AutoSize = true;
            this.lblTaxRate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblTaxRate.Location = new System.Drawing.Point(108, 165);
            this.lblTaxRate.Name = "lblTaxRate";
            this.lblTaxRate.Size = new System.Drawing.Size(71, 19);
            this.lblTaxRate.TabIndex = 2;
            this.lblTaxRate.Text = "Tax Rate";
            // 
            // txtTaxRate
            // 
            this.txtTaxRate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtTaxRate.Location = new System.Drawing.Point(213, 162);
            this.txtTaxRate.Name = "txtTaxRate";
            this.txtTaxRate.Size = new System.Drawing.Size(272, 27);
            this.txtTaxRate.TabIndex = 2;
            // 
            // lblFinalTax
            // 
            this.lblFinalTax.AutoSize = true;
            this.lblFinalTax.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblFinalTax.Location = new System.Drawing.Point(108, 364);
            this.lblFinalTax.Name = "lblFinalTax";
            this.lblFinalTax.Size = new System.Drawing.Size(73, 19);
            this.lblFinalTax.TabIndex = 4;
            this.lblFinalTax.Text = "Final Tax";
            // 
            // txtFinalTax
            // 
            this.txtFinalTax.Enabled = false;
            this.txtFinalTax.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtFinalTax.Location = new System.Drawing.Point(213, 361);
            this.txtFinalTax.Name = "txtFinalTax";
            this.txtFinalTax.Size = new System.Drawing.Size(272, 27);
            this.txtFinalTax.TabIndex = 4;
            // 
            // btnCalculateTax
            // 
            this.btnCalculateTax.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnCalculateTax.Location = new System.Drawing.Point(247, 255);
            this.btnCalculateTax.Name = "btnCalculateTax";
            this.btnCalculateTax.Size = new System.Drawing.Size(204, 57);
            this.btnCalculateTax.TabIndex = 3;
            this.btnCalculateTax.Text = "Calculate Tax";
            this.btnCalculateTax.UseVisualStyleBackColor = true;
            this.btnCalculateTax.Click += new System.EventHandler(this.btnCalculateTax_Click);
            // 
            // frmTaxCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(637, 441);
            this.Controls.Add(this.btnCalculateTax);
            this.Controls.Add(this.txtFinalTax);
            this.Controls.Add(this.lblFinalTax);
            this.Controls.Add(this.txtTaxRate);
            this.Controls.Add(this.lblTaxRate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Name = "frmTaxCalculator";
            this.Text = "Tax Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblTaxRate;
        private System.Windows.Forms.TextBox txtTaxRate;
        private System.Windows.Forms.Label lblFinalTax;
        private System.Windows.Forms.TextBox txtFinalTax;
        private System.Windows.Forms.Button btnCalculateTax;
    }
}

