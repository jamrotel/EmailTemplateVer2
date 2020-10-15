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
    public partial class GroupEmailAccountModification : MetroFramework.Forms.MetroForm
    {
        public GroupEmailAccountModification()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
           
            Outlook.Application application = new Outlook.Application();
            Outlook.MailItem mail = application.CreateItemFromTemplate(AppDomain.CurrentDomain.BaseDirectory + @"\EmailTemplates\GroupEmailAccount\REQ# - SCTASK Group Email Account Access Request.oft") as Outlook.MailItem;
           
            // GMN = GroupMailboxName ; GME = GroupMailboxEmail 
            mail.HTMLBody = mail.HTMLBody.Replace("RequestorEmail", "" + txtEmailAddress.Text + "");
            mail.HTMLBody = mail.HTMLBody.Replace("RequestorName", ""+txtFirstName.Text+"");
            mail.HTMLBody = mail.HTMLBody.Replace("GMN", "" + txtGroupMailboxName.Text + "");
            mail.HTMLBody = mail.HTMLBody.Replace("GME", "" + txtGMBEmail.Text + "");
            mail.HTMLBody = mail.HTMLBody.Replace("ActionsDone", "" + txtActionsDone.Text + "");
 
            //-- update TO / CC / Subj -- //
            mail.To = txtEmailAddress.Text;
            mail.Subject = txtReq.Text + " - "  + txtSCTask.Text  + " Group Email Account Modification Request ";
            //mail.CC = txt.Text;

            //mail.Attachments.Add(AppDomain.CurrentDomain.BaseDirectory + @"\EmailTemplates\Attachments\Test.txt");
            mail.Display(false);
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
            txtActionsDone.Clear();
           }
    }
}
