using Microsoft.AspNetCore.Mvc;
using ViolaProject_Api.Dtos.CategoryDtos;


namespace ViolaProject_Api.Dtos.CategoryRepository
{
    // KategoriDepo arayüzü, kategori işlemlerini tanımlayan bir sözleşme sağlar.
    public interface KategoriDepo
    {
        // Tüm kategorileri asenkron olarak getirir.
        Task<List<ResaultCategoryDto>> GetAllCategoryAsync();

        // Yeni bir kategori oluşturur.
        void CreateCategory(CreateCategoryDto category);
        void DeleteCategory(int id);
        void UpdateCategory(UpdateCategoryDto category);
        Task<GetByIDCategoryDto> GetCategory(int id);
        
    }
}
