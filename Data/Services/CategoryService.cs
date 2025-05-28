using Inlämning1Tomasso.Data.DTOs;
using Inlämning1Tomasso.Data.Interface.Repositories;
using Inlämning1Tomasso.Data.Interface.Services;
using Inlämning1Tomasso.Data.Models;
namespace Inlämning1Tomasso.Data.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public List<CategoryDto> GetAllCategories()
        {
            return _categoryRepository.GetAllCategories()
                .Select(c => new CategoryDto
                {
                    CategoryID = c.CategoryID,          // <- Avkommentera detta!
                    CategoryName = c.CategoryName
                }).ToList();
        }


        public CategoryDto CreateCategory(CategoryDto categoryDto)
        {
            var category = new Category
            {
                CategoryName = categoryDto.CategoryName
            };

            _categoryRepository.CreateCategory(category);

            return new CategoryDto
            {
                //CategoryID = category.CategoryID,
                CategoryName = category.CategoryName
            };
        }

    }
}
