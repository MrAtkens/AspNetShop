﻿using System.Collections.Generic;

namespace AspNetShop.Domain
{
    public class Category : Entity
    {
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public string ImageUrl { get; set; }
    }
}