using Inlämning1Tomasso.Data.DTOs;
using Inlämning1Tomasso.Data.Interface.Repositories;
using Inlämning1Tomasso.Data.Interface.Services;

namespace Inlämning1Tomasso.Data.Services
{
    public class DishService : IDishService
    {
        private readonly IDishRepository _dishRepository;

        public DishService(IDishRepository dishRepo)
        {
            _dishRepository = dishRepo;
        }

        public DishIngredientsDto GetDishIngredients(int dishId)
        {
            return _dishRepository.GetDishIngredients(dishId);
        }
    }
}
