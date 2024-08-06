using ViolaProject_Api.Dtos.BlogDtos;
using ViolaProject_Api.Dtos.CategoryDtos;

namespace ViolaProject_Api.Dtos.BlogRepository
{
    public interface IBlogRepository
    {
        // IBlogRepository arayüzü, kategori işlemlerini tanımlayan bir sözleşme sağlar.

        //  asenkron olarak getirir.
        Task<List<ResaultBlogDto>> GetAllBlogAsync();

        // Yeni bir kategori oluşturur.
        void CreateBlog(CreateBlogDto categoryDto);
        void DeleteBlog(int id);
        void UpdateBlog(UpdateBlogDto categoryDto);
        Task<GetByIDBlogDto> GetBlog(int id);
    } 
}
