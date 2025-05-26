

namespace Inlämning1Tomasso.Data.Interface.Repositories
{
    public interface IIngredientRepository
    {
   
            //void AddIngredient(Ingredient ingredient);
            //void DeleteIngredient(int ingredientID);
            //void UpdateIngredient(Ingredient ingredient);
            List<Ingredient> GetAllIngredients();
        }
    }