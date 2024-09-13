using CoffeBlend.DtoLayer.ProductDtos;
using CoffeBlend.DtoLayer.TableDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace CoffeBlend.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class OrderController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public OrderController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            
            var responseMessage2 = await client.GetAsync("https://localhost:7245/api/Products");
            if (responseMessage2.IsSuccessStatusCode)
            {
                var jsondata2 = await responseMessage2.Content.ReadAsStringAsync();
                var values2 = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsondata2);
                List<SelectListItem> ProductValues = (from x in values2
                                                      select new SelectListItem
                                                      {
                                                          Text = x.Title,
                                                          Value = x.ProductId.ToString(),
                                                      }).ToList();
                ViewBag.ProductList = ProductValues;

            }
            return View();
        }
    }
}
