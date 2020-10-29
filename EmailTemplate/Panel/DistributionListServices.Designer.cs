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
            this.metroButton18 = new MetroFramework.Controls.MetroButton();
            this.metroButton17 = new MetroFramework.Controls.MetroButton();
            this.btnCreateDL = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroButton18
            // 
            this.metroButton18.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroButton18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.metroButton18.ForeColor = System.Drawing.Color.White;
            this.metroButton18.Location = new System.Drawing.Point(207, 195);
            this.metroButton18.Name = "metroButton18";
            this.metroButton18.Size = new System.Drawing.Size(204, 52);
            this.metroButton18.TabIndex = 22;
            this.metroButton18.Text = "Modify Distribution List";
            this.metroButton18.UseCustomBackColor = true;
            this.metroButton18.UseCustomForeColor = true;
            this.metroButton18.UseSelectable = true;
            // 
            // metroButton17
            // 
            this.metroButton17.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroButton17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.metroButton17.ForeColor = System.Drawing.Color.White;
            this.metroButton17.Location = new System.Drawing.Point(207, 253);
            this.metroButton17.Name = "metroButton17";
            this.metroButton17.Size = new System.Drawing.Size(204, 52);
            this.metroButton17.TabIndex = 23;
            this.metroButton17.Text = "Delete Distribution List";
            this.metroButton17.UseCustomBackColor = true;
            this.metroButton17.UseCustomForeColor = true;
            this.metroButton17.UseSelectable = true;
            // 
            // btnCreateDL
            // 
            this.btnCreateDL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreateDL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnCreateDL.ForeColor = System.Drawing.Color.White;
            this.btnCreateDL.Location = new System.Drawing.Point(207, 137);
            this.btnCreateDL.Name = "btnCreateDL";
            this.btnCreateDL.Size = new System.Drawing.Size(204, 52);
            this.btnCreateDL.TabIndex = 21;
            this.btnCreateDL.Text = "Create Group \r\nDistribution List";
            this.btnCreateDL.UseCustomBackColor = true;
            this.btnCreateDL.UseCustomForeColor = true;
            this.btnCreateDL.UseSelectable = true;
            this.btnCreateDL.Click += new System.EventHandler(this.btnCreateDL_Click);
            // 
            // DistributionListServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.metroButton18);
            this.Controls.Add(this.metroButton17);
            this.Controls.Add(this.btnCreateDL);
            this.Name = "DistributionListServices";
            this.Size = new System.Drawing.Size(590, 480);
            this.Load += new System.EventHandler(this.DistributionListServices_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton18;
        private MetroFramework.Controls.MetroButton metroButton17;
        private MetroFramework.Controls.MetroButton btnCreateDL;
    }
}
