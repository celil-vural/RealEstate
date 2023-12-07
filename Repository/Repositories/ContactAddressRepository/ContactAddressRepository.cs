using Entity.Dtos.ContactAddressDtos;
using Repository.Repositories.Dapper;

namespace Repository.Repositories.ContactAddressRepository;

public class ContactAddressRepository(DapperContext context)
    : BaseRepository<ResultContactAddressDto>(context), IContactAddressRepository
{
    public Task<ICollection<ResultContactAddressDto>> GetAllAsync()
    {
        const string query = "SELECT * FROM ContactAddress";
        return base.GetAllAsync(query);
    }

    public void CreateAsync(CreateContactAddressDto dto)
    {
        const string query = """
                             INSERT INTO ContactAddress (Title, Icon,Content)
                             VALUES (@Title, @Icon, @Content)
                             """;
        ExecuteAsync(query, dto);
    }

    public void DeleteAsync(int id)
    {
        const string query = "DELETE FROM ContactAddress WHERE ContactAddressId = @Id";
        ExecuteAsync(query, new { Id = id });
    }

    public void UpdateAsync(UpdateContactAddressDto dto)
    {
        const string query = """
                             UPDATE ContactAddress SET Title = @Title,
                                                       Icon = @Icon, Content = @Content WHERE ContactAddressId = @Id
                             """;
        ExecuteAsync(query, dto);
    }

    public Task<ResultContactAddressDto> GetByIdAsync(int id)
    {
        const string query = "SELECT * FROM ContactAddress WHERE ContactAddressId = @id";
        return GetAsync(query, new { id });
    }
}