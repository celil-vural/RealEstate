using Entity.Dtos.PopularLocationDtos;
using Repository.Repositories.Dapper;

namespace Repository.Repositories.PopularLocationRepository;

public class PopularLocationRepository(DapperContext context)
    : BaseRepository<ResultPopularLocationDto>(context), IPopularLocationRepository
{
    public Task<ICollection<ResultPopularLocationDto>> GetAllAsync()
    {
        const string query = "SELECT * FROM PopularLocation";
        return base.GetAllAsync(query);
    }

    public Task<ResultPopularLocationDto> GetByIdAsync(int id)
    {
        const string query = "SELECT * FROM PopularLocation WHERE LocationId = @Id";
        return GetAsync(query);
    }

    public void CreateAsync(CreatePopularLocationDto dto)
    {
        const string query = "INSERT INTO PopularLocation (CityName,ImageUrl) VALUES (@CityName,@ImageUrl)";
        ExecuteAsync(query, dto);
    }

    public void UpdateAsync(UpdatePopularLocationDto dto)
    {
        const string query =
            "UPDATE PopularLocation SET CityName = @CityName, ImageUrl = @ImageUrl WHERE LocationId = @LocationId";
        ExecuteAsync(query, dto);
    }

    public async void DeleteAsync(int id)
    {
        const string query = "DELETE FROM PopularLocation WHERE LocationId = @Id";
        await ExecuteAsync(query, new { Id = id });
    }
}