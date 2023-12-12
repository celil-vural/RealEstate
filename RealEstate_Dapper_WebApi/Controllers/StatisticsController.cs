using Microsoft.AspNetCore.Mvc;
using Repository.Repositories.StatisticsRepository;

namespace RealEstate_Dapper_WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StatisticsController(IStatisticsRepository repository) : ControllerBase
{
    [HttpGet("CategoryCount")]
    public async Task<IActionResult> CategoryCount()
    {
        var result = await repository.CategoryCount();
        return Ok(result);
    }

    [HttpGet("ActiveCategoryCount")]
    public async Task<IActionResult> ActiveCategoryCount()
    {
        var result = await repository.ActiveCategoryCount();
        return Ok(result);
    }

    [HttpGet("PassiveCategoryCount")]
    public async Task<IActionResult> PassiveCategoryCount()
    {
        var result = await repository.PassiveCategoryCount();
        return Ok(result);
    }

    [HttpGet("ProductCount")]
    public async Task<IActionResult> ProductCount()
    {
        var result = await repository.ProductCount();
        return Ok(result);
    }

    [HttpGet("ApartmentCount")]
    public async Task<IActionResult> ApartmentCount()
    {
        var result = await repository.ApartmentCount();
        return Ok(result);
    }

    [HttpGet("EmployeeNameByMaxProductCount")]
    public async Task<IActionResult> EmployeeNameByMaxProductCount()
    {
        var result = await repository.EmployeeNameByMaxProductCount();
        return Ok(result);
    }

    [HttpGet("CategoryNameByMaxProductCount")]
    public async Task<IActionResult> CategoryNameByMaxProductCount()
    {
        var result = await repository.CategoryNameByMaxProductCount();
        return Ok(result);
    }

    [HttpGet("AverageProductPriceByRent")]
    public async Task<IActionResult> AverageProductPriceByRent()
    {
        var result = await repository.AverageProductPriceByRent();
        return Ok(result);
    }

    [HttpGet("AverageProductPriceBySale")]
    public async Task<IActionResult> AverageProductPriceBySale()
    {
        var result = await repository.AverageProductPriceBySale();
        return Ok(result);
    }

    [HttpGet("CityNameByMaxProductCount")]
    public async Task<IActionResult> CityNameByMaxProductCount()
    {
        var result = await repository.CityNameByMaxProductCount();
        return Ok(result);
    }

    [HttpGet("DifferentCityCount")]
    public async Task<IActionResult> DifferentCityCount()
    {
        var result = await repository.DifferentCityCount();
        return Ok(result);
    }

    [HttpGet("LastProductPrice")]
    public async Task<IActionResult> LastProductPrice()
    {
        var result = await repository.LastProductPrice();
        return Ok(result);
    }

    [HttpGet("NewestBuildingYear")]
    public async Task<IActionResult> NewestBuildingYear()
    {
        var result = await repository.NewestBuildingYear();
        return Ok(result);
    }

    [HttpGet("OldestBuildingYear")]
    public async Task<IActionResult> OldestBuildingYear()
    {
        var result = await repository.OldestBuildingYear();
        return Ok(result);
    }

    [HttpGet("ActiveEmployeeCount")]
    public async Task<IActionResult> ActiveEmployeeCount()
    {
        var result = await repository.ActiveEmployeeCount();
        return Ok(result);
    }

    [HttpGet("AverageRoomCount")]
    public async Task<IActionResult> AverageRoomCount()
    {
        var result = await repository.AverageRoomCount();
        return Ok(result);
    }
}