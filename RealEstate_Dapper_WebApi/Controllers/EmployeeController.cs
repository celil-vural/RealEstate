using Entity.Dtos.EmployeeDtos;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_WebApi.Repository.EmployeeRepository;

namespace RealEstate_Dapper_WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController(IEmployeeRepository repository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAllEmployees()
    {
        var employees = await repository.GetAllEmployeeAsync();
        return Ok(employees);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetEmployeeById([FromRoute] int id)
    {
        var employee = await repository.GetEmployeeByIdAsync(id);
        if (employee is null) return NotFound();
        return Ok(employee);
    }

    [HttpPost]
    public async Task<IActionResult> CreateEmployee([FromBody] CreateEmployeeDto employeeDto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        repository.CreateEmployeeAsync(employeeDto);
        //return CreatedAtAction(nameof(GetEmployeeById), new { id = employeeDto.EmployeeID }, employeeDto);
        return Created();
    }

    [HttpPut]
    public async Task<IActionResult> UpdateEmployee([FromBody] UpdateEmployeeDto employeeDto)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        var employee = await repository.GetEmployeeByIdAsync(employeeDto.EmployeeID);
        if (employee is null) return NotFound();
        repository.UpdateEmployeeAsync(employeeDto);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteEmployee([FromRoute] int id)
    {
        var employee = await repository.GetEmployeeByIdAsync(id);
        if (employee is null) return NotFound();
        repository.DeleteEmployeeAsync(id);
        return NoContent();
    }
}