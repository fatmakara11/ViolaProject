using Dapper;
using ViolaProject_Api.Dtos.CategoryDtos;
using ViolaProject_Api.Dtos.ProductDtos;
using ViolaProject_Api.Models.DapperContext;

namespace ViolaProject_Api.Dtos.ProductRepository
{
    public class ProductDepo2 : ProductDepo
    {
        private readonly Context _context;

        // Constructor, Context bağımlılığını alır ve sınıfın bir örneğini oluşturur.
        public ProductDepo2(Context context)
        {
            _context = context;
        }

        public async Task<List<UrunSonuc>> GetAllProductAsync()
        {
            // ürünleri getirmek için kullanılacak SQL sorgusu.
            string query = "SELECT * FROM Product";

            // Veritabanı bağlantısı oluşturulur ve sorgu çalıştırılır.
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<UrunSonuc>(query);
                return values.ToList();
            }
        }

        public async Task<List<UrunveKategoriSonuc>> GetUrunveKategoriSonucAsync()
        {
            // ürünlerin kategorisini getirmek için kullanılacak SQL sorgusu.
            string query = "SELECT ProductID,ProductTitle,Price,CategoryName From Product inner join Category on Product.ProductCategory=Category.CategoryID";

            // Veritabanı bağlantısı oluşturulur ve sorgu çalıştırılır.
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<UrunveKategoriSonuc>(query);
                return values.ToList();
            }
        }
    }
}
