using CoffeBlend.DtoLayer.MenuDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CoffeBlend.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class MenuController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public MenuController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7245/api/Menu");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultMenuDto>>(jsondata);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult CreateMenu()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateMenu(CreateMenuDto createMenuDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createMenuDto);
            StringContent strcontent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7245/api/Menu", strcontent);
            if (responseMessage.IsSuccessStatusCode)
            {
                TempData["Status"] = "Kayıt Eklendi";
                TempData["Icon"] = "success";
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateMenu(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7245/api/Menu/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultMenuByIdDto>(jsondata);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateMenu(UpdateMenuDto updateMenuDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateMenuDto);
            StringContent strcontent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7245/api/Menu", strcontent);
            if (responseMessage.IsSuccessStatusCode)
            {
                TempData["Status"] = "Kayıt Güncellendi";
                TempData["Icon"] = "success";
                return RedirectToAction("Index");
            }
            return View();

        }

        public async Task<IActionResult> DeleteMenu(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7245/api/Menu/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                TempData["Status"] = "Kayıt Silindi";
                TempData["Icon"] = "success";
            }
            return RedirectToAction("Index");
        }
    }
}
