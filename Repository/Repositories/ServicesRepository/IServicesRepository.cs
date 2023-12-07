using Entity.Dtos.ServicesDtos;

namespace Repository.Repositories.ServicesRepository;

public interface IServicesRepository : IBaseRepository<ResultServicesDto, CreateServiceDto, UpdateServiceDto>;