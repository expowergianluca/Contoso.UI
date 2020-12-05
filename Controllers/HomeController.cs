using Microsoft.AspNetCore.Mvc;

namespace Contoso.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Home page";
            return View();
        }
    }
}