using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using AutoMapper;

namespace Logic
{
    public class ManagerOperations
    {
        private readonly IUnitOfWork _uow;
        public ManagerOperations(IUnitOfWork uow)
        {
            this._uow = uow;
        }

        public List<Manager> GetManager()
        {

            return Mapper.Map<IEnumerable<Database.Manager>, List<Manager>>(_uow.Managers.Get());

        }
        public Manager GetManagerById(int id)
        {

            return Mapper.Map<Database.Manager, Manager>(_uow.Managers.GetOne(x => (x.Id == id)));

        }
        public void AddManager(Manager Manager)
        {

            _uow.Managers.Create(new Database.Manager { Login = Manager.getLogin(), Password = Manager.getPassword(), ShortName = Manager.getShortname(), PhoneNumber = Manager.getPhoneNumber(), Authorized = Manager.getAuthorized() });
            _uow.Save();
        }

        public void DeleteManager(int id)
        {
            _uow.Managers.Remove(_uow.Managers.FindById(id));
            _uow.Save();
        }
    }
}
