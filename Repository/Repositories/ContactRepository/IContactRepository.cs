using Entity.Dtos.ContactDtos;

namespace Repository.Repositories.ContactRepository;

public interface IContactRepository : IBaseRepository<ResultContactDto, CreateContactDto, UpdateContactDto>;