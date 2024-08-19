namespace ViolaProject_UI.Dtos.ProductDtos
{
    public class UpdateProductDto
    {

        public int ProductID { get; set; }
        public string ProductTitle { get; set; }
        public decimal Price { get; set; }
        public string CategoryName { get; set; }
        public string CoverImage { get; set; }

    }
}
