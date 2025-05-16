using inlämning1Tomasso.Data.Interface.Repositories;
using inlämning1Tomasso.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace inlämning1Tomasso.Data.Repos
{
    public class OrderRepo : IOrderRepository
    {
        private readonly DbContext _context;

        public OrderRepo(DbContext context)
        {
            _context = context;
        }

        public void AddOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public void DeleteOrder(int orderID)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAllOrders(int orderID)
        {
            throw new NotImplementedException();
        }
    }
}
