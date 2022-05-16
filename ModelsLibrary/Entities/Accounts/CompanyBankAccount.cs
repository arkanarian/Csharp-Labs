using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsLibrary.Interfaces;

namespace ModelsLibrary.Entities
{
    public class CompanyBankAccount : BankAccount
    {
        public String CompanyName { get; set; }
        public int UNP { get; set; }
        public int BIK { get; set; }
        public String Address { get; set; }
        public CompanyType CompanyType { get; set; }
        public List<SalaryProjectAccount> Employees { get; set; }
        public CompanyBankAccount() : base()
        {
            CompanyName = "";
            UNP = 0;
            Address = "";
            BankID = 0;
            Employees = new List<SalaryProjectAccount>();
        }
        public CompanyBankAccount(string Email, string Telephone, string CompanyName, int UNP, string Address, int BankID, CompanyType CompanyType, int AccountID) : base(Telephone, Email, BankID, AccountID)
        {
            this.CompanyName = CompanyName;
            this.UNP = UNP;
            this.Address = Address;
            this.CompanyType = CompanyType;
            Employees = new List<SalaryProjectAccount>();
        }
        //public void AddSalaryAccount(ClientUser usr, int salary, int BankID, int accountID)
        //{
        //    Employees.Add(new SalaryProjectAccount(usr.FirstName, usr.LastName, usr.PassportNum, usr.PassportID, usr.Telephone, usr.Email, BankID, accountID, salary));
        //}
        //public void ComposeSalaryProject(SalaryProjectAccount emp)
        //{
        //    emp.EmployeeStatus = EmployeeStatus.NotApproved;
        //    Employees.Add(emp);
        //}
    }
}
