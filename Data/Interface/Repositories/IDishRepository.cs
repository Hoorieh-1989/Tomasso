using inlämning1Tomasso.Data.Models;

namespace inlämning1Tomasso.Data.Interface.Repositories
{
    public interface IDishRepository
    {

        void AddDish(Dish dish);

        void UpdateDish(Dish dish);

        void DeleteDish(int dishID);

        List<Dish> GetAllDishes(int dishID);
    }
}
