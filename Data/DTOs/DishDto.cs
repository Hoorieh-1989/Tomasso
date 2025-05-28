using System.Collections.Generic;

namespace Inlämning1Tomasso.Data.DTOs
{
    public class DishDto
    {
        public int DishID { get; set; }
        public string? DishName { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }

        public int CategoryID { get; set; }
        public string? CategoryName { get; set; }

        public List<IngredientDto>? Ingredients { get; set; }
    }
}
