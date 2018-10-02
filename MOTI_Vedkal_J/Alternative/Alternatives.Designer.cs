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
            this.AlternativesCB.FormattingEnabled = true;
            this.AlternativesCB.Location = new System.Drawing.Point(508, 12);
            this.AlternativesCB.Name = "AlternativesCB";
            this.AlternativesCB.Size = new System.Drawing.Size(121, 21);
            this.AlternativesCB.TabIndex = 1;
            this.AlternativesCB.TextChanged += new System.EventHandler(this.AlternativesCB_TextChanged);
            // 
            // Alternatives
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 450);
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
    }
}