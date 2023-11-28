using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_WebApi.Dtos.ServicesDtos;
using RealEstate_Dapper_WebApi.Repository.ServicesRepository;

namespace RealEstate_Dapper_WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ServicesController(IServicesRepository repository): ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAllServices()
    {
        var services = await repository.GetAllServices();
        return Ok(services);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetServiceById(int id)
    {
        var service = await repository.GetServiceByIdAsync(id);
        return Ok(service);
    }
    [HttpPost]
    public async Task<IActionResult> CreateService([FromBody] CreateServiceDto createServiceDto)
    {
        repository.CreateServiceAsync(createServiceDto);
        return StatusCode(201);
    }
    [HttpPut]
    public async Task<IActionResult> UpdateService([FromBody] UpdateServiceDto updateServiceDto)
    {
        repository.UpdateServiceAsync(updateServiceDto);
        return StatusCode(204);
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteService(int id)
    {
        repository.DeleteServiceAsync(id);
        return StatusCode(204);
    }
}