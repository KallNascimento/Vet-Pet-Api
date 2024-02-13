using Vet_Pet_Api.Entities;

namespace Vet_Pet_Api.Repositories
{
    public interface ICategoryRepository
    {
        Task<Category> GetCategoryByIdAsync(Guid id);
        Task<ICollection<Category>> GetAllCategoriesAsync();
        Task<Category> CreateAsync(Category category);
        Task<Category> UpdateAsync(Guid id); 
        Task<Category> DeleteAsync(Guid id);
    }
}
