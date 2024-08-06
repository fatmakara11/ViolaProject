using Dapper;
using ViolaProject_Api.Dtos.BlogDtos;
using ViolaProject_Api.Models.DapperContext;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace ViolaProject_Api.Dtos.BlogRepository
{
    public class BlogRepository : IBlogRepository
    {
        private readonly Context _context;

        public BlogRepository(Context context)
        {
            _context = context;
        }

        public async void  CreateBlog(CreateBlogDto createDto)
        {
            string query = "INSERT INTO Blog (Baslik, KisaYazi, Tarih, GoruntuUrl, Yazar, DetayliYazi, YazarFotoUrl) VALUES (@Baslik, @KisaYazi, @Tarih, @GoruntuUrl, @Yazar, @DetayliYazi, @YazarFotoUrl)";

            var parameters = new DynamicParameters();
            parameters.Add("@Baslik", createDto.Baslik);
            parameters.Add("@KisaYazi", createDto.KisaYazi);
            parameters.Add("@Tarih", createDto.Tarih);
            parameters.Add("@GoruntuUrl", createDto.GoruntuUrl);
            parameters.Add("@Yazar", createDto.Yazar);
            parameters.Add("@DetayliYazi", createDto.DetayliYazi);
            parameters.Add("@YazarFotoUrl", createDto.YazarFotoUrl);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteBlog(int id)
        {
            string query = "DELETE FROM Blog WHERE BlogID = @blogID";

            var parameters = new DynamicParameters();
            parameters.Add("@blogID", id);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResaultBlogDto>> GetAllBlogAsync()
        {
            string query = "SELECT * FROM Blog";

            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResaultBlogDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIDBlogDto> GetBlog(int id)
        {
            string query = "SELECT * FROM Blog WHERE BlogID = @blogID";

            var parameters = new DynamicParameters();
            parameters.Add("@blogID", id);

            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryFirstOrDefaultAsync<GetByIDBlogDto>(query, parameters);
                return value;
            }
        }

        public async void UpdateBlog(UpdateBlogDto updateBlogDto)
        {
            string query = "UPDATE Blog SET Baslik = @Baslik, KisaYazi = @KisaYazi, Tarih = @Tarih, GoruntuUrl = @GoruntuUrl, Yazar = @Yazar, DetayliYazi = @DetayliYazi, YazarFotoUrl = @YazarFotoUrl WHERE BlogID = @blogID";

            var parameters = new DynamicParameters();
            parameters.Add("@Baslik", updateBlogDto.Baslik);
            parameters.Add("@KisaYazi", updateBlogDto.KisaYazi);
            parameters.Add("@Tarih", updateBlogDto.Tarih);
            parameters.Add("@GoruntuUrl", updateBlogDto.GoruntuUrl);
            parameters.Add("@Yazar", updateBlogDto.Yazar);
            parameters.Add("@DetayliYazi", updateBlogDto.DetayliYazi);
            parameters.Add("@YazarFotoUrl", updateBlogDto.YazarFotoUrl);
            parameters.Add("@blogID", updateBlogDto.BlogID);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        
    }
}
