﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core
{
    public class ProductFeature 
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public int weight { get; set; }
        public int widht { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
