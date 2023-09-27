namespace DataManipulation.Entities
{
    public class OrderEntity
    {
        public int Id { get; set; }
        public decimal OrderPrice { get; set; }
        public string OrderAddress { get; set; }
        public string OrderDescription { get; set; }
        public string PaymentType { get; set; }
        public string Status { get; set; }
        public List<OrderDetailsEntity> OrderDetails { get; set; }
        public UserEntity User { get; set; }
        public int UserId { get; set; }
        public string CreatedOrder { get; set; }
    }
}