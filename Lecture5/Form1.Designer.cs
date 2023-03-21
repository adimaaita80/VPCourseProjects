namespace Lecture5
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
            this.btnPrintHello = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLetterCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPrintHello
            // 
            this.btnPrintHello.Location = new System.Drawing.Point(71, 165);
            this.btnPrintHello.Name = "btnPrintHello";
            this.btnPrintHello.Size = new System.Drawing.Size(202, 59);
            this.btnPrintHello.TabIndex = 0;
            this.btnPrintHello.Text = "Print Welcome Message";
            this.btnPrintHello.UseVisualStyleBackColor = true;
            this.btnPrintHello.Click += new System.EventHandler(this.btnPrintHello_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(71, 90);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(359, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(68, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(125, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Please enter your name:";
            // 
            // lblLetterCount
            // 
            this.lblLetterCount.AutoSize = true;
            this.lblLetterCount.Location = new System.Drawing.Point(395, 113);
            this.lblLetterCount.Name = "lblLetterCount";
            this.lblLetterCount.Size = new System.Drawing.Size(0, 13);
            this.lblLetterCount.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 259);
            this.Controls.Add(this.lblLetterCount);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnPrintHello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrintHello;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLetterCount;
    }
}

