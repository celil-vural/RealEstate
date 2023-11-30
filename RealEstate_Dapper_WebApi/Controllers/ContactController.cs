using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_WebApi.Dtos.ContactDtos;
using RealEstate_Dapper_WebApi.Repository.ContactRepository;

namespace RealEstate_Dapper_WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ContactController(IContactRepository repository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAllContacts()
    {
        var contacts = await repository.GetAllContactAsync();
        return Ok(contacts);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetContactById([FromRoute] int id)
    {
        var contact = await repository.GetContactByIdAsync(id);
        return Ok(contact);
    }

    [HttpPost]
    public async Task<IActionResult> CreateContact([FromForm] CreateContactDto dto)
    {
        repository.CreateContactAsync(dto);
        return Created();
    }

    [HttpPut]
    public async Task<IActionResult> UpdateContact([FromForm] UpdateContactDto dto)
    {
        repository.UpdateContactAsync(dto);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteContact([FromRoute] int id)
    {
        repository.DeleteContactAsync(id);
        return NoContent();
    }
}