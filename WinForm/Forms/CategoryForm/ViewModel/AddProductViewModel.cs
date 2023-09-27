
namespace WinForm.Forms.CategoryForm.ViewModel
{
    internal class AddProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Weight { get; set; }
        public decimal Price { get; set; }
        
        public int CategoryId { get; set; }

    }
}
