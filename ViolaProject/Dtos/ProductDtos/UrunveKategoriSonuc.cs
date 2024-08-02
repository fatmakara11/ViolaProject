namespace ViolaProject_Api.Dtos.ProductDtos
{
    public class UrunveKategoriSonuc
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string ProductTitle { get; set; }
        public decimal Price { get; set; }
        public string CategoryName { get; set; }
        public string CoverImage { get; set; }
    }
}
