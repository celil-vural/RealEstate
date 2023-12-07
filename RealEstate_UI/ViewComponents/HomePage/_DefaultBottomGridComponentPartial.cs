using Entity.Dtos.BottomGridDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_UI.Utilities.Const;

namespace RealEstate_UI.ViewComponents.HomePage
{
    public class _DefaultBottomGridComponentPartial(IHttpClientFactory httpClientFactory) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = httpClientFactory.CreateClient();
            var response = await client.GetAsync(Urls.BottomGridUrl);
            if (response.IsSuccessStatusCode)
            {
                var json= await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ICollection<ResultBottomGridDto>>(json);
                return View(values);
            }
            return View();
        }
    }
}
