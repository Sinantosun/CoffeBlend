using CoffeBlend.DtoLayer.CategoryDtos;
using CoffeBlend.DtoLayer.ProductDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Newtonsoft.Json;

namespace CoffeBlend.WebUI.ViewComponents.DefaultComponents
{
    public class _DefaultProductsComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultProductsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7245/api/Categories/GetRandom3Categories");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsondata);
                ViewBag.Categories = values;
            }

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
