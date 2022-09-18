using System;
using System.Collections.Generic;

namespace ProniaWebsite.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }

    }
}
