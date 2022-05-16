using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsLibrary.Interfaces;

namespace ModelsLibrary.Entities
{
    public class Transaction : ITransaction
    {
        public int SourceAccountID { get; set; }
        public int SourceBankID { get; set; }
        public int DestinationAccountID { get; set; }
        public int DestinationBankID { get; set; }
        public int Sum { get; set; }
        public TransactionStatus Status { get; set; }
        public int ID { get; set; }
        public Transaction()
        {
        }

        public Transaction(int SourceAccountID, int SourceBankID, int DestinationAccountID, int DestinationBankID, int Sum, int ID, TransactionStatus Status = TransactionStatus.Approved)
        {
            this.SourceBankID = SourceBankID;
            this.SourceAccountID = SourceAccountID;
            this.DestinationBankID = DestinationBankID;
            this.DestinationAccountID = DestinationAccountID;
            this.Sum = Sum;
            this.Status = Status;
            this.ID = ID;
        }
    }
}
