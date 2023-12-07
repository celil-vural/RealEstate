using Entity.Dtos.ContactDtos;
using Repository.Repositories.Dapper;

namespace Repository.Repositories.ContactRepository;

public class ContactRepository(DapperContext context) : BaseRepository<ResultContactDto>(context), IContactRepository
{
    public Task<ICollection<ResultContactDto>> GetAllAsync()
    {
        const string query = "SELECT * FROM Contact";
        return base.GetAllAsync(query);
    }

    public void CreateAsync(CreateContactDto dto)
    {
        const string query = """
                             INSERT INTO Contact (Name, Subject, Email, Message)
                             VALUES (@Name, @Subject, @Email, @Message)
                             """;
        ExecuteAsync(query, dto);
    }

    public void DeleteAsync(int id)
    {
        const string query = "DELETE FROM Contact WHERE ContactId = @id";
        ExecuteAsync(query, new { id });
    }

    public void UpdateAsync(UpdateContactDto dto)
    {
        const string query = "UPDATE Contact SET Seen = @Seen, SeenDate = @SeenDate WHERE ContactId = @ContactId";
        ExecuteAsync(query, dto);
    }

    public Task<ResultContactDto> GetByIdAsync(int id)
    {
        const string query = "SELECT * FROM Contact WHERE ContactId = @id";
        return GetAsync(query, new { id });
    }
}