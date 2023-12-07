using Entity.Dtos.AddressDtos;

namespace RealEstate_Dapper_WebApi.Repository.AddressRepository;

public interface IAddressRepository : IBaseRepository<ResultAddressDto, CreateAddressDto, UpdateAddressDto>;