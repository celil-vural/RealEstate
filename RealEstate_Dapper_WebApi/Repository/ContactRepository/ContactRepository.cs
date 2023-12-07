using Dapper;
using Entity.Dtos.ContactDtos;
using RealEstate_Dapper_WebApi.Model.DapperContext;

namespace RealEstate_Dapper_WebApi.Repository.ContactRepository;

public class ContactRepository(DapperContext context) : IContactRepository
{
    public async Task<ICollection<ResultContactDto>> GetAllContactAsync()
    {
        var query = @"SELECT * FROM Contact";
        using var connection = context.CreateConnection();
        var result = await connection.QueryAsync<ResultContactDto>(query);
        return result.ToHashSet();
    }

    public async void CreateContactAsync(CreateContactDto dto)
    {
        var query = @"INSERT INTO Contact (Name, Subject, Email, Message)
VALUES (@Name, @Subject, @Email, @Message)";
        using var connection = context.CreateConnection();
        await connection.ExecuteAsync(query, dto);
    }

    public void DeleteContactAsync(int id)
    {
        var query = @"DELETE FROM Contact WHERE ContactId = @id";
        using var connection = context.CreateConnection();
        connection.Execute(query, new { id });
    }

    public async void UpdateContactAsync(UpdateContactDto dto)
    {
        var query = @"UPDATE Contact SET Seen = @Seen, SeenDate = @SeenDate WHERE ContactId = @ContactId";
        using var connection = context.CreateConnection();
        await connection.ExecuteAsync(query, dto);
    }

    public async Task<ResultContactDto> GetContactByIdAsync(int id)
    {
        var query = @"SELECT * FROM Contact WHERE ContactId = @id";
        using var connection = context.CreateConnection();
        var result = await connection.QueryFirstOrDefaultAsync<ResultContactDto>(query, new { id });
        return result;
    }
}