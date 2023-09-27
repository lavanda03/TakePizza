using DataManipulation.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataManipulation.Repositories
{
    public class ProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository()
        {
            _context = new ApplicationDbContext();
        }

        public int AddProduct(ProductEntity product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product.Id;
        }

        public List<ProductEntity> GetAllProductsByCategoryId(int categoryId)
        {
            return _context.Products.Where(x => x.CategoryId == categoryId).ToList();
        }

        public List<ProductEntity> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public bool ExistProductByCode(string name)
        {
            return _context.Products.Any(p => p.Name.ToLower() == name.ToLower());
        }

        public ProductEntity? GetProductById(int productId)
        {
            return _context.Products
                .Include(c => c.Category)
                .FirstOrDefault(u => u.Id == productId);
        }

        public ProductEntity? GetProductByCode(string name)
        {
            return _context.Products.FirstOrDefault(p => p.Name == name);
        }

        public void UpdateProduct(ProductEntity product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(ProductEntity product)
        {
            _context.Remove(product);
            _context.SaveChanges();
        }
    }
}