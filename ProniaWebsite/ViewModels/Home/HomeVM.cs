using System;
using System.Collections.Generic;
using ProniaWebsite.Models;

namespace ProniaWebsite.ViewModels.Home
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Service> Services { get; set; }
        public IEnumerable<Product> Featured { get; set; }
        public IEnumerable<Product> BestSeller { get; set; }
        public IEnumerable<Product> Latest { get; set; }

    }
}
