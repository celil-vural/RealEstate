using RealEstate_UI.Dtos.ServiceDtos;
using RealEstate_UI.Dtos.WhoWeAreDto;

namespace RealEstate_UI.Models.WhoWeAreDetailModels;

public record WhoWeAreModel(ResultWhoWeAreDto? resultWhoWeAreDto,ICollection<ResultServicesDto?>? resultServicesDtos);