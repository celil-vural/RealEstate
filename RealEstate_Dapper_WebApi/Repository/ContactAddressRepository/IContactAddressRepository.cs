using Entity.Dtos.ContactAddressDtos;

namespace RealEstate_Dapper_WebApi.Repository.ContactAddressRepository;

public interface IContactAddressRepository
{
    Task<ICollection<ResultContactAddressDto>> GetAllContactAddressAsync();
    void CreateContactAddressAsync(CreateContactAddressDto dto);
    void DeleteContactAddressAsync(int id);
    void UpdateContactAddressAsync(UpdateContactAddressDto dto);
    Task<ResultContactAddressDto> GetContactAddressByIdAsync(int id);
}