namespace Lecture_7
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
            this.btnDisplayNewForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDisplayNewForm
            // 
            this.btnDisplayNewForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisplayNewForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDisplayNewForm.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayNewForm.ForeColor = System.Drawing.Color.Purple;
            this.btnDisplayNewForm.Location = new System.Drawing.Point(153, 170);
            this.btnDisplayNewForm.Name = "btnDisplayNewForm";
            this.btnDisplayNewForm.Size = new System.Drawing.Size(346, 112);
            this.btnDisplayNewForm.TabIndex = 0;
            this.btnDisplayNewForm.Text = "Display new form";
            this.btnDisplayNewForm.UseVisualStyleBackColor = false;
            this.btnDisplayNewForm.Click += new System.EventHandler(this.btnDisplayNewForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 469);
            this.Controls.Add(this.btnDisplayNewForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDisplayNewForm;
    }
}

