using CoffeBlend.DtoLayer.TableDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Net.Http;

namespace CoffeBlend.WebUI.ViewComponents.DefaultComponents
{
    public class _DefaultBookATableComponentPartial : ViewComponent
    {
		private readonly IHttpClientFactory _httpClientFactory;

		public _DefaultBookATableComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult> InvokeAsync()
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
