using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string ShortName { get; set; }
        public string PhoneNumber { get; set; }
        public bool Authorized { get; set; }
        public User() { }
        public User(string login, string password, string shortName, string phoneNumber)
        {
            Login = login;
            Password = password;
            ShortName = shortName;
            PhoneNumber = phoneNumber;
        }
     

    }
}
