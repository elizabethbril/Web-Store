using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Admin:User
    {
        public Admin() { }
        public Admin(User user) :
             base(user.getLogin(), user.getPassword(), user.getShortname(), user.getPhoneNumber())
        {

        }
    }
}
