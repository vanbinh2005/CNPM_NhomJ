using KoiOderingSystemsRepositories.Entities;
using KoiOderingSystemsRepositories.Interfaces;
using KoiOderingSystemsServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoiOderingSystemsServices.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IProductRepository _productRepository;

        public OrderService(IOrderRepository orderRepository, IProductRepository productRepository)
        {
            _orderRepository = orderRepository;
            _productRepository = productRepository;
        }

        public async Task<Order> PlaceOrder(Order order)
        {
            decimal totalPrice = 0;
            foreach (var item in order.Items)
            {
                var product = await _productRepository.GetProductById(item.Id);
                if (product != null && product.Stock >= item.Quantity)
                {
                    totalPrice += product.Price * item.Quantity;
                }
                else
                {
                    throw new Exception($"Product {product.Name} is out of stock.");
                }
            }

            order.TotalPrice = totalPrice;
            order.ShippingFee = 20; // Phí vận chuyển có thể thay đổi tùy theo các điều kiện.
            order.GrandTotal = totalPrice + order.ShippingFee;

            return await _orderRepository.CreateOrder(order);
        }

        public async Task<Order> GetOrderById(int orderId)
        {
            return await _orderRepository.GetOrderById(orderId);
        }
    }

}
