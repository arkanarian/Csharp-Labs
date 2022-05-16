using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsLibrary.Interfaces;

namespace ModelsLibrary.Entities
{
    public class CompanyUser : ICompanyUser
    {
        public Guid UserID { get; set; }
        public String Login { get; set; }
        public String Password { get; set; }
        public String Email { get; set; }
        public String Telephone { get; set; }
        public String CompanyName { get; set; }
        public int UNP { get; set; }
        public String Address { get; set; }
        public int BankID { get; set; }
        public CompanyType CompanyType { get; set; }
        public UserType UserType { get; set; } = UserType.Company;
        public List<CompanyBankAccount> Accounts { get; set; }
        public CompanyUser()
        {
            this.Accounts = new List<CompanyBankAccount>();
        }
        public CompanyUser(string Login, string Password, string Email, string Telephone, string CompanyName, int UNP, string Address, int BankID, string CompanyType) : base()
        {
            this.Login = Login;
            this.Password = Password;
            this.Email = Email;
            this.Telephone = Telephone;
            this.CompanyName = CompanyName;
            this.UNP = UNP;
            this.Address = Address;
            this.BankID = BankID;
            this.CompanyType = SelectCompanyType(CompanyType);
            this.Accounts = new List<CompanyBankAccount>();
        }
        public CompanyBankAccount CreateNewAccount(int AccountID)
        {
            var acc = new CompanyBankAccount(Email, Telephone, CompanyName, UNP, Address, BankID, CompanyType, AccountID);
            Accounts.Add(acc);
            return acc;
        }
        public CompanyType SelectCompanyType(string companyType)
        {
            switch (companyType)
            {
                case "ИП":
                    return CompanyType.IP;
                case "ООО":
                    return CompanyType.OOO;
                case "ЗАО":
                    return CompanyType.ZAO;
                case "ОАО":
                    return CompanyType.OAO;
                case "АО":
                    return CompanyType.AO;
                default: 
                    throw new ArgumentException("Incorrect Company Type");
            }
        }
        public CompanyBankAccount FindAccount(int accountID)
        {
            return Accounts.FirstOrDefault(item => item.AccountID == accountID);
        }
    }
}
