using Microsoft.AspNetCore.Mvc;

namespace CoffeBlend.WebUI.ViewComponents.AdminLayoutComponents
{
    public class _AdminNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
