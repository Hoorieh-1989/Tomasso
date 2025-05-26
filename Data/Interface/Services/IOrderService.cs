using Inlämning1Tomasso.Data.DTOs;


namespace Inlämning1Tomasso.Data.Interface.Services
{
    public interface IOrderService
    {
        OrderDto AddOrder(CreateOrderDto dto, int userId);

        List<OrderDto> GetAllOrders(int userId);
    }

}

