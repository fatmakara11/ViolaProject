using ViolaProject_Api.Dtos.CategoryDtos;
using ViolaProject_Api.Models.DapperContext;
using Dapper;


namespace ViolaProject_Api.Dtos.CategoryRepository
{
    // KategoriDepo2 class'ı KategoriDepo class'ından türemiştir.
    // Bu class kategorileri oluşturma ve tüm kategorileri getirme işlevlerini sağlar.
    public class KategoriDepo2 : KategoriDepo
    {
        private readonly Context _context;

        // Constructor, Context bağımlılığını alır ve sınıfın bir örneğini oluşturur.
        public KategoriDepo2(Context context)
        {
            _context = context;
        }

        // KategoriOlustur metodu, yeni bir kategori oluşturur.
        public async void KategoriOlustur(KategoriOlustur kategori)
        {
            // Kategori eklemek için kullanılacak SQL sorgusu.
            string query = "INSERT INTO Category (CategoryName, CategoryStatus) VALUES (@categoryName, @categoryStatus)";

            // Sorgu için parametreleri belirler.
            var parametres = new DynamicParameters();
            parametres.Add("@categoryName", kategori.CategoryName);
            parametres.Add("@categoryStatus", true);

            // Veritabanı bağlantısı oluşturulur ve sorgu çalıştırılır.
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parametres);
            }
        }
        // Kategorisil metodu, kategoriyi siler.
        public async void KategoriSil(int id)
        {
            // Kategori silmek için kullanılacak SQL sorgusu.
            string query = "DELETE From Category Where CategoryID=@categoryID";

            // Sorgu için parametreleri belirler.
            var parametres = new DynamicParameters();
            parametres.Add("@categoryID",id);

            // Veritabanı bağlantısı oluşturulur ve sorgu çalıştırılır.
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parametres);
            }
        }
        // KategoriGüncelleme metodu, kategoriyi günceller.
        public async void KategoriGüncelleme(KategoriGüncelleme kategori)
        {
            if (kategori == null)
            {
                throw new ArgumentNullException(nameof(kategori), "Kategori nesnesi null olamaz.");
            }
            // Kategori güncellemek için kullanılacak SQL sorgusu.
            string query = "Update Category Set CategoryName=@categoryName,CategoryStatus=@categoryStatus where CategoryID=@categoryID";

            // Sorgu için parametreleri belirler.
            var parametres = new DynamicParameters();
            parametres.Add("@categoryName", kategori.CategoryName);
            parametres.Add("@categoryStatus", kategori.CategoryStarus);
            parametres.Add("@categoryID", kategori.CategoryID);



            // Veritabanı bağlantısı oluşturulur ve sorgu çalıştırılır.
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parametres);
            }
        }

        // Tüm kategorileri getirir.
        async Task<List<KaregoriSonuc>> KategoriDepo.GetAllCategoryAsync()
        {
            // Kategorileri getirmek için kullanılacak SQL sorgusu.
            string query = "SELECT * FROM Category";

            // Veritabanı bağlantısı oluşturulur ve sorgu çalıştırılır.
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<KaregoriSonuc>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIDKategori> GetCategory(int id)
        {

            string query = "Select * From Category Where CategoryID=@categoryID";

            // Sorgu için parametreleri belirler.
            var parametres = new DynamicParameters();
            parametres.Add("@categoryID", id);

            // Veritabanı bağlantısı oluşturulur ve sorgu çalıştırılır.
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIDKategori>(query , parametres);
                return values;
            }
        }
    }
}
