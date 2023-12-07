using Entity.Dtos.ContactAddressDtos;

namespace Repository.Repositories.ContactAddressRepository;

public interface
    IContactAddressRepository : IBaseRepository<ResultContactAddressDto, CreateContactAddressDto,
        UpdateContactAddressDto>;
