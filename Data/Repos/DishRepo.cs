using inlämning1Tomasso.Data.Interface.Repositories;
using inlämning1Tomasso.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace inlämning1Tomasso.Data.Repos
{
    public class Dishrepo : IDishRepository
    {
        private readonly TomasoDbContext _context;

        public Dishrepo(TomasoDbContext context)
        {
            _context = context;
        }

        public void AddDish(Dish dish)
        {
            _context.Dishes.Add(dish);
            _context.SaveChanges();
        }

        public void DeleteDish(int dishId)
        {
            var dish = _context.Dishes.SingleOrDefault(d => d.DishID == dishId);
            if (dish != null)
            {
                _context.Dishes.Remove(dish);
                _context.SaveChanges();
            }
        }

        public void UpdateDish(Dish dish)
        {
            var existingDish = _context.Dishes.SingleOrDefault(d => d.DishID == dish.DishID);
            if (existingDish != null)
            {
                _context.Entry(existingDish).CurrentValues.SetValues(dish);
                _context.SaveChanges();
            }
        }

        public List<Dish> GetAllDishes()
        {
            return _context.Dishes.ToList();
        }

        public List<Ingredient> GetIngredientsByDishId(int dishId)
        {
            return _context.DishIngredients
                .Where(di => di.DishID == dishId)
                .Include(di => di.Ingredient)
                .Select(di => di.Ingredient)
                .ToList();
        }

        public List<Dish> GetDishesByIngredientId(int ingredientId)
        {
            return _context.DishIngredients
                .Where(di => di.IngredientID == ingredientId)
                .Include(di => di.Dish)
                .Select(di => di.Dish)
                .ToList();
        }

        public List<Dish> GetAllDishes(int dishID)
        {
            throw new NotImplementedException();
        }
    }
}
