namespace Inlämning1Tomasso.Data.DTOs
{
    public class DishDto
    {
        public int DishID { get; set; }
        public string DishName { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }

        // Här är Category som en CategoryDto
        public CategoryDto? Category { get; set; }

        public List<IngredientDto> Ingredients { get; set; } = new();
    }
}
