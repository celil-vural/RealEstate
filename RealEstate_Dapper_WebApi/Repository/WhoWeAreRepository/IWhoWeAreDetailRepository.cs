using Entity.Dtos.WhoWeAreDtos;

namespace RealEstate_Dapper_WebApi.Repository.WhoWeAreRepository;

public interface IWhoWeAreDetailRepository
{
    Task<ICollection<ResultWhoWeAreDto>> GetAllWhoWeAreDetail();
    Task<ResultWhoWeAreDto> GetWhoWeAreDetailByIdAsync(int id);
    void CreateWhoWeAreDetailAsync(CreateWhoWeAreDto createWhoWeAreDto);
    void UpdateWhoWeAreDetailAsync(UpdateWhoWeAreDto updateWhoWeAreDto);
    void DeleteWhoWeAreDetailAsync(int id);
}