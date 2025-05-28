using Inlämning1Tomasso.Data.DTOs;
using Inlämning1Tomasso.Data.Interface.Repositories;
using Inlämning1Tomasso.Data.Interface.Services;
using Inlämning1Tomasso.Data.Models;
using System.Threading.Tasks;
using System.Linq;

namespace Inlämning1Tomasso.Data.Services
{
    public class DishService : IDishService
    {
        private readonly IDishRepository _dishRepository;

        public DishService(IDishRepository dishRepository)
        {
            _dishRepository = dishRepository;
        }

        // Hämtar maträtt med ingredienser via repository
        public DishIngredientsDto GetDishIngredients(int dishId)
        {
            return _dishRepository.GetDishIngredients(dishId);
        }

        // Skapar en ny maträtt asynkront
        public async Task<DishDto> CreateDishAsync(DishCreateDto dto)
        {
            var newDish = new Dish
            {
                DishName = dto.DishName,
                Price = dto.Price,
                Description = dto.Description,
                CategoryID = dto.CategoryID,
                Ingredients = new List<Ingredient>()
            };

            if (dto.Ingredients != null && dto.Ingredients.Any())
            {
                foreach (var ingredientDto in dto.Ingredients)
                {
                    // Eftersom det är nya ingredienser utan ID, skapar vi nya Ingredient-objekt direkt
                    var newIngredient = new Ingredient
                    {
                        Name = ingredientDto.Name
                    };
                    newDish.Ingredients.Add(newIngredient);
                }
            }

            var createdDish = await _dishRepository.CreateDishAsync(newDish);

            var fullDish = await _dishRepository.GetDishWithDetailsAsync(createdDish.DishID);

            return new DishDto
            {
                DishID = fullDish.DishID,
                DishName = fullDish.DishName,
                Price = fullDish.Price,
                Description = fullDish.Description,
                Category = fullDish.Category != null
         ? new CategoryDto
         {
             CategoryID = fullDish.Category.CategoryID,
             CategoryName = fullDish.Category.CategoryName
         }
         : null,
                Ingredients = fullDish.Ingredients.Select(i => new IngredientDto
                {
                    IngredientID = i.IngredientID,
                    Name = i.Name
                }).ToList()
            };
        }
    }
}

