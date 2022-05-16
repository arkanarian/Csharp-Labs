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
    public partial class ucCompanyAccounts : UserControl
    {
        public ucCompanyAccounts()
        {
            InitializeComponent();
            ClearData();
        }
        private static ucCompanyAccounts _instance;
        public static ucCompanyAccounts Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucCompanyAccounts();
                return _instance;
            }
        }
        public void ClearData()
        {
            listAccounts.Items.Clear();
            cmbAccounts.Items.Clear();
        }
        public void LoadData()
        {
            UpdateAccountsList();
            UpdateCMBAccounts();
            UpdateAllAccounts();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                MainForm.Instanse.appModel.CreateCompanyAccount();
                UpdateAccountsList();
                UpdateAllAccounts();
            }
            catch (AppException ex)
            {
                ex.ShowErrorMessage();
            }
            catch (Exception ex)
            {
                var appex = new AppException(ex.Message);
                appex.ShowErrorMessage();
            }
        }

        private void UpdateAccountsList()
        {
            listAccounts.Items.Clear();
            var company = (CompanyUser)MainForm.Instanse.appModel.CurrentUser;
            foreach (var acc in company.Accounts.Select((value, i) => new {i, value}))
            {
                string s = String.Format("{0,-23} {1,10} BYN", acc.value.AccountID, acc.value.Money);
                listAccounts.Items.Insert(acc.i, s);
            }
            UpdateCMBAccounts();
        }

        private void UpdateCMBAccounts()
        {
            cmbAccounts.Items.Clear();
            var company = (CompanyUser)MainForm.Instanse.appModel.CurrentUser;
            foreach (var acc in company.Accounts)
            {
                cmbAccounts.Items.Add(acc.AccountID);
            }
        }

        public void UpdateAllAccounts()
        {
            cmbAccountsTS.Items.Clear();
            List<IBankAccount> accounts = MainForm.Instanse.appModel.ParseAccounts();
            foreach (var acc in accounts)
            {
                string type = acc.GetType().Name;
                if (type == "CompanyBankAccount") type = "Company";
                else if (type == "ClientBankAccount") type = "Client";
                else if (type == "SalaryProjectAccount") type = "Employee";
                string s = acc.AccountID + "(" + type + ")";
                cmbAccountsTS.Items.Add(s);
            }
        }

        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtSumm.Text, out var money) || money <= 0) throw new AppException("Incorrect money. Must be number above zero. Try again");
                if (MainForm.Instanse.appModel.CurrentBankAccount == null) throw new AppException("You should acitvate bank account.");
                MainForm.Instanse.appModel.AddMoneyToAccount(money);
                txtSumm.Text = String.Empty;
                UpdateAccountsList();
                ucCompanyPage.Instance.UpdateCurrentAccountInf(MainForm.Instanse.appModel.CurrentBankAccount);
            }
            catch (AppException ex)
            {
                ex.ShowErrorMessage();
            }
            catch (Exception ex)
            {
                AppException appex = new AppException(ex.Message);
                appex.ShowErrorMessage();
            }
        }

        private void btnGiveCash_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtSumCash.Text, out var money) || money <= 0) throw new AppException("Incorrect money. Must be number above zero. Try again");
                if (MainForm.Instanse.appModel.CurrentBankAccount == null) throw new AppException("You should acitvate bank account.");
                if (MainForm.Instanse.appModel.CurrentBankAccount.Money < money) throw new AppException("Not enough money to take off.");
                MainForm.Instanse.appModel.TakeOffMoneyAccount(money);
                txtSumm.Text = String.Empty;
                cmbAccounts.Text = String.Empty;
                UpdateAccountsList();
                ucCompanyPage.Instance.UpdateCurrentAccountInf(MainForm.Instanse.appModel.CurrentBankAccount);
            }
            catch (AppException ex)
            {
                ex.ShowErrorMessage();
            }
            catch (Exception ex)
            {
                AppException appex = new AppException(ex.Message);
                appex.ShowErrorMessage();
            }
        }

        private void btnActivateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                string saccID = cmbAccounts.Text;
            if (saccID == "")
            {
                throw new AppException("Fields mustn't be empty");
            }
            int accID = int.Parse(saccID);
                 MainForm.Instanse.appModel.UpdateCurrentAccountCompany(accID);
                ucCompanyPage.Instance.UpdateCurrentAccountInf(MainForm.Instanse.appModel.CurrentBankAccount);
            }
            catch (AppException ex)
            {
                ex.ShowErrorMessage();
            }
            catch (Exception ex)
            {
                AppException appex = new AppException(ex.Message);
                appex.ShowErrorMessage();
            }
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtSumTS.Text, out var money) || money <= 0) throw new AppException("Incorrect money. Must be number above zero. Try again");
                string saccID = cmbAccountsTS.Text;
                if (saccID == "")
                {
                    throw new AppException("Fields mustn't be empty");
                }
                string[] coll = saccID.Split('(');
                int accID = int.Parse(coll[0]);
                MainForm.Instanse.appModel.CreateTransaction(accID, money);
                UpdateAccountsList();
            }
            catch (AppException ex)
            {
                ex.ShowErrorMessage();
            }
            catch (Exception ex)
            {
                AppException appex = new AppException(ex.Message);
                appex.ShowErrorMessage();
            }
        }

        private void btnRemoveAccount_Click(object sender, EventArgs e)
        {
            try
            {
                MainForm.Instanse.appModel.RemoveAccount();
                UpdateAccountsList();
                UpdateCMBAccounts();
                UpdateAllAccounts();
                ucCompanyPage.Instance.UpdateCurrentAccountInf(MainForm.Instanse.appModel.CurrentBankAccount);
            }
            catch (AppException ex)
            {
                ex.ShowErrorMessage();
            }
            catch (Exception ex)
            {
                AppException appex = new AppException(ex.Message);
                appex.ShowErrorMessage();
            }

        }
    }
}
