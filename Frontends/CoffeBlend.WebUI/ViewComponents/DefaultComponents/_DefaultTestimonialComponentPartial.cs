using Microsoft.AspNetCore.Mvc;

namespace CoffeBlend.WebUI.ViewComponents.DefaultComponents
{
    public class _DefaultTestimonialComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
