﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class PhotoTechique:Item
    {
        public PhotoTechique() { }
        public PhotoTechique(string description, int price, string name, string imageLink, int views) :
           base(description, price, name, imageLink, views)
        { }
    }
}
