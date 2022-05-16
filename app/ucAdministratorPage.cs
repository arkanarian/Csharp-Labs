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
using System.IO;
using System.Windows.Forms;
using ModelsLibrary.Entities;
using ModelsLibrary.Interfaces;

namespace ApplicationForm
{
    public partial class ucAdministratorPage : UserControl
    {
        public ucAdministratorPage()
        {
            InitializeComponent();
        }
        private static ucAdministratorPage _instance;
        public static ucAdministratorPage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucAdministratorPage();
                return _instance;
            }
        }
        public void LoadData()
        {
            UpdateLogs();
            UpdateCMBActions();
        }
        public void ClearData()
        {
            listActions.Items.Clear();
            listLogs.Items.Clear();
        }
        private SortedDictionary<int, string> UpdateListActions()
        {
            var _actions = MainForm.Instanse.appModel.FinSystem.Actions;
            SortedDictionary<int, string> actions = new SortedDictionary<int, string>();
            foreach (var action in _actions.ExecutedTransactions.Keys)
            {
                var ts = _actions.ExecutedTransactions[action];
                string s = String.Format("Transaction. ID: {0}, DestinationBankID: {1}, DestinationAccountID: {2}, SourceBankID: {3}, SourceAccountID: {4}, Status: {5}", ts.ID, ts.DestinationBankID, ts.DestinationAccountID, ts.SourceBankID, ts.SourceAccountID, ts.Status);
                actions.Add(action, s);
            }
            foreach (var action in _actions.CreatedClientAccounts.Keys)
            {
                var cl = _actions.CreatedClientAccounts[action];
                string s = String.Format("Created Client Account. {0} {1}, PassportNum: {2}, Bank: {3}\nAccount: {4} {5} BYN", cl.FirstName, cl.LastName, cl.PassportNum, cl.BankID,cl.AccountID,cl.Money);
                actions.Add(action, s);
            }
            foreach (var action in _actions.CreatedCompanyAccounts.Keys)
            {
                var co = _actions.CreatedCompanyAccounts[action];
                string s = String.Format("Create Company Account. \"{0}\", {1}, UNP {2}, Bank: {3}\n Account: {4} {5} BYN, isEmployees: {5}", co.CompanyName, co.Address,co.UNP,co.BankID,co.AccountID,co.Money, co.Employees != null);
                actions.Add(action, s);
            }
            //var sortedActions = actions.OrderBy(x => x.Key);
            return actions;
        }
        public void UpdateCMBActions()
        {
            listActions.Items.Clear();
            var actions = UpdateListActions();
            int i = 0;
            foreach (var act in actions)
            {
                listActions.Items.Insert(i++, String.Format("{0,-16} {1}\n",act.Key, act.Value));
            }
            UpdateLogs();
        }

        private void btnDenyAction_Click(object sender, EventArgs e)
        {
            MainForm.Instanse.appModel.FinSystem.UndoAction();
            UpdateCMBActions();
        }
        private void UpdateLogs()
        {
            listLogs.Items.Clear();
            foreach (String s in MainForm.Instanse.appModel.FinSystem.Log.LogList)
            {
                listLogs.Items.Add(s);
            }
        }
    }
}
