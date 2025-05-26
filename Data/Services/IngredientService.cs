
using Inlämning1Tomasso.Data.Interface.Services;

using Inlämning1Tomasso.Data.Interface.Repositories;


namespace Inlämning1Tomasso.Data.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly IIngredientRepository _ingredientRepository;

        public IngredientService(IIngredientRepository ingredientRepo)
        {
            _ingredientRepository = ingredientRepo;
        }

        //public void AddIngredient(Ingredient ingredient)
        //{
        //    _ingredientRepo.AddIngredient(ingredient);
        //}

        //public void DeleteIngredient(int ingredientID)
        //{
        //    _ingredientRepo.DeleteIngredient(ingredientID);
        //}

        //public void UpdateIngredient(Ingredient ingredient)
        //{
        //    _ingredientRepo.UpdateIngredient(ingredient);
        //}

        public List<Ingredient> GetAllIngredients()
        {
            return _ingredientRepository.GetAllIngredients();
        }
    }
}
