using CoffeBlend.DtoLayer.ContactInfoDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CoffeBlend.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class ContactInfoController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ContactInfoController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7245/api/ContactInfo");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultContactInfoDto>>(jsondata);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult CreateContactInfo()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateContactInfo(CreateContactInfoDto createContactInfoDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createContactInfoDto);
            StringContent strcontent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7245/api/ContactInfo", strcontent);
            if (responseMessage.IsSuccessStatusCode)
            {
                TempData["Status"] = "Kayıt Eklendi";
                TempData["Icon"] = "success";
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateContactInfo(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7245/api/ContactInfo/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultContactInfoByIdDto>(jsondata);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateContactInfo(UpdateContactInfoDto updateContactInfoDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateContactInfoDto);
            StringContent strcontent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7245/api/ContactInfo", strcontent);
            if (responseMessage.IsSuccessStatusCode)
            {
                TempData["Status"] = "Kayıt Güncellendi";
                TempData["Icon"] = "success";
                return RedirectToAction("Index");
            }
            return View();

        }

        public async Task<IActionResult> DeleteContactInfo(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7245/api/ContactInfo/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                TempData["Status"] = "Kayıt Silindi";
                TempData["Icon"] = "success";
            }
            return RedirectToAction("Index");
        }
    }
}
