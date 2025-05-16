
using inlämning1Tomasso.Data.Models;
using inlämning1Tomasso.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Inlämning1Tomaso.Data.Repos
{
    public class OrderRepository
    {
        private readonly TomassoDbContext _context;

        public OrderRepository(TomassoDbContext context)
        {
            _context = context;
        }

        // Skapa en ny beställning
        public void AddOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        // Ta bort en beställning
        public void DeleteOrder(int orderID)
        {
            var order = _context.Orders
                .Include(o => o.Dishes)  // Inkludera beställda rätter direkt (utan orderrader)
                .FirstOrDefault(o => o.OrderID == orderID);

            if (order != null)
            {
                // Ta bort själva beställningen
                _context.Orders.Remove(order);
                _context.SaveChanges();
            }
        }

        // Hämta alla beställningar
        public List<Order> GetAllOrders()
        {
            return _context.Orders
                .Include(o => o.Dishes)  // Inkludera beställda rätter direkt
                .ToList();
        }

        // Hämta en specifik beställning med detaljer (beställda rätter)
        public Order GetOrderWithDishes(int orderID)
        {
            return _context.Orders
                .Include(o => o.Dishes)  // Inkludera beställda rätter direkt
                .FirstOrDefault(o => o.OrderID == orderID);
        }


    }
}