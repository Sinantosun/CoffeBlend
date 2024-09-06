using Microsoft.AspNetCore.Mvc;

namespace CoffeBlend.WebUI.ViewComponents.AdminLayoutComponents
{
    public class _AdminScriptsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
