using System.Collections.Generic;
using Contoso.Models.Services.Application;
using Contoso.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Contoso.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Product Administration";

            List<ProductViewModel> products = productService.GetProducts();
            return View(products);
        }
    }
}