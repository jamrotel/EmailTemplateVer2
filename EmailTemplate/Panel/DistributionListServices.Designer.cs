namespace EmailTemplate.Panel
{
    partial class DistributionListServices
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
            this.btnDLModify = new MetroFramework.Controls.MetroButton();
            this.btnDLDeletion = new MetroFramework.Controls.MetroButton();
            this.btnCreateDL = new MetroFramework.Controls.MetroButton();
            this.btnDLAccess = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDLModify
            // 
            this.btnDLModify.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDLModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnDLModify.ForeColor = System.Drawing.Color.White;
            this.btnDLModify.Location = new System.Drawing.Point(25, 117);
            this.btnDLModify.Name = "btnDLModify";
            this.btnDLModify.Size = new System.Drawing.Size(194, 40);
            this.btnDLModify.TabIndex = 22;
            this.btnDLModify.Text = "Modify Distribution List";
            this.btnDLModify.UseCustomBackColor = true;
            this.btnDLModify.UseCustomForeColor = true;
            this.btnDLModify.UseSelectable = true;
            this.btnDLModify.Click += new System.EventHandler(this.btnDLModify_Click);
            // 
            // btnDLDeletion
            // 
            this.btnDLDeletion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDLDeletion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnDLDeletion.ForeColor = System.Drawing.Color.White;
            this.btnDLDeletion.Location = new System.Drawing.Point(25, 163);
            this.btnDLDeletion.Name = "btnDLDeletion";
            this.btnDLDeletion.Size = new System.Drawing.Size(194, 40);
            this.btnDLDeletion.TabIndex = 23;
            this.btnDLDeletion.Text = "Delete Distribution List";
            this.btnDLDeletion.UseCustomBackColor = true;
            this.btnDLDeletion.UseCustomForeColor = true;
            this.btnDLDeletion.UseSelectable = true;
            this.btnDLDeletion.Click += new System.EventHandler(this.btnDLDeletion_Click);
            // 
            // btnCreateDL
            // 
            this.btnCreateDL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreateDL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnCreateDL.ForeColor = System.Drawing.Color.White;
            this.btnCreateDL.Location = new System.Drawing.Point(25, 71);
            this.btnCreateDL.Name = "btnCreateDL";
            this.btnCreateDL.Size = new System.Drawing.Size(194, 40);
            this.btnCreateDL.TabIndex = 21;
            this.btnCreateDL.Text = "Create Group \r\nDistribution List";
            this.btnCreateDL.UseCustomBackColor = true;
            this.btnCreateDL.UseCustomForeColor = true;
            this.btnCreateDL.UseSelectable = true;
            this.btnCreateDL.Click += new System.EventHandler(this.btnCreateDL_Click);
            // 
            // btnDLAccess
            // 
            this.btnDLAccess.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDLAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnDLAccess.ForeColor = System.Drawing.Color.White;
            this.btnDLAccess.Location = new System.Drawing.Point(25, 209);
            this.btnDLAccess.Name = "btnDLAccess";
            this.btnDLAccess.Size = new System.Drawing.Size(194, 40);
            this.btnDLAccess.TabIndex = 24;
            this.btnDLAccess.Text = "Distribution List Access";
            this.btnDLAccess.UseCustomBackColor = true;
            this.btnDLAccess.UseCustomForeColor = true;
            this.btnDLAccess.UseSelectable = true;
            this.btnDLAccess.Click += new System.EventHandler(this.btnDLAccess_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "DISTRIBUTION LIST SERVICES";
            // 
            // DistributionListServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDLAccess);
            this.Controls.Add(this.btnDLModify);
            this.Controls.Add(this.btnDLDeletion);
            this.Controls.Add(this.btnCreateDL);
            this.Name = "DistributionListServices";
            this.Load += new System.EventHandler(this.DistributionListServices_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnDLModify;
        private MetroFramework.Controls.MetroButton btnDLDeletion;
        private MetroFramework.Controls.MetroButton btnCreateDL;
        private MetroFramework.Controls.MetroButton btnDLAccess;
        private System.Windows.Forms.Label label1;
    }
}
