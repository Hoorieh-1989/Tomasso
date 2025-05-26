using Inlämning1Tomasso.Data.Models;

namespace Inlämning1Tomasso.Data.Repos
{
    public class DishOrderRepository
    {
        public int OrderID { get; set; }
        public int DishID { get; set; }

        //Navprop

        public Order? Order { get; set; }

        public Dish? Dish { get; set; }
    }
}
