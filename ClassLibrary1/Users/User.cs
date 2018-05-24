using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class User
    {
        public string login;
        public string password;
        public string shortName;
        public string phoneNumber;
        public bool authorized;

        public User() { }
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
