using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Database;

namespace Logic
{
    public class LaptopOperations
    {

        private readonly IUnitOfWork _uow;
        public LaptopOperations()
        {
            _uow = new UnitOfWork();
        }

        public List<Laptop> GetLaptop()
        {

            return Mapper.Map<IEnumerable<Database.Laptop>, List<Laptop>>(_uow.Laptops.Get());

        }
        public Laptop GetLaptopById(int id)
        {

            return Mapper.Map<Database.Laptop, Laptop>(_uow.Laptops.GetOne(x => (x.Id == id)));

        }
        public void AddLaptop(Laptop Laptop)
        {

            _uow.Laptops.Create(new Database.Laptop { Name = Laptop.Name, Description = Laptop.Description, Price = Laptop.Price });

        }

        public void DeleteLaptop(int id)
        {
            _uow.Laptops.Remove(_uow.Laptops.FindById(id));
        }
    }
}
