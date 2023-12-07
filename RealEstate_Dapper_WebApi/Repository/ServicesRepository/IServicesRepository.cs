using Entity.Dtos.ServicesDtos;

namespace RealEstate_Dapper_WebApi.Repository.ServicesRepository;

public interface IServicesRepository
{
    Task<ICollection<ResultServicesDto>> GetAllServices();
    Task<ResultServicesDto> GetServiceByIdAsync(int id);
    void CreateServiceAsync(CreateServiceDto dto);
    void UpdateServiceAsync(UpdateServiceDto dto);
    void DeleteServiceAsync(int id);
}