﻿

namespace Inlämning1Tomasso.Data.Interface.Services
{
    public interface IIngredientService
    {
        //void AddIngredient(Ingredient ingredient); 
        //void DeleteIngredient(int ingredientID); 
        //void UpdateIngredient(Ingredient ingredient); 
        public List<Ingredient> GetAllIngredients();
    }
}
