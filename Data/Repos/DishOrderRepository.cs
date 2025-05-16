using inlämning1Tomasso.Data.Models;

namespace inlämning1Tomasso.Data.Repos
{
    public class DishOrderRepository
    {
       public int DishID { get; set; }

        public int OrderID { get; set; }

        //public int Quantity { get; set; }

        //public decimal Price { get; set; }

        // Navigation property
        public DishOrder DishOrder { get; set; }
        public Dish Dish { get; set; }  

    }
}
