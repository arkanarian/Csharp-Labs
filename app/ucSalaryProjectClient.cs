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
    public partial class ucSalaryProjectClient : UserControl
    {
        public ucSalaryProjectClient()
        {
            InitializeComponent();
        }
        private static ucSalaryProjectClient _instance;
        public static ucSalaryProjectClient Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucSalaryProjectClient();
                return _instance;
            }
        }

        private void btnRegistrate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtUNP.Text, out var UNP) || txtUNP.Text.Length != 8) throw new AppException("Incorrect UNP. Must contain only 8 numbers. Try again");
                //string bankName = cmbBank.Text;
                //if (bankName == "")
                //{
                //    throw new AppException("Fields mustn't be empty");
                //}
                MainForm.Instanse.appModel.AddSalaryAccountFromClient(UNP);
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
                lblAccountInf.Text = MainForm.Instanse.appModel.CurrentBankAccount.AccountID + "\n" + MainForm.Instanse.appModel.CurrentBankAccount.Money;
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

        public void ClearData()
        {
            MainForm.Instanse.appModel.CurrentBankAccount = null;
            ucClientPage.Instance.UpdateCurrentAccountInf(MainForm.Instanse.appModel.CurrentBankAccount);
        }
        public void LoadData()
        {
            UpdateSPBlocks();
        }
        public void UpdateSPBlocks()
        {
            var usr = (ClientUser)MainForm.Instanse.appModel.CurrentUser;
            if (usr.SalaryProjectAccount != null)
            {
                panel1.Visible = true;
                label8.Visible = false;
                label7.Visible = false;
                txtUNP.Visible = false;
                btnRegistrate.Visible = false;
                MainForm.Instanse.appModel.CurrentBankAccount = usr.SalaryProjectAccount;
                lblAccountInf.Text = MainForm.Instanse.appModel.CurrentBankAccount.AccountID + "\n" + MainForm.Instanse.appModel.CurrentBankAccount.Money;
                ucClientPage.Instance.UpdateCurrentAccountInf(MainForm.Instanse.appModel.CurrentBankAccount);
                lblSalary.Text = usr.SalaryProjectAccount.Salary.ToString();
                UpdateAllAccounts();
            }
            else
            {
                panel1.Visible = false;
                label8.Visible = true;
                label7.Visible = true;
                txtUNP.Visible = true;
                btnRegistrate.Visible = true;
            }
        }
    }
}
