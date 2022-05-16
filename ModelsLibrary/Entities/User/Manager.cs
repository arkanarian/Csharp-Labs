using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsLibrary.Interfaces;

namespace ModelsLibrary.Entities
{
    public class Manager : IManager
    {
        public Guid UserID { get; set; }
        public String Login { get; set; }
        public String Password { get; set; }
        public String Email { get; set; }
        public String Telephone { get; set; }
        public UserType UserType { get; set; } = UserType.Manager;
        public Manager()
        {
            Login = "";
            Password = "";
            Email = "";
            Telephone = "";
        }
        public Manager(string login, string password)
        {
            Login = login;
            Password = password;
            Email = "";
            Telephone = "";
        }
    }
}

