using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models
{
    public class Order
    {
        public int orderId;
        public Item item;
        public User user;

        public Order(int orderId, Item item, User user)
        {
            this.orderId = orderId;
            this.item = item;
            this.user = user;
        }
    }
}