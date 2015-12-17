﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BebaVinho.Domain
{
    public class ProductDetails
    {
        public ProductDetails()
        {
            
        }

        public int Id { get; set; }
        public string SmallDetail { get; set; }
        public string Detail { get; set; }
        public string ImagePath1 { get; set; }
        public string ImagePath2 { get; set; }
        public int ProductId { get; set; }
    }
}
