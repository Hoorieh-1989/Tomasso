using Inlämning1Tomasso.Data.Interface.Repositories;
using Inlämning1Tomasso.Data.Models;


namespace Inlämning1Tomasso.Data.Repos
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly TomassoDbContext _context;

        public CategoryRepository(TomassoDbContext context)
        {
            _context = context;
        }


        public List<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public void CreateCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }


    }
}
