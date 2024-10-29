using OrderSystem.Interfaces;
using OrderSystem.Models;
using OrderSystem.Repositories;
using OrderSystem.Services;
using System;

namespace OrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductRepository productRepository = new ProductRepository();
            IOrderService orderService = new OrderService(productRepository);

            var product = productRepository.GetProductById(1);
            var order = new Order();
            order.Products.Add(product);

            orderService.PlaceOrder(order);
        }
    }
}
