using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLibrary.Interfaces
{
    public enum UserType
    {
        Client,
        Company,
        Operator,
        Manager,
        Administrator
    }
    public interface IUser
    {
        Guid UserID { get; set; }
        String Login { get; set; }
        String Password { get; set; }
        String Email { get; set; }
        String Telephone { get; set; }
        UserType UserType { get; set; }

    }
}
