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

            return Mapper.Map<IEnumerable<Database.Order>, List<Order>>(_uow.Orders.GetWithInclude(u=>u.User,u=>u.Item));

        }
        public Order GetOrderById(int id)
        {

            return Mapper.Map<Database.Order, Order>(_uow.Orders.GetOne(x => (x.Id == id)));

        }
        public void AddOrder(Order Order)
        {

            _uow.Orders.Create(new Database.Order { Item = new Database.Item(Order.item.Description, Order.item.Price, Order.item.Name, Order.item.ImageLink, Order.item.Views), User = new Database.User(Order.user.getLogin(), Order.user.getPassword(), Order.user.getShortname(), Order.user.getPhoneNumber()),Submitted=Order.submitted });
       
        }

        public void DeleteOrder(int id)
        {
            _uow.Orders.Remove(_uow.Orders.FindById(id));
        
        }
    }
}
