using Entity.Dtos.ServicesDtos;
using Microsoft.AspNetCore.Mvc;
using Repository.Repositories.ServicesRepository;

namespace RealEstate_Dapper_WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ServicesController(IServicesRepository repository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAllServices()
    {
        var services = await repository.GetAllAsync();
        return Ok(services);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetServiceById(int id)
    {
        var service = await repository.GetByIdAsync(id);
        return Ok(service);
    }
    [HttpPost]
    public async Task<IActionResult> CreateService([FromBody] CreateServiceDto createServiceDto)
    {
        repository.CreateAsync(createServiceDto);
        return StatusCode(201);
    }
    [HttpPut]
    public async Task<IActionResult> UpdateService([FromBody] UpdateServiceDto updateServiceDto)
    {
        repository.UpdateAsync(updateServiceDto);
        return StatusCode(204);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteService(int id)
    {
        repository.DeleteAsync(id);
        return StatusCode(204);
    }
}