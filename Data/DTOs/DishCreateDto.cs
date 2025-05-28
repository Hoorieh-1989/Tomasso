using System.ComponentModel.DataAnnotations;

namespace Inlämning1Tomasso.Data.DTOs
{
    public class DishCreateDto
    {
        [Required]
        [StringLength(50)]
        public string DishName { get; set; }

        [Required]
        public decimal Price { get; set; }

        [StringLength(300)]
        public string? Description { get; set; }

        [Required]
        public int CategoryID { get; set; }

       
        public List<IngredientDto> Ingredients { get; set; } = new();
    }
}
