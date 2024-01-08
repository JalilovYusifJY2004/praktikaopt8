using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Praktika1opt.DAL;
using Praktika1opt.Models;
using Praktika1opt.ViewModels;

namespace Praktika1opt.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
       _context = context;
        }
        public async  Task<IActionResult> Index()
        {
            List<Product> products = await _context.Products.Include(p => p.Category).ToListAsync();
            List<Category> categories = await _context.Categories.ToListAsync();

            HomeVM homeVM = new HomeVM
            {
                Products = products,
                Categories = categories
            };
            return View(homeVM);
        }
    }
}
