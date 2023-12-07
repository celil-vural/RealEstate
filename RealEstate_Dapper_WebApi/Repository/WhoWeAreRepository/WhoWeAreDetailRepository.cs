using Dapper;
using Entity.Dtos.WhoWeAreDtos;
using RealEstate_Dapper_WebApi.Model.DapperContext;

namespace RealEstate_Dapper_WebApi.Repository.WhoWeAreRepository;
public class WhoWeAreDetailRepository(DapperContext context) : IWhoWeAreDetailRepository
{
    public async Task<ICollection<ResultWhoWeAreDto>> GetAllWhoWeAreDetail()
    {
        string query = @"SELECT * FROM WhoWeAreDetail";
        using (var connection = context.CreateConnection())
        {
            var result = await connection.QueryAsync<ResultWhoWeAreDto>(query);
            return result.ToHashSet();
        }
    }

    public async Task<ResultWhoWeAreDto> GetWhoWeAreDetailByIdAsync(int id)
    {
        string query = @"SELECT * FROM WhoWeAreDetail WHERE WhoWeAreDetailID = @id";
        using (var connection = context.CreateConnection())
        {
            var result = await connection.QueryFirstOrDefaultAsync<ResultWhoWeAreDto>(query, new { id });
            return result;
        }
    }

    public async void CreateWhoWeAreDetailAsync(CreateWhoWeAreDto createWhoWeAreDto)
    {
        string query = @"INSERT INTO WhoWeAreDetail (Title,Subtitle, Description1, Description2) 
        VALUES (@Title, @Subtitle, @Description1,@Description2)";
        using (var connection = context.CreateConnection())
        {
            await connection.ExecuteAsync(query, createWhoWeAreDto);
        }
    }

    public async void UpdateWhoWeAreDetailAsync(UpdateWhoWeAreDto updateWhoWeAreDto)
    {
        string query = @"UPDATE WhoWeAreDetail SET Title = @Title,
                          Subtitle = @Subtitle, Description1 = @Description1, 
                          Description2 = @Description2 WHERE WhoWeAreDetailID = @WhoWeAreDetailID";
        using (var connection = context.CreateConnection())
        {
            await connection.ExecuteAsync(query, updateWhoWeAreDto);
        }
    }

    public async void DeleteWhoWeAreDetailAsync(int id)
    {
        string query = @"DELETE FROM WhoWeAreDetail WHERE WhoWeAreDetailID = @id";
        using (var connection = context.CreateConnection())
        {
            await connection.ExecuteAsync(query, new { id });
        }
    }
}