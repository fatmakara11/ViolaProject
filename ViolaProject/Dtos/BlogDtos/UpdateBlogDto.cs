namespace ViolaProject_Api.Dtos.BlogDtos
{
    public class UpdateBlogDto
    {
        public int BlogID { get; set; }
        public string Baslik { get; set; }
        public string KisaYazi { get; set; }
        public DateTime Tarih { get; set; } = DateTime.Now; // Varsayılan tarih değeri
        public string GoruntuUrl { get; set; }
        public string Yazar { get; set; }
        public string DetayliYazi { get; set; }
        public string YazarFotoUrl { get; set; }
    }
}
