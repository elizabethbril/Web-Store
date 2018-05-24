﻿using System;
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
            Tablet tablet = new Tablet("no descr",6299, "Tablet Lenovo Tab 3 Plus X70L LTE 2/32GB Black", "copy_lenovo_tab3_za0y0036ua_5ab11c32760cb_images_3640238468.jpg",0);
            User user = new User("nestea08@yandex.ru","11111111","nestea08","380964101687");
            Admin admin = new Admin("admin", "admin", "admin", "admin");
            //add some laptops
            context.Laptops.Add(new Laptop("no descr", 6599, "Laptop Acer Aspire 1 A114-31-C5UB (NX.SHXEU.008) Black 14", "acer-aspire-1-a114-31-c5ub-nx-shxeu-008-black-141-150x150.jpg", 0));
            context.Laptops.Add(new Laptop("no descr", 7699, "Laptop Dell Inspiron 3552 (I35P45DIL-60) Black 15.6", "dell-inspiron-3552-i35c45diw-60-black-15-6-150x150.jpg", 3));
            context.Laptops.Add(new Laptop("no descr", 5999, "Ноутбук Lenovo IdeaPad 110-15IBR (80T700D2RA) Black 15.6", "lenovo-ideapad-110-15ibr-80t700d2ra-black-15-63-150x150.jpg", 5));
            context.Laptops.Add(new Laptop("no descr", 6599, "Ноутбук Lenovo IdeaPad 320-15IAP (80XR00NYRA) White 15.6", "lenovo-ideapad-320-15ikb-80xl02qwra-white-15-6-150x150.jpg", 1));

            //add some smartphones
            context.SmartPhones.Add(new SmartPhone("no descr", 11499, "Smartphone SAMSUNG GALAXY A7 SM-A720F DUAL SIM BLACK (SM-A720FZKDSEK)", "samsung-galaxy-a7-sm-a720f-dual-sim-black-sm-a720fzkdsek4-150x150.jpg", 0));
            context.SmartPhones.Add(new SmartPhone("no descr", 11499, "Smartphone LG K220 X POWER DUAL SIM GOLD LGK220DS.ACISGD", "lg-k220-x-power-dual-sim-gold-lgk220ds-acisgd1-150x150.jpg", 7));
            context.SmartPhones.Add(new SmartPhone("no descr", 13608, "Smartphone SONY XPERIA Z 3 DS D 6633 BLACK", "sony-xperia-z-3-ds-d-6633-black-150x150.jpg", 11));
            context.SmartPhones.Add(new SmartPhone("no descr", 9385, "Smartphone MOTOROLA XT1650 Z LUNAR FINE GOLD", "motorola-xt1650-z-lunar-fine-gold6-150x150.jpg", 1));
            context.SmartPhones.Add(new SmartPhone("no descr", 2811, "Smartphone LENOVO VIBE C A2020 DUAL SIM WHITE PA300041UA", "lenovo-vibe-c-a2020-dual-sim-white-pa300041ua1-150x150.jpg", 2));

            //add some tablets
            context.Tablets.Add(new Tablet("no descr", 6299, "Tablet Lenovo Tab 3 Plus X70L LTE 2/32GB Black", "copy_lenovo_tab3_za0y0036ua_5ab11c32760cb_images_3640238468.jpg", 0));
            context.Tablets.Add(new Tablet("no descr", 5389, "Tablet Asus ZenPad 10 2/32GB Wi-Fi FullHD Dark Gray (Z301MF-1H023A)", "copy_asus_z301mfl_1h020a_5a854ca23c3d8_images_3057835983.jpg", 25));
            context.Tablets.Add(new Tablet("no descr", 4399, "Tablet Pixus Vision 10.1 3G 3/16GB", "copy_pixus_vision_10_1_3g_5a749c016e4e2_images_2828805919.jpg", 6));
            context.Tablets.Add(new Tablet("no descr", 5389, "Tablet Lenovo Tab 3 X70F 2/16GB Black (ZA0X0197UA)", "copy_lenovo_tab3_za0x0066ua_5aa66c1762d34_images_3510251871.jpg", 1));
            context.Tablets.Add(new Tablet("no descr", 7199, "Tablet Lenovo Tab 3 Plus X70L 3G 16GB Slate Black (ZA0Y0036UA)", "copy_lenovo_tab3_za0x0066ua_58ab07b3567a1_images_1865224058.jpg", 0));
           // context.Admins.Add(new Admin("admin", "admin", "admin", "admin"));
            
            context.Admins.Add(admin);
            context.Users.Add(user);
            context.SaveChanges();
            
        }
    }
}
