using Microsoft.AspNetCore.Mvc;

namespace CoffeBlend.WebUI.ViewComponents.AdminLayoutComponents
{
    public class _AdminHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
