namespace bookStore.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderPlaced { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
    public class OrderDetail
    {
        public int Id { get; set; }
        public int orderId { get; set; }
        public Order Order { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }

    }
}
