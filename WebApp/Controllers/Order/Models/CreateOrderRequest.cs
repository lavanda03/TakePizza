namespace WebApp.Controllers.Order.Models
{
    public class CreateOrderRequest
    {
        public decimal OrderPrice { get; set; }
        public string OrderAddress { get; set; }
        public string OrderDescription { get; set; }
        public string PaymentType { get; set; }
        public string Status { get; set; }
        public int UserId { get; set; }
        public List<CreateOrderDetailsRequest> Details { get; set; }

    }

}
