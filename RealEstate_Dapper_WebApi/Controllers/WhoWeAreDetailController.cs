using Entity.Dtos.WhoWeAreDtos;
using Microsoft.AspNetCore.Mvc;
using Repository.Repositories.WhoWeAreRepository;

namespace RealEstate_Dapper_WebApi.Controllers;
[ApiController]
[Route("api/[controller]")]
public class WhoWeAreDetailController(IWhoWeAreDetailRepository detailRepository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var values = await detailRepository.GetAllAsync();
        return Ok(values);
    }

    [HttpPost]
    public async Task<IActionResult> CreateWhoWeAreDetail([FromBody] CreateWhoWeAreDto dto)
    {
        detailRepository.CreateAsync(dto);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteWhoWeAreDetail([FromRoute] int id)
    {
        detailRepository.DeleteAsync(id);
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> UpdateWhoWeAreDetail([FromBody] UpdateWhoWeAreDto dto)
    {
        detailRepository.UpdateAsync(dto);
        return Ok();
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetWhoWeAreDetailById([FromRoute] int id)
    {
        var value = await detailRepository.GetByIdAsync(id);
        return Ok(value);
    }
}