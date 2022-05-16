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
    public partial class ucCompanyPage : UserControl
    {
        public ucCompanyPage()
        {
            InitializeComponent();
            pnlDivider.Width = 5;
            lbBankName.Text = MainForm.Instanse.appModel.CurrentBank.Name;
            var company = (CompanyUser)MainForm.Instanse.appModel.CurrentUser;
            string companyInf = String.Format("{0} \"{1}\", {2}",company.CompanyType,company.CompanyName,company.Address);
            lblCompanyInf.Text = companyInf;
            LoadData();
        }
        private static ucCompanyPage _instance;
        public static ucCompanyPage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucCompanyPage();
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

        private void btnSalaryProject_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(MainForm.Instanse.appModel.CurrentBankAccount != null))
                {
                    throw new AppException("Choose your current bank account");
                }
                if (!PnlContainer.Controls.ContainsKey("ucSalaryProjectCompany"))
                {
                    ucSalaryProjectCompany.Instance.Dock = DockStyle.Fill;
                    PnlContainer.Controls.Add(ucSalaryProjectCompany.Instance);
                }
                ucSalaryProjectCompany.Instance.BringToFront();
                ucSalaryProjectCompany.Instance.LoadData();
            }
            catch (AppException ex)
            {
                ex.ShowErrorMessage();
            }
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            if (!PnlContainer.Controls.ContainsKey("ucCompanyAccounts"))
            {
                ucCompanyAccounts.Instance.Dock = DockStyle.Fill;
                PnlContainer.Controls.Add(ucCompanyAccounts.Instance);
            }
            ucCompanyAccounts.Instance.BringToFront();
            ucCompanyAccounts.Instance.LoadData();
        }
        public void ClearData()
        {
            if (PnlContainer.Controls.ContainsKey("ucCompanyAccounts"))
                ucCompanyAccounts.Instance.ClearData();
            if (PnlContainer.Controls.ContainsKey("ucSalaryProjectCompany"))
                ucSalaryProjectCompany.Instance.ClearData();
            lblAccountInf.Text = string.Empty;
        }
        public void LoadData()
        {
            if (PnlContainer.Controls.ContainsKey("ucCompanyAccounts"))
                ucCompanyAccounts.Instance.LoadData();
            lbBankName.Text = MainForm.Instanse.appModel.CurrentBank.Name;
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
