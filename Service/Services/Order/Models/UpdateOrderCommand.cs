namespace Service.Services.Order.Models
{
    public class UpdateOrderCommand
    {
        public int Id { get; set; }
        public decimal OrderPrice { get; set; }
        public string OrderAddress { get; set; }
        public string OrderDescription { get; set; }
        public string PaymentType { get; set; }
        public string Status { get; set; }
    }
}