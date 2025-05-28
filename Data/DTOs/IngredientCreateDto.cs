using System.ComponentModel.DataAnnotations;

namespace inlämning1Tomasso.Data.DTOs
{
    public class IngredientCreateDto
    {
       
    [Required]
        public string Name { get; set; }
    }
}
