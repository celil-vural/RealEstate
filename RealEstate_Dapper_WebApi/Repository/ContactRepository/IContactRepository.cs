using Entity.Dtos.ContactDtos;

namespace RealEstate_Dapper_WebApi.Repository.ContactRepository;

public interface IContactRepository : IBaseRepository<ResultContactDto, CreateContactDto, UpdateContactDto>;