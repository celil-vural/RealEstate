using Entity.Dtos.AddressDtos;

namespace RealEstate_Dapper_WebApi.Repository.AddressRepository;

public interface IAddressRepository
{
    Task<ICollection<ResultAddressDto>> GetAllAddressAsync();
    void CreateAddressAsync(CreateAddressDto dto);
    void DeleteAddressAsync(int id);
    void UpdateAddressAsync(UpdateAddressDto dto);
    Task<ResultAddressDto> GetAddressByIdAsync(int id);
}