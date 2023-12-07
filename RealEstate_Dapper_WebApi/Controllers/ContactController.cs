using Entity.Dtos.ContactDtos;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_WebApi.Repository.ContactRepository;

namespace RealEstate_Dapper_WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ContactController(IContactRepository repository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAllContacts()
    {
        var contacts = await repository.GetAllAsync();
        return Ok(contacts);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetContactById([FromRoute] int id)
    {
        var contact = await repository.GetByIdAsync(id);
        return Ok(contact);
    }

    [HttpPost]
    public async Task<IActionResult> CreateContact([FromForm] CreateContactDto dto)
    {
        repository.CreateAsync(dto);
        return Created();
    }

    [HttpPut]
    public async Task<IActionResult> UpdateContact([FromForm] UpdateContactDto dto)
    {
        repository.UpdateAsync(dto);
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteContact([FromRoute] int id)
    {
        repository.DeleteAsync(id);
        return NoContent();
    }
}