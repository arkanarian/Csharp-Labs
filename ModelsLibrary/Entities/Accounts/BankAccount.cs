using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsLibrary.Interfaces;

namespace ModelsLibrary.Entities
{
    public class BankAccount : IBankAccount
    {
        public String Telephone { get; set; }
        public String Email { get; set; }
        public int AccountID { get; set; }
        public int BankID { get; set; }
        public int Money { get; set; }
        // поля и методы (переводы, количество денег, депозиты) касающиеся определенного одного банка
        //public List<Deposit> Deposits { get; set; }
        //public List<Loan> Loans { get; set; }
        public BankAccount()
        {
            Telephone = "";
            Email = "";
            AccountID = 0;
            BankID = 0;
            Money = 0;
        }

        public BankAccount(string Telephone, string Email, int BankID, int AccountID)
        {
            this.Telephone = Telephone;
            this.Email = Email;
            this.AccountID = AccountID;
            this.BankID = BankID;
            this.Money = 0;
        }
        public void AddMoney(int money)
        {
            Money += money;
        }
        public void TakeOffMoney(int money)
        {
            Money -= money;
        }
    }
}
