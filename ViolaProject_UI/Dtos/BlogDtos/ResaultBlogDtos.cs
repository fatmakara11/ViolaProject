namespace ViolaProject_UI.Dtos.BlogDtos
{
    public class ResaultBlogDtos
    {
        public string Baslik { get; set; }
        public string KisaYazi { get; set; }
        public DateTime Tarih { get; set; } = DateTime.Now; // Varsayılan tarih değeri
        public string GoruntuUrl { get; set; }
        public string Yazar { get; set; }
        public string DetayliYazi { get; set; }
        public string YazarFotoUrl { get; set; }
    }
}
