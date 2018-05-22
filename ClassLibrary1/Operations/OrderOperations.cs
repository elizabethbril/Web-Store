using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using AutoMapper;

namespace Logic
{
    public class OrderOperations
    {
        private readonly IUnitOfWork _uow;
        public OrderOperations()
        {
            _uow = new UnitOfWork();
        }

        public List<Order> GetOrder()
        {

            return Mapper.Map<IEnumerable<Database.Order>, List<Order>>(_uow.Orders.Get());

        }
        public Order GetOrderById(int id)
        {

            return Mapper.Map<Database.Order, Order>(_uow.Orders.GetOne(x => (x.Id == id)));

        }
        public void AddOrder(Order Order)
        {

            _uow.Orders.Create(new Database.Order { Item = Mapper.Map<Item, Database.Item>(Order.item), User = Mapper.Map<User, Database.User>(Order.user) });
       
        }

        public void DeleteOrder(int id)
        {
            _uow.Orders.Remove(_uow.Orders.FindById(id));
        
        }
    }
}
