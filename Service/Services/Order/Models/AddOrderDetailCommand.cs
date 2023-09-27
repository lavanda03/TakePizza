namespace Service.Services.Order.Models;

public class AddOrderDetailCommand
{
    public int ProductId { get; set; }
    public int TotalQuantity { get; set; }
    public decimal TotalPrice { get; set; }
}