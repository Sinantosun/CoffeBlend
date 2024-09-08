using Microsoft.AspNetCore.Mvc;

namespace CoffeBlend.WebUI.ViewComponents.UILayoutComponents
{
	public class _UILayoutHeadComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
