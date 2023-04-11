namespace Lecture_14
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
            this.cbxCountries = new System.Windows.Forms.ComboBox();
            this.lbxCities = new System.Windows.Forms.ListBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtNewItem = new System.Windows.Forms.TextBox();
            this.txtNewCBXItems = new System.Windows.Forms.TextBox();
            this.btnAddCBXItem = new System.Windows.Forms.Button();
            this.txtSelectedListBoxItem = new System.Windows.Forms.TextBox();
            this.lblSelectedItem = new System.Windows.Forms.Label();
            this.lblSelectedCBXItem = new System.Windows.Forms.Label();
            this.txtSelectedComboBoxItem = new System.Windows.Forms.TextBox();
            this.btnDeleteListBoxItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxCountries
            // 
            this.cbxCountries.FormattingEnabled = true;
            this.cbxCountries.Items.AddRange(new object[] {
            "Jordan",
            "Syria",
            "Nigeria",
            "United Kingdom"});
            this.cbxCountries.Location = new System.Drawing.Point(25, 17);
            this.cbxCountries.Name = "cbxCountries";
            this.cbxCountries.Size = new System.Drawing.Size(268, 21);
            this.cbxCountries.TabIndex = 0;
            this.cbxCountries.SelectedIndexChanged += new System.EventHandler(this.cbxCountries_SelectedIndexChanged);
            // 
            // lbxCities
            // 
            this.lbxCities.FormattingEnabled = true;
            this.lbxCities.Items.AddRange(new object[] {
            "Amman",
            "Damascus",
            "Cairo",
            "London",
            "Paris"});
            this.lbxCities.Location = new System.Drawing.Point(25, 163);
            this.lbxCities.Name = "lbxCities";
            this.lbxCities.Size = new System.Drawing.Size(268, 186);
            this.lbxCities.TabIndex = 1;
            this.lbxCities.SelectedIndexChanged += new System.EventHandler(this.lbxCities_SelectedIndexChanged);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(218, 373);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(147, 23);
            this.btnAddItem.TabIndex = 5;
            this.btnAddItem.Text = "Add Item To ListBox";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtNewItem
            // 
            this.txtNewItem.Location = new System.Drawing.Point(25, 375);
            this.txtNewItem.Name = "txtNewItem";
            this.txtNewItem.Size = new System.Drawing.Size(186, 20);
            this.txtNewItem.TabIndex = 6;
            // 
            // txtNewCBXItems
            // 
            this.txtNewCBXItems.Location = new System.Drawing.Point(25, 63);
            this.txtNewCBXItems.Name = "txtNewCBXItems";
            this.txtNewCBXItems.Size = new System.Drawing.Size(186, 20);
            this.txtNewCBXItems.TabIndex = 8;
            // 
            // btnAddCBXItem
            // 
            this.btnAddCBXItem.Location = new System.Drawing.Point(218, 61);
            this.btnAddCBXItem.Name = "btnAddCBXItem";
            this.btnAddCBXItem.Size = new System.Drawing.Size(147, 23);
            this.btnAddCBXItem.TabIndex = 7;
            this.btnAddCBXItem.Text = "Add Item To ComboBox";
            this.btnAddCBXItem.UseVisualStyleBackColor = true;
            this.btnAddCBXItem.Click += new System.EventHandler(this.btnAddCBXItem_Click);
            // 
            // txtSelectedListBoxItem
            // 
            this.txtSelectedListBoxItem.Location = new System.Drawing.Point(495, 163);
            this.txtSelectedListBoxItem.Name = "txtSelectedListBoxItem";
            this.txtSelectedListBoxItem.Size = new System.Drawing.Size(258, 20);
            this.txtSelectedListBoxItem.TabIndex = 9;
            // 
            // lblSelectedItem
            // 
            this.lblSelectedItem.AutoSize = true;
            this.lblSelectedItem.Location = new System.Drawing.Point(492, 146);
            this.lblSelectedItem.Name = "lblSelectedItem";
            this.lblSelectedItem.Size = new System.Drawing.Size(110, 13);
            this.lblSelectedItem.TabIndex = 10;
            this.lblSelectedItem.Text = "Selected ListBox Item";
            // 
            // lblSelectedCBXItem
            // 
            this.lblSelectedCBXItem.AutoSize = true;
            this.lblSelectedCBXItem.Location = new System.Drawing.Point(492, 14);
            this.lblSelectedCBXItem.Name = "lblSelectedCBXItem";
            this.lblSelectedCBXItem.Size = new System.Drawing.Size(127, 13);
            this.lblSelectedCBXItem.TabIndex = 12;
            this.lblSelectedCBXItem.Text = "Selected ComboBox Item";
            // 
            // txtSelectedComboBoxItem
            // 
            this.txtSelectedComboBoxItem.Location = new System.Drawing.Point(495, 39);
            this.txtSelectedComboBoxItem.Name = "txtSelectedComboBoxItem";
            this.txtSelectedComboBoxItem.Size = new System.Drawing.Size(258, 20);
            this.txtSelectedComboBoxItem.TabIndex = 11;
            // 
            // btnDeleteListBoxItem
            // 
            this.btnDeleteListBoxItem.BackColor = System.Drawing.Color.Red;
            this.btnDeleteListBoxItem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteListBoxItem.ForeColor = System.Drawing.Color.White;
            this.btnDeleteListBoxItem.Location = new System.Drawing.Point(495, 211);
            this.btnDeleteListBoxItem.Name = "btnDeleteListBoxItem";
            this.btnDeleteListBoxItem.Size = new System.Drawing.Size(154, 44);
            this.btnDeleteListBoxItem.TabIndex = 13;
            this.btnDeleteListBoxItem.Text = "Delete Item";
            this.btnDeleteListBoxItem.UseVisualStyleBackColor = false;
            this.btnDeleteListBoxItem.Click += new System.EventHandler(this.btnDeleteListBoxItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.btnDeleteListBoxItem);
            this.Controls.Add(this.lblSelectedCBXItem);
            this.Controls.Add(this.txtSelectedComboBoxItem);
            this.Controls.Add(this.lblSelectedItem);
            this.Controls.Add(this.txtSelectedListBoxItem);
            this.Controls.Add(this.txtNewCBXItems);
            this.Controls.Add(this.btnAddCBXItem);
            this.Controls.Add(this.txtNewItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lbxCities);
            this.Controls.Add(this.cbxCountries);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCountries;
        private System.Windows.Forms.ListBox lbxCities;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox txtNewItem;
        private System.Windows.Forms.TextBox txtNewCBXItems;
        private System.Windows.Forms.Button btnAddCBXItem;
        private System.Windows.Forms.TextBox txtSelectedListBoxItem;
        private System.Windows.Forms.Label lblSelectedItem;
        private System.Windows.Forms.Label lblSelectedCBXItem;
        private System.Windows.Forms.TextBox txtSelectedComboBoxItem;
        private System.Windows.Forms.Button btnDeleteListBoxItem;
    }
}

