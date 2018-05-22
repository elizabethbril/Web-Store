using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using AutoMapper;

namespace Logic
{
    public class UserOperations
    {
        private readonly UnitOfWork _uow;
        public UserOperations(UnitOfWork uow)
        {
            this._uow = uow;
        }

        public List<User> GetUser()
        {

            return Mapper.Map<IEnumerable<Database.User>, List<User>>(_uow.Users.Get());

        }
        public User GetUserById(int id)
        {

            return Mapper.Map<Database.User, User>(_uow.Users.GetOne(x => (x.Id == id)));

        }
        public void AddUser(User User)
        {

            _uow.Users.Create(new Database.User { Login = User.getLogin(), Password = User.getPassword(), ShortName = User.getShortname(),PhoneNumber=User.getPhoneNumber(),Authorized=User.getAuthorized() });
            _uow.Save();
        }

        public void DeleteUser(int id)
        {
            _uow.Users.Remove(_uow.Users.FindById(id));
            _uow.Save();
        }
    }
}
