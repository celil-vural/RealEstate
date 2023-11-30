using Dapper;
using RealEstate_Dapper_WebApi.Dtos.AddressDtos;
using RealEstate_Dapper_WebApi.Model.DapperContext;

namespace RealEstate_Dapper_WebApi.Repository.AddressRepository;

public class AddressRepository(DapperContext context) : IAddressRepository
{
    public async Task<ICollection<ResultAddressDto>> GetAllAddressAsync()
    {
        var query = @"SELECT * FROM Address";
        using var connection = context.CreateConnection();
        var result = await connection.QueryAsync<ResultAddressDto>(query);
        return result.ToHashSet();
    }

    public async void CreateAddressAsync(CreateAddressDto dto)
    {
        var query = @"INSERT INTO Address (AddressTitle, Address)
VALUES (@AddressTitle, @Address)";
        using var connection = context.CreateConnection();
        await connection.ExecuteAsync(query, dto);
    }

    public void DeleteAddressAsync(int id)
    {
        var query = @"DELETE FROM Address WHERE AddressId = @Id";
        using var connection = context.CreateConnection();
        connection.ExecuteAsync(query, new { Id = id });
    }

    public async void UpdateAddressAsync(UpdateAddressDto dto)
    {
        var query = @"UPDATE Address SET AddressTitle = @AddressTitle, Address = @Address,
                   Status=@Status WHERE AddressId = @Id";
        using var connection = context.CreateConnection();
        await connection.ExecuteAsync(query, dto);
    }

    public async Task<ResultAddressDto> GetAddressByIdAsync(int id)
    {
        var query = @"SELECT * FROM Address WHERE AddressId  = @Id";
        using var connection = context.CreateConnection();
        var result = await connection.QueryFirstOrDefaultAsync<ResultAddressDto>(query, new { Id = id });
        return result;
    }
}