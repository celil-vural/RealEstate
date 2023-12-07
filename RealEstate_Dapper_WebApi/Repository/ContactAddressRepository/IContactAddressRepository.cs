using Entity.Dtos.ContactAddressDtos;

namespace RealEstate_Dapper_WebApi.Repository.ContactAddressRepository;

public interface
    IContactAddressRepository : IBaseRepository<ResultContactAddressDto, CreateContactAddressDto,
    UpdateContactAddressDto>;
