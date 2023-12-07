using Entity.Dtos.CategoryDtos;
using Entity.Dtos.ProductDtos;
using Entity.Dtos.ProductShowCaseTypeDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using RealEstate_UI.Utilities.Const;

namespace RealEstate_UI.Controllers;

public class ProductController(IHttpClientFactory factory) : Controller
{
    public async Task<IActionResult> Index()
    {
        var client = factory.CreateClient();
        var response = await client.GetAsync(Urls.ProductWithDetailsUrl);
        if (response.IsSuccessStatusCode)
        {
            var jsonData = await response.Content.ReadAsStringAsync();
            var products = JsonConvert.DeserializeObject<List<ResultProductWithDetailsDto>>(jsonData);
            return View(products);
        }

        return View();
    }

    [HttpGet]
    public async Task<IActionResult> CreateProduct()
    {
        List<SelectListItem> categoryList = new();
        List<SelectListItem> productTypeList = new();
        var client = factory.CreateClient();
        var response = await client.GetAsync(Urls.CategoryUrl);
        if (response.IsSuccessStatusCode)
        {
            var jsonData = await response.Content.ReadAsStringAsync();
            var categories = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);
            categoryList = categories.Select(x => new SelectListItem
            {
                Text = x.CategoryName,
                Value = x.CategoryId.ToString()
            }).ToList();
            ViewBag.CategoryList = categoryList;
        }

        var response2 = await client.GetAsync(Urls.ProductShowCaseTypeUrl);
        if (response2.IsSuccessStatusCode)
        {
            var jsonData = await response2.Content.ReadAsStringAsync();
            var productShowCaseTypes = JsonConvert.DeserializeObject<List<ResultProductShowCaseTypeDto>>(jsonData);
            productTypeList = productShowCaseTypes.Select(x => new SelectListItem
            {
                Text = x.ProductShowCaseTypeName,
                Value = x.ProductShowCaseTypeID.ToString()
            }).ToList();
            ViewBag.ProductShowCaseTypeList = productTypeList;
        }

        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateProduct([FromForm] CreateProductDto dto)
    {
        var client = factory.CreateClient();
        var response = await client.PostAsJsonAsync(Urls.ProductUrl, dto);
        
        return View();
    }
}