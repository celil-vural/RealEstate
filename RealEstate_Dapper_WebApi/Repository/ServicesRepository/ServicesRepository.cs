using Dapper;
using RealEstate_Dapper_WebApi.Dtos.ServicesDtos;
using RealEstate_Dapper_WebApi.Model.DapperContext;

namespace RealEstate_Dapper_WebApi.Repository.ServicesRepository;

public class ServicesRepository(DapperContext context):IServicesRepository
{
    public async Task<ICollection<ResultServicesDto>> GetAllServices()
    {
        var query = "SELECT * FROM Services";
        using var connection = context.CreateConnection();
        var result = await connection.QueryAsync<ResultServicesDto>(query);
        return result.ToList();
    }

    public async Task<ResultServicesDto> GetServiceByIdAsync(int id)
    {
        var query = "SELECT * FROM Services WHERE ServiceID = @id";
        using var connection = context.CreateConnection();
        var result = await connection.QueryFirstOrDefaultAsync<ResultServicesDto>(query, new {id});
        return result;
    }

    public async void UpdateServiceAsync(UpdateServiceDto dto)
    {
        var query = "UPDATE Services SET ServiceName = @ServiceName,ServiceStatus = @ServiceStatus WHERE ServiceID = @ServiceID";
        using var connection = context.CreateConnection();
        await connection.ExecuteAsync(query, dto);
    }

    public async void CreateServiceAsync(CreateServiceDto dto)
    {
        var query = "INSERT INTO Services (ServiceName,ServiceStatus) VALUES (@ServiceName,@ServiceStatus)";
        using var connection = context.CreateConnection();
        await connection.ExecuteAsync(query, dto);
    }

    public async void DeleteServiceAsync(int id)
    {
        var query = "DELETE FROM Services WHERE ServiceID = @id";
        using var connection = context.CreateConnection();
        await connection.ExecuteAsync(query, new { id });
    }
}