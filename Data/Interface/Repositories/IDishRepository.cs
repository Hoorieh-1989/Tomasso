using inlämning1Tomasso.Data.Models;
using System.Collections.Generic;

namespace inlämning1Tomasso.Data.Interface.Repositories
{
    public interface IDishRepository
    {
        void AddDish(Dish dish);

        void UpdateDish(Dish dish);

        void DeleteDish(int dishID);

        List<Dish> GetAllDishes();         // Hämta alla rätter

        Dish GetDishById(int dishID);      // Hämta en specifik rätt
    }
}
