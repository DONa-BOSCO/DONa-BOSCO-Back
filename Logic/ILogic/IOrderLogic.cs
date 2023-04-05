using Entities.Entities;
using API.Models; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IOrderLogic
    {
        int AddOrder(OrderItem orderItem);
        List<OrderItem> GetAllOrder();
        List<OrderItem> GetOrderById(int id);
        void DeactivateOrder(int id);
        void UpdateOrder(OrderItem orderItem);
    }
}
