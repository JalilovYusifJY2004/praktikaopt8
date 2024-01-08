using Microsoft.AspNetCore.Mvc;

namespace Praktika1opt.Areas.PraktikaAdmin.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
