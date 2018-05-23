using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Database;

namespace Logic
{
    public class TabletOperations
    {
        private readonly IUnitOfWork _uow;
        public TabletOperations()
        {
            _uow = new UnitOfWork();
        }

        public List<Tablet> GetTablet()
        {

            return Mapper.Map<IEnumerable<Database.Tablet>, List<Tablet>>(_uow.Tablets.Get());

        }
        public Tablet GetTabletById(int id)
        {

            return Mapper.Map<Database.Tablet, Tablet>(_uow.Tablets.GetOne(x => (x.Id == id)));

        }
        public void AddTablet(Tablet Tablet)
        {

            _uow.Tablets.Create(new Database.Tablet { Name = Tablet.Name, Description = Tablet.Description, Price = Tablet.Price, imageLink = Tablet.ImageLink, Views = Tablet.Purchases });
            
        }

        public void DeleteTablet(int id)
        {
            _uow.Tablets.Remove(_uow.Tablets.FindById(id));
            
        }
    }
}
