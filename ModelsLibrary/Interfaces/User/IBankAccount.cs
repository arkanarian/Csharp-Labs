using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLibrary.Interfaces
{
    public interface IBankAccount
    {
        String Telephone { get; set; }
        String Email { get; set; }
        int AccountID { get; set; }
        int BankID { get; set; }
        int Money { get; set; }
    }
}
