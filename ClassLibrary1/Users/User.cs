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
<<<<<<< HEAD
=======
        protected bool authorized;
>>>>>>> Dimolll

        public User(string login, string password, string shortName, string phoneNumber)
        {
            this.login = login;
            this.password = password;
            this.shortName = shortName;
            this.phoneNumber = phoneNumber;
        }
<<<<<<< HEAD

        public string getLogin() {return login; }
        public string getpPassword() { return password; }
=======
        public bool getAuthorized() { return authorized; }
        public string getLogin() {return login; }
        public string getPassword() { return password; }
>>>>>>> Dimolll
        public string getShortname() { return shortName; }
        public string getPhoneNumber() { return phoneNumber; }

    }
}
