using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Database;

namespace ClassLibrary1
{
    public class TabletOperations
    {
        private readonly UnitOfWork _uow;
        public TabletOperations(UnitOfWork uow)
        {
            this._uow = uow;
        }

        public List<Logic.Tablet> GetTablet()
        {

            return Mapper.Map<IEnumerable<Tablet>, List<Logic.Tablet>>(_uow.Tablets.Get());

        }
        public Logic.Tablet GetTabletById(int id)
        {

            return Mapper.Map<Tablet, Logic.Tablet>(_uow.Tablets.GetOne(x => (x.Id == id)));

        }
        public void AddTablet(Logic.Tablet Tablet)
        {

            _uow.Tablets.Create(new Tablet { Name = Tablet.Name, Description = Tablet.Description, Price = Tablet.Price });
            _uow.Save();
        }

        public void DeleteTablet(int id)
        {
            _uow.Tablets.Remove(_uow.Tablets.FindById(id));
            _uow.Save();
        }
    }
}
