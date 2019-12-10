﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Threading;
using EmailTemplate.Panel;

namespace EmailTemplate.Panel
{
    public partial class InstallationAccessRequest : pnlSlider
    {

        
        public InstallationAccessRequest(Form owner) : base(owner)
        {
            InitializeComponent();

        }

        private void btnSoftware_Click(object sender, EventArgs e)
        {
            EmailTemplate em = new EmailTemplate();
            em.OpenSoftInstallation();
        }
        
        private void btnElevatedAccess_Click(object sender, EventArgs e)
        {
            EmailTemplate em = new EmailTemplate();
            em.OpenElevatedAdmin();
        }

        private void btnVPNAccess_Click(object sender, EventArgs e)
        {
            EmailTemplate em = new EmailTemplate();
            em.OpenVPNRemoteAccessRequest();
        }

        private void btnRemoteAccessCitrix_Click(object sender, EventArgs e)
        {
            EmailTemplate em = new EmailTemplate();
            em.OpenRemoteAccessCitrix();
        }

        private void btnSharedFileFolderAccess_Click(object sender, EventArgs e)
        {
            EmailTemplate em = new EmailTemplate();
            em.OpenSharedFileFolderAccess();
                    }
    }
}
