using Entity.Dtos.AddressDtos;

namespace Repository.Repositories.AddressRepository;

public interface IAddressRepository : IBaseRepository<ResultAddressDto, CreateAddressDto, UpdateAddressDto>;