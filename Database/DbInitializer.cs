using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Database
{
    public class DbInitializer:DropCreateDatabaseAlways<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
            Tablet tablet = new Tablet("no descr",6299, "Tablet Lenovo Tab 3 Plus X70L LTE 2/32GB Black", "copy_lenovo_tab3_za0y0036ua_5ab11c32760cb_images_3640238468.jpg",0);
            User user = new User("nestea08@yandex.ru","11111111","nestea08","380964101687");
            
            //add some laptops
            context.Laptops.Add(new Laptop("no descr", 6599, "Laptop Acer Aspire 1 A114-31-C5UB (NX.SHXEU.008) Black 14", "acer-aspire-1-a114-31-c5ub-nx-shxeu-008-black-141-150x150.jpg", 0));
            context.Laptops.Add(new Laptop("no descr", 7699, "Laptop Dell Inspiron 3552 (I35P45DIL-60) Black 15.6", "dell-inspiron-3552-i35c45diw-60-black-15-6-150x150.jpg", 3));
            context.Laptops.Add(new Laptop("no descr", 5999, "Ноутбук Lenovo IdeaPad 110-15IBR (80T700D2RA) Black 15.6", "lenovo-ideapad-110-15ibr-80t700d2ra-black-15-63-150x150.jpg", 5));
            context.Laptops.Add(new Laptop("no descr", 6599, "Ноутбук Lenovo IdeaPad 320-15IAP (80XR00NYRA) White 15.6", "lenovo-ideapad-320-15ikb-80xl02qwra-white-15-6-150x150.jpg", 1));
            context.Laptops.Add(new Laptop("no descr", 6535, "Ноутбук Asus X541NA (X541NA-GO129) White 15.6", "asus-x541na-x541na-go129-white-15-63-150x150.jpeg", 1));

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

            //add some phototechniqe
            context.PhotoTechiques.Add(new PhotoTechique("no descr", 74999, "Panasonic Lumix DC-GH5S Body Black (DC-GH5SEE-K)", "canon_powershot_g7_x_mark_ii_images_1797905293.jpg", 1));
            context.PhotoTechiques.Add(new PhotoTechique("no descr", 27999, "Sony Alpha 6300 Body Black (ILCE6300B.CEC)", "sony_ilce6300b_cec_images_1538298308.jpg", 8));
            context.PhotoTechiques.Add(new PhotoTechique("no descr", 18999, "Panasonic Lumix DMC-G7 Kit 14-42mm Black (DMC-G7KEE-K)", "panasonic_lumix_dmc_g7kee_k_images_1319226872.jpg", 0));
            context.PhotoTechiques.Add(new PhotoTechique("no descr", 30999, "Canon EOS M6 15-45 IS STM Silver (1725C045)", "canon_1724c045_images_3422208311.jpg", 0));
            context.PhotoTechiques.Add(new PhotoTechique("no descr", 74999, "Olympus OM-D E-M10 Mark II Pancake Zoom 14-42mm Kit Black (V207052BE000)", "olympus_omd_em10ll_pancake_kit_black_images_1382665659.jpg", 1));

            //add some accessories
            context.Accessories.Add(new Accessories("no descr", 1799, "GamePad Sony Dualshock V2 Bluetooth PS4 Black", "sony_dualshock_4_v2_for_ps_4_black_images_1769139205.jpg", 15));
            context.Accessories.Add(new Accessories("no descr", 2199, "USB-hub Kingston Nucleum USB 3.1 Type-C (C-HUBC1-SR-EN)", "kingston_c_hubc1_sr_en_images_2949154215.jpg", 9));
            context.Accessories.Add(new Accessories("no descr", 3199, "Kingston HyperX Cloud II (KHX-HSCP-RD) Red", "kingston_hyperx_cloud_ii_red_images_434614402.jpg", 87));
            context.Accessories.Add(new Accessories("no descr", 156, "Kingston HyperX Savage USB 3.1 64GB (HXS3/64GB)", "kingston_hxs3_64gb_images_1826556130.png", 15));
            context.Accessories.Add(new Accessories("no descr", 156, "GameMouse Logitech G903 Black", "32530415_images_2933174479.jpg", 0));

            context.Users.Add(user);
            context.SaveChanges();
            
        }
    }
}
