using Inlämning1Tomasso.Data.DTOs;


namespace Inlämning1Tomasso.Data.Interface.Services
{
    public interface ICategoryService
    {
        List<CategoryDto> GetAllCategories();

        CategoryDto CreateCategory(CategoryDto categoryDto);

    }
}
