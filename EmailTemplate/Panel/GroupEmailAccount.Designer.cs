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
            this.metroButton22 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroButton22
            // 
            this.metroButton22.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.metroButton22.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton22.ForeColor = System.Drawing.Color.White;
            this.metroButton22.Location = new System.Drawing.Point(167, 93);
            this.metroButton22.Name = "metroButton22";
            this.metroButton22.Size = new System.Drawing.Size(226, 85);
            this.metroButton22.TabIndex = 23;
            this.metroButton22.Text = "Group Email Account \r\nAccess and Modification\r\n";
            this.metroButton22.UseCustomBackColor = true;
            this.metroButton22.UseCustomForeColor = true;
            this.metroButton22.UseSelectable = true;
            // 
            // GroupEmailAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Controls.Add(this.metroButton22);
            this.Name = "GroupEmailAccount";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton22;
    }
}
