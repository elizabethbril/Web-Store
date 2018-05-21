using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using AutoMapper;

namespace ClassLibrary1
{
    public class SmartPhoneOperations
    {
        private readonly UnitOfWork _uow;
        public SmartPhoneOperations(UnitOfWork uow)
        {
            this._uow = uow;
        }

        public List<Logic.SmartPhone> GetSmartPhone()
        {

            return Mapper.Map<IEnumerable<SmartPhone>, List<Logic.SmartPhone>>(_uow.SmartPhones.Get());

        }
        public Logic.SmartPhone GetSmartPhoneById(int id)
        {

            return Mapper.Map<SmartPhone, Logic.SmartPhone>(_uow.SmartPhones.GetOne(x => (x.Id == id)));

        }
        public void AddSmartPhone(Logic.SmartPhone SmartPhone)
        {

            _uow.SmartPhones.Create(new SmartPhone { Name = SmartPhone.Name, Description = SmartPhone.Description, Price = SmartPhone.Price });
            _uow.Save();
        }

        public void DeleteSmartPhone(int id)
        {
            _uow.SmartPhones.Remove(_uow.SmartPhones.FindById(id));
            _uow.Save();
        }
    }
}
