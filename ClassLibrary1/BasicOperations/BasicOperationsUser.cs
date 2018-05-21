using System.Collections.Generic;
using Database;

namespace ClassLibrary1.BasicOperations
{
    public class BasicOperationUser
    {
        private readonly UnitOfWork _uow;
        public BasicOperationUser(UnitOfWork uow)
        {
            this._uow = uow;
        }

        public List<User> GetDepartament()
        {
            //var places = new List<Departament>();
            //places = Mapper.Map<IEnumerable<Departament1>, List<Departament>>(_uow.Departaments.Get());
            //return places;
            return Mapper.Map<IEnumerable<Users>, List<Item>>(_uow.Users.Get());

        }
        public Item GetUserById(int id)
        {
            //var places = new Departament();
            //places = Mapper.Map<Departament1,Departament>(_uow.Departaments.Get(x=>(x.DepPk==id)));
            //return places;
            return Mapper.Map<User, User>(_uow.Users.GetOne(x => (x.Id == id)));

        }
        public void AddUser(User user)
        {
            //  var uow = new UnitOfWork();
            _uow.I.Create(new User { Name = user.Name, Building = departament.Building });
            _uow.Save();
        }

        public void DeleteDepartament(int id)
        {
            _uow.Departaments.Remove(_uow.Departaments.FindById(id));
            _uow.Save();
        }
    }
}
