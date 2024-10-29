using OrderSystem.Interfaces;
using OrderSystem.Models;
using System;

namespace OrderSystem.Services
{
    public class OrderService : IOrderService
    {
        private readonly IProductRepository _productRepository;

        public OrderService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void PlaceOrder(Order order)
        {
            order.OrderDate = DateTime.Now;
            Console.WriteLine($"Pedido realizado com {order.Products.Count} produto(s). Total: {order.CalculateTotal():C}");
        }
    }
}
