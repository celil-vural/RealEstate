using RealEstate_Dapper_WebApi.Dtos.ContactDtos;

namespace RealEstate_Dapper_WebApi.Repository.ContactRepository;

public interface IContactRepository
{
    Task<ICollection<ResultContactDto>> GetAllContactAsync();
    void CreateContactAsync(CreateContactDto dto);
    void DeleteContactAsync(int id);
    void UpdateContactAsync(UpdateContactDto dto);
    Task<ResultContactDto> GetContactByIdAsync(int id);
}