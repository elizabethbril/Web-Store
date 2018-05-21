using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Database
{
    public class ShopContext:DbContext
    {
        public ShopContext() : base("DbConnection")
        {

        }
    }
}
