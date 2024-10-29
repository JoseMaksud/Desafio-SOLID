using OrderSystem.Models;

namespace OrderSystem.Interfaces
{
    public interface IOrderService
    {
        void PlaceOrder(Order order);
    }
}
