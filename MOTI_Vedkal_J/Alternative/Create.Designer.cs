namespace MOTI_Vedkal_J.Alternative
{
    partial class Create
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
            this.AlternativeNameLB = new System.Windows.Forms.Label();
            this.AlternativeNameTB = new System.Windows.Forms.TextBox();
            this.CriteriaNameLB = new System.Windows.Forms.Label();
            this.CriteriaNameTB = new System.Windows.Forms.TextBox();
            this.ValueLB = new System.Windows.Forms.Label();
            this.ValueTB = new System.Windows.Forms.TextBox();
            this.ValueCHB = new System.Windows.Forms.CheckBox();
            this.ValueNUM = new System.Windows.Forms.NumericUpDown();
            this.NextBTN = new System.Windows.Forms.Button();
            this.BackBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ValueNUM)).BeginInit();
            this.SuspendLayout();
            // 
            // AlternativeNameLB
            // 
            this.AlternativeNameLB.AutoSize = true;
            this.AlternativeNameLB.Location = new System.Drawing.Point(28, 27);
            this.AlternativeNameLB.Name = "AlternativeNameLB";
            this.AlternativeNameLB.Size = new System.Drawing.Size(86, 13);
            this.AlternativeNameLB.TabIndex = 0;
            this.AlternativeNameLB.Text = "Alternative name";
            // 
            // AlternativeNameTB
            // 
            this.AlternativeNameTB.Location = new System.Drawing.Point(135, 27);
            this.AlternativeNameTB.Name = "AlternativeNameTB";
            this.AlternativeNameTB.Size = new System.Drawing.Size(283, 20);
            this.AlternativeNameTB.TabIndex = 1;
            // 
            // CriteriaNameLB
            // 
            this.CriteriaNameLB.AutoSize = true;
            this.CriteriaNameLB.Location = new System.Drawing.Point(31, 76);
            this.CriteriaNameLB.Name = "CriteriaNameLB";
            this.CriteriaNameLB.Size = new System.Drawing.Size(68, 13);
            this.CriteriaNameLB.TabIndex = 2;
            this.CriteriaNameLB.Text = "Criteria name";
            // 
            // CriteriaNameTB
            // 
            this.CriteriaNameTB.Enabled = false;
            this.CriteriaNameTB.Location = new System.Drawing.Point(135, 76);
            this.CriteriaNameTB.Name = "CriteriaNameTB";
            this.CriteriaNameTB.Size = new System.Drawing.Size(283, 20);
            this.CriteriaNameTB.TabIndex = 3;
            // 
            // ValueLB
            // 
            this.ValueLB.AutoSize = true;
            this.ValueLB.Location = new System.Drawing.Point(34, 126);
            this.ValueLB.Name = "ValueLB";
            this.ValueLB.Size = new System.Drawing.Size(34, 13);
            this.ValueLB.TabIndex = 4;
            this.ValueLB.Text = "Value";
            // 
            // ValueTB
            // 
            this.ValueTB.Location = new System.Drawing.Point(135, 126);
            this.ValueTB.Name = "ValueTB";
            this.ValueTB.Size = new System.Drawing.Size(283, 20);
            this.ValueTB.TabIndex = 5;
            this.ValueTB.Visible = false;
            // 
            // ValueCHB
            // 
            this.ValueCHB.AutoSize = true;
            this.ValueCHB.Location = new System.Drawing.Point(248, 128);
            this.ValueCHB.Name = "ValueCHB";
            this.ValueCHB.Size = new System.Drawing.Size(15, 14);
            this.ValueCHB.TabIndex = 6;
            this.ValueCHB.UseVisualStyleBackColor = true;
            this.ValueCHB.Visible = false;
            // 
            // ValueNUM
            // 
            this.ValueNUM.Location = new System.Drawing.Point(225, 126);
            this.ValueNUM.Name = "ValueNUM";
            this.ValueNUM.Size = new System.Drawing.Size(120, 20);
            this.ValueNUM.TabIndex = 7;
            this.ValueNUM.Visible = false;
            // 
            // NextBTN
            // 
            this.NextBTN.Location = new System.Drawing.Point(320, 254);
            this.NextBTN.Name = "NextBTN";
            this.NextBTN.Size = new System.Drawing.Size(98, 23);
            this.NextBTN.TabIndex = 8;
            this.NextBTN.Text = "Next";
            this.NextBTN.UseVisualStyleBackColor = true;
            this.NextBTN.Click += new System.EventHandler(this.NextBTN_Click);
            // 
            // BackBTN
            // 
            this.BackBTN.Location = new System.Drawing.Point(13, 254);
            this.BackBTN.Name = "BackBTN";
            this.BackBTN.Size = new System.Drawing.Size(75, 23);
            this.BackBTN.TabIndex = 9;
            this.BackBTN.Text = "Back";
            this.BackBTN.UseVisualStyleBackColor = true;
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 289);
            this.Controls.Add(this.BackBTN);
            this.Controls.Add(this.NextBTN);
            this.Controls.Add(this.ValueNUM);
            this.Controls.Add(this.ValueCHB);
            this.Controls.Add(this.ValueTB);
            this.Controls.Add(this.ValueLB);
            this.Controls.Add(this.CriteriaNameTB);
            this.Controls.Add(this.CriteriaNameLB);
            this.Controls.Add(this.AlternativeNameTB);
            this.Controls.Add(this.AlternativeNameLB);
            this.Name = "Create";
            this.Text = "Create";
            ((System.ComponentModel.ISupportInitialize)(this.ValueNUM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AlternativeNameLB;
        private System.Windows.Forms.TextBox AlternativeNameTB;
        private System.Windows.Forms.Label CriteriaNameLB;
        private System.Windows.Forms.TextBox CriteriaNameTB;
        private System.Windows.Forms.Label ValueLB;
        private System.Windows.Forms.TextBox ValueTB;
        private System.Windows.Forms.CheckBox ValueCHB;
        private System.Windows.Forms.NumericUpDown ValueNUM;
        private System.Windows.Forms.Button NextBTN;
        private System.Windows.Forms.Button BackBTN;
    }
}