using TikiAPI.Data;

namespace TikiAPI.DTO
{
    public class OrderProductDTO
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
