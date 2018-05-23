using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Database
{
    public class DbInitializer:DropCreateDatabaseIfModelChanges<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
            Laptop laptop1 = new Laptop("no descr", 6599, "Laptop Acer Aspire 1 A114-31-C5UB (NX.SHXEU.008) Black 14", "acer-aspire-1-a114-31-c5ub-nx-shxeu-008-black-141-150x150.jpg", 0);
            Laptop laptop2 = new Laptop("no descr", 7699, "Laptop Dell Inspiron 3552 (I35P45DIL-60) Black 15.6", "dell-inspiron-3552-i35c45diw-60-black-15-6-150x150.jpg", 0);
            SmartPhone phone1 = new SmartPhone("no descr", 11499, "Smartphone SAMSUNG GALAXY A7 SM-A720F DUAL SIM BLACK (SM-A720FZKDSEK)", "samsung-galaxy-a7-sm-a720f-dual-sim-black-sm-a720fzkdsek4-150x150.jpg", 0);
            Tablet tablet = new Tablet("no descr",6299, "Tablet Lenovo Tab 3 Plus X70L LTE 2/32GB Black", "copy_lenovo_tab3_za0y0036ua_5ab11c32760cb_images_3640238468.jpg",0);
            User user = new User("nestea08@yandex.ru","11111111","nestea08","380964101687");
            context.Laptops.Add(laptop1);
            context.Laptops.Add(laptop2);
            context.SmartPhones.Add(phone1);
            context.Tablets.Add(tablet);
            context.Users.Add(user);
            context.SaveChanges();
            
        }
    }
}
