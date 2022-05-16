using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsLibrary.Entities;

namespace ModelsLibrary.Interfaces
{
    public interface IBank
    {
        String Name { get; set; }
        Guid ID { get; set; }
        int BankID { get; set; }
        List<ClientBankAccount> ClientAccounts { get; set; }
        List<CompanyBankAccount> CompanyAccounts { get; set; }

    }
}
