namespace ViolaProject_Api.Dtos.ProductDtos
{
    public class CreateProductDto
    {
        public string ProductTitle { get; set; }
        public decimal Price { get; set; }
        public string CategoryName { get; set; }
        public string CoverImage { get; set; }

    }
}
