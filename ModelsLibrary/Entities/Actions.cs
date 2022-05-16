using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLibrary.Entities
{
    public class Actions
    {
        public Dictionary<int, Transaction> ExecutedTransactions { get; set; }
        public Dictionary<int, ClientBankAccount> CreatedClientAccounts { get; set; }
        public Dictionary<int, CompanyBankAccount> CreatedCompanyAccounts { get; set; }

        public Actions()
        {
            ExecutedTransactions = new Dictionary<int, Transaction>();
            CreatedClientAccounts = new Dictionary<int, ClientBankAccount>();
            CreatedCompanyAccounts = new Dictionary<int, CompanyBankAccount>();
        }
        public void WriteAction(Transaction ts, int id)
        {
            ExecutedTransactions.Add(id, ts);
        }
        public void WriteAction(ClientBankAccount acc, int id)
        {
            CreatedClientAccounts.Add(id, acc);
        }
        public void WriteAction(CompanyBankAccount acc, int id)
        {
            CreatedCompanyAccounts.Add(id, acc);
        }
        public bool FindActionTS(int id)
        {
            if (ExecutedTransactions.ContainsKey(id)) return true;
            return false;
        }
        public bool FindActionClAcc(int id)
        {
            if (CreatedClientAccounts.ContainsKey(id)) return true;
            return false;
        }
        public bool FindActionCompAcc(int id)
        {
            if (CreatedCompanyAccounts.ContainsKey(id)) return true;
            return false;
        }
        public Transaction LastActionTS()
        {
            //var i = ExecutedTransactions.Count - 1;
            //return ExecutedTransactions[i];
            return ExecutedTransactions.Values.Last();
        }
        public ClientBankAccount LastActionClAcc()
        {
            //var i = CreatedClientAccounts.Count - 1;
            //return CreatedClientAccounts[i];
            return CreatedClientAccounts.Values.Last();
        }
        public CompanyBankAccount LastActionCompAcc()
        {
            //var i = CreatedCompanyAccounts.Count - 1;
            return CreatedCompanyAccounts.Values.Last();
        }
        public void DeleteAction(int id)
        {
            if(ExecutedTransactions.ContainsKey(id)) ExecutedTransactions.Remove(id);
            else if(CreatedClientAccounts.ContainsKey(id)) CreatedClientAccounts.Remove(id);
            else if(CreatedCompanyAccounts.ContainsKey(id)) CreatedCompanyAccounts.Remove(id);
        }
    }
}
