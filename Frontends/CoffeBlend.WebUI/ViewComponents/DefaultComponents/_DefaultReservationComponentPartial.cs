using Microsoft.AspNetCore.Mvc;

namespace CoffeBlend.WebUI.ViewComponents.DefaultComponents
{
    public class _DefaultReservationComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
        
    }
}
