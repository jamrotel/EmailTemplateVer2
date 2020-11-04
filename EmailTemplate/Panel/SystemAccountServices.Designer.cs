namespace EmailTemplate.Panel
{
    partial class SystemAccountServices
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenericAccount = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenericAccount
            // 
            this.btnGenericAccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenericAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnGenericAccount.ForeColor = System.Drawing.Color.White;
            this.btnGenericAccount.Location = new System.Drawing.Point(24, 72);
            this.btnGenericAccount.Name = "btnGenericAccount";
            this.btnGenericAccount.Size = new System.Drawing.Size(167, 35);
            this.btnGenericAccount.TabIndex = 15;
            this.btnGenericAccount.Text = "Generic Account Creation";
            this.btnGenericAccount.UseCustomBackColor = true;
            this.btnGenericAccount.UseCustomForeColor = true;
            this.btnGenericAccount.UseSelectable = true;
            this.btnGenericAccount.Click += new System.EventHandler(this.btnGenericAccount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "SYSTEM ACCOUNT SERVICES";
            // 
            // SystemAccountServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenericAccount);
            this.Name = "SystemAccountServices";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnGenericAccount;
        private System.Windows.Forms.Label label1;
    }
}
