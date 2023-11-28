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
        [HttpGet("GetAllProductWithDetails")]
        public async Task<IActionResult> GetAllProductWithDetails()
        {
            var values = await repository.GetAllProductWithDetailsAsync();
            return Ok(values);
        }
        [HttpGet("GetProductWithDetailsById/{id}")]
        public async Task<IActionResult> GetProductWithDetailsById([FromRoute] int id)
        {
            var values = await repository.GetProductWithDetailsByIdAsync(id);
            return Ok(values);
        }
        [HttpGet("GetProductById/{id}")]
        public async Task<IActionResult> GetProductById([FromRoute] int id)
        {
            var values = await repository.GetProductByIdAsync(id);
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateProduct([FromBody] CreateProductDto dto)
        {
            repository.CreateProductAsync(dto);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateProduct([FromBody] UpdateProductDto dto)
        {
            repository.UpdateProductAsync(dto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct([FromRoute] int id)
        {
            repository.DeleteProductAsync(id);
            return Ok();
        }
    }
}