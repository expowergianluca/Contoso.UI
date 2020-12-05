using Microsoft.AspNetCore.Mvc;

namespace Contoso.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Product Administration";
            return View();
        }
    }
}