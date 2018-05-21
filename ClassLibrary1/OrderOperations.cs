using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using AutoMapper;

namespace ClassLibrary1
{
    public class OrderOperations
    {
        private readonly UnitOfWork _uow;
        public OrderOperations(UnitOfWork uow)
        {
            this._uow = uow;
        }

        public List<Logic.Order> GetOrder()
        {

            return Mapper.Map<IEnumerable<Order>, List<Logic.Order>>(_uow.Orders.Get());

        }
        public Logic.Order GetOrderById(int id)
        {

            return Mapper.Map<Order, Logic.Order>(_uow.Orders.GetOne(x => (x.Id == id)));

        }
        public void AddOrder(Logic.Order Order)
        {

            _uow.Orders.Create(new Order { Item = Mapper.Map<Logic.Item,Item>(Order.item), User = Mapper.Map<Logic.User,User>(Order.user) });
            _uow.Save();
        }

        public void DeleteOrder(int id)
        {
            _uow.Orders.Remove(_uow.Orders.FindById(id));
            _uow.Save();
        }
    }
}
