using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViolaProject_Api.Dtos.CategoryDtos;
using ViolaProject_Api.Dtos.CategoryRepository;
using System.Threading.Tasks;

namespace ViolaProject_Api.Controllers
{
    // Bu attribute, bu sınıfın bir API kontrolcüsü olduğunu belirtir ve 
    // varsayılan rota olarak "api/Categories" rotasını kullanır.
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly KategoriDepo _kategoriDepo2;
        // private KategoriGüncelleme kategoriGüncelleme;

        // Constructor, KategoriDepo bağımlılığını alır ve sınıfın bir örneğini oluşturur.
        public CategoriesController(KategoriDepo kategoriDepo2)
        {
            _kategoriDepo2 = kategoriDepo2;
        }

        // Bu endpoint, GET isteği ile tüm kategorileri getirir.
        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            // Tüm kategorileri asenkron olarak getirir.
            var values = await _kategoriDepo2.GetAllCategoryAsync();

            // Kategorileri başarılı bir şekilde döner.
            return Ok(values);
        }

        // Bu endpoint, POST isteği ile yeni bir kategori oluşturur.
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategory)
        {
            // Yeni bir kategori oluşturur.
            _kategoriDepo2.CreateCategory(createCategory);

            // Başarılı bir şekilde eklenen kategoriyi döner.
            return Ok("Kategori Başarılı Bir Şekilde Eklendi");
        }
        // Bu endpoint, DELETE isteği verilen Id deki  bir kategoriyi  siler.
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            // istenilen kategori silinir
            _kategoriDepo2.DeleteCategory(id);

            // Başarılı bir şekilde kategori silinir.
            return Ok("Kategori Başarılı Bir Şekilde Silindi");
        }
        // Bu endpoint, UPDATE isteği istenilen kategoriyi günceller.
        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto category)
        {
            if (category == null)
            {
                return BadRequest("Kategori bilgisi boş olamaz.");
            }

            _kategoriDepo2.UpdateCategory(category);
            return Ok("Kategori Başarılı Bir Şekilde Güncellendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
         var value= await _kategoriDepo2.GetCategory(id);
            return Ok(value);
        }
    }
}
