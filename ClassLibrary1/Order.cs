using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Order
    {
        public int orderId;
        public bool submitted;
        public Item item;
        public User user;
        public Order() { }
        public Order(int orderId, Item item, User user)
        {
            this.orderId = orderId;
            this.item = item;
            this.user = user;
        }
    }
}
