using inlämning1Tomasso.Data.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inlämning1Tomaso.Data.Models
{
    public class DishIngredient
    {

        [Key]
        public int DishIngredientID { get; set; }
        [Required]

        [Key, Column(Order = 0)]
        public int DishID { get; set; }

        [Key, Column(Order = 1)]
        public int IngredientID { get; set; }

        // Här använder vi navigeringsproperties, inte ID-egenskaper.
        [ForeignKey("DishID")]
        public Dish Dish { get; set; }

        [ForeignKey("IngredientID")]
        public Ingredient Ingredient { get; set; }
    }
}