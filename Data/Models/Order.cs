using System.ComponentModel.DataAnnotations;


namespace inlämning1Tomasso.Data.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [Required]
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;

        [Required]
        public decimal TotalPrice { get; set; }

        [Required]
        public int UserID { get; set; }
        public User User { get; set; }

        public List<Dish> Dishes{ get; set; }
    }
}
