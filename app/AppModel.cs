using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsLibrary;
using ModelsLibrary.Entities;
using ModelsLibrary.Interfaces;

namespace ApplicationForm
{
    public class AppModel
    {
        public FinancialSystem FinSystem { get; set; }
        public IUser CurrentUser { get; set; }
        public IBank CurrentBank { get; set; }
        public IBankAccount CurrentBankAccount { get; set; }
        private DataBaseMovings DBMovings { get; set; }
        public AppModel()
        {
            FinSystem = new FinancialSystem();
            CurrentUser = null;
            CurrentBank = null;
            DBMovings = new DataBaseMovings();
        }

        // Registrate Client User
        public void SignUpUser(string name, string login, string password, string telephone, string email, string passportNum, int passportID)
        {
            if (FinSystem.FindUser(login) != null) throw new AppException(String.Format("User with '{0}' login already exists. Try another login", login));
            FinSystem.RegistrateUser(name, login, password, telephone, email, passportNum, passportID);
            SignInUser(login, password);
        }
        public void LogOutUser()
        {
            CurrentUser = null;
            CurrentBankAccount = null;
            CurrentBank = null;
        }

        // Registrate Company User
        public void SignUpUser(string login, string password, string email, string telephone, string companyName, int UNP, string address, int bankID, string companyType)
        {
            if(FinSystem.FindUser(login) != null) throw new AppException(String.Format("User with '{0}' login already exists. Try another login", login));
            FinSystem.RegistrateUser(login, password, email, telephone, companyName, UNP, address, bankID, companyType);
            SignInUser(login, password);
            CurrentBank = FinSystem.Banks.Find(item => item.BankID == bankID);
        }
        public void SignInUser(string login, string password)
        {
            try
            {
                var usr = FinSystem.FindUser(login);
                var superusr = FinSystem.FindSuperUser(login);
                if(usr == null && superusr == null)
                {
                    throw new AppException(String.Format("No such user with '{0}' login", login));
                }
                usr = superusr == null ? usr : superusr;
                if (FinSystem.ComparePasswords(usr, password)){
                    CurrentUser = usr;
                }
                if (usr.UserType == UserType.Company)
                {
                    var company = (CompanyUser)usr;
                    CurrentBank = FinSystem.Banks.Find(item => item.BankID == company.BankID);
                }
                else if (usr.UserType == UserType.Client)
                {
                    // set current bank
                }
            }
            catch (Exception e)
            {
                throw new AppException(e.Message);
            } 
        }

        public void CreateTransaction(int accIDReacieve, int sum)
        {
            var accounts = ParseAccounts();
            var acc = accounts.FirstOrDefault(item => item.AccountID == accIDReacieve);
            if (acc == null) throw new AppException("No account with this Accound ID");
            FinSystem.CreateTransaction(CurrentBankAccount.AccountID, CurrentBankAccount.BankID, acc.AccountID, acc.BankID, sum);
        }

        public void AddSalaryAccountFromCompany(string PassportNum)
        {
            FinSystem.AddSalaryAccountFromCompany(PassportNum, (CompanyBankAccount)CurrentBankAccount);
        }
        public void AddSalaryAccountFromClient(int UNP)
        {
            FinSystem.AddSalaryAccountFromClient(UNP, (ClientUser)CurrentUser);
        }
        public void CreateCompanyAccount()
        {
            FinSystem.CreateCompanyAccount((CompanyUser)CurrentUser);
        }
        public void CreateClientAccount()
        {
            if (CurrentBank == null) throw new AppException("You should choose your current bank");
            FinSystem.CreateClientAccount((ClientUser)CurrentUser, (Bank)CurrentBank);
        }

        public void RemoveAccount()
        {
            if(CurrentBankAccount == null) throw new AppException("You should choose active account.");
            FinSystem.RemoveAccount(CurrentBankAccount);
            CurrentBankAccount = null;
        }
        public void AddMoneyToAccount(int money)
        {
            FinSystem.AddMoneyToAccount((BankAccount)CurrentBankAccount, money);
        }
        public void TakeOffMoneyAccount(int money)
        {
            FinSystem.TakeOffMoneyAccount((BankAccount)CurrentBankAccount, money);
        }
        public void UpdateCurrentAccountCompany(int accID)
        {
            var company = (CompanyUser)CurrentUser;
            var acc = company.Accounts.FirstOrDefault(item => item.AccountID == accID);
            if (acc == null) throw new AppException("Account with this ID was not found.");
            CurrentBankAccount = acc;
        }
        public void UpdateCurrentAccountClient(int accID)
        {
            var client = (ClientUser)CurrentUser;
            var acc = client.BankAccounts.FirstOrDefault(item => item.AccountID == accID);
            if (acc == null) throw new AppException("Account with this ID was not found.");
            CurrentBankAccount = acc;
        }
        public void UpdateCurrentBank(string bankName)
        {
            var bank = FinSystem.Banks.FirstOrDefault(item => item.Name == bankName);
            if (bank == null) throw new AppException("Bank with this name was not found.");
            CurrentBank = bank;
        }
        

        public List<IBankAccount> ParseAccounts()
        {
            var accounts = new List<IBankAccount>();
            foreach (var bank in FinSystem.Banks)
            {
                foreach (var acc in bank.ClientAccounts)
                {
                    accounts.Add(acc);
                }
                foreach (var acc in bank.CompanyAccounts)
                {
                    accounts.Add(acc);
                }
                foreach (var accs in bank.SalaryProjects.Values)
                {
                    foreach (var acc in accs)
                    {
                        accounts.Add(acc);
                    }
                }
            }
            return accounts;
        }
        public void StoreDataToFile()
        {
            DBMovings.StoreDataToFile2(FinSystem);
        }
        public void CloseLog()
        {
            FinSystem.Log.CloseLog();
        }
        public void LoadDataFromFile()
        {
            FinSystem = DBMovings.LoadDataFromFile2();
        }
    }
}
