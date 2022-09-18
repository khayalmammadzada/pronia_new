using System;
using System.Collections.Generic;

namespace ProniaWebsite.Models
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal SellPrice { get; set; }
        public decimal CostPrice { get; set; }
        public int Rating { get; set; }
        public string BarCode { get; set; }
        public int SoldCount { get; set; }
        public IEnumerable<ProductImage> ProductImages { get; set; }
        public ICollection<ProductColor> ProductColors { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }

    }
}
