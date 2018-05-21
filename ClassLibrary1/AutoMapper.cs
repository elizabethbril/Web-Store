using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Database;

namespace ClassLibrary1
{
    public class AutoMapper
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Database.Laptop, Logic.Laptop>();
                cfg.CreateMap<Database.Accessories, Logic.Accessories>();
                cfg.CreateMap<Database.SmartPhone, Logic.SmartPhone>();
                cfg.CreateMap<Database.PhotoTechique,Logic.PhotoTechique>();
                cfg.CreateMap<Database.Tablet, Logic.Tablet>();
                cfg.CreateMap<Database.User, Logic.User>();
                cfg.CreateMap<Database.Manager, Logic.Manager>();
                cfg.CreateMap<Database.Admin, Logic.Admin>();
                cfg.CreateMap<Database.Order, Logic.Order>();
            });
        }
    }
}
