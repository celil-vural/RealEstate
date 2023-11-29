using Dapper;
using RealEstate_Dapper_WebApi.Dtos.PopularLocationDtos;
using RealEstate_Dapper_WebApi.Model.DapperContext;

namespace RealEstate_Dapper_WebApi.Repository.PopularLocationRepository;

public class PopularLocationRepository(DapperContext context):IPopularLocationRepository
{
    public async Task<ICollection<ResultPopularLocationDto>> GetAllPopularLocationDetailAsync()
    {
        string query = @"SELECT * FROM PopularLocation";
        using var connection = context.CreateConnection();
        var result = await connection.QueryAsync<ResultPopularLocationDto>(query);
        return result.ToHashSet();
    }

    public async Task<ResultPopularLocationDto> GetPopularLocationDetailByIdAsync(int id)
    {
        string query = @"SELECT * FROM PopularLocation WHERE LocationId = @Id";
        using var connection = context.CreateConnection();
        var result = await connection.QueryFirstOrDefaultAsync<ResultPopularLocationDto>(query, new { Id = id });
        return result;
    }

    public void CreatePopularLocationDetailAsync(CreatePopularLocationDto dto)
    {
        string query = @"INSERT INTO PopularLocation (CityName,ImageUrl) VALUES (@CityName,@ImageUrl)";
        using var connection = context.CreateConnection();
        connection.ExecuteAsync(query, dto);
    }

    public async void UpdatePopularLocationDetailAsync(UpdatePopularLocationDto dto)
    {
        string query = @"UPDATE PopularLocation SET CityName = @CityName, ImageUrl = @ImageUrl WHERE LocationId = @LocationId";
        using var connection = context.CreateConnection();
        await connection.ExecuteAsync(query, dto);
    }

    public async void DeletePopularLocationDetailAsync(int id)
    {
        string query = @"DELETE FROM PopularLocation WHERE LocationId = @Id";
        using var connection = context.CreateConnection();
        await connection.ExecuteAsync(query, new { Id = id });
    }
}