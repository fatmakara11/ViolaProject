using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ViolaProject_UI.Dtos.BlogDtos;

namespace ViolaProject_UI.ViewComponents.HomePage
{
    public class _DefaultHomePageBlog : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultHomePageBlog(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44388/api/Blog");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResaultBlogDtos>>(jsonData);
                ViewBag.Blogs = values;
                return View();
            }

            return View();
        }
    }
}
