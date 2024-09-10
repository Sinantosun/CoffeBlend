using CoffeBlend.DtoLayer.ProductDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CoffeBlend.WebUI.Controllers
{
    public class ProductController : Controller
    {
		private readonly IHttpClientFactory _httpClientFactory;

		public ProductController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage2 = await client.GetAsync("https://localhost:7245/api/Products/GetProductListWithCategory");
			if (responseMessage2.IsSuccessStatusCode)
			{
				var jsondata2 = await responseMessage2.Content.ReadAsStringAsync();
				var values2 = JsonConvert.DeserializeObject<List<ResultPrdouctWithCategory>>(jsondata2);
				return View(values2);
			}
			return View();
        }
    }
}
