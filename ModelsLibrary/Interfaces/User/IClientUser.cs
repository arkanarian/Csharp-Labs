using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsLibrary.Interfaces;
using ModelsLibrary.Entities;

namespace ModelsLibrary.Interfaces
{
    public enum UserStatus
    {
        NotApproved,
        Approved,
        Denied
    }
    public interface IClientUser : IUser
    {
        String Name { get; set; }
        String FirstName { get; set; }
        String LastName { get; set; }
        String PassportNum { get; set; }
        int PassportID { get; set; }
        UserStatus UserStatus { get; set; }
        //public List<Deposit> Deposits { get; set; }
        //public List<Loan> Loans { get; set; }
        List<ClientBankAccount> BankAccounts { get; set; }
        SalaryProjectAccount SalaryProjectAccount { get; set; }
    }
}
