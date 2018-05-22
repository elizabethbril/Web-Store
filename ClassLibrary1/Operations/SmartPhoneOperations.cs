using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using AutoMapper;

namespace Logic
{
    public class SmartPhoneOperations
    {
        private readonly IUnitOfWork _uow;
        public SmartPhoneOperations(IUnitOfWork uow)
        {
            this._uow = uow;
        }

        public List<SmartPhone> GetSmartPhone()
        {

            return Mapper.Map<IEnumerable<Database.SmartPhone>, List<SmartPhone>>(_uow.SmartPhones.Get());

        }
        public SmartPhone GetSmartPhoneById(int id)
        {

            return Mapper.Map<Database.SmartPhone, SmartPhone>(_uow.SmartPhones.GetOne(x => (x.Id == id)));

        }
        public void AddSmartPhone(SmartPhone SmartPhone)
        {

            _uow.SmartPhones.Create(new Database.SmartPhone { Name = SmartPhone.Name, Description = SmartPhone.Description, Price = SmartPhone.Price });
            _uow.Save();
        }

        public void DeleteSmartPhone(int id)
        {
            _uow.SmartPhones.Remove(_uow.SmartPhones.FindById(id));
            _uow.Save();
        }
    }
}
