namespace inlämning1Tomasso.Data.Models
{
    public class DishOrder
    {

        public int OrderID { get; set; }

        public int DishID { get; set; }

        // Navigation property
        public Dish Dish { get; set; }
        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}
