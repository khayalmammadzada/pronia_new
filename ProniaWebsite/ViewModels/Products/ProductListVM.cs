using System;
using System.Collections.Generic;
using ProniaWebsite.Models;

namespace ProniaWebsite.ViewModels.Products
{
    public class ProductListVM
    {
        public IEnumerable<Product> Products;
        public IEnumerable<Color> Colors;
        public IEnumerable<Category> Categories;
        public int ProductCount;
        public IEnumerable<ProductCategory> ProductCategories;

    }
}
