using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Logic
    {
        List<Item> items = new List<Item>();
        List<User> users = new List<User>();
        List<Order> orders = new List<Order>();

        public void Registration(string login, string password, string shortName, string phone) 
        {
            users.Add(new User(login,password,shortName, phone));
        }

        public void ChangeItem(Item item)
        {
            
        }

        public void doOrder(Item item, User user) {
            orders.Add(new Order(45, item, user));
        }

        public void newManager(User user)
        {
            for(int i=0; i<users.Count;i++)
            {
                if (users[i].Equals(user))
                {
                    User newManag = new Manager(user);
                    users[i] = newManager(user);
                }
            }
            User kek = new Manager(User user);
        }
    }
}
