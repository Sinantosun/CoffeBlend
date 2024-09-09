using Microsoft.AspNetCore.Mvc;

namespace CoffeBlend.WebUI.Controllers
{
    public class ProductDetailController : Controller
    {
        public IActionResult Index(int id)
        {
            ViewBag.Id = id;    
            return View();
        }
    }
}
