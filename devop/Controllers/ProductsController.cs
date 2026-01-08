using Microsoft.AspNetCore.Mvc;

namespace devop.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            ViewBag.ProductId = id;
            return View();
        }
    }
}
