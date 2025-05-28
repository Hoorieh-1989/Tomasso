using Inlämning1Tomasso.Data.DTOs;
using System.Threading.Tasks;

namespace Inlämning1Tomasso.Data.Interface.Services
{
    public interface IDishService
    {
        Task<DishDto> CreateDishAsync(DishCreateDto dto);
        DishIngredientsDto GetDishIngredients(int dishId);
    }
}
