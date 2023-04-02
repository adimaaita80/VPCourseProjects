namespace Lecture_10
{
    partial class Form1
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
            this.lblNumberOfControls = new System.Windows.Forms.Label();
            this.txtNumberOfControls = new System.Windows.Forms.TextBox();
            this.btnCreateControls = new System.Windows.Forms.Button();
            this.pnlDynamicControls = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumberOfControls
            // 
            this.lblNumberOfControls.AutoSize = true;
            this.lblNumberOfControls.Location = new System.Drawing.Point(35, 167);
            this.lblNumberOfControls.Name = "lblNumberOfControls";
            this.lblNumberOfControls.Size = new System.Drawing.Size(98, 13);
            this.lblNumberOfControls.TabIndex = 0;
            this.lblNumberOfControls.Text = "Number of controls";
            // 
            // txtNumberOfControls
            // 
            this.txtNumberOfControls.Location = new System.Drawing.Point(139, 164);
            this.txtNumberOfControls.Name = "txtNumberOfControls";
            this.txtNumberOfControls.Size = new System.Drawing.Size(241, 20);
            this.txtNumberOfControls.TabIndex = 1;
            // 
            // btnCreateControls
            // 
            this.btnCreateControls.Location = new System.Drawing.Point(139, 204);
            this.btnCreateControls.Name = "btnCreateControls";
            this.btnCreateControls.Size = new System.Drawing.Size(141, 41);
            this.btnCreateControls.TabIndex = 2;
            this.btnCreateControls.Text = "Create Controls";
            this.btnCreateControls.UseVisualStyleBackColor = true;
            this.btnCreateControls.Click += new System.EventHandler(this.btnCreateControls_Click);
            // 
            // pnlDynamicControls
            // 
            this.pnlDynamicControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDynamicControls.Location = new System.Drawing.Point(76, 276);
            this.pnlDynamicControls.Name = "pnlDynamicControls";
            this.pnlDynamicControls.Size = new System.Drawing.Size(304, 472);
            this.pnlDynamicControls.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Button",
            "TextBox",
            "Label"});
            this.comboBox1.Location = new System.Drawing.Point(139, 118);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(241, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Control Type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 770);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pnlDynamicControls);
            this.Controls.Add(this.btnCreateControls);
            this.Controls.Add(this.txtNumberOfControls);
            this.Controls.Add(this.lblNumberOfControls);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumberOfControls;
        private System.Windows.Forms.TextBox txtNumberOfControls;
        private System.Windows.Forms.Button btnCreateControls;
        private System.Windows.Forms.Panel pnlDynamicControls;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}

