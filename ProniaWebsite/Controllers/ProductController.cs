using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProniaWebsite.DAL;
using ProniaWebsite.Models;
using ProniaWebsite.ViewModels.Products;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProniaWebsite.Controllers
{
    public class ProductController : Controller
    {
        ProniaContext _context { get; }

        public ProductController(ProniaContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? colorId)
        {
            var products = _context.Products.Include(p => p.ProductImages)
                .Include(p => p.ProductColors).ThenInclude(pc => pc.Color).AsQueryable();
            int count = products.Count();
            if (colorId != null)
            {
                products = products.Where(p => p.ProductColors.Any(pc => pc.ColorId == colorId));
            }
            ProductListVM productListVM = new ProductListVM
            {
                Products = products.ToList(),
                Colors = _context.Colors.Include(c => c.ProductColors),
                ProductCount = count
            };
            return View(productListVM);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            Product product = await _context.Products.Where(p => p.Id == id)
                .Include(p => p.ProductImages)
                .Include(p => p.ProductColors).ThenInclude(pc => pc.Color)
                .FirstOrDefaultAsync();
            return View(product);
        }
        public IActionResult GetDataById(int? id)
        {
            if (id is null) return NotFound();
            Product product = _context.Products.Include(p => p.ProductImages)
                .Include(p => p.ProductColors).ThenInclude(pc => pc.Color)
                .Where(p => p.Id == id).FirstOrDefault();
            if (product is null) return NotFound();
            return PartialView("_ProductModalPartialView", product);
        }
    }
}
