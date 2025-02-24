using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeelUrFood
{
    public partial class frmMainDashboard : Form
    {
        frmBilling BillingForm;
        frmOperations OperationsForm;
        frmSettings SettingsForm;
        frmCheckStatusPing CheckStatusPingForm;
        public frmMainDashboard()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED
                return cp;
            }
        }

        private void BillingBtn_Click(object sender, EventArgs e)
        {
            if (BillingForm == null)
            {
                BillingForm = new frmBilling();
                BillingForm.FormClosed += frmBilling_FormClosed;
                BillingForm.MdiParent = this;
                BillingForm.Dock = DockStyle.Fill;
                BillingForm.Show();
            }
            else
            {
                BillingForm.Activate();
            }
           
        }
        private void frmBilling_FormClosed(object sender, FormClosedEventArgs e)
        {
            BillingForm = null;
        }

        private void OperationsBtn_Click(object sender, EventArgs e)
        {
            if (OperationsForm == null)
            {
                OperationsForm = new frmOperations();
                OperationsForm.FormClosed += frmOperations_FormClosed;
                OperationsForm.MdiParent = this;
                OperationsForm.Dock = DockStyle.Fill;
                OperationsForm.Show();
            }
            else
            {
                OperationsForm.Activate();
            }
        }
        private void frmOperations_FormClosed(object sender, FormClosedEventArgs e)
        {
            OperationsForm = null;
        }

        private void KioskStatusPingBtn_Click(object sender, EventArgs e)
        {
            if (CheckStatusPingForm == null)
            {
                CheckStatusPingForm = new frmCheckStatusPing();
                CheckStatusPingForm.FormClosed += frmOperations_FormClosed;
                CheckStatusPingForm.MdiParent = this;
                CheckStatusPingForm.Dock = DockStyle.Fill;
                CheckStatusPingForm.Show();
            }
            else
            {
                CheckStatusPingForm.Activate();
            }
        }
        private void frmCheckStatusPing_FormClosed(object sender, FormClosedEventArgs e)
        {
            CheckStatusPingForm = null;
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            if (SettingsForm == null)
            {
                SettingsForm = new frmSettings();
                SettingsForm.FormClosed += frmSettings_FormClosed;
                SettingsForm.MdiParent = this;
                SettingsForm.Dock = DockStyle.Fill;
                SettingsForm.Show();
            }
            else
            {
                SettingsForm.Activate();
            }
        }
        private void frmSettings_FormClosed(object sender, FormClosedEventArgs e)
        {

            SettingsForm = null;
        }

        private void LiveViewBtn_Click(object sender, EventArgs e)
        {

        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            frmLoginPage frmLogin = new frmLoginPage();
            frmLogin.Show();
            Application.DoEvents();
            this.Hide();

        }
    }
}
