﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class SmartPhone: Item
    {
        public SmartPhone() { }
        public SmartPhone(string description, int price, string name, string imageLink, int views) :
            base(description, price, name, imageLink, views)
        { }
    }
}
