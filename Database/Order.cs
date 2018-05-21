using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Order
    {
        public int Id { get; set; }

        public Item Item { get; set; }
        public int? ItemId { get; set; } 

        public User User { get; set; }
        public int? UserId { get; set; }

        public Order() { }
        public Order(Item item, User user)
        {
            Item = item;
            User = user;
        }
    }
}
