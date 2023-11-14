using System.Globalization;
using DataManipulation.Entities;
using DataManipulation.Repositories;
using Service.Services.Order.Models;

namespace Service.Services.Order
{
    public class OrderService
    {
        private readonly OrderRepository _orderRepository;
        private readonly UserRepository _userRepository;
        private readonly OrderDetailRepository _orderDetailRepository;

        private readonly List<string> _paymentTypes = new() { "cash", "card" };
        private readonly List<string> _statusTypes = new() { "pending", "approved", "delivered" };


        public OrderService()
        {
            _orderRepository = new OrderRepository();
            _userRepository = new UserRepository();
            _orderDetailRepository = new OrderDetailRepository();
        }

        public int AddOrder(AddOrderCommand command)
        {
            if (command.UserId <= 0)
                throw new Exception(ErrorHandlerService.ParameterNotValidError("User Id"));

            var user = _userRepository.GetUserById(command.UserId);

            if (user == null)
                throw new Exception(ErrorHandlerService.ParameterNotFoundError("User"));

            if (command.OrderPrice <= 0)
                throw new Exception(ErrorHandlerService.ParameterLessThanError("Price", default));

            if (string.IsNullOrEmpty(command.OrderAddress))
                throw new Exception(ErrorHandlerService.ParameterNotValidError("Address"));

            if (command.OrderAddress.Any(digit =>
                    !char.IsLetter(digit) && !char.IsDigit(digit) && !char.IsSeparator(digit)))
            {
                throw new Exception(
                    ErrorHandlerService.ParameterMustHaveError("Address", new[] { "letters", "digits" }));
            }

            if (string.IsNullOrEmpty(command.OrderDescription))
                throw new Exception(ErrorHandlerService.ParameterNotValidError("Description"));

            if (string.IsNullOrEmpty(command.PaymentType) || !_paymentTypes.Contains(command.PaymentType.ToLower()))
                throw new Exception(ErrorHandlerService.ParameterNotValidError("Payment"));

            if (string.IsNullOrEmpty(command.Status) || !_statusTypes.Contains(command.Status.ToLower()))
                throw new Exception(ErrorHandlerService.ParameterNotValidError("Status"));

            var orderId = _orderRepository.AddOrder(new OrderEntity
            {
                OrderPrice = command.OrderPrice,
                OrderAddress = command.OrderAddress,
                OrderDescription = command.OrderDescription,
                PaymentType = command.PaymentType.ToLower(),
                Status = command.Status.ToLower(),
                UserId = command.UserId,
                CreatedOrder = DateTime.Now.ToString(CultureInfo.InvariantCulture)
            });

            foreach (var orderDetail in command.OrderDetails)
            {
                _orderDetailRepository.AddOrderDetail(new OrderDetailsEntity
                {
                    OrderId = orderId,
                    ProductId = orderDetail.ProductId,
                    TotalPrice = orderDetail.TotalPrice,
                    TotalQuantity = orderDetail.TotalQuantity
                });
            }

            return orderId;
        }
        public List<GetAllOrder>GetAllOrdersByUserId(int userId)
        {
            var newList= new List<GetAllOrder>();

            var orderEntity = _orderRepository.GetAllOrdersByUserId(userId);

            if (orderEntity == null)
                throw new Exception(ErrorHandlerService.ParameterNotValidError("User Id"));

            foreach (var order in orderEntity)
            {
                newList.Add(new GetAllOrder()
                {

                    Id = order.Id,
                    OrderPrice = order.OrderPrice,
                    OrderAddress = order.OrderAddress,
                    OrderDescription = order.OrderDescription,
                    PaymentType = order.PaymentType,
                  

                });
            }
            return newList;
        }
        public GetOrderResult GetOrderById(int orderId)
        {
            if (orderId <= 0)
                throw new Exception(ErrorHandlerService.ParameterNotValidError("Order Id"));

            var orderEntity = _orderRepository.GetOrderById(orderId);

            if (orderEntity == null)
                throw new Exception(ErrorHandlerService.ParameterNotFoundError("Order"));

            var result = new GetOrderResult
            {
                Id = orderEntity.Id,
                OrderPrice = orderEntity.OrderPrice,
                OrderAddress = orderEntity.OrderAddress,
                OrderDescription = orderEntity.OrderDescription,
                PaymentType = orderEntity.PaymentType,
                Status = orderEntity.Status,
                UserId= orderEntity.UserId  
            };

            return result;
        }

