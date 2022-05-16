using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsLibrary.Interfaces;

namespace ModelsLibrary.Entities
{
    public class Operator : IOperator
    {
        public Guid UserID { get; set; }
        public String Login { get; set; }
        public String Password { get; set; }
        public String Email { get; set; }
        public String Telephone { get; set; }
        public UserType UserType { get; set; } = UserType.Operator;
        public Operator()
        {
            Login = "";
            Password = "";
            Email = "";
            Telephone = "";
        }
        public Operator(string login, string password)
        {
            Login = login;
            Password = password;
            Email = "";
            Telephone = "";
        }
    }
}
