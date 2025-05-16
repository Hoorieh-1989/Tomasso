using System.ComponentModel.DataAnnotations;

namespace inlämning1Tomasso.Data.Models
{
    public class Dish
    {
        [Key]
        public int DishID { get; set; }

        [Required]

        [StringLength(50)]

        public string DishName { get; set; }

        [Required]


        public decimal Price { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [Required]

        [StringLength(50)]
        public List<Ingredient> Ingredients { get; set; }
        public List<Order> Orders { get; set; }
        public object DishIngredients { get; internal set; }
    }
}
