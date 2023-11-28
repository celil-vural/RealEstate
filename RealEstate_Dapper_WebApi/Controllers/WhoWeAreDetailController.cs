using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_WebApi.Dtos.CategoryDtos;
using RealEstate_Dapper_WebApi.Dtos.WhoWeAreDtos;
using RealEstate_Dapper_WebApi.Repository.WhoWeAreRepository;

namespace RealEstate_Dapper_WebApi.Controllers;
[ApiController]
[Route("api/[controller]")]
public class WhoWeAreDetailController(IWhoWeAreDetailRepository detailRepository):ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var values = await detailRepository.GetAllWhoWeAreDetail();
        return Ok(values);
    }

    [HttpPost]
    public async Task<IActionResult> CreateWhoWeAreDetail([FromBody] CreateWhoWeAreDto dto)
    {
        detailRepository.CreateWhoWeAreDetailAsync(dto);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteWhoWeAreDetail([FromRoute] int id)
    {
        detailRepository.DeleteWhoWeAreDetailAsync(id);
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> UpdateWhoWeAreDetail([FromBody] UpdateWhoWeAreDto dto)
    {
        detailRepository.UpdateWhoWeAreDetailAsync(dto);
        return Ok();
    }

    [HttpGet("{id}")] 
    public async Task<IActionResult> GetWhoWeAreDetailById([FromRoute] int id)
    {
        var value = await detailRepository.GetWhoWeAreDetailByIdAsync(id);
        return Ok(value);
    }
}