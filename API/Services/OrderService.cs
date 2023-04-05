using API.IServices;
using Entities.Entities;
using Logic.ILogic;
using Resources.RequestModels;
using Microsoft.AspNetCore.Mvc;

namespace API.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderLogic _orderLogic;

        public OrderService(IOrderLogic orderLogic)
        {
            _orderLogic = orderLogic;
        }

        void IOrderService.DeactivateOrder(int id)
        {
            _orderLogic.DeactivateOrder(id);
        }

        public List<OrderItem> GetAllOrder()
        {
            return _orderLogic.GetAllOrder();
        }

        public List<OrderItem> GetOrderById(int id)
        {
            return _orderLogic.GetOrderById(id);
        }

        public int AddOrder(OrderItem orderItem)
        {
            return _orderLogic.AddOrder(orderItem);
        }

        public void UpdateOrder(OrderItem orderItem)
        {
            _orderLogic.UpdateOrder(orderItem);
        }

    }
}
