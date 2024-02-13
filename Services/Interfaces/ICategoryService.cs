using Vet_Pet_Api.Dtos;

namespace Vet_Pet_Api.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<ResultService<CategoryDto>> CreateAsync(CategoryDto categoryDto);
    }
}
