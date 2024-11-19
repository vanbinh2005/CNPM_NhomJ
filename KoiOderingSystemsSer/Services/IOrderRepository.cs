
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoiOderingSystemsRepositories.Entities;

namespace KoiOderingSystemsRepositories.Interfaces
{
    public interface IOrderRepository
    {
        Task<Order> CreateOrder(Order order);
        Task<Order> GetOrderById(int orderId);
    }

}
