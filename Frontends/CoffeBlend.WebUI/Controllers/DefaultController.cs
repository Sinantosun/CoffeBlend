using CoffeBlend.DtoLayer.ReservationDtos;
using CoffeBlend.DtoLayer.TableDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace CoffeBlend.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [HttpPost]
        public async Task<IActionResult> CreateReservation(CreateReservationDto createReservationDto)
        {
            createReservationDto.Status = "Rezervasyon Alındı,Onay Bekliyor";

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createReservationDto);
            StringContent strcontent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7245/api/Reservations", strcontent);
            if (responseMessage.IsSuccessStatusCode)
            {
                TempData["reservationstatus"] = "Kayıt Eklendi";
                return RedirectToAction("Index");
            }
            return View();
        }


        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7245/api/Tables/GetActiveTables");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultActiveTablesDto>>(jsondata);
                List<SelectListItem> TableValues = (from x in values
                                                    select new SelectListItem
                                                    {
                                                        Text = x.Name,
                                                        Value = x.TableID.ToString(),
                                                    }).ToList();
                ViewBag.ActiveTableList = TableValues;

            }
            return View();
        }
    }
}
