using vShop.ProductApi.Dtos;

namespace vShop.ProductApi.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDTO>> GetCategory();
        Task<IEnumerable<CategoryDTO>> GetCategoryByProducts();
        Task<CategoryDTO> GetCategoryById(int id);
        Task AddCategory(CategoryDTO categoryDTO);
        Task DeleteCategory(int id);
        Task UpdateCategory(CategoryDTO categoryDTO);

    }
}
