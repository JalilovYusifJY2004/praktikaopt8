using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Praktika1opt.DAL;
using Praktika1opt.Models;

namespace Praktika1opt.Areas.PraktikaAdmin.Controllers
{
        [Area ("PraktikAdmin")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
       _context = context;
        }
        public async  Task<IActionResult> Index()
        {
            List<Category> categories = await _context.Categories.ToListAsync();
            return View(categories);
        }
    }
}
