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
using NLog;

namespace EmailTemplate
{
    public partial class GroupEmailAccountCreation : MetroFramework.Forms.MetroForm
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public GroupEmailAccountCreation()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try {
                Outlook.Application application = new Outlook.Application();
                Outlook.MailItem mail = application.CreateItemFromTemplate(AppDomain.CurrentDomain.BaseDirectory + @"\EmailTemplates\GroupEmailAccount\REQ# - SCTASK Group Email Account Creation Request.oft") as Outlook.MailItem;

                mail.HTMLBody = mail.HTMLBody.Replace("RequestorEmail", "" + txtEmailAddress.Text + "");
                mail.HTMLBody = mail.HTMLBody.Replace("RequestorName", "" + txtFirstName.Text + "");
                mail.HTMLBody = mail.HTMLBody.Replace("GMN", "" + txtGroupMailboxName.Text + "");
                mail.HTMLBody = mail.HTMLBody.Replace("GME", "" + txtGMBEmail.Text + "");
                mail.HTMLBody = mail.HTMLBody.Replace("AdminEmail", "" + txtAdmin.Text + "");
                mail.HTMLBody = mail.HTMLBody.Replace("ReadOnly", "" + txtReadOnly.Text + "");
                mail.HTMLBody = mail.HTMLBody.Replace("SendAS", "" + txtSendAs.Text + "");
                //mail.HTMLBody = mail.HTMLBody.Replace("<SendOnBehalf>", "" + txtSendAs.Text + "");

                //---  update subj: <REQ#> and <SCTASK> -- //
                mail.HTMLBody = mail.HTMLBody.Replace("REQ#", "" + txtReq.Text + "");
                mail.HTMLBody = mail.HTMLBody.Replace("SCTASK", "" + txtSCTask.Text + "");

                //-- update TO / CC / Subj -- //
                mail.To = txtEmailAddress.Text;
                mail.Subject = txtReq.Text + " - " + txtSCTask.Text + " Group Email Account Creation Request ";
                //mail.CC = txt.Text;

                //mail.Attachments.Add(AppDomain.CurrentDomain.BaseDirectory + @"\EmailTemplates\Attachments\Test.txt");
                mail.Display(false);

                logger.Info("Group Email Account Creation Request: {value1}", txtReq.Text + " | " + txtSCTask.Text);

            }
            catch (Exception ex) {
                logger.Error("ERROR: {value1}",ex.ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        public void ClearText()
        {
            txtReq.Clear();
            txtSCTask.Clear();
            txtFirstName.Clear();
            txtEmailAddress.Clear();
            txtGroupMailboxName.Clear();
            txtGMBEmail.Clear();
            txtAdmin.Clear();
            txtReadOnly.Clear();
            txtSendAs.Clear();
            txtSendOnBehalf.Clear();
        }
    }
}
