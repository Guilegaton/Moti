namespace MOTI_Vedkal_J
{
    partial class SignUp
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginLB = new System.Windows.Forms.Label();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.SignUpBTN = new System.Windows.Forms.Button();
            this.SignInBTN = new System.Windows.Forms.Button();
            this.ErrorLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginLB
            // 
            this.LoginLB.AutoSize = true;
            this.LoginLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLB.Location = new System.Drawing.Point(87, 87);
            this.LoginLB.Name = "LoginLB";
            this.LoginLB.Size = new System.Drawing.Size(65, 26);
            this.LoginLB.TabIndex = 0;
            this.LoginLB.Text = "Login";
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(158, 93);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(100, 20);
            this.LoginTB.TabIndex = 1;
            // 
            // SignUpBTN
            // 
            this.SignUpBTN.Location = new System.Drawing.Point(204, 146);
            this.SignUpBTN.Name = "SignUpBTN";
            this.SignUpBTN.Size = new System.Drawing.Size(75, 23);
            this.SignUpBTN.TabIndex = 2;
            this.SignUpBTN.Text = "Sign Up";
            this.SignUpBTN.UseVisualStyleBackColor = true;
            this.SignUpBTN.Click += new System.EventHandler(this.SignUpBTN_Click);
            // 
            // SignInBTN
            // 
            this.SignInBTN.Location = new System.Drawing.Point(63, 146);
            this.SignInBTN.Name = "SignInBTN";
            this.SignInBTN.Size = new System.Drawing.Size(75, 23);
            this.SignInBTN.TabIndex = 3;
            this.SignInBTN.Text = "Sign In";
            this.SignInBTN.UseVisualStyleBackColor = true;
            this.SignInBTN.Click += new System.EventHandler(this.SignInBTN_Click);
            // 
            // ErrorLB
            // 
            this.ErrorLB.AutoSize = true;
            this.ErrorLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLB.ForeColor = System.Drawing.Color.Red;
            this.ErrorLB.Location = new System.Drawing.Point(154, 52);
            this.ErrorLB.Name = "ErrorLB";
            this.ErrorLB.Size = new System.Drawing.Size(0, 24);
            this.ErrorLB.TabIndex = 4;
            this.ErrorLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 211);
            this.Controls.Add(this.ErrorLB);
            this.Controls.Add(this.SignInBTN);
            this.Controls.Add(this.SignUpBTN);
            this.Controls.Add(this.LoginTB);
            this.Controls.Add(this.LoginLB);
            this.Name = "SignUp";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginLB;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.Button SignUpBTN;
        private System.Windows.Forms.Button SignInBTN;
        private System.Windows.Forms.Label ErrorLB;
    }
}

