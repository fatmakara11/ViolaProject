using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ViolaProject_UI.Dtos.ProductDtos;
using System.Net.Http;
using System.Threading.Tasks;

namespace ViolaProject_UI.ViewComponents.HomePage
{
    public class _DefaultHomePageFilters : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultHomePageFilters(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(int catId)
        {
            var client = _httpClientFactory.CreateClient();

            // GetByCategoryId
            var responseMessage = await client.GetAsync($"https://localhost:44388/api/Products/ProductListWithCategoryID/{catId}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResaultProductDto>>(jsonData);
                return View(values);
            }

            return View();
        }
    }
}
