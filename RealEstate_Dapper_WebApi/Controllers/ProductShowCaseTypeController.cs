using Entity.Dtos.ProductShowCaseTypeDtos;
using Microsoft.AspNetCore.Mvc;
using Repository.Repositories.ProductShowCaseTypeRepository;

namespace RealEstate_Dapper_WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductShowCaseTypeController(IProductShowCaseTypeRepository repository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetProductShowCaseTypes()
    {
        var productShowCaseTypes = await repository.GetAllAsync();
        return Ok(productShowCaseTypes);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetProductShowCaseTypeById(int id)
    {
        var productShowCaseType = await repository.GetByIdAsync(id);
        return Ok(productShowCaseType);
    }

    [HttpPost]
    public async Task<IActionResult> CreateProductShowCaseType(CreateProductShowCaseTypeDto dto)
    {
        repository.CreateAsync(dto);
        return Created();
    }

    [HttpPut]
    public IActionResult UpdateProductShowCaseType(UpdateProductShowCaseTypeDto dto)
    {
        repository.UpdateAsync(dto);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteProductShowCaseType(int id)
    {
        repository.DeleteAsync(id);
        return NoContent();
    }
}