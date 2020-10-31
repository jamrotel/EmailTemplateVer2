using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailTemplate.Panel
{
    public partial class EmailAccountServices : pnlSlider
    {
        public EmailAccountServices (Form owner) : base(owner)
        {
            InitializeComponent();
        }

        private void btnEmailDelegates_Click(object sender, EventArgs e)
        {
            EmailTemplate em = new EmailTemplate();
            em.OpenEmailDelegates();
        }

        private void btnAccessToUserCalendar_Click(object sender, EventArgs e)
        {
            EmailTemplate em = new EmailTemplate();
            em.OpenAccessToAnotherUserCalendar();
        }

        private void btnDisableExistingEmail_Click(object sender, EventArgs e)
        {
            EmailTemplate em = new EmailTemplate();
            em.OpenDisableExistingEmailAccount();
        }

        private void btnEmailAccountCreation_Click(object sender, EventArgs e)
        {
            EmailTemplate em = new EmailTemplate();
            em.OpenEmailAccountCreation();
        }

        private void btnEmailAlias_Click(object sender, EventArgs e)
        {
            EmailTemplate em = new EmailTemplate();
            em.OpenEmailAlias();
        }
    }
}
