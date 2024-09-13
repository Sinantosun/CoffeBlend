using Microsoft.AspNetCore.Mvc;

namespace CoffeBlend.WebUI.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
