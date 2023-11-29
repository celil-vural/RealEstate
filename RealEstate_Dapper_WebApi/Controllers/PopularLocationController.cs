using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_WebApi.Dtos.PopularLocationDtos;
using RealEstate_Dapper_WebApi.Repository.PopularLocationRepository;

namespace RealEstate_Dapper_WebApi.Controllers;
[ApiController]
[Route("api/[controller]")]
public class PopularLocationController(IPopularLocationRepository repository):ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetPopularLocations()
    {
        var popularLocations = await repository.GetAllPopularLocationDetailAsync();
        return Ok(popularLocations);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetPopularLocationById([FromRoute] int id)
    {
        var popularLocation = await repository.GetPopularLocationDetailByIdAsync(id);
        return Ok(popularLocation);
    }
    [HttpPost]
    public async Task<IActionResult> CreatePopularLocation([FromBody] CreatePopularLocationDto createPopularLocationDto)
    {
        repository.CreatePopularLocationDetailAsync(createPopularLocationDto);
        return Ok();
    }
    [HttpPut]
    public async Task<IActionResult> UpdatePopularLocation([FromBody] UpdatePopularLocationDto updatePopularLocationDto)
    {
        repository.UpdatePopularLocationDetailAsync(updatePopularLocationDto);
        return Ok();
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePopularLocation([FromRoute] int id)
    {
        repository.DeletePopularLocationDetailAsync(id);
        return Ok();
    }
}