using System.Text;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_UI.Dtos.CategoryDtos;
using RealEstate_UI.Utilities.Const;

namespace RealEstate_UI.Controllers;

public class CategoryController(IHttpClientFactory factory) : Controller
{
    public async Task<IActionResult> Index()
    {
        var client = factory.CreateClient();
        var response = await client.GetAsync(Urls.CategoryUrl);
        if (response.IsSuccessStatusCode)
        {
            var jsonData = await response.Content.ReadAsStringAsync();
            var categories = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);
            return View(categories);
        }

        return View();
    }

    [HttpGet]
    public IActionResult CreateCategory()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateCategory(CreateCategoryDto dto)
    {
        var client = factory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(dto);
        var stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var response = await client.PostAsync(Urls.CategoryUrl, stringContent);
        if (response.IsSuccessStatusCode) return RedirectToAction("Index");
        return View(dto);
    }
}