using Entity.Dtos.PopularLocationDtos;

namespace RealEstate_Dapper_WebApi.Repository.PopularLocationRepository;

public interface IPopularLocationRepository : IBaseRepository<ResultPopularLocationDto, CreatePopularLocationDto,
    UpdatePopularLocationDto>;