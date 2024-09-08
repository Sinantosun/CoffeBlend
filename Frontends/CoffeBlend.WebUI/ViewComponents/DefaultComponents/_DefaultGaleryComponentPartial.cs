using CoffeBlend.DtoLayer.GaleryDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CoffeBlend.WebUI.ViewComponents.DefaultComponents
{ 
    public class _DefaultGaleryComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultGaleryComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

      
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7245/api/Galeries");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultGaleryDto>>(jsondata);
                return View(values);
            }
            return View();
        }
    }
}
