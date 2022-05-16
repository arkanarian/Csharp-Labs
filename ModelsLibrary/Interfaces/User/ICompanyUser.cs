using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsLibrary.Entities;

namespace ModelsLibrary.Interfaces
{
    public enum CompanyType
    {
        IP,
        OOO,
        ZAO,
        OAO,
        AO
    }
    interface ICompanyUser : IUser
    {
        String CompanyName { get; set; }
        int UNP { get; set; }
        String Address { get; set; }
        CompanyType CompanyType { get; set; }
        List<CompanyBankAccount> Accounts { get; set; }
    }
}
