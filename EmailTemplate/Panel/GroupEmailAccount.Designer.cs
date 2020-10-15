namespace EmailTemplate.Panel
{
    partial class GroupEmailAccount
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
            this.btnGroupEmailAccountCreation = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGroupEmailAccountAccess = new MetroFramework.Controls.MetroButton();
            this.btnGroupEmailAccountModification = new MetroFramework.Controls.MetroButton();
            this.btnGroupEmailAccountDeletion = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnGroupEmailAccountCreation
            // 
            this.btnGroupEmailAccountCreation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGroupEmailAccountCreation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnGroupEmailAccountCreation.ForeColor = System.Drawing.Color.White;
            this.btnGroupEmailAccountCreation.Location = new System.Drawing.Point(216, 98);
            this.btnGroupEmailAccountCreation.Name = "btnGroupEmailAccountCreation";
            this.btnGroupEmailAccountCreation.Size = new System.Drawing.Size(152, 35);
            this.btnGroupEmailAccountCreation.TabIndex = 23;
            this.btnGroupEmailAccountCreation.Text = "Group Email Account \r\nCreation";
            this.btnGroupEmailAccountCreation.UseCustomBackColor = true;
            this.btnGroupEmailAccountCreation.UseCustomForeColor = true;
            this.btnGroupEmailAccountCreation.UseSelectable = true;
            this.btnGroupEmailAccountCreation.Click += new System.EventHandler(this.btnGroupEmailAccountCreation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(21, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "GROUP EMAIL ACCOUNT";
            // 
            // btnGroupEmailAccountAccess
            // 
            this.btnGroupEmailAccountAccess.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGroupEmailAccountAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnGroupEmailAccountAccess.ForeColor = System.Drawing.Color.White;
            this.btnGroupEmailAccountAccess.Location = new System.Drawing.Point(216, 139);
            this.btnGroupEmailAccountAccess.Name = "btnGroupEmailAccountAccess";
            this.btnGroupEmailAccountAccess.Size = new System.Drawing.Size(152, 35);
            this.btnGroupEmailAccountAccess.TabIndex = 26;
            this.btnGroupEmailAccountAccess.Text = "Group Email Account \r\nAccess";
            this.btnGroupEmailAccountAccess.UseCustomBackColor = true;
            this.btnGroupEmailAccountAccess.UseCustomForeColor = true;
            this.btnGroupEmailAccountAccess.UseSelectable = true;
            this.btnGroupEmailAccountAccess.Click += new System.EventHandler(this.btnGroupEmailAccountAccess_Click);
            // 
            // btnGroupEmailAccountModification
            // 
            this.btnGroupEmailAccountModification.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGroupEmailAccountModification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnGroupEmailAccountModification.ForeColor = System.Drawing.Color.White;
            this.btnGroupEmailAccountModification.Location = new System.Drawing.Point(216, 180);
            this.btnGroupEmailAccountModification.Name = "btnGroupEmailAccountModification";
            this.btnGroupEmailAccountModification.Size = new System.Drawing.Size(152, 35);
            this.btnGroupEmailAccountModification.TabIndex = 27;
            this.btnGroupEmailAccountModification.Text = "Group Email Account \r\nModification";
            this.btnGroupEmailAccountModification.UseCustomBackColor = true;
            this.btnGroupEmailAccountModification.UseCustomForeColor = true;
            this.btnGroupEmailAccountModification.UseSelectable = true;
            this.btnGroupEmailAccountModification.Click += new System.EventHandler(this.btnGroupEmailAccountModification_Click);
            // 
            // btnGroupEmailAccountDeletion
            // 
            this.btnGroupEmailAccountDeletion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGroupEmailAccountDeletion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnGroupEmailAccountDeletion.ForeColor = System.Drawing.Color.White;
            this.btnGroupEmailAccountDeletion.Location = new System.Drawing.Point(216, 221);
            this.btnGroupEmailAccountDeletion.Name = "btnGroupEmailAccountDeletion";
            this.btnGroupEmailAccountDeletion.Size = new System.Drawing.Size(152, 35);
            this.btnGroupEmailAccountDeletion.TabIndex = 28;
            this.btnGroupEmailAccountDeletion.Text = "Group Email Account \r\nDeletion";
            this.btnGroupEmailAccountDeletion.UseCustomBackColor = true;
            this.btnGroupEmailAccountDeletion.UseCustomForeColor = true;
            this.btnGroupEmailAccountDeletion.UseSelectable = true;
            // 
            // GroupEmailAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.btnGroupEmailAccountDeletion);
            this.Controls.Add(this.btnGroupEmailAccountModification);
            this.Controls.Add(this.btnGroupEmailAccountAccess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGroupEmailAccountCreation);
            this.Name = "GroupEmailAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnGroupEmailAccountCreation;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnGroupEmailAccountAccess;
        private MetroFramework.Controls.MetroButton btnGroupEmailAccountModification;
        private MetroFramework.Controls.MetroButton btnGroupEmailAccountDeletion;
    }
}
