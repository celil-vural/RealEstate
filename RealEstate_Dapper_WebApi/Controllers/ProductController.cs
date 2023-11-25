using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_WebApi.Dtos.ProductDtos;
using RealEstate_Dapper_WebApi.Repository.ProductRepository;

namespace RealEstate_Dapper_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }
        [HttpGet("GetAllProduct")]
        public async Task<IActionResult> Index()
        {
            var values = await _productRepository.GetAllProductAsync();
            return Ok(values);
        }
        [HttpGet("GetAllProductWithCategory")]
        public async Task<IActionResult> GetAllProductWithCategory()
        {
            var values = await _productRepository.GetAllProductWithCategoryAsync();
            return Ok(values);
        }
        [HttpGet("GetProductWithCategoryById/{id}")]
        public async Task<IActionResult> GetProductWithCategoryById([FromRoute] int id)
        {
            var values = await _productRepository.GetProductWithCategoryByIdAsync(id);
            return Ok(values);
        }
        [HttpGet("GetProductById/{id}")]
        public async Task<IActionResult> GetProductById([FromRoute] int id)
        {
            var values = await _productRepository.GetProductByIdAsync(id);
            return Ok(values);
        }

        [HttpPost("CreateProduct")]
        public IActionResult CreateProduct([FromBody] CreateProductDto createProductDto)
        {
            _productRepository.CreateProductAsync(createProductDto);
            return Ok();
        }

        [HttpPut("UpdateProduct")]
        public IActionResult UpdateProduct([FromBody] UpdateProductDto updateProductDto)
        {
            _productRepository.UpdateProductAsync(updateProductDto);
            return Ok();
        }

        [HttpDelete("DeleteProduct/{id}")]
        public IActionResult DeleteProduct([FromRoute] int id)
        {
            _productRepository.DeleteProductAsync(id);
            return Ok();
        }
    }
}