using Microsoft.AspNetCore.Mvc;
using ViolaProject_Api.Dtos.CategoryDtos;


namespace ViolaProject_Api.Dtos.CategoryRepository
{
    // KategoriDepo arayüzü, kategori işlemlerini tanımlayan bir sözleşme sağlar.
    public interface KategoriDepo
    {
        // Tüm kategorileri asenkron olarak getirir.
        Task<List<KaregoriSonuc>> GetAllCategoryAsync();

        // Yeni bir kategori oluşturur.
        void KategoriOlustur(KategoriOlustur kategori);
        void KategoriSil(int id);
        void KategoriGüncelleme(KategoriGüncelleme kategori);
        Task<GetByIDKategori> GetCategory(int id);
        
    }
}
