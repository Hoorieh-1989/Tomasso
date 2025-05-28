using Inlämning1Tomasso.Data.DTOs;
using Inlämning1Tomasso.Data.Models;
using System.Threading.Tasks;

namespace Inlämning1Tomasso.Data.Interface.Repositories
{
    public interface IDishRepository
    {
        DishIngredientsDto GetDishIngredients(int dishId);

        Task<Dish> CreateDishAsync(Dish dish);
    }
}
