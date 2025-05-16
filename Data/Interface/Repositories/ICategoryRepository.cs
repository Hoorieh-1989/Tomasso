using inlämning1Tomasso.Data.Models;
using System.Collections.Generic;

namespace inlämning1Tomasso.Data.Interface.Repositories
{
    public interface ICategoryRepository
    {
        void AddCategory(Category category);

        void UpdateCategory(Category category);

        void DeleteCategory(int categoryId);

        Category GetCategoryById(int categoryId);

        List<Category> GetAllCategories();
    }
}
