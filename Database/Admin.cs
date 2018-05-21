using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Admin:User
    {
        public Admin() { }
        public Admin(User user) :
             base(user.Login, user.Password, user.ShortName, user.PhoneNumber)
        {

        }
    }
}
