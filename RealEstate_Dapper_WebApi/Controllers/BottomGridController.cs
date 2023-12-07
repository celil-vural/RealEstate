using Entity.Dtos.BottomGridDtos;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_WebApi.Repository.BottomGridRepository;

namespace RealEstate_Dapper_WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BottomGridController(IBottomGridRepository repository): ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var result = await repository.GetAllAsync();
        return Ok(result);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetBottomGridDetailById([FromRoute]int id)
    {
        var result = await repository.GetByIdAsync(id);
        return Ok(result);
    }
    [HttpPost]
    public async Task<IActionResult> CreateBottomGridDetail([FromBody]CreateBottomGridDto createBottomGridDto)
    {
        repository.CreateAsync(createBottomGridDto);
        return Ok();
    }
    [HttpPut]
    public async Task<IActionResult> UpdateBottomGridDetail([FromBody]UpdateBottomGridDto updateBottomGridDto)
    {
        repository.UpdateAsync(updateBottomGridDto);
        return Ok();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteBottomGridDetail([FromRoute]int id)
    {
        repository.DeleteAsync(id);
        return Ok();
    }
}