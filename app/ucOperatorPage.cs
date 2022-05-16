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
    public partial class ucOperatorPage : UserControl
    {
        public ucOperatorPage()
        {
            InitializeComponent();
        }
        private static ucOperatorPage _instance;
        public static ucOperatorPage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucOperatorPage();
                return _instance;
            }
        }
        private void btnConfirmSP_Click(object sender, EventArgs e)
        {
            MainForm.Instanse.appModel.FinSystem.UpproveSP();
            UpdateListSP();
        }
        public void LoadData()
        {
            UpdateListSP();
        }
        public void ClearData()
        {
            listSPs.Items.Clear();
        }
        private void UpdateListSP()
        {
            listSPs.Items.Clear();
            Dictionary<CompanyBankAccount, SalaryProjectAccount> SP = MainForm.Instanse.appModel.FinSystem.GetUnapprovedSP();
            foreach (var sp in SP)
            {
                string name = '\"' + sp.Key.CompanyName + '\"';
                string s = String.Format("{0,-26}{1,-26}{2,-14}", name, sp.Value.PassportNum, sp.Key.BankID);
                listSPs.Items.Add(s);
            }
            
        }
        
    }
}

