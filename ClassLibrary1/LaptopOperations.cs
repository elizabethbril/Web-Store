using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Database;

namespace ClassLibrary1
{
    public class LaptopOperations
    {

        private readonly UnitOfWork _uow;
        public LaptopOperations(UnitOfWork uow)
        {
            this._uow = uow;
        }

        public List<Logic.Laptop> GetLaptop()
        {

            return Mapper.Map<IEnumerable<Laptop>, List<Logic.Laptop>>(_uow.Laptops.Get());

        }
        public Logic.Laptop GetLaptopById(int id)
        {

            return Mapper.Map<Laptop, Logic.Laptop>(_uow.Laptops.GetOne(x => (x.Id == id)));

        }
        public void AddLaptop(Logic.Laptop Laptop)
        {

            _uow.Laptops.Create(new Laptop { Name = Laptop.Name, Description = Laptop.Description, Price = Laptop.Price });
            _uow.Save();
        }

        public void DeleteLaptop(int id)
        {
            _uow.Laptops.Remove(_uow.Laptops.FindById(id));
            _uow.Save();
        }
    }
}
