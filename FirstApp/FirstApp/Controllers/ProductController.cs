using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            Product product = new Product();
            product.Product_Id = 1;
            product.Product_Name = "Iphone";
            product.Product_Price = 70000;
            product.Product_Description = "One of the best phone in today's world";

            return View(product);
        }
    }
}
