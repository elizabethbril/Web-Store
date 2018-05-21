using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
     public class Manager:User
    {
        public Manager(User user) :
             base(user.Login, user.Password, user.ShortName, user.PhoneNumber)
        {
           
        }
    }
}
