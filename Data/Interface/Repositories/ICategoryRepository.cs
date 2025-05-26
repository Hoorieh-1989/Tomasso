

using Inlämning1Tomasso.Data.Models;

namespace Inlämning1Tomasso.Data.Interface.Repositories
{
    public interface ICategoryRepository
    {
        List<Category> GetAllCategories();
        void CreateCategory(Category category);

    }
}

