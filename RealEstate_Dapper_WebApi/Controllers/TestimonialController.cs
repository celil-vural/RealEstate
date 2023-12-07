using Entity.Dtos.TestimonialDtos;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_WebApi.Repository.TestimonialRepository;

namespace RealEstate_Dapper_WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestimonialController(ITestimonialRepository repository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetTestimonials()
    {
        var testimonials = await repository.GetAllAsync();
        return Ok(testimonials);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetTestimonial([FromRoute] int id)
    {
        var testimonial = await repository.GetByIdAsync(id);
        return Ok(testimonial);
    }
    [HttpPost]
    public async Task<IActionResult> CreateTestimonial([FromBody] CreateTestimonialDto dto)
    {
        repository.CreateAsync(dto);
        return Created();
    }
    [HttpPut]
    public async Task<IActionResult> UpdateTestimonial([FromBody] UpdateTestimonialDto dto)
    {
        repository.UpdateAsync(dto);
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteTestimonial([FromRoute] int id)
    {
        repository.DeleteAsync(id);
        return NoContent();
    }
}