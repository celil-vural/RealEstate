using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_WebApi.Dtos.ProductShowCaseTypeDtos;
using RealEstate_Dapper_WebApi.Repository.ProductShowCaseTypeRepository;

namespace RealEstate_Dapper_WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductShowCaseTypeController(IProductShowCaseTypeReposiyory reposiyory) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetProductShowCaseTypes()
    {
        var productShowCaseTypes = await reposiyory.GetAllProductShowCaseTypeAsync();
        return Ok(productShowCaseTypes);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetProductShowCaseTypeById(short id)
    {
        var productShowCaseType = await reposiyory.GetProductShowCaseTypeByIdAsync(id);
        return Ok(productShowCaseType);
    }

    [HttpPost]
    public async Task<IActionResult> CreateProductShowCaseType(CreateProductShowCaseTypeDto dto)
    {
        reposiyory.CreateProductShowCaseTypeAsync(dto);
        return Created();
    }

    [HttpPut]
    public IActionResult UpdateProductShowCaseType(UpdateProductShowCaseTypeDto dto)
    {
        reposiyory.UpdateProductShowCaseTypeAsync(dto);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteProductShowCaseType(short id)
    {
        reposiyory.DeleteProductShowCaseTypeAsync(id);
        return NoContent();
    }
}