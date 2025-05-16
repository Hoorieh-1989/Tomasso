using System.ComponentModel.DataAnnotations;

namespace inlämning1Tomasso.Data.Models
{
    public class Ingredient
    {

        [Key]
        public int IngredientID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public List<Ingredient>Ingridients { get; set; }
    }
}
