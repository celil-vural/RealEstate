using Entity.Dtos.BottomGridDtos;
using Repository.Repositories.Dapper;

namespace Repository.Repositories.BottomGridRepository;

public class BottomGridRepository(DapperContext context)
    : BaseRepository<ResultBottomGridDto>(context), IBottomGridRepository
{
    public Task<ICollection<ResultBottomGridDto>> GetAllAsync()
    {
        const string query = "SELECT * FROM BottomGrid";
        return base.GetAllAsync(query);
    }

    public Task<ResultBottomGridDto> GetByIdAsync(int id)
    {
        const string query = "SELECT * FROM BottomGrid WHERE BottomGridID = @id";
        return GetAsync(query, new { id });
    }

    public void CreateAsync(CreateBottomGridDto dto)
    {
        const string query = """
                             INSERT INTO BottomGrid (Title, Icon, Description)
                                     VALUES (@Title, @Icon, @Description)
                             """;
        ExecuteAsync(query, dto);
    }

    public void UpdateAsync(UpdateBottomGridDto dto)
    {
        const string query = """
                             UPDATE BottomGrid SET Title = @Title,
                                                       Icon = @Icon, Description = @Description WHERE BottomGridID = @BottomGridID
                             """;
        ExecuteAsync(query, dto);
    }

    public void DeleteAsync(int id)
    {
        const string query = "DELETE FROM BottomGrid WHERE BottomGridID = @id";
        ExecuteAsync(query, new { id });
    }
}