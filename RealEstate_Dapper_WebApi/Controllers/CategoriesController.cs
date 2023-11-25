using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_WebApi.Dtos.CategoryDtos;
using RealEstate_Dapper_WebApi.Repository.CategoryRepository;

namespace RealEstate_Dapper_WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoriesController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        [HttpGet("GetAllCategory")]
        public async Task<IActionResult> Index()
        {
            var values = await _categoryRepository.GetAllCategoryAsync();
            return Ok(values);
        }

        [HttpPost("CreateCategory")]
        public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryDto category)
        {
            _categoryRepository.CreateCategoryAsync(category);
            return Ok();
        }

        [HttpDelete("DeleteCategory/{id}")]
        public async Task<IActionResult> DeleteCategory([FromRoute] int id)
        {
            _categoryRepository.DeleteCategoryAsync(id);
            return Ok();
        }

        [HttpPut("UpdateCategory")]
        public async Task<IActionResult> UpdateCategory([FromBody] UpdateCategoryDto category)
        {
            _categoryRepository.UpdateCategoryAsync(category);
            return Ok();
        }

        [HttpGet("GetCategoryById/{id}")]
        public async Task<IActionResult> GetCategoryById([FromRoute] int id)
        {
            var value = await _categoryRepository.GetCategoryByIdAsync(id);
            return Ok(value);
        }
    }
}