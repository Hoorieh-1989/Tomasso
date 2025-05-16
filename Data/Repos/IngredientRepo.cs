using inlämning1Tomasso.Data.Interface.Repositories;
using inlämning1Tomasso.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace inlämning1Tomasso.Data.Repos
{
    public class IngredientRepo : IIngredientRepository
    {
        private readonly TomasoDbContext _context;

        public IngredientRepo(TomasoDbContext context)
        {
            _context = context;
        }

        public void AddIngredient(Ingredient ingredient)
        {
            _context.Ingredients.Add(ingredient);
            _context.SaveChanges();
        }

        public void DeleteIngredient(int ingredientID)
        {
            var ingredient = _context.Ingredients.SingleOrDefault(i => i.IngredientID == ingredientID);
            if (ingredient != null)
            {
                _context.Ingredients.Remove(ingredient);
                _context.SaveChanges();
            }
        }

        public List<Ingredient> GetAllIngredients()
        {
            return _context.Ingredients.ToList();
        }

        public void UpdateIngredient(Ingredient ingredient)
        {
            var existing = _context.Ingredients.SingleOrDefault(i => i.IngredientID == ingredient.IngredientID);
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(ingredient);
                _context.SaveChanges();
            }
        }
    }
}
