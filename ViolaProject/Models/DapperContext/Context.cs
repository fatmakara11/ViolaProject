using Microsoft.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;

namespace ViolaProject_Api.Models.DapperContext
{
    // Context sınıfı, veritabanı bağlantılarını yönetmek için kullanılır.
    public class Context
    {
        // IConfiguration arayüzü, uygulama yapılandırmasını almak için kullanılır.
        private readonly IConfiguration _configuration;

        // Veritabanı bağlantı dizesini tutar.
        private readonly string _connectionString;

        // Constructor, IConfiguration bağımlılığını alır ve sınıfın bir örneğini oluşturur.
        public Context(IConfiguration configuration)
        {
            _configuration = configuration;

            // IConfiguration kullanarak bağlantı dizesini alır.
            _connectionString = configuration.GetConnectionString("connection");
        }

        // Bu metod, yeni bir veritabanı bağlantısı oluşturur ve döner.
        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}
