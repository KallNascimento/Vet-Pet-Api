using Vet_Pet_Api.Dtos;
using Vet_Pet_Api.Entities;

namespace Vet_Pet_Api.Services.Interfaces
{
    public class ICategory
    {
        Task<ResultService<CategoryDto>> CreateAsync(CategoryDto categoryDto); 
    }
}
