using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Service.Services.Order;
using WebApp.Controllers.Order.Models;


namespace WebApp.Controllers.Order
{
    [Route("api/order")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderService _orderService = new OrderService();


        [HttpPost()]
        public IActionResult AddUser([FromBody]CreateOrderRequest request)
        {
            try
            {
                var order = _orderService.AddOrder(new Service.Services.Order.Models.AddOrderCommand
                {
                    UserId = request.UserId,
                    OrderPrice = request.OrderPrice,
                    OrderAddress = request.OrderAddress,
                    OrderDescription = request.OrderDescription,
                    Status = request.Status,
                    PaymentType = request.PaymentType,
                    OrderDetails = request.Details.Select(x => new Service.Services.Order.Models.AddOrderDetailCommand
                    {
                        ProductId = x.ProductId,
                        TotalPrice = x.TotalPrice,
                        TotalQuantity = x.TotalQuantity

                    }).ToList()
                }) ;

                return CreatedAtAction("AddCategory", new { categoryId = order }, order);
                
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("orders")]
        public IActionResult GetAllOrders()
        {
            try
            {
                var orders = _orderService.GetAllOrders();
                return Ok(orders);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetOrderById(int id)
        {
            try
            {
                var order = _orderService.GetOrderById(id);
                return Ok(order);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("user/{id}")]
        public IActionResult GetOrderByUserId(int id)
        {
            try
            {
                var order = _orderService.GetAllOrdersByUserId(id);
                return Ok(order);

            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpPut()]
        public IActionResult UpdateOrder([FromBody]UpdateOrderRequest update)
        {
            try
            {
                _orderService.UpdateOrder(new Service.Services.Order.Models.UpdateOrderCommand
                {
                    Id=update.Id,   
                    OrderAddress=update.OrderAddress,   
                    OrderDescription=update.OrderDescription,
                    OrderPrice=update.OrderPrice,   
                    PaymentType=update.PaymentType, 
                    Status=update.Status,   
                });
                return Ok();
            }
            catch(Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            try
            {
                _orderService.DeleteOrder(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
