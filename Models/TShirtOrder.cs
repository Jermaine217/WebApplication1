﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class TShirtOrder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string ShippingAddress { get; set; }
        public bool Done { get; set; }
    }

}

