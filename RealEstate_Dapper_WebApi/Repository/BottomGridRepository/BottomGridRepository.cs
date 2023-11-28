using Dapper;
using RealEstate_Dapper_WebApi.Dtos.BottomGridDtos;
using RealEstate_Dapper_WebApi.Model.DapperContext;

namespace RealEstate_Dapper_WebApi.Repository.BottomGridRepository;

public class BottomGridRepository(DapperContext context): IBottomGridRepository
{
    public async Task<ICollection<ResultBottomGridDto>> GetAllBottomGridDetail()
    {
        string query = @"SELECT * FROM BottomGrid";
        using var connection = context.CreateConnection();
        var result = await connection.QueryAsync<ResultBottomGridDto>(query);
        return result.ToHashSet();
    }

    public Task<ResultBottomGridDto> GetBottomGridDetailByIdAsync(int id)
    {
        string query = @"SELECT * FROM BottomGrid WHERE BottomGridID = @id";
        using var connection = context.CreateConnection();
        var result = connection.QueryFirstOrDefaultAsync<ResultBottomGridDto>(query, new {id});
        return result;
    }

    public void CreateBottomGridDetailAsync(CreateBottomGridDto dto)
    {
        string query = @"INSERT INTO BottomGrid (Title, Icon, Description) 
        VALUES (@Title, @Icon, @Description)";
        using var connection = context.CreateConnection();
        connection.ExecuteAsync(query, dto);
    }

    public void UpdateBottomGridDetailAsync(UpdateBottomGridDto dto)
    {
        string query = @"UPDATE BottomGrid SET Title = @Title,
                          Icon = @Icon, Description = @Description WHERE BottomGridID = @BottomGridID";
        using var connection = context.CreateConnection();
        connection.ExecuteAsync(query, dto);
    }
    public void DeleteBottomGridDetailAsync(int id)
    {
        string query = @"DELETE FROM BottomGrid WHERE BottomGridID = @id";
        using var connection = context.CreateConnection();
        connection.ExecuteAsync(query, new {id});
    }
}