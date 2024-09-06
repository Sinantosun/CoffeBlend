using Microsoft.AspNetCore.Mvc;

namespace CoffeBlend.WebUI.ViewComponents.AdminLayoutComponents
{
    public class _AdminFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
