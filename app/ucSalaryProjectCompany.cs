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
    public partial class ucSalaryProjectCompany : UserControl
    {
        public ucSalaryProjectCompany()
        {
            InitializeComponent();
        }
        private static ucSalaryProjectCompany _instance;
        public static ucSalaryProjectCompany Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucSalaryProjectCompany();
                return _instance;
            }
        }

        private void btnSendSP_Click(object sender, EventArgs e)
        {
            try
            {
                string passportNum = txtPassportNum.Text;
                if (passportNum == "")
                {
                    throw new AppException("Fields mustn't be empty");
                }
                MainForm.Instanse.appModel.AddSalaryAccountFromCompany(passportNum);
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

        private void btnPaySalary_Click(object sender, EventArgs e)
        {
            foreach (var emp in ((CompanyBankAccount)MainForm.Instanse.appModel.CurrentBankAccount).Employees)
            {
                //string passNum = emp.PassportNum;
                //var usr = MainForm.Instanse.appModel.FinSystem.FindClientByPassNum(passNum);
                MainForm.Instanse.appModel.CreateTransaction(emp.AccountID, emp.Salary);
            }
        }

        private void btnSetSalary_Click(object sender, EventArgs e)
        {
            try
            {
                string passnum = cmbPassNumEmployee.Text;
                if (passnum == "")
                {
                    throw new AppException("Fields mustn't be empty");
                }
                if (!int.TryParse(txtSalary.Text, out var salary) || salary <= 0) throw new AppException("Incorrect Salary.");
                var emp = ((CompanyBankAccount)MainForm.Instanse.appModel.CurrentBankAccount).Employees.Find(item => item.PassportNum == passnum);
                emp.Salary = salary;
                UpdateData();
            }
            catch (AppException ex)
            {
                ex.ShowErrorMessage();
            }
        }

        private void btnUpdateInf_Click(object sender, EventArgs e)
        {
            UpdateData();
        }
        private void UpdateData()
        {
            listEmployees.Items.Clear();
            var acc = (CompanyBankAccount)MainForm.Instanse.appModel.CurrentBankAccount;
            foreach (var emp in acc.Employees)
            {
                string sal = emp.Salary + "  BYN";
                string s = String.Format("{0,-29}{1,-10}", emp.PassportNum, sal);
                listEmployees.Items.Add(s);
                cmbPassNumEmployee.Items.Clear();
                cmbPassNumEmployee.Items.Add(emp.PassportNum);
            }
        }
        public void LoadData()
        {
            UpdateData();
        }
        public void ClearData()
        {
            listEmployees.Items.Clear();
            cmbPassNumEmployee.Items.Clear();
        }

    }
}
