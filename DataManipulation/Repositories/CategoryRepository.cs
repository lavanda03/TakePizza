using DataManipulation.Entities;

namespace DataManipulation.Repositories
{
    public class CategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository()
        {
            _context = new ApplicationDbContext();
        }

        public List<CategoryEntity> GetAll()
        {
            return _context.Categories.ToList();
        }

        public int AddCategory(CategoryEntity category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return category.Id;
        }

        public bool ExistCategoryByName(string categoryName)
        {
            return _context.Categories.Any(u => u.Name.ToLower() == categoryName.ToLower());
        }

        public bool ExistCategoryById(int id)
        {
            return _context.Categories.Any(u => u.Id == id);
        }

        public CategoryEntity? GetCategoryById(int id)
        {
            return _context.Categories.FirstOrDefault(u => u.Id == id);
        }

        public void UpdateCategory(CategoryEntity category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
        }

        public void DeleteCategory(CategoryEntity category)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }
    }
}