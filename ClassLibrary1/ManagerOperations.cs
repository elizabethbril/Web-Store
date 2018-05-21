using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using AutoMapper;

namespace ClassLibrary1
{
    public class ManagerOperations
    {
        private readonly UnitOfWork _uow;
        public ManagerOperations(UnitOfWork uow)
        {
            this._uow = uow;
        }

        public List<Logic.Manager> GetManager()
        {

            return Mapper.Map<IEnumerable<Manager>, List<Logic.Manager>>(_uow.Managers.Get());

        }
        public Logic.Manager GetManagerById(int id)
        {

            return Mapper.Map<Manager, Logic.Manager>(_uow.Managers.GetOne(x => (x.Id == id)));

        }
        public void AddManager(Logic.Manager Manager)
        {

            _uow.Managers.Create(new Manager { Login = Manager.getLogin(), Password = Manager.getPassword(), ShortName = Manager.getShortname(), PhoneNumber = Manager.getPhoneNumber(), Authorized = Manager.getAuthorized() });
            _uow.Save();
        }

        public void DeleteManager(int id)
        {
            _uow.Managers.Remove(_uow.Managers.FindById(id));
            _uow.Save();
        }
    }
}
