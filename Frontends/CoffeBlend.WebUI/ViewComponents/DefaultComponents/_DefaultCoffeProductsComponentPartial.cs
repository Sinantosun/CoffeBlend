using CoffeBlend.DtoLayer.AboutDtos;
using CoffeBlend.DtoLayer.ProductDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CoffeBlend.WebUI.ViewComponents.DefaultComponents
{
    public class _DefaultCoffeProductsComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultCoffeProductsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7245/api/Products/GetLast5CoffeProduct");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultLast5CoffeProduct>>(jsondata);
                return View(values);
            }
            return View();
        
        }
       
    }
}
