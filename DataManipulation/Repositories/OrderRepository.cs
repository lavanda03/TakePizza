using DataManipulation.Entities;

namespace DataManipulation.Repositories
{
    public class OrderRepository
    {
        private readonly ApplicationDbContext _context;

        public OrderRepository()
        {
            _context = new ApplicationDbContext();
        }

        public int AddOrder(OrderEntity order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
            return order.Id;
        }

        public List<OrderEntity> GetAllOrder()
        {
            return _context.Orders.ToList();
        }
        public List<OrderEntity> GetAllOrdersByUserId(int Id)
        {
            return _context.Orders.Where(p => p.User.Id == Id).ToList();
        }
        public OrderEntity? GetOrderById(int order)
        {
            return _context.Orders.FirstOrDefault(u => u.Id == order);
        }

        public void UpdateOrder(OrderEntity order)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
        }

        public void DeleteOrder(OrderEntity order)
        {
            _context.Orders.Remove(order);
            _context.SaveChanges();
        }
    }
}