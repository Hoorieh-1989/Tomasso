using inlämning1Tomasso.Data.Interface.Repositories;
using inlämning1Tomasso.Data.Interface.Services;

namespace inlämning1Tomasso.Data.Services
{
    public class OrderService: IOrderService

    {

        private readonly IOrderRepository _OrderRepository;
        private readonly IUserService _userService;
    }
}
