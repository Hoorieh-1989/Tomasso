
using inlämning1Tomasso.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace inlämning1Tomasso.Data
{
    public class TomassoDbContext : DbContext
    {
        public TomassoDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<DishOrder>DishOrder{ get; set; }

        public DbSet<Category> Category { get; set; }

    }
}