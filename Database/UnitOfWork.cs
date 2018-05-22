using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class UnitOfWork:IUnitOfWork
    {
        
        public UnitOfWork()
        {
            
                
               
                Users = new ContextRepository<User>();
                Managers = new ContextRepository<Manager>();
                Admins = new ContextRepository<Admin>();
                Laptops = new ContextRepository<Laptop>();
                Accessories = new ContextRepository<Accessories>();
                PhotoTechiques = new ContextRepository<PhotoTechique>();
                SmartPhones = new ContextRepository<SmartPhone>();
                Tablets = new ContextRepository<Tablet>();
                Orders = new ContextRepository<Order>();
            
        }
        public ContextRepository<User> Users { get; }
        public ContextRepository<Manager> Managers { get; }
        public ContextRepository<Admin> Admins { get; }

        public ContextRepository<Laptop> Laptops { get; }
        public ContextRepository<Accessories> Accessories { get; }
        public ContextRepository<PhotoTechique> PhotoTechiques { get; }
        public ContextRepository<SmartPhone> SmartPhones { get; }
        public ContextRepository<Tablet> Tablets { get; }

        public ContextRepository<Order> Orders { get; }

       

    }
}
