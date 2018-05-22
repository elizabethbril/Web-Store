using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Database;

namespace Logic
{
    public class AutoMapper
    {
        
        public static void Initialize()
        {
            
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Database.Laptop, Laptop>();
                cfg.CreateMap<Database.Accessories, Accessories>();
                cfg.CreateMap<Database.SmartPhone, SmartPhone>();
                cfg.CreateMap<Database.PhotoTechique,PhotoTechique>();
                cfg.CreateMap<Database.Tablet, Tablet>();
                cfg.CreateMap<Database.User, User>();
                cfg.CreateMap<Database.Manager, Manager>();
                cfg.CreateMap<Database.Admin, Admin>();
                cfg.CreateMap<Database.Order, Order>();
            });
        }

    }
}
