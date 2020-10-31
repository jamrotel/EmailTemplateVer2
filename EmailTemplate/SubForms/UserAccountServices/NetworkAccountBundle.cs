using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace EmailTemplate
{
    public partial class NetworkAccountBundle : MetroFramework.Forms.MetroForm
    {
        Outlook.MailItem mail;
        public NetworkAccountBundle()
        {
            InitializeComponent();
            cmbAccessType.Items.Insert(0, "Read Only");
            cmbAccessType.Items.Insert(1, "Read and Write");
            GBGroupEmail.Enabled = false;
            GBSharedDrive.Enabled = false;
        }

        //========================================================================================
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Outlook.Application application = new Outlook.Application();
      
            if (CBSharedDA.Checked == true && CBGroupEmail.Checked == true)
            {
                mail = application.CreateItemFromTemplate(AppDomain.CurrentDomain.BaseDirectory + @"\EmailTemplates\UserAccountServices\SCTASKXXXXXXX  New Staff Starter Bundle.oft") as Outlook.MailItem;

                mail.HTMLBody = mail.HTMLBody.Replace("SCTASKXXXXXXX", "" + txtTaskID.Text + "");
                mail.HTMLBody = mail.HTMLBody.Replace("XXXXXXXX", "" + txtFirstName.Text + "");
                mail.HTMLBody = mail.HTMLBody.Replace("NAUSERNAME", "" + txtRecipientUsername.Text + "");
                mail.HTMLBody = mail.HTMLBody.Replace("NAEADD", "" + txtRecipientEmail.Text + "");
                mail.HTMLBody = mail.HTMLBody.Replace("NAPASS", "" + txtRecipientPassword.Text + "");

                mail.HTMLBody = mail.HTMLBody.Replace("SKYPEEADD", "" + txtRecipientEmail.Text + "");
                mail.HTMLBody = mail.HTMLBody.Replace("SKYPEPASSOWORD", "" + txtRecipientPassword.Text + "");
                mail.HTMLBody = mail.HTMLBody.Replace("SDAPATH", "" + txtFolderPath.Text + "");
                mail.HTMLBody = mail.HTMLBody.Replace("SDATYPE", "" + cmbAccessType.Text + "");
                mail.HTMLBody = mail.HTMLBody.Replace("GEADD", "" + txtGroupEmailAccount.Text + "");
                mail.HTMLBody = mail.HTMLBody.Replace("GETYPE", "" + CBGroupType.Text + "");

                mail.To = txtRequestorEmail.Text;
                mail.CC = txtRecipientEmail.Text;
                mail.Subject = txtTaskID.Text + " - New Staff Starter Bundle";
                mail.Display(false);
            }

            if (CBSharedDA.Checked == false && CBGroupEmail.Checked == true)
            {
                mail = application.CreateItemFromTemplate(AppDomain.CurrentDomain.BaseDirectory + @"\EmailTemplates\UserAccountServices\SCTASKXXXXXXX  New Staff Starter Group Email.oft") as Outlook.MailItem;

                mail.HTMLBody = mail.HTMLBody.Replace("SCTASKXXXXXXX", "" + txtTaskID.Text + "");
                mail.HTMLBody = mail.HTMLBody.Replace("XXXXXXXX", "" + txtFirstName.Text + "");
                mail.HTMLBody = mail.HTMLBody.Replace("NAUSERNAME", "" + txtRecipientUsername.Text + "");
                mail.HTMLBody = mail.HTMLBody.Replace("NAEADD", "" + txtRecipientEmail.Text + "");
                mail.HTMLBody = mail.HTMLBody.Replace("NAPASS", "" + txtRecipientPassword.Text + "");

                mail.HTMLBody = mail.HTMLBody.Replace("SKYPEEADD", "" + txtRecipientEmail.Text + "");
                mail.HTMLBody = mail.HTMLBody.Replace("SKYPEPASSOWORD", "" + txtRecipientPassword.Text + "");
                mail.HTMLBody = mail.HTMLBody.Replace("GEADD", "" + txtGroupEmailAccount.Text + "");
                mail.HTMLBody = mail.HTMLBody.Replace("GETYPE", "" + CBGroupType.Text + "");

                mail.To = txtRequestorEmail.Text;
                mail.CC = txtRecipientEmail.Text;
                mail.Subject = txtTaskID.Text + " - New Staff Starter Bundle";
                mail.Display(false);
            }

            if (CBSharedDA.Checked == true && CBGroupEmail.Checked == false)
            {
                mail = application.CreateItemFromTemplate(AppDomain.CurrentDomain.BaseDirectory + @"\EmailTemplates\UserAccountServices\SCTASKXXXXXXX  New Staff Starter Shared Drive.oft") as Outlook.MailItem;

                mail.HTMLBody = mail.HTMLBody.Replace("SCTASKXXXXXXX", "" + txtTaskID.Text + "");
                mail.HTMLBody = mail.HTMLBody.Replace("XXXXXXXX", "" + txtFirstName.Text + "");
                mail.HTMLBody = mail.HTMLBody.Replace("NAUSERNAME", "" + txtRecipientUsername.Text + "");
                mail.HTMLBody = mail.HTMLBody.Replace("NAEADD", "" + txtRecipientEmail.Text + "");
                mail.HTMLBody = mail.HTMLBody.Replace("NAPASS", "" + txtRecipientPassword.Text + "");

                mail.HTMLBody = mail.HTMLBody.Replace("SKYPEEADD", "" + txtRecipientEmail.Text + "");
                mail.HTMLBody = mail.HTMLBody.Replace("SKYPEPASSOWORD", "" + txtRecipientPassword.Text + "");
                mail.HTMLBody = mail.HTMLBody.Replace("SDAPATH", "" + txtFolderPath.Text + "");
                mail.HTMLBody = mail.HTMLBody.Replace("SDATYPE", "" + cmbAccessType.Text + "");

                mail.To = txtRequestorEmail.Text;
                mail.CC = txtRecipientEmail.Text;
                mail.Subject = txtTaskID.Text + " - New Staff Starter Bundle";
                mail.Display(false);
            }

            if (CBSharedDA.Checked == false && CBGroupEmail.Checked == false)
            {
                mail = application.CreateItemFromTemplate(AppDomain.CurrentDomain.BaseDirectory + @"\EmailTemplates\UserAccountServices\SCTASKXXXXXXX  New Staff Starter Only.oft") as Outlook.MailItem;

                mail.HTMLBody = mail.HTMLBody.Replace("SCTASKXXXXXXX", "" + txtTaskID.Text + "");
                mail.HTMLBody = mail.HTMLBody.Replace("XXXXXXXX", "" + txtFirstName.Text + "");
                mail.HTMLBody = mail.HTMLBody.Replace("NAUSERNAME", "" + txtRecipientUsername.Text + "");
                mail.HTMLBody = mail.HTMLBody.Replace("NAEADD", "" + txtRecipientEmail.Text + "");
                mail.HTMLBody = mail.HTMLBody.Replace("NAPASS", "" + txtRecipientPassword.Text + "");

                mail.HTMLBody = mail.HTMLBody.Replace("SKYPEEADD", "" + txtRecipientEmail.Text + "");
                mail.HTMLBody = mail.HTMLBody.Replace("SKYPEPASSOWORD", "" + txtRecipientPassword.Text + "");

                mail.To = txtRequestorEmail.Text;
                mail.CC = txtRecipientEmail.Text;
                mail.Subject = txtTaskID.Text + " - New Staff Starter Bundle";
                mail.Display(false);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        public void ClearText()
        {
            txtReqNumber.Clear();
            txtReqNumber.Clear();
            txtFirstName.Clear();
            txtRequestorEmail.Clear();
            txtRecipientUsername.Clear();
            txtRecipientEmail.Clear();
            txtRecipientPassword.Clear();
            txtFolderPath.Clear();
            cmbAccessType.Text = "";
            txtGroupEmailAccount.Clear();
            CBGroupType.Text = "";

        }

        private void NetworkAccountBundle_Load(object sender, EventArgs e)
        {

        }

        private void CBSharedDA_Click(object sender, EventArgs e)
        {
            if (CBSharedDA.Checked){

                GBSharedDrive.Enabled = true;
            }
            else
                GBSharedDrive.Enabled = false;
        }

        private void CBGroupEmail_Click(object sender, EventArgs e)
        {
            if (CBGroupEmail.Checked) { 
                GBGroupEmail.Enabled = true;
            }
            else
                GBGroupEmail.Enabled = false;
        }
    }
}
