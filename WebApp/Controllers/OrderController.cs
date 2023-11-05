using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Services.Order;

namespace WebApp.Controllers
{
    [Route("api/Order")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderService _orderService= new OrderService();

        [HttpGet("Orders")]
        public IActionResult GetAllOrders()
        {
            try
            {
                var orders=_orderService.GetAllOrders();
                return Ok(orders);
            }
            catch (Exception ex) 
            {
                return BadRequest();  
            }   
        }

        [HttpGet("Order")]
        public IActionResult GetOrderById(int id) 
        {
            try 
            {
                var order=_orderService.GetOrderById(id);
                return Ok(order);
            }
            catch (Exception ex) 
            {
                return NotFound();
            }
        }

        [HttpGet("OrdersByUserId")]
        public IActionResult GetOrderByUserId(int userId)
        {
            try
            {
                var order=_orderService.GetAllOrdersByUserId(userId);  
                return Ok(order);   
                
            }
            catch(Exception ex) 
            {
                return NotFound();
            }
        }

       
    }
}
