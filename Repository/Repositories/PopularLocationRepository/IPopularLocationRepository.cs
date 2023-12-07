using Entity.Dtos.PopularLocationDtos;

namespace Repository.Repositories.PopularLocationRepository;

public interface IPopularLocationRepository : IBaseRepository<ResultPopularLocationDto, CreatePopularLocationDto,
    UpdatePopularLocationDto>;