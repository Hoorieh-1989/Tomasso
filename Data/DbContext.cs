using Inlämning1Tomaso.Data.Models;
using inlämning1Tomasso.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace inlämning1Tomasso.Data
{
    public class TomasoDbContext : DbContext
    {
        public TomasoDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<DishIngredient> DishIngredients { get; set; }
    }
}