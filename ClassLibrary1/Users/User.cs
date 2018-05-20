using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class User
    {
        protected string login;
        protected string password;
        protected string shortName;
        protected string phoneNumber;
        protected bool authorized;

        public User(string login, string password, string shortName, string phoneNumber)
        {
            this.login = login;
            this.password = password;
            this.shortName = shortName;
            this.phoneNumber = phoneNumber;
        }
        public bool getAuthorized() { return authorized; }
        public string getLogin() {return login; }
        public string getPassword() { return password; }
        public string getShortname() { return shortName; }
        public string getPhoneNumber() { return phoneNumber; }

    }
}
