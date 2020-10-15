﻿namespace EmailTemplate
{
    partial class NetworkAccountSuspension
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTicketNumber = new System.Windows.Forms.TextBox();
            this.txtRecipientEmail = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticket Number (SCTASK / REQ):\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recipient\'s Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Requestor\'s (First Name):";
            // 
            // txtTicketNumber
            // 
            this.txtTicketNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketNumber.Location = new System.Drawing.Point(274, 79);
            this.txtTicketNumber.Multiline = true;
            this.txtTicketNumber.Name = "txtTicketNumber";
            this.txtTicketNumber.Size = new System.Drawing.Size(255, 28);
            this.txtTicketNumber.TabIndex = 0;
            // 
            // txtRecipientEmail
            // 
            this.txtRecipientEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecipientEmail.Location = new System.Drawing.Point(274, 181);
            this.txtRecipientEmail.Multiline = true;
            this.txtRecipientEmail.Name = "txtRecipientEmail";
            this.txtRecipientEmail.Size = new System.Drawing.Size(255, 28);
            this.txtRecipientEmail.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(274, 113);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(255, 28);
            this.txtFirstName.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(417, 285);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(112, 32);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(274, 285);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 32);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(126, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Requestor\'s Email:";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAddress.Location = new System.Drawing.Point(274, 147);
            this.txtEmailAddress.Multiline = true;
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(255, 28);
            this.txtEmailAddress.TabIndex = 2;
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(274, 215);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(255, 28);
            this.txtusername.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(110, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Recipient Username:";
            // 
            // txtdate
            // 
            this.txtdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtdate.Location = new System.Drawing.Point(274, 249);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(255, 26);
            this.txtdate.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(132, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Reactivation Date";
            // 
            // NetworkAccountSuspension
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 333);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtRecipientEmail);
            this.Controls.Add(this.txtTicketNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "NetworkAccountSuspension";
            this.Text = "Email | Network Account Suspension";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTicketNumber;
        private System.Windows.Forms.TextBox txtRecipientEmail;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.Label label5;
    }
}