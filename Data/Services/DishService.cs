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
            // Skapa Dish-entity från DTO
            var newDish = new Dish
            {
                DishName = dto.DishName,
                Price = dto.Price,
                Description = dto.Description,
                CategoryID = dto.CategoryID
                // Ingredients sätts separat om du har det
            };

            // Spara via repository och få tillbaka sparad entity (med ID)
            var createdDish = await _dishRepository.CreateDishAsync(newDish);

            // Mappa till DTO att returnera (du kan använda AutoMapper eller mappa manuellt)
            var dishDto = new DishDto
            {
            //    DishID = createdDish.DishID,
                DishName = createdDish.DishName,
                Price = createdDish.Price,
                CategoryName = null, // Du kan hämta kategori om du vill
                Ingredients = null // Sätt ingredienser om du vill
            };

            return dishDto;
        }
    }
}
