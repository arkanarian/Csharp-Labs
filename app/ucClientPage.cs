using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelsLibrary.Entities;
using ModelsLibrary.Interfaces;

namespace ApplicationForm
{
    public partial class ucClientPage : UserControl
    {
        public ucClientPage()
        {
            InitializeComponent();
            pnlDivider.Width = 5; 
            var usr = (ClientUser)MainForm.Instanse.appModel.CurrentUser;
            string inf = String.Format("{0} {1} ({2}), email: {3}", usr.FirstName, usr.LastName, usr.PassportNum, usr.Email);
            lblCompanyInf.Text = inf;
            LoadData();
        }
        private static ucClientPage _instance;
        public static ucClientPage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucClientPage();
                return _instance;
            }
        }
        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }

        private void btnBase_MouseHover(object sender, EventArgs e)
        {
            var btn = sender as Button;
            btn.BackColor = Color.MediumSeaGreen;
            btn.ForeColor = Color.White;
        }

        private void btnBase_MouseLeave(object sender, EventArgs e)
        {
            var btn = sender as Button;
            btn.BackColor = Color.White;
            btn.ForeColor = SystemColors.ControlText;
        }
        private void btnAccounts_Click(object sender, EventArgs e)
        {
            ucSalaryProjectClient.Instance.ClearData();
            if (!PnlContainer.Controls.ContainsKey("ucClientAccounts"))
            {
                ucClientAccounts.Instance.Dock = DockStyle.Fill;
                PnlContainer.Controls.Add(ucClientAccounts.Instance);
            }
            ucClientAccounts.Instance.BringToFront();
            ucClientAccounts.Instance.LoadData();
        }

        private void btnSalaryProject_Click(object sender, EventArgs e)
        {
            if (!PnlContainer.Controls.ContainsKey("ucSalaryProjectClient"))
            {
                ucSalaryProjectClient.Instance.Dock = DockStyle.Fill;
                PnlContainer.Controls.Add(ucSalaryProjectClient.Instance);
            }
            ucSalaryProjectClient.Instance.BringToFront();
            ucSalaryProjectClient.Instance.LoadData();
        }
        public void ClearData()
        {
            if (PnlContainer.Controls.ContainsKey("ucClientAccounts"))
                ucClientAccounts.Instance.ClearData();
            if (PnlContainer.Controls.ContainsKey("ucSalaryProjectClient"))
                ucSalaryProjectClient.Instance.ClearData();
            lblAccountInf.Text = string.Empty;
            lblBankInf.Text = string.Empty;
        }
        public void LoadData()
        {
            if (PnlContainer.Controls.ContainsKey("ucClientAccounts"))
                ucClientAccounts.Instance.LoadData();
            if (PnlContainer.Controls.ContainsKey("ucSalaryProjectClient"))
                ucSalaryProjectClient.Instance.LoadData();
        }
        public void UpdateCurrentBankInf(IBank bank)
        {
            string s = "";
            if (bank == null) s = "Bank haven't benn choosed";
            else s = String.Format("{0}", bank.Name);
            lblBankInf.Text = s;
        }
        public void UpdateCurrentAccountInf(IBankAccount acc)
        {
            string s = "";
            if (acc == null) s = "Account haven't been choosed";
            else s = String.Format("{0} - {1} BYN", acc.AccountID, acc.Money);
            lblAccountInf.Text = s;
        }
    }
}
