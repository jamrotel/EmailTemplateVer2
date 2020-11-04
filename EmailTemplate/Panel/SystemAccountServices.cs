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
    public partial class SystemAccountServices : pnlSlider
    {
        public SystemAccountServices(Form owner) : base(owner)
        {
            InitializeComponent();
        }

        private void btnGenericAccount_Click(object sender, EventArgs e)
        {
            EmailTemplate em = new EmailTemplate();
            em.OpenGenericAccountCreation();
        }
    }
}
