using System;
namespace ProniaWebsite.Models
{
    public class ProductImage:BaseEntity
    {
        public string ImageUrl { get; set; }
        public bool? Status { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
       

    }
}
