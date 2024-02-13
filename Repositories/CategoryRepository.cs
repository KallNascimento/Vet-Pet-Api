using Vet_Pet_Api.Entities;

namespace Vet_Pet_Api.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public Task<Category> CreateAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public Task<Category> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Category>> GetAllCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetCategoryByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Category> UpdateAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
