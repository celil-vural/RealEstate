using Entity.Dtos.CategoryDtos;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_WebApi.Repository.CategoryRepository;

namespace RealEstate_Dapper_WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController(ICategoryRepository repository) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await repository.GetAllAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryDto dto)
        {
            repository.CreateAsync(dto);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteCategory([FromRoute] int id)
        {
            repository.DeleteAsync(id);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory([FromBody] UpdateCategoryDto dto)
        {
            repository.UpdateAsync(dto);
            return Ok();
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetCategoryById([FromRoute] int id)
        {
            var value = await repository.GetByIdAsync(id);
            return Ok(value);
        }
    }
}