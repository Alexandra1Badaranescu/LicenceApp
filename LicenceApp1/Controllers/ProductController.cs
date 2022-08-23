using Microsoft.AspNetCore.Mvc;

namespace LicenceApp1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
