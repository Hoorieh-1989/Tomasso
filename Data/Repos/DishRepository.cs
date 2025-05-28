using Inlämning1Tomasso.Data.DTOs;
using Inlämning1Tomasso.Data.Interface.Repositories;
using Inlämning1Tomasso.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Inlämning1Tomasso.Data.Repos
{
    public class DishRepository : IDishRepository
    {
        private readonly TomassoDbContext _context;

        public DishRepository(TomassoDbContext context)
        {
            _context = context;
        }

        public DishIngredientsDto GetDishIngredients(int dishId)
        {
            var dish = _context.Dishes
                .Include(d => d.Ingredients)
                .FirstOrDefault(d => d.DishID == dishId);

            if (dish == null) return null;

            return new DishIngredientsDto
            {
                DishID = dish.DishID,
                DishName = dish.DishName,
                Description = dish.Description,
                Price = dish.Price,
                Ingredients = dish.Ingredients.Select(i => new IngredientDto
                {
                    IngredientID = i.IngredientID,
                    Name = i.Name
                }).ToList()
            };
        }

        public async Task<Dish> CreateDishAsync(Dish dish)
        {
            _context.Dishes.Add(dish);
            await _context.SaveChangesAsync();
            return dish;
        }
    }
}
