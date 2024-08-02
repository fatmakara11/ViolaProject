
using ViolaProject_Api.Dtos.ProductDtos;

namespace ViolaProject_Api.Dtos.ProductRepository
{
    public interface ProductDepo
    {
        Task<List<UrunSonuc>> GetAllProductAsync();
        Task<List<UrunveKategoriSonuc>> GetUrunveKategoriSonucAsync(string where);




    }
}
