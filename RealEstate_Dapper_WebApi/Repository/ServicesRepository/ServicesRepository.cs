using Entity.Dtos.ServicesDtos;
using RealEstate_Dapper_WebApi.Model.DapperContext;

namespace RealEstate_Dapper_WebApi.Repository.ServicesRepository;

public class ServicesRepository(DapperContext context) : BaseRepository<ResultServicesDto>(context), IServicesRepository
{
    public Task<ICollection<ResultServicesDto>> GetAllAsync()
    {
        const string query = "SELECT * FROM Services";
        return base.GetAllAsync(query);
    }

    public Task<ResultServicesDto> GetByIdAsync(int id)
    {
        const string query = "SELECT * FROM Services WHERE ServiceID = @id";
        return GetAsync(query, new { id });
    }

    public async void UpdateAsync(UpdateServiceDto dto)
    {
        const string query =
            "UPDATE Services SET ServiceName = @ServiceName,ServiceStatus = @ServiceStatus WHERE ServiceID = @ServiceID";
        ExecuteAsync(query, dto);
    }

    public void CreateAsync(CreateServiceDto dto)
    {
        const string query = "INSERT INTO Services (ServiceName) VALUES (@ServiceName)";
        ExecuteAsync(query, dto);
    }

    public async void DeleteAsync(int id)
    {
        const string query = "DELETE FROM Services WHERE ServiceID = @id";
        await ExecuteAsync(query, new { id });
    }
}