using inlämning1Tomasso.Data.Models;

namespace inlämning1Tomasso.Data.Interface.Repositories
{
    public interface IOrderRepository
    {

        void AddOrder(Order order);
        void DeleteOrder(int orderID);  

        List<Order> GetAllOrders(int orderID);
    }
}
