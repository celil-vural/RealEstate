using Entity.Dtos.TestimonialDtos;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_WebApi.Repository.TestimonialRepsitory;

namespace RealEstate_Dapper_WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestimonialController(ITestimonialRepsitory repsitory): ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetTestimonials()
    {
        var testimonials = await repsitory.GetAllTestimonialDetailAsync();
        return Ok(testimonials);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetTestimonial([FromRoute] int id)
    {
        var testimonial = await repsitory.GetTestimonialDetailByIdAsync(id);
        return Ok(testimonial);
    }
    [HttpPost]
    public async Task<IActionResult> CreateTestimonial([FromBody] CreateTestimonialDto dto)
    {
        repsitory.CreateTestimonialDetailAsync(dto);
        return Created();
    }
    [HttpPut]
    public async Task<IActionResult> UpdateTestimonial([FromBody] UpdateTestimonialDto dto)
    {
        repsitory.UpdateTestimonialDetailAsync(dto);
        return NoContent();
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTestimonial([FromRoute] int id)
    {
        repsitory.DeleteTestimonialDetailAsync(id);
        return NoContent();
    }
}