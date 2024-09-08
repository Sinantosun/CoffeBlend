using Microsoft.AspNetCore.Mvc;

namespace CoffeBlend.WebUI.ViewComponents.UILayoutComponents
{
    public class _UILayoutFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
