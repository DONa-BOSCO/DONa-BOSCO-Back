
using API.IServices;
using API.Models.FilterModels;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class OrderController : ControllerBase
    {

        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost(Name = "AddOrder")]
        public int AddUserRol([FromBody] OrderItem orderItem)
        {
            return _orderService.AddOrder(orderItem);
        }

        [HttpGet(Name = "GetAllOrder")]
        public List<OrderItem> GetAllOrder()
        {
            return _orderService.GetAllOrder();
        }

        [HttpPatch(Name = "UpdateOrder")]
        public void Patch([FromBody] OrderItem orderItem)
        {
            _orderService.UpdateOrder(orderItem);
        }

        [HttpGet(Name = "GetOrderById")]
        public List<OrderItem> GetOrderById([FromQuery] int id)
        {
            return _orderService.GetOrderById(id);
        }

        [HttpDelete(Name = "DeactivateOrder")]
        public void DeactivateOrder([FromQuery] int id)
        {
            _orderService.DeactivateOrder(id);
        }
    }
}
