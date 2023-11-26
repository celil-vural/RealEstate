using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_WebApi.Dtos.ProductDtos;
using RealEstate_Dapper_WebApi.Repository.ProductRepository;

namespace RealEstate_Dapper_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(IProductRepository repository) : ControllerBase
    {
        [HttpGet("GetAllProduct")]
        public async Task<IActionResult> Index()
        {
            var values = await repository.GetAllProductAsync();
            return Ok(values);
        }
        [HttpGet("GetAllProductWithCategory")]
        public async Task<IActionResult> GetAllProductWithCategory()
        {
            var values = await repository.GetAllProductWithCategoryAsync();
            return Ok(values);
        }
        [HttpGet("GetProductWithCategoryById/{id}")]
        public async Task<IActionResult> GetProductWithCategoryById([FromRoute] int id)
        {
            var values = await repository.GetProductWithCategoryByIdAsync(id);
            return Ok(values);
        }
        [HttpGet("GetProductById/{id}")]
        public async Task<IActionResult> GetProductById([FromRoute] int id)
        {
            var values = await repository.GetProductByIdAsync(id);
            return Ok(values);
        }

        [HttpPost("CreateProduct")]
        public IActionResult CreateProduct([FromBody] CreateProductDto dto)
        {
            repository.CreateProductAsync(dto);
            return Ok();
        }

        [HttpPut("UpdateProduct")]
        public IActionResult UpdateProduct([FromBody] UpdateProductDto dto)
        {
            repository.UpdateProductAsync(dto);
            return Ok();
        }

        [HttpDelete("DeleteProduct/{id}")]
        public IActionResult DeleteProduct([FromRoute] int id)
        {
            repository.DeleteProductAsync(id);
            return Ok();
        }
    }
}