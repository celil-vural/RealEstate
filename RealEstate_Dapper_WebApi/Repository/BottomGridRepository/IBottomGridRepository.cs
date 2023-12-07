using Entity.Dtos.BottomGridDtos;

namespace RealEstate_Dapper_WebApi.Repository.BottomGridRepository;
public interface IBottomGridRepository
{
    Task<ICollection<ResultBottomGridDto>> GetAllBottomGridDetail();
    Task<ResultBottomGridDto> GetBottomGridDetailByIdAsync(int id);
    void CreateBottomGridDetailAsync(CreateBottomGridDto dto);
    void UpdateBottomGridDetailAsync(UpdateBottomGridDto dto);
    void DeleteBottomGridDetailAsync(int id);
}