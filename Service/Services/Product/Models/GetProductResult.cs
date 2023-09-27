namespace Service.Services.Product.Models;

public class GetProductResult
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Weight { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public CategoryData Category { get; set; }
}