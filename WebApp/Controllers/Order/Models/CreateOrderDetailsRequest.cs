namespace WebApp.Controllers.Order.Models
{
    public class CreateOrderDetailsRequest
    {
        public int ProductId { get; set; }
        public int TotalQuantity { get; set; }
        public decimal TotalPrice { get; set; }
    }

}
