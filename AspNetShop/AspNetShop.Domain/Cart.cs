using System;
using System.Collections.Generic;

namespace AspNetShop.Domain
{
    public class Cart : Entity
    {
        public virtual ICollection<ProductInCart> ProductsInCart { get; set; }
        public virtual User User { get; set; }

        public Guid UserId { get; set; }
    }
}