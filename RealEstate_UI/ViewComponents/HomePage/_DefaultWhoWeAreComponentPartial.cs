using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_UI.Dtos.ServiceDtos;
using RealEstate_UI.Dtos.WhoWeAreDto;
using RealEstate_UI.Models.WhoWeAreDetailModels;
using RealEstate_UI.Utilities.Const;

namespace RealEstate_UI.ViewComponents.HomePage
{
    public class _DefaultWhoWeAreComponentPartial(IHttpClientFactory httpClientFactory)  : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = httpClientFactory.CreateClient();
            var WhoWeAreUrl = Constants.baseUrl+"api/WhoWeAreDetail";
            var responseWhoWeAre = await client.GetAsync(WhoWeAreUrl);
            
            ResultWhoWeAreDto whoWeAreDto = null;
            if (responseWhoWeAre.IsSuccessStatusCode)
            {
                var json = await responseWhoWeAre.Content.ReadAsStringAsync();
                whoWeAreDto = JsonConvert.DeserializeObject<List<ResultWhoWeAreDto>>(json)[0];
            }
            var servicesUrl = Constants.baseUrl+"api/Services";
            var responseServices = await client.GetAsync(servicesUrl);
            ICollection<ResultServicesDto> serviceDtos = new List<ResultServicesDto>();
            if (responseServices.IsSuccessStatusCode)
            {
                var json = await responseServices.Content.ReadAsStringAsync();
                serviceDtos = JsonConvert.DeserializeObject<List<ResultServicesDto>>(json);
            }
            return View(new WhoWeAreModel(whoWeAreDto,serviceDtos));
        }
    }
}
