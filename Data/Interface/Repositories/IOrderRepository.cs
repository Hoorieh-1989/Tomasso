using Inlämning1Tomasso.Data.Models;


namespace inlämning1Tomasso.Data.Interface.Repositories
{
    public interface IOrderRepository
    {
        void AddOrder(Order order);
        List<Order> GetAllOrdersByUserId(int userId);
    }
}
