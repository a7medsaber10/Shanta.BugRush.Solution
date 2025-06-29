using Shanta.Core.Entities.Product;


namespace Shanta.Core.Entities.Order
{
    public class OrderItem : BaseEntity
    {

        public Guid ProductId { get; set; }
        public Product.Product Product { get; set; }
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
        public Guid ProductVariantId { get; set; }
        public ProductVariant ProductVariant { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
