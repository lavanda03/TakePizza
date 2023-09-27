namespace Service.Services.Category.Models
{
    public class UpdateCategoryCommand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}