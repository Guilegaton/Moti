namespace MOTI_Vedkal_J.Criteria
{
    partial class AddCriteria
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
            this.NameLB = new System.Windows.Forms.Label();
            this.TypeLB = new System.Windows.Forms.Label();
            this.EdIzmerLB = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.UnitTB = new System.Windows.Forms.TextBox();
            this.TypeCB = new System.Windows.Forms.ComboBox();
            this.CreateBTN = new System.Windows.Forms.Button();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.ErrorLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLB
            // 
            this.NameLB.AutoSize = true;
            this.NameLB.Location = new System.Drawing.Point(13, 40);
            this.NameLB.Name = "NameLB";
            this.NameLB.Size = new System.Drawing.Size(35, 13);
            this.NameLB.TabIndex = 0;
            this.NameLB.Text = "Name";
            // 
            // TypeLB
            // 
            this.TypeLB.AutoSize = true;
            this.TypeLB.Location = new System.Drawing.Point(13, 76);
            this.TypeLB.Name = "TypeLB";
            this.TypeLB.Size = new System.Drawing.Size(31, 13);
            this.TypeLB.TabIndex = 1;
            this.TypeLB.Text = "Type";
            // 
            // EdIzmerLB
            // 
            this.EdIzmerLB.AutoSize = true;
            this.EdIzmerLB.Location = new System.Drawing.Point(13, 117);
            this.EdIzmerLB.Name = "EdIzmerLB";
            this.EdIzmerLB.Size = new System.Drawing.Size(26, 13);
            this.EdIzmerLB.TabIndex = 3;
            this.EdIzmerLB.Text = "Unit";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(103, 32);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(161, 20);
            this.NameTB.TabIndex = 4;
            // 
            // UnitTB
            // 
            this.UnitTB.Location = new System.Drawing.Point(103, 117);
            this.UnitTB.Name = "UnitTB";
            this.UnitTB.Size = new System.Drawing.Size(161, 20);
            this.UnitTB.TabIndex = 6;
            // 
            // TypeCB
            // 
            this.TypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeCB.FormattingEnabled = true;
            this.TypeCB.Location = new System.Drawing.Point(103, 76);
            this.TypeCB.Name = "TypeCB";
            this.TypeCB.Size = new System.Drawing.Size(161, 21);
            this.TypeCB.TabIndex = 7;
            // 
            // CreateBTN
            // 
            this.CreateBTN.Location = new System.Drawing.Point(172, 169);
            this.CreateBTN.Name = "CreateBTN";
            this.CreateBTN.Size = new System.Drawing.Size(75, 23);
            this.CreateBTN.TabIndex = 8;
            this.CreateBTN.Text = "Create";
            this.CreateBTN.UseVisualStyleBackColor = true;
            this.CreateBTN.Click += new System.EventHandler(this.CreateBTN_Click);
            // 
            // CancelBTN
            // 
            this.CancelBTN.Location = new System.Drawing.Point(39, 169);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(75, 23);
            this.CancelBTN.TabIndex = 9;
            this.CancelBTN.Text = "Cancel";
            this.CancelBTN.UseVisualStyleBackColor = true;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // ErrorLB
            // 
            this.ErrorLB.AutoSize = true;
            this.ErrorLB.Location = new System.Drawing.Point(13, 13);
            this.ErrorLB.Name = "ErrorLB";
            this.ErrorLB.Size = new System.Drawing.Size(0, 13);
            this.ErrorLB.TabIndex = 10;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 204);
            this.Controls.Add(this.ErrorLB);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.CreateBTN);
            this.Controls.Add(this.TypeCB);
            this.Controls.Add(this.UnitTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.EdIzmerLB);
            this.Controls.Add(this.TypeLB);
            this.Controls.Add(this.NameLB);
            this.Name = "Add";
            this.Text = "Criteria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLB;
        private System.Windows.Forms.Label TypeLB;
        private System.Windows.Forms.Label EdIzmerLB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox UnitTB;
        private System.Windows.Forms.ComboBox TypeCB;
        private System.Windows.Forms.Button CreateBTN;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.Label ErrorLB;
    }
}