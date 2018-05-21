using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Manager : User
    {
        /*public Manager(string login, string password, string shortName, string phoneNumber) :
             base(login, password, shortName, phoneNumber)
        { }*/
        public Manager(User user) :
<<<<<<< HEAD
             base( user.getLogin(), user.getpPassword(), user.getShortname(), user.getPhoneNumber())
        {
            login = user.getLogin();
            password = user.getpPassword();
            shortName = user.getShortname();
            phoneNumber = user.getPhoneNumber();
=======
             base( user.getLogin(), user.getPassword(), user.getShortname(), user.getPhoneNumber())
        {
>>>>>>> Dimolll
        }
    }
}
