using OrderSystem.Interfaces;
using OrderSystem.Models;
using System.Collections.Generic;

namespace OrderSystem.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Product GetProductById(int id)
        {
            // Simulação de busca de um produto
            return new Product { Id = id, Name = "Produto Exemplo", Price = 10.0m };
        }

        public List<Product> GetAllProducts()
        {
            // Simulação de lista de produtos
            return new List<Product>
            {
                new Product { Id = 1, Name = "Produto A", Price = 10.0m },
                new Product { Id = 2, Name = "Produto B", Price = 15.5m }
            };
        }
    }
}
