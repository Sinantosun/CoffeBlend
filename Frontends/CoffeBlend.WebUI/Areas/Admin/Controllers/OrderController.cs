using CoffeBlend.DtoLayer.ProductDtos;
using CoffeBlend.DtoLayer.TableDetailDtos;
using CoffeBlend.DtoLayer.TableDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Text;

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

        async Task LoadDropdown()
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
        }



        [HttpGet]
        public async Task<IActionResult> Index(int tableId,string tableName)
        {
            ViewBag.tableId = tableId;
            ViewBag.tableName = tableName;
            await LoadDropdown();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(CreateTableDetailDto tableDetailDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(tableDetailDto);
            StringContent str = new StringContent(jsonData, Encoding.UTF8, "application/json");
            await client.PostAsync("https://localhost:7245/api/TableDetail", str);
            await LoadDropdown();
            return View();
        }
       

        public async Task<JsonResult> GetProductPriceByProductId(int id)
        {

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7245/api/Products/GetProductPriceById/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultProductPriceByProductIdDto>(jsondata);
                return Json(values.Price);
        

            }
            return Json(null);
        }
    }
}
