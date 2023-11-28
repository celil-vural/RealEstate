﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_UI.Models.ProductModels;
using RealEstate_UI.Utilities.Const;

namespace RealEstate_UI.ViewComponents.HomePage
{
    public class _DefaultHomePageProductList(IHttpClientFactory httpClientFactory) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = httpClientFactory.CreateClient();
            var url = Urls.baseUrl+"api/Product/GetAllProductWithCategory";
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(json);
                return View(values);
            }
            return View();
        }
    }
}
