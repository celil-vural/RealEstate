using Entity.Dtos.ServicesDtos;
using Entity.Dtos.WhoWeAreDtos;

namespace RealEstate_UI.Models.WhoWeAreDetailModels;

public record WhoWeAreModel(ResultWhoWeAreDto? resultWhoWeAreDto,ICollection<ResultServicesDto?>? resultServicesDtos);