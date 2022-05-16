using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLibrary.Interfaces
{
    public enum TransactionStatus
    {
        NotApproved,
        Approved
    }
    public interface ITransaction
    {
        int SourceAccountID { get; set; }
        int SourceBankID { get; set; }
        int DestinationAccountID { get; set; }
        int DestinationBankID { get; set; }
        int Sum { get; set; }
    }
}
