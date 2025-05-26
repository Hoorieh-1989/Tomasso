
using Inlämning1Tomasso.Data.Models;

using inlämning1Tomasso.Data.Interface.Repositories;
using Inlämning1Tomasso.Data;
using Microsoft.EntityFrameworkCore;


namespace Inlämning1Tomasso.Data.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly TomassoDbContext _context;

        public OrderRepository(TomassoDbContext context)
        {
            _context = context;
        }

        public void AddOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        //public List<Order> GetAllOrders(int orderID)
        //{
        //    return _context.Orders
        //                    .Include(o => o.OrderDishes)  // Inkludera OrderDishes för att få alla rätter för varje beställning
        //                    .ToList();
        //}

        public List<Order> GetAllOrdersByUserId(int userId)
        {
            return _context.Orders
       .Include(o => o.DishOrders)
       .Where(o => o.UserID == userId)
       .ToList();
        }
    }
}