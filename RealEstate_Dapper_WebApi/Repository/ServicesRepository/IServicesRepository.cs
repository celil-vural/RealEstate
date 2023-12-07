using Entity.Dtos.ServicesDtos;

namespace RealEstate_Dapper_WebApi.Repository.ServicesRepository;

public interface IServicesRepository : IBaseRepository<ResultServicesDto, CreateServiceDto, UpdateServiceDto>;