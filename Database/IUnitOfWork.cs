using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public interface IUnitOfWork
    {
        ContextRepository<User> Users { get; }
        ContextRepository<Manager> Managers { get; }
        ContextRepository<Admin> Admins { get; }

        ContextRepository<Laptop> Laptops { get; }
        ContextRepository<Accessories> Accessories { get; }
        ContextRepository<PhotoTechique> PhotoTechiques{ get; }
        ContextRepository<SmartPhone> SmartPhones { get; }
        ContextRepository<Tablet> Tablets { get; }

        ContextRepository<Order> Orders { get; }

        void Save();
        void Dispose();
    }
}
