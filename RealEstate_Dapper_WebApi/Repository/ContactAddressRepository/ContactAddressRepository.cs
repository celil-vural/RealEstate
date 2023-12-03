using Dapper;
using RealEstate_Dapper_WebApi.Dtos.ContactAddressDtos;
using RealEstate_Dapper_WebApi.Model.DapperContext;

namespace RealEstate_Dapper_WebApi.Repository.ContactAddressRepository;

public class ContactAddressRepository(DapperContext context) : IContactAddressRepository
{
    public async Task<ICollection<ResultContactAddressDto>> GetAllContactAddressAsync()
    {
        var query = @"SELECT * FROM ContactAddress";
        using var connection = context.CreateConnection();
        var result = await connection.QueryAsync<ResultContactAddressDto>(query);
        return result.ToHashSet();
    }

    public async void CreateContactAddressAsync(CreateContactAddressDto dto)
    {
        var query = @"INSERT INTO ContactAddress (Title, Icon,Content) 
VALUES (@Title, @Icon, @Content)";
        using var connection = context.CreateConnection();
        await connection.ExecuteAsync(query, dto);
    }

    public async void DeleteContactAddressAsync(int id)
    {
        var query = @"DELETE FROM ContactAddress WHERE ContactAddressId = @Id";
        using var connection = context.CreateConnection();
        await connection.ExecuteAsync(query, new { Id = id });
    }
    
    public async void UpdateContactAddressAsync(UpdateContactAddressDto dto)
    {
        var query = @"UPDATE ContactAddress SET Title = @Title, 
                          Icon = @Icon, Content = @Content WHERE ContactAddressId = @Id";
        using var connection = context.CreateConnection();
        await connection.ExecuteAsync(query, dto);
    }

    public async Task<ResultContactAddressDto> GetContactAddressByIdAsync(int id)
    {
        var query = @"SELECT * FROM ContactAddress WHERE ContactAddressId = @Id";
        using var connection = context.CreateConnection();
        var result = await connection.QueryFirstOrDefaultAsync<ResultContactAddressDto>(query, new { Id = id });
        return result;
    }
}