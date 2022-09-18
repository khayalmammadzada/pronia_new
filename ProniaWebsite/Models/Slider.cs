using System;
using System.ComponentModel.DataAnnotations;

namespace ProniaWebsite.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [MaxLength(50), Required]
        public string MainTitle { get; set; }
        [MaxLength(30)]
        public string SubTitle { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        [MaxLength(100)]
        public string ImageUrl { get; set; }
        [MaxLength(20)]
        public string BtnText { get; set; }
        public string BtnUrl { get; set; }
        [Range(1,7)]
        public int Order { get; set; }

    }
}
