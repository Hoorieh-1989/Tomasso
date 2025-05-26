
using Inlämning1Tomasso.Data.Interface.Repositories;

namespace Inlämning1Tomasso.Data.Repos
{
    public class IngredientRepository : IIngredientRepository
    {
        private readonly TomassoDbContext _context;

        public IngredientRepository(TomassoDbContext context)
        {
            _context = context;
        }

        //public void AddIngredient(Ingredient ingredient)
        //{
        //    _context.Ingredients.Add(ingredient);
        //    _context.SaveChanges();
        //}


        //public void DeleteIngredient(int ingredientID)
        //{
        //    var ingredient = _context.Ingredients.SingleOrDefault(i => i.IngredientID == ingredientID);
        //    if (ingredient != null)
        //    {
        //        _context.Ingredients.Remove(ingredient);
        //        _context.SaveChanges();
        //    }
        //}

        //// Uppdatera en ingrediens
        //public void UpdateIngredient(Ingredient ingredient)
        //{
        //    var existing = _context.Ingredients.SingleOrDefault(i => i.IngredientID == ingredient.IngredientID);
        //    if (existing != null)
        //    {
        //        _context.Entry(existing).CurrentValues.SetValues(ingredient);
        //        _context.SaveChanges();
        //    }
        //}

        // Hämta alla ingredienser
        public List<Ingredient> GetAllIngredients()
        {
            return _context.Ingredients.ToList();
        }
    }
}
