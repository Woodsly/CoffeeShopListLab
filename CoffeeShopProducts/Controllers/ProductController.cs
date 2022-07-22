using CoffeeShopProducts.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopProducts.Controllers
{
    public class ProductController : Controller
    {
        private CoffeeProductDBContext context = new CoffeeProductDBContext();
        public IActionResult ProductDetails(int productId)
        {
            Product p = context.Products.FirstOrDefault(p => p.Id == productId);
            return View(p);
        }
        public IActionResult Products()
        {
            List<Product> products = context.Products.ToList();
            return View(products);
        }
        public IActionResult Index()
        {
            return View(context.Products.ToList());
        }
    }
}
