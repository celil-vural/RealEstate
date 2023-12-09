using System.Text;
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

    [HttpGet]
    public IActionResult CreateEmployee()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateEmployee(CreateEmployeeDto createEmployeeDto)
    {
        Console.WriteLine("------------------");
        Console.WriteLine(createEmployeeDto.Phone);
        Console.WriteLine(createEmployeeDto.Name);
        var client = clientFactory.CreateClient();
        var json = JsonConvert.SerializeObject(createEmployeeDto);
        var data = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await client.PostAsync(Urls.EmployeeUrl, data);
        if (response.IsSuccessStatusCode) return RedirectToAction("Index");
        return View();
    }

    public async Task<IActionResult> DeleteEmployee(int id)
    {
        var client = clientFactory.CreateClient();
        var response = await client.DeleteAsync($"{Urls.EmployeeUrl}/{id}");
        if (response.IsSuccessStatusCode) return RedirectToAction("Index");
        return RedirectToAction("Index");
    }

    [HttpGet]
    public async Task<IActionResult> UpdateEmployee(int id)
    {
        var client = clientFactory.CreateClient();
        var response = await client.GetAsync($"{Urls.EmployeeUrl}/{id}");
        if (response.IsSuccessStatusCode)
        {
            var jsonData = await response.Content.ReadAsStringAsync();
            var Employee = JsonConvert.DeserializeObject<UpdateEmployeeDto>(jsonData);
            return View(Employee);
        }

        return RedirectToAction("Index");
    }

    [HttpPost]
    public async Task<IActionResult> UpdateEmployee(UpdateEmployeeDto dto)
    {
        var client = clientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(dto);
        var stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var response = await client.PutAsync(Urls.EmployeeUrl, stringContent);
        if (response.IsSuccessStatusCode) return RedirectToAction("Index");
        return View(dto);
    }
}