﻿using ETicaret.Domain.Entities.Common;

namespace ETicaret.Domain.Entities
{
    public class Brand : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
