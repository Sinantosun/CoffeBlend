using Microsoft.AspNetCore.Mvc;

namespace CoffeBlend.WebUI.ViewComponents.AdminLayoutComponents
{
    public class _AdminSideBarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
