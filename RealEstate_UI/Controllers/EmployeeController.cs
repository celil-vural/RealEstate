using Entity.Dtos.EmployeeDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_UI.Utilities.Const;

namespace RealEstate_UI.Controllers;

public class EmployeeController(IHttpClientFactory clientFactory) : Controller
{
    public async Task<IActionResult> Index()
    {
        var client = clientFactory.CreateClient();
        var response = await client.GetAsync(Urls.EmployeeUrl);
        if (response.IsSuccessStatusCode)
        {
            var json = await response.Content.ReadAsStringAsync();
            var employees = JsonConvert.DeserializeObject<List<ResultEmployeeDto>>(json);
            return View(employees);
        }

        return View();
    }
}