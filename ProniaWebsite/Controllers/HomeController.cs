using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProniaWebsite.DAL;
using ProniaWebsite.Models;
using ProniaWebsite.ViewModels.Home;
//using ProniaWebsite.Models;

namespace ProniaWebsite.Controllers
{
    public class HomeController : Controller
    {
        ProniaContext _context;

       public HomeController(ProniaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM vm = new HomeVM();
            vm.Sliders = _context.Sliders.OrderBy(x => x.Order);
            vm.Services = _context.Services.Where(x => x.IsActive);
            vm.Featured = _context.Products.Take(8).Include(p => p.ProductImages);
            vm.BestSeller = _context.Products.OrderBy(p => p.SoldCount).Take(8).Include(p => p.ProductImages);
            vm.Latest = _context.Products.OrderByDescending(p => p.CreatedTime).Take(8).Include(p => p.ProductImages);
            return View(vm);
        }

        
    }
}
