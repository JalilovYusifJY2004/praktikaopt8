using Microsoft.AspNetCore.Mvc;

namespace Praktika1opt.Areas.PraktikaAdmin.Controllers
{
    [Area("PraktikAdmin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
