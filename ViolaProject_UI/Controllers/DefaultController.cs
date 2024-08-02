using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using ViolaProject_UI.Dtos.BestsellerDtos;
using ViolaProject_UI.Dtos.ProductDtos;

namespace ViolaProject_UI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Index()
        {
            List<ResaultBestsellerDtos> list = new List<ResaultBestsellerDtos>();
            return View(list);
        }
        public async Task<ActionResult> GetFilterList(int catId)
        {
            var client = _httpClientFactory.CreateClient();

            // GetByCategoryId
            var responseMessage = await client.GetAsync($"https://localhost:44388/api/Products/ProductListWithCategoryID/{catId}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResaultProductDtos>>(jsonData);
                return PartialView("~/Views/Shared/Components/_DefaultHomePageFilters/Default.cshtml",values);
            }
            else {
                return Json(true);
            }
        }
    }
}
