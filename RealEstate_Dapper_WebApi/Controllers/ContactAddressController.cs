using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_WebApi.Dtos.ContactAddressDtos;
using RealEstate_Dapper_WebApi.Repository.ContactAddressRepository;

namespace RealEstate_Dapper_WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ContactAddressController(IContactAddressRepository repository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAllContactAddressAsync()
    {
        var result = await repository.GetAllContactAddressAsync();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetContactAddressByIdAsync([FromRoute] int id)
    {
        var result = await repository.GetContactAddressByIdAsync(id);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> CreateContactAddressAsync([FromBody] CreateContactAddressDto dto)
    {
        repository.CreateContactAddressAsync(dto);
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> UpdateContactAddressAsync([FromBody] UpdateContactAddressDto dto)
    {
        repository.UpdateContactAddressAsync(dto);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteContactAddressAsync([FromRoute] int id)
    {
        repository.DeleteContactAddressAsync(id);
        return Ok();
    }
}