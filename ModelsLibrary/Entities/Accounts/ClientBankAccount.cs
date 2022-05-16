using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsLibrary.Interfaces;

namespace ModelsLibrary.Entities
{
    public class ClientBankAccount : BankAccount
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String PassportNum { get; set; }
        public int PassportID { get; set; }
        public ClientBankAccount() : base()
        {
            FirstName = "";
            LastName = "";
            PassportNum = "";
            PassportID = 0;
        }
        public ClientBankAccount(string firstName, string lastName, string passportNum, int passportID, string telephone, string email, int bankID, int accountID) : base(telephone, email, bankID, accountID)
        {
            FirstName = firstName;
            LastName = lastName;
            PassportNum = passportNum;
            PassportID = passportID;
        }
        public void TransferMoney(int money, BankAccount accRecieve)
        {
            Money -= money;
            accRecieve.Money += money;
        }
    }
}
