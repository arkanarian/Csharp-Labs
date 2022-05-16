using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLibrary.Entities
{
    public enum EmployeeStatus
    {
        NotComposed,
        NotApproved,
        Approved,
        Denied
    }
    public class SalaryProjectAccount : ClientBankAccount
    {
        public int Salary { get; set; }
        public EmployeeStatus EmployeeStatus { get; set; }
        public SalaryProjectAccount() : base()
        {
            EmployeeStatus = EmployeeStatus.NotComposed;
        }
        public SalaryProjectAccount(string firstName, string lastName, string passportNum, int passportID, string telephone, string email, int bankID, int accountID, int salary) : base(firstName, lastName, passportNum, passportID, telephone, email, bankID, accountID)
        {
            Salary = salary;
            EmployeeStatus = EmployeeStatus.NotComposed;
        }
    }
}
