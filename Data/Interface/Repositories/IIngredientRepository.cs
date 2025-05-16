using inlämning1Tomasso.Data.Models;

namespace inlämning1Tomasso.Data.Interface.Repositories
{
    public interface IIngredientRepository
    {
        /// CRUD operations for Ingridient entity
        void AddIngredient(Ingredient ingredient);

        void UpdateIngredient(Ingredient ingredient);

        void DeleteIngredient(int ingredientID);    

   

    }
}
