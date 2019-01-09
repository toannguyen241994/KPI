﻿using Framework.Constract.SeedWork;

namespace Blue.Data.Models
{
    public class ProductCategory : BaseEntity
    {
        public bool IsFeaturedProduct { get; set; }

        public int DisplayOrder { get; set; }

        public long CategoryId { get; set; }

        public long ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
