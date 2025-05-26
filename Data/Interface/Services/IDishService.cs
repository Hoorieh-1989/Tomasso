


using Inlämning1Tomasso.Data.DTOs;

namespace Inlämning1Tomasso.Data.Interface.Services
{
    public interface IDishService
    {
        DishIngredientsDto GetDishIngredients(int dishId);
    }

}

