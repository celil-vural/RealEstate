using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_WebApi.Dtos.BottomGridDtos;
using RealEstate_Dapper_WebApi.Repository.BottomGridRepository;

namespace RealEstate_Dapper_WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BottomGridController(IBottomGridRepository repository): ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var result = await repository.GetAllBottomGridDetail();
        return Ok(result);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetBottomGridDetailById([FromRoute]int id)
    {
        var result = await repository.GetBottomGridDetailByIdAsync(id);
        return Ok(result);
    }
    [HttpPost]
    public async Task<IActionResult> CreateBottomGridDetail([FromBody]CreateBottomGridDto createBottomGridDto)
    {
        repository.CreateBottomGridDetailAsync(createBottomGridDto);
        return Ok();
    }
    [HttpPut]
    public async Task<IActionResult> UpdateBottomGridDetail([FromBody]UpdateBottomGridDto updateBottomGridDto)
    {
        repository.UpdateBottomGridDetailAsync(updateBottomGridDto);
        return Ok();
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBottomGridDetail([FromRoute]int id)
    {
        repository.DeleteBottomGridDetailAsync(id);
        return Ok();
    }
}