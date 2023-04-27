namespace Lecture_19
{
    partial class frmUserControlDemo
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
            this.ucEmployeeCard1 = new Lecture_19.ucEmployeeCard();
            this.SuspendLayout();
            // 
            // ucEmployeeCard1
            // 
            this.ucEmployeeCard1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucEmployeeCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucEmployeeCard1.Location = new System.Drawing.Point(100, 79);
            this.ucEmployeeCard1.Name = "ucEmployeeCard1";
            this.ucEmployeeCard1.Size = new System.Drawing.Size(558, 233);
            this.ucEmployeeCard1.TabIndex = 0;
            // 
            // frmUserControlDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucEmployeeCard1);
            this.Name = "frmUserControlDemo";
            this.Text = "frmUserControlDemo";
            this.Load += new System.EventHandler(this.frmUserControlDemo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ucEmployeeCard ucEmployeeCard1;
    }
}