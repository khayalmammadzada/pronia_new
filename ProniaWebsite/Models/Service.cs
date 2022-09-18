using System;
using System.ComponentModel.DataAnnotations;

namespace ProniaWebsite.Models
{
    public class Service
    {
        
        public int Id { get; set; }
        [StringLength(maximumLength:50), MaxLength(50), Required]
        public string Name { get; set; }
        [Required]
        public string Icon { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }


    }
}
