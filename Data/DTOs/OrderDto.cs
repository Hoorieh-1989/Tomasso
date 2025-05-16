namespace inlämning1Tomasso.Data.DTOs
{
    public class OrderDto
    {
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public List<int> DishIDs { get; set; } = new List<int>(); // dishes served
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public decimal TotalAmount { get; set; }
    }
}
