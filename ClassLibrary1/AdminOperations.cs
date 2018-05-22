using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using AutoMapper;

namespace Logic
{
    public class AdminOperations
    {
        private readonly UnitOfWork _uow;
        public AdminOperations(UnitOfWork uow)
        {
            this._uow = uow;
        }

        public List<Admin> GetAdmin()
        {

            return Mapper.Map<IEnumerable<Database.Admin>, List<Admin>>(_uow.Admins.Get());

        }
        public Admin GetAdminById(int id)
        {

            return Mapper.Map<Database.Admin, Admin>(_uow.Admins.GetOne(x => (x.Id == id)));

        }
        public void AddAdmin(Admin Admin)
        {

            _uow.Admins.Create(new Database.Admin { Login = Admin.getLogin(), Password = Admin.getPassword(), ShortName = Admin.getShortname(), PhoneNumber = Admin.getPhoneNumber(), Authorized = Admin.getAuthorized() });
            _uow.Save();
        }

        public void DeleteAdmin(int id)
        {
            _uow.Admins.Remove(_uow.Admins.FindById(id));
            _uow.Save();
        }
    }
}
