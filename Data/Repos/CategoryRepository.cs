using inlämning1Tomasso.Data.Interface.Repositories;
using inlämning1Tomasso.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace inlämning1Tomasso.Data.Repos
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly TomassoDbContext _context;

        public CategoryRepository(TomassoDbContext context)
        {
            _context = context;
        }

        public void AddCategory(Category category)
        {
            _context.Category.Add(category);
            _context.SaveChanges();
        }

        public void DeleteCategory(int categoryId)
        {
            var category = _context.Category.Find(categoryId);
            if (category != null)
            {
                _context.Category.Remove(category);
                _context.SaveChanges();
            }
        }

        public List<Category> GetAllCategories()
        {
            return _context.Category.ToList();
        }

        public Category GetCategoryById(int categoryId)
        {
            return _context.Category.FirstOrDefault(c => c.CategoryID == categoryId);
        }

        public void UpdateCategory(Category category)
        {
            var existing = _context.Category.Find(category.CategoryID);
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(category);
                _context.SaveChanges();
            }
        }
    }
}
