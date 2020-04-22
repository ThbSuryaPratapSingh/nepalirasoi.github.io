﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NepaliRasoi.Entities
{
    public class Category : BaseEntity
    {
        public string ImageURl {get;set;}
        public List<Product> Products { get; set; }
        
        public bool isFeatured { get; set; }
    }
}
