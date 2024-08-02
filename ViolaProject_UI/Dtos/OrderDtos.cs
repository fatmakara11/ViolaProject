using ViolaProject_UI.Models.Base;

namespace ViolaProject_UI.Dtos
{
    public class OrderDtos
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public UnitType _UnitType { get; set; }
    }
}
