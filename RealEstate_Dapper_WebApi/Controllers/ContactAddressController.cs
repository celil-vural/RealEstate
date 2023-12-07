using Entity.Dtos.ContactAddressDtos;
using Microsoft.AspNetCore.Mvc;
using Repository.Repositories.ContactAddressRepository;

namespace RealEstate_Dapper_WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ContactAddressController(IContactAddressRepository repository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAllContactAddressAsync()
    {
        var result = await repository.GetAllAsync();
        return Ok(result);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetContactAddressByIdAsync([FromRoute] int id)
    {
        var result = await repository.GetByIdAsync(id);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> CreateContactAddressAsync([FromBody] CreateContactAddressDto dto)
    {
        repository.CreateAsync(dto);
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> UpdateContactAddressAsync([FromBody] UpdateContactAddressDto dto)
    {
        repository.UpdateAsync(dto);
        return Ok();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteContactAddressAsync([FromRoute] int id)
    {
        repository.DeleteAsync(id);
        return Ok();
    }
}