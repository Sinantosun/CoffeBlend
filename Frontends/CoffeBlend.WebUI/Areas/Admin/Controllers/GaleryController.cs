using CoffeBlend.DtoLayer.GaleryDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CoffeBlend.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class GaleryController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public GaleryController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
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
        [HttpGet]
        public IActionResult CreateGalery()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateGalery(CreateGaleryDto createGaleryDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createGaleryDto);
            StringContent strcontent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7245/api/Galeries", strcontent);
            if (responseMessage.IsSuccessStatusCode)
            {
                TempData["Status"] = "Kayıt Eklendi";
                TempData["Icon"] = "success";
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateGalery(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7245/api/Galeries/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultGaleryByIdDto>(jsondata);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateGalery(UpdateGaleryDto updateGaleryDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateGaleryDto);
            StringContent strcontent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7245/api/Galeries", strcontent);
            if (responseMessage.IsSuccessStatusCode)
            {
                TempData["Status"] = "Kayıt Güncellendi";
                TempData["Icon"] = "success";
                return RedirectToAction("Index");
            }
            return View();

        }

        public async Task<IActionResult> DeleteGalery(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7245/api/Galeries/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                TempData["Status"] = "Kayıt Silindi";
                TempData["Icon"] = "success";
            }
            return RedirectToAction("Index");
        }
    }
}
