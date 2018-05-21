using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using AutoMapper;

namespace ClassLibrary1
{
    public class AdminOperations
    {
        private readonly UnitOfWork _uow;
        public AdminOperations(UnitOfWork uow)
        {
            this._uow = uow;
        }

        public List<Logic.Admin> GetAdmin()
        {

            return Mapper.Map<IEnumerable<Admin>, List<Logic.Admin>>(_uow.Admins.Get());

        }
        public Logic.Admin GetAdminById(int id)
        {

            return Mapper.Map<Admin, Logic.Admin>(_uow.Admins.GetOne(x => (x.Id == id)));

        }
        public void AddAdmin(Logic.Admin Admin)
        {

            _uow.Admins.Create(new Admin { Login = Admin.getLogin(), Password = Admin.getPassword(), ShortName = Admin.getShortname(), PhoneNumber = Admin.getPhoneNumber(), Authorized = Admin.getAuthorized() });
            _uow.Save();
        }

        public void DeleteAdmin(int id)
        {
            _uow.Admins.Remove(_uow.Admins.FindById(id));
            _uow.Save();
        }
    }
}
