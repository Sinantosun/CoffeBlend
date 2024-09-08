using Microsoft.AspNetCore.Mvc;

namespace CoffeBlend.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
