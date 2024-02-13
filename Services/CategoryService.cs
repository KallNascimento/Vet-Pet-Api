using AutoMapper;
using Vet_Pet_Api.Dtos;
using Vet_Pet_Api.Repositories;
using Vet_Pet_Api.Services.Interfaces;

namespace Vet_Pet_Api.Services
{
    public class CategoryService : ICategoryService
    {

        private readonly ICategoryRepository categoryRepository;
        private readonly IMapper mapper;
        public CategoryService(IMapper mapper, ICategoryRepository categoryRepository) { }
        public Task<ResultService<CategoryDto>> CreateAsync(CategoryDto categoryDto)
        {
            throw new NotImplementedException();
        }
    }
}
