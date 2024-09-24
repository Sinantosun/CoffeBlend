using CoffeBlend.DtoLayer.AdminDashboardDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CoffeBlend.WebUI.ViewComponents.AdminDashboardComponents
{
    public class _AdminDashboardWeatherComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://weatherapi-com.p.rapidapi.com/current.json?q=40.991188,29.016914"),
                Headers =
    {
        { "x-rapidapi-key", "enter-here-your-rapid-api-key" },
        { "x-rapidapi-host", "weatherapi-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<ResultWeatherAPIDto>(body);
                return View(value);
            
            }
        }
    }
}
