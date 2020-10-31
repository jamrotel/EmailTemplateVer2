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
using NLog;
using System.Reflection;
using System.Windows.Forms;
using System.Configuration;

namespace EmailTemplate
{
    public partial class About : MetroFramework.Forms.MetroForm
    {
        public About()
        {
            InitializeComponent();

            lblVersion.Text = Properties.Settings.Default.Versioning;
            lblAuthor.Text = Properties.Settings.Default.Author;
        }
    }
}
