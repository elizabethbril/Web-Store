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
             base( user.getLogin(), user.getPassword(), user.getShortname(), user.getPhoneNumber())
        {
        }
    }
}
