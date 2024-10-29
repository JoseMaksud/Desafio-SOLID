using OrderSystem.Models;
using System.Collections.Generic;

namespace OrderSystem.Interfaces
{
    public interface IProductRepository
    {
        Product GetProductById(int id);
        List<Product> GetAllProducts();
    }
}
