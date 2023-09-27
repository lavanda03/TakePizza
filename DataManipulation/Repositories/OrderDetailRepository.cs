using DataManipulation.Entities;

namespace DataManipulation.Repositories
{
    public class OrderDetailRepository
    {
        private readonly ApplicationDbContext _context;

        public OrderDetailRepository()
        {
            _context = new ApplicationDbContext();
        }

        public int AddOrderDetail(OrderDetailsEntity orderDetails)
        {
            _context.OrderDetails.Add(orderDetails);
            _context.SaveChanges();
            return orderDetails.Id;
        }

        public List<OrderDetailsEntity> GetAllOrderDetails()
        {
            return _context.OrderDetails.ToList();
        }

        public OrderDetailsEntity? GetOrderDetail(int orderDetails)
        {
            return _context.OrderDetails.FirstOrDefault(u => u.Id == orderDetails);
        }

        public void UpdateOrderDetail(OrderDetailsEntity orderDetails)
        {
            _context.OrderDetails.Update(orderDetails);
            _context.SaveChanges();
        }

        public void DeleteOrderDetail(OrderDetailsEntity orderDetails)
        {
            _context.OrderDetails.Remove(orderDetails);
            _context.SaveChanges();
        }
    }
}