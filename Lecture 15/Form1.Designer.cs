namespace Lecture_15
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
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.chkbxSwimming = new System.Windows.Forms.CheckBox();
            this.chkbxReading = new System.Windows.Forms.CheckBox();
            this.chkbxGaming = new System.Windows.Forms.CheckBox();
            this.chkbxHiking = new System.Windows.Forms.CheckBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.rbtnFulltime = new System.Windows.Forms.RadioButton();
            this.rbtnParttime = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(19, 42);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(59, 23);
            this.rbtnMale.TabIndex = 0;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(95, 42);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(77, 23);
            this.rbtnFemale.TabIndex = 1;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // chkbxSwimming
            // 
            this.chkbxSwimming.AutoSize = true;
            this.chkbxSwimming.Location = new System.Drawing.Point(18, 31);
            this.chkbxSwimming.Name = "chkbxSwimming";
            this.chkbxSwimming.Size = new System.Drawing.Size(103, 23);
            this.chkbxSwimming.TabIndex = 2;
            this.chkbxSwimming.Text = "Swimming";
            this.chkbxSwimming.UseVisualStyleBackColor = true;
            // 
            // chkbxReading
            // 
            this.chkbxReading.AutoSize = true;
            this.chkbxReading.Location = new System.Drawing.Point(18, 71);
            this.chkbxReading.Name = "chkbxReading";
            this.chkbxReading.Size = new System.Drawing.Size(85, 23);
            this.chkbxReading.TabIndex = 5;
            this.chkbxReading.Text = "Reading";
            this.chkbxReading.UseVisualStyleBackColor = true;
            // 
            // chkbxGaming
            // 
            this.chkbxGaming.AutoSize = true;
            this.chkbxGaming.Location = new System.Drawing.Point(18, 114);
            this.chkbxGaming.Name = "chkbxGaming";
            this.chkbxGaming.Size = new System.Drawing.Size(83, 23);
            this.chkbxGaming.TabIndex = 6;
            this.chkbxGaming.Text = "Gaming";
            this.chkbxGaming.UseVisualStyleBackColor = true;
            // 
            // chkbxHiking
            // 
            this.chkbxHiking.AutoSize = true;
            this.chkbxHiking.Location = new System.Drawing.Point(18, 164);
            this.chkbxHiking.Name = "chkbxHiking";
            this.chkbxHiking.Size = new System.Drawing.Size(73, 23);
            this.chkbxHiking.TabIndex = 7;
            this.chkbxHiking.Text = "Hiking";
            this.chkbxHiking.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(30, 445);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(182, 45);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register Employee";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // rbtnFulltime
            // 
            this.rbtnFulltime.AutoSize = true;
            this.rbtnFulltime.Location = new System.Drawing.Point(26, 46);
            this.rbtnFulltime.Name = "rbtnFulltime";
            this.rbtnFulltime.Size = new System.Drawing.Size(89, 23);
            this.rbtnFulltime.TabIndex = 10;
            this.rbtnFulltime.TabStop = true;
            this.rbtnFulltime.Text = "Full-time";
            this.rbtnFulltime.UseVisualStyleBackColor = true;
            // 
            // rbtnParttime
            // 
            this.rbtnParttime.AutoSize = true;
            this.rbtnParttime.Location = new System.Drawing.Point(137, 46);
            this.rbtnParttime.Name = "rbtnParttime";
            this.rbtnParttime.Size = new System.Drawing.Size(92, 23);
            this.rbtnParttime.TabIndex = 11;
            this.rbtnParttime.TabStop = true;
            this.rbtnParttime.Text = "Part-time";
            this.rbtnParttime.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnFemale);
            this.groupBox1.Controls.Add(this.rbtnMale);
            this.groupBox1.Location = new System.Drawing.Point(30, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 85);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkbxReading);
            this.groupBox2.Controls.Add(this.chkbxSwimming);
            this.groupBox2.Controls.Add(this.chkbxGaming);
            this.groupBox2.Controls.Add(this.chkbxHiking);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(30, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 204);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hobbies";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtnParttime);
            this.groupBox3.Controls.Add(this.rbtnFulltime);
            this.groupBox3.Location = new System.Drawing.Point(30, 339);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 100);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Employment Type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(339, 511);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegister);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.CheckBox chkbxSwimming;
        private System.Windows.Forms.CheckBox chkbxReading;
        private System.Windows.Forms.CheckBox chkbxGaming;
        private System.Windows.Forms.CheckBox chkbxHiking;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.RadioButton rbtnFulltime;
        private System.Windows.Forms.RadioButton rbtnParttime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

