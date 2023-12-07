using Entity.Dtos.AddressDtos;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_WebApi.Repository.AddressRepository;

namespace RealEstate_Dapper_WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AddressController(IAddressRepository repository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await repository.GetAllAsync();
        return Ok(result);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById([FromRoute] int id)
    {
        var result = await repository.GetByIdAsync(id);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateAddressDto dto)
    {
        repository.CreateAsync(dto);
        return Created();
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateAddressDto dto)
    {
        repository.UpdateAsync(dto);
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        repository.DeleteAsync(id);
        return NoContent();
    }
}