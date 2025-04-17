using Microsoft.AspNetCore.Mvc;
using Assignment5;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly OrderService _orderService;

        public OrderController(OrderService orderService)
        {
            this._orderService = orderService;
        }

        [HttpGet]
        public ActionResult<List<Order>> GetOrders()
        {
            var orders = _orderService.QueryOrder(o => true);
            return Ok(orders);
        }
        [HttpPost("add")]
        public IActionResult AddOrder(int orderId, string customer, List<OrderDetails> orderDetails)
        {
            if (_orderService.AddOrder(orderId, customer, orderDetails))
            {
                return Ok("Order added successfully.");
            }
            return BadRequest("Order already exists.");
        }
        [HttpPost("update")]
        public IActionResult UpdateOrder(int orderId, string customer, List<OrderDetails> orderDetails)
        {
            if (_orderService.UpdateOrder(orderId, customer, orderDetails))
            {
                return Ok("Order updated successfully.");
            }
            return NotFound("Order not found.");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteOrder(int id)
        {
            if (_orderService.RemoveOrder(id))
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrderById(int id)
        {
            var order = _orderService.QueryOrder(o => o.OrderId == id).FirstOrDefault();
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }
    }
}