namespace MOTI_Vedkal_J
{
    partial class Alternatives
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
            this.AlternativesGrid = new System.Windows.Forms.DataGridView();
            this.AlternativesCB = new System.Windows.Forms.ComboBox();
            this.CriteriaBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AlternativesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AlternativesGrid
            // 
            this.AlternativesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlternativesGrid.Location = new System.Drawing.Point(12, 40);
            this.AlternativesGrid.Name = "AlternativesGrid";
            this.AlternativesGrid.Size = new System.Drawing.Size(628, 377);
            this.AlternativesGrid.TabIndex = 0;
            // 
            // AlternativesCB
            // 
            this.AlternativesCB.Cursor = System.Windows.Forms.Cursors.Default;
            this.AlternativesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AlternativesCB.FormattingEnabled = true;
            this.AlternativesCB.Location = new System.Drawing.Point(508, 12);
            this.AlternativesCB.Name = "AlternativesCB";
            this.AlternativesCB.Size = new System.Drawing.Size(121, 21);
            this.AlternativesCB.TabIndex = 1;
            this.AlternativesCB.TextChanged += new System.EventHandler(this.AlternativesCB_TextChanged);
            // 
            // CriteriaBTN
            // 
            this.CriteriaBTN.Location = new System.Drawing.Point(13, 12);
            this.CriteriaBTN.Name = "CriteriaBTN";
            this.CriteriaBTN.Size = new System.Drawing.Size(75, 23);
            this.CriteriaBTN.TabIndex = 2;
            this.CriteriaBTN.Text = "Criteria";
            this.CriteriaBTN.UseVisualStyleBackColor = true;
            this.CriteriaBTN.Click += new System.EventHandler(this.CriteriaBTN_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Alternatives
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CriteriaBTN);
            this.Controls.Add(this.AlternativesCB);
            this.Controls.Add(this.AlternativesGrid);
            this.Name = "Alternatives";
            this.Text = "Alternatives";
            ((System.ComponentModel.ISupportInitialize)(this.AlternativesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AlternativesGrid;
        private System.Windows.Forms.ComboBox AlternativesCB;
        private System.Windows.Forms.Button CriteriaBTN;
        private System.Windows.Forms.Button button1;
    }
}