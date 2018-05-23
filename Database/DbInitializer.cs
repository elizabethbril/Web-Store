using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Database
{
    public class DbInitializer:CreateDatabaseIfNotExists<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
            Laptop laptop1 = new Laptop("no descr", 6599, "Laptop Acer Aspire 1 A114-31-C5UB (NX.SHXEU.008) Black 14");
            Laptop laptop2 = new Laptop("no descr", 6599, "Laptop Acer Aspire 1 A114-31-C5UB (NX.SHXEU.008) Black 14");
        }
    }
}
