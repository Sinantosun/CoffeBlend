using Microsoft.AspNetCore.Mvc;

namespace CoffeBlend.WebUI.ViewComponents.DefaultComponents
{
    public class _DefaultBookATableComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
