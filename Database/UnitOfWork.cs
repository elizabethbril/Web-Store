﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly ShopContext context;

        public UnitOfWork(ShopContext _context, ContextRepository<User> userRepository,
            ContextRepository<Manager> managerRepository, ContextRepository<Admin> adminRepository,
            ContextRepository<Laptop> laptopRepository, ContextRepository<Accessories> accessoriesRepository,
            ContextRepository<PhotoTechique> photoTechiqueRepository, ContextRepository<SmartPhone> smartPhoneRepository,
            ContextRepository<Tablet> tabletRepository, ContextRepository<Order> orderRepository)
        {
            context = _context;
            Users = userRepository;
            Managers = managerRepository;
            Admins = adminRepository;
            Laptops = laptopRepository;
            Accessories = accessoriesRepository;
            PhotoTechiques = photoTechiqueRepository;
            SmartPhones = smartPhoneRepository;
            Tablets = tabletRepository;
            Orders = orderRepository;
           
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

        public void Save()
        {
           context.SaveChanges();
        }

        private bool _disposed;


        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;
            if (disposing)
            {
                context.Dispose();
            }

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}