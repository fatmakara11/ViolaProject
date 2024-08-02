using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViolaProject_Api.Dtos.ProductRepository;

namespace ViolaProject_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductDepo _productDepo2;
        // Constructor, ProductDepo bağımlılığını alır ve sınıfın bir örneğini oluşturur.
        public ProductsController(ProductDepo productDepo2)
        {
            _productDepo2 = productDepo2;
        }

        // Bu endpoint, GET isteği ile tüm ürünleri getirir.
        [HttpGet]
        public async Task<IActionResult> ProductList()
        {
            // Tüm ürünleri asenkron olarak getirir.
            var values = await _productDepo2.GetAllProductAsync();

            // ürünleri başarılı bir şekilde döner.
            return Ok(values);
        }
        // Bu endpoint, GET isteği ile tüm ürünleri getirir.
        [HttpGet("ProductListWithCategory")]
        public async Task<IActionResult> ProductListWithCategory()
        {
            // Tüm ürünleri asenkron olarak getirir.
            var values = await _productDepo2.GetUrunveKategoriSonucAsync("");

            // ürünleri başarılı bir şekilde döner.
            return Ok(values);
        }
        [HttpGet]
        [Route("ProductListWithCategoryID/{CategoryID}")]
        public async Task<IActionResult> ProductListWithCategoryID(int CategoryID)
        {
            // Tüm ürünleri asenkron olarak getirir.
            // Category Id 0 a eşit değilse where e category id i ekle
            string where = "";
            if (CategoryID != 0)
                where = $"CategoryID={CategoryID}";
            var values = await _productDepo2.GetUrunveKategoriSonucAsync(where);

            // ürünleri başarılı bir şekilde döner.
            return Ok(values);
        }

    }
}
