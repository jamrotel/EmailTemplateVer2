﻿ using MetroFramework;
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
using NLog;
using System.Reflection;
using System.Windows.Forms;
using System.Configuration;

namespace EmailTemplate
{
    public partial class EmailTemplate : MetroFramework.Forms.MetroForm
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public EmailTemplate()
        {
            try
            {
                InitializeComponent();
                Version version = Assembly.GetExecutingAssembly().GetName().Version;
                Properties.Settings.Default.Versioning = version.ToString();
                Properties.Settings.Default.Save();

            }
            catch (Exception ex)
            {
                logger.Debug("Debug:", ex.ToString());

            }
        }
        //======================user account creation- pannel variable ============================
        void _pnlone_Shown(object sender, EventArgs e)
        {
        }
        void _pnlone_Closed(object sender, EventArgs e)
        {
        }
        //====================================================
        //========================email support- pannel variable=============================
        void _EmailSupport__Shown(object sender, EventArgs e)
        {
        }
        void _EmailSupport_Closed(object sender, EventArgs e)
        {
        }
        //====================================================
        //=====================================================
        void _Dis__Shown(object sender, EventArgs e)
        {
        }
        void _Dis_Closed(object sender, EventArgs e)
        {
        }
        //====================================================
        //main pannel of - email support
        private void panelEmailSupport_Click_1(object sender, EventArgs e)
        {
            EmailSupport _EmailSupport = new EmailSupport(this);
            _EmailSupport.Closed += _EmailSupport_Closed;
            _EmailSupport.Shown += _EmailSupport__Shown;
            _EmailSupport.swipe(true);
        }

        //main pannel of - email account services
        private void panelEmailAccountServices_Click(object sender, EventArgs e)
        {
            EmailAccountServices _EmailStrike = new EmailAccountServices(this);
            _EmailStrike.swipe(true);
        }

        //Main pannel of - installation / Access request
        private void panelAccess_Click(object sender, EventArgs e)
        {
            InstallationAccessRequest _Access = new InstallationAccessRequest(this);
            _Access.swipe(true);
        }

        //Main pannel of - user account services
        private void panelUserAccount_Click(object sender, EventArgs e)
        {
            UserAccountServices _pnlone = new UserAccountServices(this);
            _pnlone.Closed += _pnlone_Closed;
            _pnlone.Shown += _pnlone_Shown;
            _pnlone.swipe(true);
        }
        //Main pannel of - Distribution List services
        private void panelDistributionListServices_Click_1(object sender, EventArgs e)
        {
            DistributionListServices _Dis = new DistributionListServices(this);
            _Dis.swipe(true);
        }
        //Main pannel of - Meeting Room
        private void panelMeetingRoom_Click(object sender, EventArgs e)
        {
            MeetingRoom _MR = new MeetingRoom(this);
            _MR.swipe(true);
        }
        //Main pannel of - Group Email Account
        private void panelGroupEmailAccount_Click(object sender, EventArgs e)
        {
            GroupEmailAccount _GEA = new GroupEmailAccount(this);
            _GEA.swipe(true);
        }
        // not sure what this is  ??


        //=========================================================sub pannels============================================================================
        //================USER-ACCOUNT-SERVICES==================
        public void OpenNetworkAccountBundle()
        {
            NetworkAccountBundle NAB = new NetworkAccountBundle();
            NAB.Show();
        }
        public void OpenNetworkAccountOnly()
        {
            NetworkAccountOnly NAO = new NetworkAccountOnly();
            NAO.Show();
        }
        public void OpenNetworkAccountSuspension()
        {
            NetworkAccountSuspension NAS = new NetworkAccountSuspension();
            NAS.Show();
        }
        public void OpenEmployeeNetworkEmailReactivation()
        {
            EmployeeNetworkEmailReactivation ENER = new EmployeeNetworkEmailReactivation();
            ENER.Show();
        }
        public void OpenITEquipmentServiceCancellation()
        {
            ITEquipmentServiceCancellation ITSC = new ITEquipmentServiceCancellation();
            ITSC.Show();
        }
        public void OpenChangetoPermanentUser()
        {
            ChangetoPermanentUser CTPU = new ChangetoPermanentUser();
            CTPU.Show();
        }
        public void OpenModifyEndDate()
        {
            ModifyEndDate MED = new ModifyEndDate();
            MED.Show();
        }

        //================USER-ACCOUNT-SERVICES==================
        //===============Installation-Accss-REQUEST===================
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
        public void OpenSharedDriveAccess() {
            SharedDriveAccess sharedDriveAccess = new SharedDriveAccess();
            sharedDriveAccess.Show();
        }
        public void OpenShareFileAccess()
        {
            ShareFileAccess shareFileAccess = new ShareFileAccess();
            shareFileAccess.Show();
        }
        public void OpenMSLyncAccount()
        {
            MSLyncAccount mSLyncAccount = new MSLyncAccount();
            mSLyncAccount.Show();
            
        }
        public void OpenAudioWebConferencing()
        {
            AudioWebConferencing audioWebConferencing = new AudioWebConferencing();
            audioWebConferencing.Show();

        }

        private void panelAdditionalInformation_Click(object sender, EventArgs e)
        {
            AdditionalInformation _AdditionalInformation = new AdditionalInformation(this);
            _AdditionalInformation.Closed += _EmailSupport_Closed;
            _AdditionalInformation.Shown += _EmailSupport__Shown;
            _AdditionalInformation.swipe(true);
        }

        private void panelAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        //=============== Group Email Account =================== //
        public void OpenGroupEmailAccountCreation()
        {
            GroupEmailAccountCreation GEAC = new GroupEmailAccountCreation();
            GEAC.Show();
        }
        public void OpenGroupEmailAccountAccess()
        {
            GroupEmailAccountAccess GEAA = new GroupEmailAccountAccess();
            GEAA.Show();
        }
        public void OpenGroupEmailAccountModification()
        {
            GroupEmailAccountModification GEAM = new GroupEmailAccountModification();
            GEAM.Show();
        }
        public void OpenGroupEmailAccountDeletion()
        {
            GroupEmailAccountDeletion GEAD = new GroupEmailAccountDeletion();
            GEAD.Show();
        }

        // ---- Distribution List Services ----- //
        public void OpenDistributionListCreation()
        {
            CreateDistributionList CDL = new CreateDistributionList();
            CDL.Show();
        }

        // About Form
    }

}
