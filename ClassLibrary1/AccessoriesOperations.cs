﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using AutoMapper;

namespace ClassLibrary1
{
    public class AccessoriesOperations
    {
        private readonly UnitOfWork _uow;
        public AccessoriesOperations(UnitOfWork uow)
        {
            this._uow = uow;
        }

        public List<Logic.Accessories> GetAccessories()
        {

            return Mapper.Map<IEnumerable<Accessories>, List<Logic.Accessories>>(_uow.Accessories.Get());

        }
        public Logic.Accessories GetAccessoriesById(int id)
        {

            return Mapper.Map<Accessories, Logic.Accessories>(_uow.Accessories.GetOne(x => (x.Id == id)));

        }
        public void AddAccessories(Logic.Accessories Accessories)
        {

            _uow.Accessories.Create(new Accessories { Name = Accessories.Name, Description = Accessories.Description, Price = Accessories.Price });
            _uow.Save();
        }

        public void DeleteAccessories(int id)
        {
            _uow.Accessories.Remove(_uow.Accessories.FindById(id));
            _uow.Save();
        }
    }
}
