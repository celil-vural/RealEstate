using Entity.Dtos.PopularLocationDtos;
using Microsoft.AspNetCore.Mvc;
using Repository.Repositories.PopularLocationRepository;

namespace RealEstate_Dapper_WebApi.Controllers;
[ApiController]
[Route("api/[controller]")]
public class PopularLocationController(IPopularLocationRepository repository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetPopularLocations()
    {
        var popularLocations = await repository.GetAllAsync();
        return Ok(popularLocations);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetPopularLocationById([FromRoute] int id)
    {
        var popularLocation = await repository.GetByIdAsync(id);
        return Ok(popularLocation);
    }
    [HttpPost]
    public async Task<IActionResult> CreatePopularLocation([FromBody] CreatePopularLocationDto createPopularLocationDto)
    {
        repository.CreateAsync(createPopularLocationDto);
        return Ok();
    }
    [HttpPut]
    public async Task<IActionResult> UpdatePopularLocation([FromBody] UpdatePopularLocationDto updatePopularLocationDto)
    {
        repository.UpdateAsync(updatePopularLocationDto);
        return Ok();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeletePopularLocation([FromRoute] int id)
    {
        repository.DeleteAsync(id);
        return Ok();
    }
}