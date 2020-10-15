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
    public partial class GroupEmailAccount : pnlSlider
    {
        public GroupEmailAccount (Form owner) : base(owner)
        {
            InitializeComponent();
        }

        private void btnGroupEmailAccountCreation_Click(object sender, EventArgs e)
        {
            EmailTemplate em = new EmailTemplate();
            em.OpenGroupEmailAccountCreation();
        }

        private void btnGroupEmailAccountAccess_Click(object sender, EventArgs e)
        {
            EmailTemplate em = new EmailTemplate();
            em.OpenGroupEmailAccountAccess();
        }

        private void btnGroupEmailAccountModification_Click(object sender, EventArgs e)
        {
            EmailTemplate em = new EmailTemplate();
            em.OpenGroupEmailAccountModification();
        }
    }
}
