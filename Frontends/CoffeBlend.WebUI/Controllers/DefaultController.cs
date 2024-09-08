using Microsoft.AspNetCore.Mvc;

namespace CoffeBlend.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
