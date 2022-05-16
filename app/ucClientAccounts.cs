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
    public partial class ucClientAccounts : UserControl
    {
        public ucClientAccounts()
        {
            InitializeComponent();
            ClearData();
        }
        private static ucClientAccounts _instance;
        public static ucClientAccounts Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucClientAccounts();
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
            UpdateCMBBanks();
            UpdateAllAccounts();
        }

        private void btnActivateBank_Click(object sender, EventArgs e)
        {
            try
            {
                string bankName = cmbBanks.Text;
                if (bankName == "")
                {
                    throw new AppException("Fields mustn't be empty");
                }
                MainForm.Instanse.appModel.UpdateCurrentBank(bankName);
                ucClientPage.Instance.UpdateCurrentBankInf(MainForm.Instanse.appModel.CurrentBank);
                UpdateAccountsList();
                UpdateCMBAccounts();
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
                MainForm.Instanse.appModel.UpdateCurrentAccountClient(accID);
                ucClientPage.Instance.UpdateCurrentAccountInf(MainForm.Instanse.appModel.CurrentBankAccount);
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
                if (saccID == "") throw new AppException("Fields mustn't be empty");
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

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                MainForm.Instanse.appModel.CreateClientAccount();
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

        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtSumm.Text, out var money) || money <= 0) throw new AppException("Incorrect money. Must be number above zero. Try again");
                if (MainForm.Instanse.appModel.CurrentBankAccount == null) throw new AppException("You should acitvate bank account.");
                MainForm.Instanse.appModel.AddMoneyToAccount(money);
                txtSumm.Text = String.Empty;
                UpdateAccountsList();
                ucClientPage.Instance.UpdateCurrentAccountInf(MainForm.Instanse.appModel.CurrentBankAccount);
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
                ucClientPage.Instance.UpdateCurrentAccountInf(MainForm.Instanse.appModel.CurrentBankAccount);
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
        public void UpdateCMBBanks()
        {
            cmbBanks.Items.Clear();
            foreach (var bank in MainForm.Instanse.appModel.FinSystem.Banks)
            {
                cmbBanks.Items.Add(bank.Name);
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
                UpdateAccountsList();
                ucClientPage.Instance.UpdateCurrentAccountInf(MainForm.Instanse.appModel.CurrentBankAccount);
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

        private void UpdateAccountsList()
        {
            listAccounts.Items.Clear();
            var bank = MainForm.Instanse.appModel.CurrentBank;
            if (bank == null) return;
            var client = (ClientUser)MainForm.Instanse.appModel.CurrentUser;
            int i = 0;
            foreach (var acc in client.BankAccounts)
            {
                if (acc.BankID == bank.BankID)
                {
                    string s = String.Format("{0,-23} {1,10} BYN", acc.AccountID, acc.Money);
                    listAccounts.Items.Insert(i++, s);
                }
            }
            UpdateCMBAccounts();
        }
        private void UpdateCMBAccounts()
        {
            cmbAccounts.Items.Clear();
            var bank = MainForm.Instanse.appModel.CurrentBank;
            if (bank == null) return;
            var client = (ClientUser)MainForm.Instanse.appModel.CurrentUser;
            foreach (var acc in client.BankAccounts)
            {
                if (acc.BankID == bank.BankID)
                {
                    cmbAccounts.Items.Add(acc.AccountID);
                }
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
    }
}
