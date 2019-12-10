using MetroFramework;
using EmailTemplate.Panel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace EmailTemplate
{

    public partial class EmailTemplate : MetroFramework.Forms.MetroForm
    {
        public EmailTemplate()
        {
            InitializeComponent();
          
        }

        void _pnlone_Shown(object sender, EventArgs e)
        {

        }

        void _pnlone_Closed(object sender, EventArgs e)
        {
        }
        private void panelEmailSupport_Click_1(object sender, EventArgs e)
        {
            EmailSupport _EmailSupport = new EmailSupport(this);
            _EmailSupport.Closed += _EmailSupport_Closed;
            _EmailSupport.Shown += _EmailSupport__Shown;
            _EmailSupport.swipe(true);
        }

        private void panelEmailAccountServices_Click(object sender, EventArgs e)
        {
            EmailAccountServices _EmailStrike = new EmailAccountServices(this);
            _EmailStrike.swipe(true);
        }

        private void panelAccess_Click(object sender, EventArgs e)
        {
            InstallationAccessRequest _Access = new InstallationAccessRequest(this);
            _Access.swipe(true);
        }

        private void panelUserAccount_Click(object sender, EventArgs e)
        {
            UserAccountServices _pnlone = new UserAccountServices(this);
            _pnlone.Closed += _pnlone_Closed;
            _pnlone.Shown += _pnlone_Shown;
            _pnlone.swipe(true);
        }
        void _EmailSupport__Shown(object sender, EventArgs e)
        {

        }

        void _EmailSupport_Closed(object sender, EventArgs e)
        {

        }
     

        public void OpenSoftInstallation()
        {
            SoftwareInstallation sft = new SoftwareInstallation();
            sft.Show();
        }
        public void OpenElevatedAdmin()
        {
            ElevatedAdminRights elevatedAdmin = new ElevatedAdminRights();
            elevatedAdmin.Show();
        }

        public void OpenVPNRemoteAccessRequest() {
            VPNAccess vpnaccess = new VPNAccess();
            vpnaccess.Show();
        }
        public void OpenRemoteAccessCitrix() {
            RemoteAccessCitrix remoteAccessCitrix = new RemoteAccessCitrix();
            remoteAccessCitrix.Show();
        }
        public void OpenSharedFileFolderAccess() {
            SharedFileFolderAccess sharedFileFolderAccess = new SharedFileFolderAccess();
            sharedFileFolderAccess.Show();
        }


    }
   
}
