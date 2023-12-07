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
        var result = await repository.GetAllAddressAsync();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] int id)
    {
        var result = await repository.GetAddressByIdAsync(id);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateAddressDto dto)
    {
        repository.CreateAddressAsync(dto);
        return Created();
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateAddressDto dto)
    {
        repository.UpdateAddressAsync(dto);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        repository.DeleteAddressAsync(id);
        return NoContent();
    }
}