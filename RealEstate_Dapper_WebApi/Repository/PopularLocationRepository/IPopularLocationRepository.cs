using RealEstate_Dapper_WebApi.Dtos.PopularLocationDtos;
namespace RealEstate_Dapper_WebApi.Repository.PopularLocationRepository;
public interface IPopularLocationRepository
{
    Task<ICollection<ResultPopularLocationDto>> GetAllPopularLocationDetailAsync();
    Task<ResultPopularLocationDto> GetPopularLocationDetailByIdAsync(int id);
    void CreatePopularLocationDetailAsync(CreatePopularLocationDto dto);
    void UpdatePopularLocationDetailAsync(UpdatePopularLocationDto dto);
    void DeletePopularLocationDetailAsync(int id);
}