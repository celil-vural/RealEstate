using Entity.Dtos.WhoWeAreDtos;
using Repository.Repositories.Dapper;

namespace Repository.Repositories.WhoWeAreRepository;

public class WhoWeAreDetailRepository(DapperContext context)
    : BaseRepository<ResultWhoWeAreDto>(context), IWhoWeAreDetailRepository
{
    public Task<ICollection<ResultWhoWeAreDto>> GetAllAsync()
    {
        const string query = "SELECT * FROM WhoWeAreDetail";
        return GetAllAsync(query);
    }

    public Task<ResultWhoWeAreDto> GetByIdAsync(int id)
    {
        const string query = "SELECT * FROM WhoWeAreDetail WHERE WhoWeAreDetailID = @id";
        return GetAsync(query, new { id });
    }

    public void CreateAsync(CreateWhoWeAreDto dto)
    {
        const string query = """
                             INSERT INTO WhoWeAreDetail (Title,Subtitle, Description1, Description2)
                                     VALUES (@Title, @Subtitle, @Description1,@Description2)
                             """;
        ExecuteAsync(query, dto);
    }

    public void UpdateAsync(UpdateWhoWeAreDto dto)
    {
        const string query = """
                             UPDATE WhoWeAreDetail SET Title = @Title,
                                                       Subtitle = @Subtitle, Description1 = @Description1,
                                                       Description2 = @Description2 WHERE WhoWeAreDetailID = @WhoWeAreDetailID
                             """;
        ExecuteAsync(query, dto);
    }

    public async void DeleteAsync(int id)
    {
        const string query = "DELETE FROM WhoWeAreDetail WHERE WhoWeAreDetailID = @id";
        await ExecuteAsync(query, new { id });
    }
}