        public void UpdateOrder(UpdateOrderCommand command)
        {
            if (command.Id <= 0)
                throw new Exception(ErrorHandlerService.ParameterNotValidError("Order Id"));

            if (string.IsNullOrEmpty(command.OrderAddress))
                throw new Exception(ErrorHandlerService.ParameterNotValidError("Order Address"));

            if (command.OrderAddress.Any(digit => !char.IsLetter(digit) && !char.IsDigit(digit) && !char.IsSeparator(digit)))
            {
                throw new Exception(
                    ErrorHandlerService.ParameterMustHaveError("Address", new[] { "letters", "digits" }));
            }

            if (command.OrderPrice <= 0)
                throw new Exception(ErrorHandlerService.ParameterNotValidError("Price"));

            if (string.IsNullOrEmpty(command.OrderDescription))
                throw new Exception(ErrorHandlerService.ParameterNotValidError("Description"));

            if (string.IsNullOrEmpty(command.Status) || !_statusTypes.Contains(command.Status.ToLower()))
                throw new Exception(ErrorHandlerService.ParameterNotValidError("Status"));

            if (string.IsNullOrEmpty(command.PaymentType) || !_paymentTypes.Contains(command.PaymentType.ToLower()))
                throw new Exception(ErrorHandlerService.ParameterNotValidError("Payment"));

            var orderEntity = _orderRepository.GetOrderById(command.Id);

            if (orderEntity == null)
                throw new Exception(ErrorHandlerService.ParameterNotFoundError("Order"));

            if (command.OrderPrice != orderEntity.OrderPrice)
                orderEntity.OrderPrice = command.OrderPrice;

            if (command.OrderAddress != orderEntity.OrderAddress)
                orderEntity.OrderAddress = command.OrderAddress;

            if (command.OrderDescription != orderEntity.OrderDescription)
                orderEntity.OrderDescription = command.OrderDescription;

            if (command.Status != orderEntity.Status)
                orderEntity.Status = command.Status.ToLower();

            if (command.PaymentType != orderEntity.PaymentType)
                orderEntity.PaymentType = command.PaymentType.ToLower();

            _orderRepository.UpdateOrder(orderEntity);
        }

        public void DeleteOrder(int orderId)
        {
            if (orderId <= 0)
                throw new Exception(ErrorHandlerService.ParameterNotValidError("Order Id"));

            var orderEntity = _orderRepository.GetOrderById(orderId);

            if (orderEntity == null)
                throw new Exception(ErrorHandlerService.ParameterNotFoundError("Order"));

            _orderRepository.DeleteOrder(orderEntity);
        }

        public List<GetAllOrder> GetAllOrders()
        {
            var orderEntity = _orderRepository.GetAllOrder();
            var result = new List<GetAllOrder>();

            foreach (var order in orderEntity)
            {
                result.Add(new GetAllOrder
                {
                    Id = order.Id,
                    OrderPrice = order.OrderPrice,
                    OrderAddress = order.OrderAddress,
                    OrderDescription = order.OrderDescription,
                    Status = order.Status,
                    PaymentType = order.PaymentType,
                    UserId = order.UserId
                });
            }

            return result;
        }

        public List<GetAllOrder> QueryOrders(QueryOrdersCriteria criteria)
        {
            if (criteria == null)
                throw new Exception(ErrorHandlerService.ParameterNotValidError("Criteria"));

            var orderEntities = _orderRepository.GetAllOrder();
            var result = new List<GetAllOrder>();

            if (!string.IsNullOrEmpty(criteria.PaymentType))
                orderEntities = orderEntities.Where(o => o.PaymentType.ToLower() == criteria.PaymentType.ToLower())
                    .ToList();

            if (!string.IsNullOrEmpty(criteria.StatusType))
                orderEntities = orderEntities.Where(o => o.Status.ToLower() == criteria.StatusType.ToLower()).ToList();

            foreach (var order in orderEntities)
            {
                result.Add(new GetAllOrder
                {
                    Id = order.Id,
                    OrderPrice = order.OrderPrice,
                    OrderAddress = order.OrderAddress,
                    OrderDescription = order.OrderDescription,
                    Status = order.Status,
                    PaymentType = order.PaymentType,
                    UserId = order.UserId
                });
            }

            return result;
        }
    }
}