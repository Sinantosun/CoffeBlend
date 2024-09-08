using Microsoft.AspNetCore.Mvc;

namespace CoffeBlend.WebUI.ViewComponents.UILayoutComponents
{
    public class _UILayoutScriptsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
