using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViolaProject_Api.Dtos.BlogDtos;
using ViolaProject_Api.Dtos.BlogRepository;
using ViolaProject_Api.Dtos.CategoryDtos;
using ViolaProject_Api.Dtos.CategoryRepository;

namespace ViolaProject_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
            private readonly IBlogRepository _blogRepository;

        public BlogController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }



        
        [HttpGet]
            public async Task<IActionResult> BlogList()
            {
                
                var values = await _blogRepository.GetAllBlogAsync();

                // Kategorileri başarılı bir şekilde döner.
                return Ok(values);
            }

            // Bu endpoint, POST isteği ile yeni bir kategori oluşturur.
            [HttpPost]
            public async Task<IActionResult> CreateBlog(CreateBlogDto createBlogDto)
            {
                // Yeni bir kategori oluşturur.
               _blogRepository.CreateBlog(createBlogDto);

                // Başarılı bir şekilde eklenen kategoriyi döner.
                return Ok("Blog Başarılı Bir Şekilde Eklendi");
            }
            // Bu endpoint, DELETE isteği verilen Id deki  bir kategoriyi  siler.
            [HttpDelete]
            public async Task<IActionResult> DeleteBlog(int id)
            {
                // istenilen kategori silinir
                _blogRepository.DeleteBlog(id);

                // Başarılı bir şekilde kategori silinir.
                return Ok("Blog Başarılı Bir Şekilde Silindi");
            }
            // Bu endpoint, UPDATE isteği istenilen kategoriyi günceller.
            [HttpPut]
            public async Task<IActionResult> UpdateBlog (UpdateBlogDto updateBlogDto)
            {
              

                _blogRepository.UpdateBlog(updateBlogDto);
                return Ok("Blog Başarılı Bir Şekilde Güncellendi");
            }
            [HttpGet("{id}")]
            public async Task<IActionResult> GetBlog(int id)
            {
                var value = await _blogRepository.GetBlog(id);
                return Ok(value);
            }
        }
    }

