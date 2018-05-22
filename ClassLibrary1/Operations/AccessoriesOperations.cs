﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using AutoMapper;

namespace Logic
{
    public class AccessoriesOperations
    {
        private readonly IUnitOfWork _uow;
        public AccessoriesOperations()
        {
            _uow = new UnitOfWork();
        }

        public List<Accessories> GetAccessories()
        {

            return Mapper.Map<IEnumerable<Database.Accessories>, List<Accessories>>(_uow.Accessories.Get());

        }
        public Accessories GetAccessoriesById(int id)
        {

            return Mapper.Map<Database.Accessories, Accessories>(_uow.Accessories.GetOne(x => (x.Id == id)));

        }
        public void AddAccessories(Accessories Accessories)
        {

            _uow.Accessories.Create(new Database.Accessories { Name = Accessories.Name, Description = Accessories.Description, Price = Accessories.Price });
            
        }

        public void DeleteAccessories(int id)
        {
            _uow.Accessories.Remove(_uow.Accessories.FindById(id));
            
        }
    }
}