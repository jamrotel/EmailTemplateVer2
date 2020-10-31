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
    public partial class AccessToAnotherUserCalendar : MetroFramework.Forms.MetroForm
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public AccessToAnotherUserCalendar()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
           
            Outlook.Application application = new Outlook.Application();
            Outlook.MailItem mail = application.CreateItemFromTemplate(AppDomain.CurrentDomain.BaseDirectory + @"\EmailTemplates\DistributionListServices\REQ# - SCTASK Group Distribution List Creation Request.oft") as Outlook.MailItem;

            // GMN = GroupMailboxName ; GME = GroupMailboxEmail 
            mail.HTMLBody = mail.HTMLBody.Replace("RequestorName", "" + txtFirstName.Text + "");
            mail.HTMLBody = mail.HTMLBody.Replace("SCTASK", "" + txtSCTask.Text + "");
            mail.HTMLBody = mail.HTMLBody.Replace("DLName", "" + txtDLName.Text + "");
            mail.HTMLBody = mail.HTMLBody.Replace("DLOwner", "" + txtOwner.Text + "");
            mail.HTMLBody = mail.HTMLBody.Replace("DLAdmin", "" + txtAdmin.Text + "");
            mail.HTMLBody = mail.HTMLBody.Replace("DLMembers", "" + txtMembers.Text + "");
            mail.HTMLBody = mail.HTMLBody.Replace("DLEmail", "" + txtDLEmail.Text + "");
            //mail.HTMLBody = mail.HTMLBody.Replace("", "" + txtReadOnly.Text + "");
            //mail.HTMLBody = mail.HTMLBody.Replace("", "" + txtSendAs.Text + "");

            //-- update TO / CC / Subj -- //
            mail.To = txtEmailAddress.Text;
            mail.Subject = txtReq.Text + " - "  + txtSCTask.Text  + " Group Distribution List Creation Request  ";
            //mail.CC = txt.Text;

            //mail.Attachments.Add(AppDomain.CurrentDomain.BaseDirectory + @"\EmailTemplates\Attachments\Test.txt");
            mail.Display(false);

            logger.Info("Group Distribution List Creation Request: {value1}", txtReq.Text + " | " + txtSCTask.Text);
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
            txtDLName.Clear();
            txtDLEmail.Clear();
            txtAdmin.Clear();
            txtMembers.Clear();
        }
    }
}
