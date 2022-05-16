using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsLibrary.Interfaces;

namespace ModelsLibrary.Entities
{
    public class ClientUser : IClientUser
    {
        public Guid UserID { get; set; }
        public String Name { get; set; }
        public void SetName(string name)
        {
            Name = name;
            string[] s = Name.Split(' ');
            FirstName = s[0];
            LastName = s[1];
        }
        public String Login { get; set; }
        public String Password { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Telephone { get; set; }
        public String Email { get; set; }
        public String PassportNum { get; set; }
        public int PassportID { get; set; }
        // поля и методы касающиеся информации (переводы, количество денег, депозиты) собранной со всех банков
        public List<ClientBankAccount> BankAccounts { get; set; }
        public SalaryProjectAccount SalaryProjectAccount { get; set; }
        public UserStatus UserStatus { get; set; }
        public UserType UserType { get; set; } = UserType.Client;
        public ClientUser()
        {
            SalaryProjectAccount = null;
            BankAccounts = new List<ClientBankAccount>();
        }
        public ClientUser(FinancialSystem finSystem)
        {
            SalaryProjectAccount = null;
            BankAccounts = new List<ClientBankAccount>();
        }
        public void RegistrateSalaryProject()
        {
            if (SalaryProjectAccount != null) throw new Exception("Unable to create salary project. Salary project already exists");

        }
        public ClientUser(string name, string login, string password, string telephone, string email, string passportNum, int passportID)
        {
            SetName(name);
            Login = login;
            Password = password;
            Telephone = telephone;
            Email = email;
            PassportNum = passportNum;
            PassportID = passportID;
            UserStatus = UserStatus.NotApproved;
            SalaryProjectAccount = null;
            BankAccounts = new List<ClientBankAccount>();
        }
        public void TransferMoney(int accID, int money, ClientBankAccount accRecieve)
        {
            BankAccounts.Find(item => item.AccountID == accID).TransferMoney(money, accRecieve);
        }
        public ClientBankAccount CreateNewAccount(int AccountID, int bankID)
        {
            var acc = new ClientBankAccount(FirstName, LastName, PassportNum, PassportID, Telephone, Email, bankID, AccountID);
            BankAccounts.Add(acc);
            return acc;
        }
        public ClientBankAccount FindAccount(int accountID)
        {
            return BankAccounts.FirstOrDefault(item => item.AccountID == accountID);
        }
        //public void AddSalaryAccount(int BankID, int AccountID)
        //{
        //    SalaryProjectAccount = new SalaryProjectAccount(FirstName, LastName, PassportNum, PassportID, Telephone, Email, BankID, AccountID, 0);
        //}
        //public void ComposeSalaryProject(SalaryProjectAccount acc)
        //{
        //    SalaryProjectAccount = acc;
        //    acc.EmployeeStatus = EmployeeStatus.NotApproved;
        //}
    }
}
