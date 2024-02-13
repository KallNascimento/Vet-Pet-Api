using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vet_Pet_Api.Dtos;
using Vet_Pet_Api.Entities;
using Vet_Pet_Api.Helpers;

namespace Vet_Pet_Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly DataContext _context;

        public CategoriesController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CategoryDto dto) {

            var category = await _context.Categories.Add(dto);
            return Ok(category);

        }
    }
}
