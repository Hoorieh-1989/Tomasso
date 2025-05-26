using Inlämning1Tomasso.Data.DTOs;
using inlämning1Tomasso.Data.Interface.Repositories;
using Inlämning1Tomasso.Data;

using Inlämning1Tomasso.Data.Interface.Services;
using Inlämning1Tomasso.Data.Models;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;
    private readonly TomassoDbContext _context;

    public OrderService(IOrderRepository orderRepository, TomassoDbContext context)
    {
        _orderRepository = orderRepository;
        _context = context;
    }

    public List<OrderDto> GetAllOrders(int userId)
    {
        var orders = _orderRepository.GetAllOrdersByUserId(userId);

        return orders.Select(o => new OrderDto
        {
            OrderID = o.OrderID,
            UserID = o.UserID,
            UserName = _context.Users.Find(o.UserID)?.UserName,
            OrderDate = o.OrderDate,
            Price = o.TotalPrice,
            Dishes = o.DishOrders.Select(od => new OrderDishDto
            {
                DishID = od.DishID,
                Name = _context.Dishes.Find(od.DishID)?.DishName,
                Quantity = od.Quantity,
                Price = od.Price
            }).ToList()
        }).ToList();
    }

    public OrderDto AddOrder(CreateOrderDto dto, int userId)
    {
        var order = new Order
        {
            UserID = userId,
            OrderDate = DateTime.UtcNow,
          DishOrders = new List<DishOrder>()
        };

        decimal total = 0;

        foreach (var item in dto.Dishes)
        {
            var dish = _context.Dishes.Find(item.DishID);
            if (dish == null) continue;

            var dishorder = new DishOrder
            {
                DishID = dish.DishID,
                Quantity = item.Quantity,
                Price = dish.Price * item.Quantity
            };

            order.DishOrders.Add(dishorder);
            total += dishorder.Price;
        }

        order.TotalPrice = total;

        _orderRepository.AddOrder(order);


        return new OrderDto
        {
            OrderID = order.OrderID,
            UserID = order.UserID,
            UserName = _context.Users.Find(userId)?.UserName,
            OrderDate = order.OrderDate,
            Price = order.TotalPrice,
            Dishes = order.DishOrders.Select(od => new OrderDishDto
            {
                DishID = od.DishID,
                Name = _context.Dishes.Find(od.DishID)?.DishName,  // Ändrat till DishName
                Quantity = od.Quantity,
                Price = od.Price
            }).ToList()
        };
    }
}
