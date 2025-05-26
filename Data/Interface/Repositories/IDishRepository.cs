using Inlämning1Tomasso.Data.DTOs;

namespace Inlämning1Tomasso.Data.Interface.Repositories
{
    public interface IDishRepository
    {
        DishIngredientsDto GetDishIngredients(int dishId);

    }
}
