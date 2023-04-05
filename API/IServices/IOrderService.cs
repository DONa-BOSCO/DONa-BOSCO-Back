using Entities.Entities;
using Resources.RequestModels;
using Microsoft.AspNetCore.Mvc;
using API.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Generic;
using Logic.ILogic;
using API.Models.FilterModels;
using OrderFilter = Logic.ILogic.OrderFilter;

namespace API.IServices
{
    public interface IOrderService
    {
        int AddOrder(OrderItem orderItem);
        List<OrderItem> GetAllOrder();
        List<OrderItem> GetOrderById(int id);
        void DeactivateOrder(int id);
        void UpdateOrder(OrderItem orderItem);
    }
}
